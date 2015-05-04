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
using FoodSafetyMonitoring.dao;
using FoodSafetyMonitoring.Common;
using System.Data;

namespace FoodSafetyMonitoring.Manager
{
    /// <summary>
    /// UserControl1.xaml 的交互逻辑
    /// </summary>
    public partial class SysMonthReport : UserControl
    {
        private IDBOperation dbOperation;

        private List<DeptItemInfo> list = new List<DeptItemInfo>();

        private readonly List<string> year = new List<string>() { "2010",
            "2011", 
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"};//初始化变量

        private readonly List<string> month = new List<string>() { "01",
            "02", 
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"};//初始化变量

        public SysMonthReport(IDBOperation dbOperation)
        {
            InitializeComponent();

            this.dbOperation = dbOperation;

            _year.ItemsSource = year;
            _year.SelectedIndex = 5;

            _month.ItemsSource = month;
            _month.SelectedIndex = 3;
            //检测站点
            ComboboxTool.InitComboboxSource(_detect_dept, "call p_user_dept(" + (Application.Current.Resources["User"] as UserInfo).ID + ")", "cxtj");
            //检测项目
            ComboboxTool.InitComboboxSource(_detect_item, "call p_user_item(" + (Application.Current.Resources["User"] as UserInfo).ID + ")", "cxtj");
            //检测结果
            ComboboxTool.InitComboboxSource(_detect_result, "SELECT resultId,resultName FROM t_det_result where openFlag='1'  ORDER BY id", "cxtj");

            //如果登录用户的部门是站点级别，则将查询条件检测站点赋上默认值
            if (isDept())
            {
                _detect_dept.SelectedIndex = 1;
            }
        }

        //判断登录用户的部门级别
        private bool isDept()
        {
            string flag = dbOperation.GetDbHelper().GetSingle("select FLAG_TIER from sys_client_sysdept where INFO_CODE =" + (Application.Current.Resources["User"] as UserInfo).DepartmentID).ToString();

            if (flag == "4")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void _query_Click(object sender, RoutedEventArgs e)
        {
            string date;

            //判断查询条件：年月
            date = _year.Text + "-" + _month.Text;

            DataTable table = dbOperation.GetDbHelper().GetDataSet(string.Format("call p_report_month('{0}','{1}','{2}','{3}','{4}')",
                              (Application.Current.Resources["User"] as UserInfo).ID, date,
                               _detect_dept.SelectedIndex < 1 ? "" : (_detect_dept.SelectedItem as Label).Tag,
                               _detect_item.SelectedIndex < 1 ? "" : (_detect_item.SelectedItem as Label).Tag,
                               _detect_result.SelectedIndex < 1 ? "" : (_detect_result.SelectedItem as Label).Tag)).Tables[0];


            list.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DeptItemInfo info = new DeptItemInfo();
                //info.DeptId = table.Rows[i][0].ToString();
                info.DeptName = table.Rows[i][1].ToString();
                //info.ItemId = table.Rows[i][2].ToString();
                info.ItemName = table.Rows[i][3].ToString();
                info.Count = table.Rows[i][4].ToString();
                info.Sum = table.Rows[i][5].ToString();
                info.Yin = table.Rows[i][6].ToString();
                info.Yang = table.Rows[i][7].ToString();
                info.Yisi = table.Rows[i][8].ToString();
                list.Add(info);
            }

            //得到行和列标题 及数量            
            string[] DeptNames = list.Select(t => t.DeptName).Distinct().ToArray();
            string[] ItemNames = list.Select(t => t.ItemName).Distinct().ToArray();

            //创建DataTable
            DataTable tabledisplay = new DataTable();

            //表中第一行第一列交叉处一般显示为第1列标题
            tabledisplay.Columns.Add(new DataColumn("序号"));
            tabledisplay.Columns.Add(new DataColumn("检测站点名称"));

            //表中后面每列的标题其实是列分组的关键字
            for (int i = 0; i < ItemNames.Length; i++)
            {
                DataColumn column = new DataColumn(ItemNames[i]);
                tabledisplay.Columns.Add(column);
            }
            //表格后面为合计列
            tabledisplay.Columns.Add(new DataColumn("合计"));
            tabledisplay.Columns.Add(new DataColumn("阴性样本"));
            tabledisplay.Columns.Add(new DataColumn("疑似阳性样本"));
            tabledisplay.Columns.Add(new DataColumn("阳性样本"));

            //为表中各行生成数据
            for (int i = 0; i < DeptNames.Length; i++)
            {
                var row = tabledisplay.NewRow();
                //每行第0列为行分组关键字
                row[0] = i + 1;
                row[1] = DeptNames[i];
                //每行的其余列为行列交叉对应的汇总数据
                for (int j = 0; j < ItemNames.Length; j++)
                {
                    string num = list.Where(t => t.DeptName == DeptNames[i] && t.ItemName == ItemNames[j]).Select(t => t.Count).FirstOrDefault();
                    if (num == null || num == "")
                    {
                        num = '0'.ToString();
                    }
                    row[ItemNames[j]] = num;
                }
                row[ItemNames.Length + 2] = list.Where(t => t.DeptName == DeptNames[i]).Select(t => t.Sum).FirstOrDefault();
                row[ItemNames.Length + 3] = list.Where(t => t.DeptName == DeptNames[i]).Select(t => t.Yin).FirstOrDefault();
                row[ItemNames.Length + 4] = list.Where(t => t.DeptName == DeptNames[i]).Select(t => t.Yisi).FirstOrDefault();
                row[ItemNames.Length + 5] = list.Where(t => t.DeptName == DeptNames[i]).Select(t => t.Yang).FirstOrDefault();

                tabledisplay.Rows.Add(row);
            }

            //表格最后添加合计行
            tabledisplay.Rows.Add(tabledisplay.NewRow()[1] = "合计");
            for (int j = 2; j < tabledisplay.Columns.Count; j++)
            {
                int sum = 0;
                for (int i = 0; i < tabledisplay.Rows.Count - 1; i++)
                {
                    sum += Convert.ToInt32(tabledisplay.Rows[i][j].ToString());
                }
                //sum_column += sum;
                tabledisplay.Rows[tabledisplay.Rows.Count - 1][j] = sum;
            }

            //表格的标题
            string title = "";
            title = string.Format("■{0}年{1}月  检测数据月报表（单位：份次）", _year.Text, _month.Text);
            _tableview.SetDataTable(tabledisplay, title, new List<int>());

        }

        private void _export_Click(object sender, RoutedEventArgs e)
        {
            _tableview.ExportExcel();
        }
        [Serializable]
        public class DeptItemInfo
        {
            //public string DeptId { get; set; }

            public string DeptName { get; set; }

            //public string ItemId { get; set; }

            public string ItemName { get; set; }

            public string Count { get; set; }

            public string Sum { get; set; }

            public string Yin { get; set; }

            public string Yang { get; set; }

            public string Yisi { get; set; }
        }
    }
}
