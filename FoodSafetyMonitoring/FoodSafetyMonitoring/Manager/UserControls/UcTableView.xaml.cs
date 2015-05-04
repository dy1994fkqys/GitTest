using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

namespace FoodSafetyMonitoring.Manager.UserControls
{
    /// <summary>
    /// UcTableView.xaml 的交互逻辑
    /// </summary>
    public partial class UcTableView : UserControl
    {
        public UcTableView()
        {
            InitializeComponent();
            this.SizeChanged += new SizeChangedEventHandler(UcTableView_SizeChanged);
        }

        void UcTableView_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (dt == null)
            {
                return;
            }
            _gridview.Columns.Clear();
            foreach (DataColumn c in dt.Columns)
            {
                GridViewColumn gvc = new GridViewColumn();
                gvc.Header = c.ColumnName;
                gvc.Width = _listview.ActualWidth / dt.Columns.Count - 1;
                gvc.DisplayMemberBinding = (new Binding(c.ColumnName));
                _gridview.Columns.Add(gvc);
            }
            _listview.ItemsSource = null;
            _listview.ItemsSource = dt.DefaultView;
        }

        private DataTable dt;
        private string title;
        private List<int> columnNumbers;
        //private List<int> sumColumns = new List<int>();

        public void SetDataTable(DataTable _dt, string title, List<int> columnNumbers)
        {
            this.dt = _dt.Copy();
            this.title = title;
            this.columnNumbers = columnNumbers;
            _title.Text = title;

            _gridview.Columns.Clear();
            foreach (DataColumn c in dt.Columns)
            {
                GridViewColumn gvc = new GridViewColumn();
                gvc.Header = c.ColumnName;
                gvc.Width = _listview.ActualWidth / dt.Columns.Count - 4;
                gvc.DisplayMemberBinding = (new Binding(c.ColumnName));
                _gridview.Columns.Add(gvc);
            }
            _listview.ItemsSource = dt.DefaultView;
        }

        public void ExportExcel()
        {
            if (dt == null)
            {
                return;
            }
            System.Windows.Forms.SaveFileDialog sfd = new System.Windows.Forms.SaveFileDialog();
            sfd.Filter = "导出文件 (*.csv)|*.csv";
            sfd.FilterIndex = 0;
            sfd.RestoreDirectory = true;
            sfd.Title = "导出文件保存路径";
            sfd.ShowDialog();
            string strFilePath = sfd.FileName;
            if (strFilePath != "")
            {
                if (File.Exists(strFilePath))
                {
                    File.Delete(strFilePath);
                }
                StreamWriter sw = new StreamWriter(new FileStream(strFilePath, FileMode.CreateNew), Encoding.Default);
                string tableHeader = " ";
                foreach (DataColumn c in dt.Columns)
                {
                    GridViewColumn gvc = new GridViewColumn();
                    tableHeader += c.ColumnName + ",";
                }
                sw.WriteLine(title);
                sw.WriteLine(tableHeader);

                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    DataRow row = dt.Rows[j];
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        sb.Append(row[i]);
                        sb.Append(",");
                    }
                    sw.WriteLine(sb);
                }

                //StringBuilder sum_sb = new StringBuilder();
                //for (int i = 0; i < dt.Columns.Count; i++)
                //{
                //    if (i == 0)
                //    {
                //        sum_sb.Append("共计");
                //    }
                //    else if (columnNumbers.Contains(i))
                //    {
                //        sum_sb.Append(sumColumns[columnNumbers.IndexOf(i)]);
                //    }
                //    sum_sb.Append(",");
                //}
                //sw.WriteLine(sum_sb);

                sw.Close();
                MessageBox.Show("导出文件成功！", "成功", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


    }

    public class MyColumn
    {
        //原始列名
        private string column_source;

        public string Column_source
        {
            get { return column_source; }
            set { column_source = value; }
        }
        /// <summary>
        /// 显示列名
        /// </summary>
        private string column_show;

        public string Column_show
        {
            get { return column_show; }
            set { column_show = value; }
        }
        /// <summary>
        /// 列宽
        /// </summary>
        private int width = 1;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        /// <summary>
        /// 是否显示
        /// </summary>
        private bool bShow = true;

        public bool BShow
        {
            get { return bShow; }
            set { bShow = value; }
        }

        public MyColumn(string column_source, string column_show) 
        {
            this.column_show = column_show;
            this.column_source = column_source;
        }
    }


    public class BackGroundConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            ListViewItem lvi = (ListViewItem)value;
            ListView lv = ItemsControl.ItemsControlFromItemContainer(lvi) as ListView;
            int index = lv.ItemContainerGenerator.IndexFromContainer(lvi);
            if (index % 2 == 0)
            {
                return Brushes.AliceBlue;
            }
            else
            {
                return Brushes.Azure;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}
