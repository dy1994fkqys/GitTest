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
using System.Windows.Shapes;
using FoodSafetyMonitoring.dao;
using DBUtility;
using System.Data;
using Toolkit = Microsoft.Windows.Controls;

namespace FoodSafetyMonitoring.Manager
{
    /// <summary>
    /// SetTaskGrade.xaml 的交互逻辑
    /// </summary>
    public partial class SetTaskGrade : Window
    {
        private IDBOperation dbOperation;
        private string gradeId;
        private string cityId;
        private DataTable currentTable;

        public SetTaskGrade(IDBOperation dbOperation, string grade_id, string city_id, DataTable current_table)
        {
            InitializeComponent();

            this.dbOperation = dbOperation;

            gradeId = grade_id;

            cityId = city_id;

            currentTable = current_table;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (_grade_down.Text == "" || _grade_up.Text == "") 
            {
                _txtmsg.Text = "*请输入参数！";
                return;
            }

            if (int.Parse(_grade_up.Text) <= int.Parse(_grade_down.Text))
            {
                _txtmsg.Text = "*参数下限值必须小于上限值！";
                return;
            }

            bool exit_flag = dbOperation.GetDbHelper().Exists(string.Format("select count(gradeId) from t_city_grade where cityId = '{0}' and gradeId = '{1}'", cityId, gradeId));

            if (exit_flag)
            {
                int n = dbOperation.GetDbHelper().ExecuteSql(string.Format("update t_city_grade set parameterDown='{0}',parameterUp = '{1}',createUserid='{2}',createDate='{3}' where cityId = '{4}' and gradeId = '{5}' ",
                                                                  _grade_down.Text, _grade_up.Text,
                                                                  (Application.Current.Resources["User"] as UserInfo).ID,
                                                                  DateTime.Now, cityId, gradeId));
                if (n == 1)
                {
                    Toolkit.MessageBox.Show("检测任务指标更新成功！", "系统提示", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
                else
                {
                    Toolkit.MessageBox.Show("检测任务指标更新失败！", "系统提示", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
            }
            else
            {
                int n = dbOperation.GetDbHelper().ExecuteSql(string.Format("insert into t_city_grade(cityId,gradeId,parameterDown,parameterUp,createUserid,createDate) values('{0}','{1}','{2}','{3}','{4}', '{5}')",
                                                                 cityId, gradeId, _grade_down.Text, _grade_up.Text,
                                                                 (Application.Current.Resources["User"] as UserInfo).ID,
                                                                 DateTime.Now));
                if (n == 1)
                {
                    Toolkit.MessageBox.Show("检测任务指标插入成功！", "系统提示", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
                else
                {
                    Toolkit.MessageBox.Show("检测任务指标插入失败！", "系统提示", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
            }
        }

        private void Thumb_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {
            this.Left += e.HorizontalChange;
            this.Top += e.VerticalChange;
        }

        private void exit_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.Close();
            }
        }
    }
}
