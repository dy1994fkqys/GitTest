using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms.Integration;
using System.Windows.Threading;
using FoodSafetyMonitoring.dao;
using System.Data;
using Visifire.Charts;
using Toolkit = Microsoft.Windows.Controls;


namespace FoodSafetyMonitoring.Manager
{
    /// <summary>
    /// SysComparisonAndAnalysis.xaml 的交互逻辑
    /// </summary>
    public partial class SysComparisonAndAnalysis : UserControl
    {
        private IDBOperation dbOperation;
        private readonly List<string> analysisThemes = new List<string>() { "-请选择-",
            "各检测站点检测总量占比分析", 
            "直属与企业检测点检测总量比较分析",
            "直属与企业检测点阳性样本检出比较分析",
            "不同检测项目检测量占比分析",
            "不同检测项目阳性样本检测占比分析",
            "阳性样本检出总量占比分析"};//初始化变量


        public SysComparisonAndAnalysis(IDBOperation dbOperation)
        {
            InitializeComponent();
            this.dbOperation = dbOperation;
            _analysis_theme.ItemsSource = analysisThemes;
            _analysis_theme.SelectedIndex = 0;
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
        }

        private void _query_Click(object sender, RoutedEventArgs e)
        {
            if (_analysis_theme.SelectedIndex < 1)
            {
                Toolkit.MessageBox.Show("请先选择分析主题!!!");
                return;
            }
            DataTable table = null;
            string userId = (Application.Current.Resources["User"] as UserInfo).ID;
            string function = "";
            switch (_analysis_theme.Text)
            {
                case "各检测站点检测总量占比分析": function = "p_dbfx_jczl"; break;
                case "直属与企业检测点检测总量比较分析": function = "p_dbfx_jcdfx"; break;
                case "直属与企业检测点阳性样本检出比较分析": function = "p_dbfx_jcdyxfx"; break;
                case "不同检测项目检测量占比分析": function = "p_dbfx_jcxm"; break;
                case "不同检测项目阳性样本检测占比分析": function = "p_dbfx_jcxmyx"; break;
                case "阳性样本检出总量占比分析": function = "p_dbfx_yxyx"; break;
                default: break;
            }

            //if (_analysis_theme.Text == "各检测站点检测总量占比分析")
            //{
            //    table = dbOperation.GetComparisonAndAnalysiseData(_analysis_theme.Text, (DateTime)dtpStartDate.Value, (DateTime)dtpEndDate.Value);
            //}
            //else
            //{
                table = dbOperation.GetDbHelper().GetDataSet(string.Format("call {0}({1},'{2}','{3}')", function, userId, (DateTime)dtpStartDate.Value, (DateTime)dtpEndDate.Value)).Tables[0];
            //}

            switch (_analysis_theme.Text)
            {
                case "不同检测项目检测量占比分析": table.Columns.Remove("ItemID"); break;
                case "不同检测项目阳性样本检测占比分析": table.Columns.Remove("ItemID"); break;
                default: break;
            }

            table.Columns[0].ColumnName = "检测站点";
            table.Columns[1].ColumnName = "检测数量";
            table.Columns.Add("占比(%)", Type.GetType("System.String"));
            double sum = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                sum += Convert.ToDouble(table.Rows[i][1].ToString());
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i][2] = Math.Round(Convert.ToDouble(table.Rows[i][1].ToString()) / sum, 4, MidpointRounding.AwayFromZero) * 100 + "%";
            }
            _chart.Children.Clear();
            Chart chart = new Chart();
            chart.Background = Brushes.Transparent;
            chart.View3D = true;
            chart.Bevel = true;
            Title title = new Title();
            title.Text = _analysis_theme.Text;
            title.FontFamily = new FontFamily("宋体");
            title.FontSize = 14;
            DataSeries dataSeries = new DataSeries();
            dataSeries.RenderAs = RenderAs.Pie;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataPoint point = new DataPoint();
                point.AxisXLabel = table.Rows[i][0].ToString();
                point.YValue = Convert.ToDouble(table.Rows[i][1].ToString());
                point.LabelStyle = LabelStyles.Inside;
                point.LabelText = table.Rows[i][0].ToString();
                point.LabelFontFamily = new FontFamily("宋体");
                point.LabelFontSize = 14;
                dataSeries.DataPoints.Add(point);
            }
            chart.Series.Add(dataSeries);
            chart.Titles.Add(title);
            _chart.Children.Add(chart);


            string table_title = "■数据统计时间:" + dtpStartDate.Value.Value.Year + "年" + dtpStartDate.Value.Value.Month + "月" + dtpStartDate.Value.Value.Day + "日到" + dtpEndDate.Value.Value.Year + "年" + dtpEndDate.Value.Value.Month + "月" + dtpEndDate.Value.Value.Day + "日"; ;
            table.Rows.Add(new object[] { "合计", sum, "100%" });
            _tableview.SetDataTable(table, table_title, new List<int>());

        }

        private void _export_Click(object sender, RoutedEventArgs e)
        {
            _tableview.ExportExcel();
        }



    }

}
