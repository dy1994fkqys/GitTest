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
using System.Data;
using DBUtility;
using FoodSafetyMonitoring.Common;
using Toolkit = Microsoft.Windows.Controls;

namespace FoodSafetyMonitoring.Manager
{
    /// <summary>
    /// detectDetailsReview.xaml 的交互逻辑
    /// </summary>
    public partial class detectDetailsReview : Window
    {
        private IDBOperation dbOperation;
        private DbHelperMySQL dbHelper = null;
        int orderid ;

        public detectDetailsReview(IDBOperation dbOperation, int id)
        {
            InitializeComponent();

            this.dbOperation = dbOperation;
            dbHelper = DbHelperMySQL.CreateDbHelper();

            orderid = id;

            string reviewflag = dbHelper.GetSingle(string.Format("select ReviewFlag from t_detect_report where ORDERID = '{0}'", id)).ToString();
            DataTable table = dbOperation.GetDbHelper().GetDataSet(string.Format("call p_detect_details('{0}')", id)).Tables[0];

            //给画面上的控件赋值
            _areaName.Text = table.Rows[0][10].ToString();
            _companyName.Text = table.Rows[0][11].ToString();
            _cardId.Text = table.Rows[0][12].ToString();
            _itemName.Text = table.Rows[0][3].ToString();
            _objectName.Text = table.Rows[0][4].ToString();
            _sampleName.Text = table.Rows[0][5].ToString();
            _reagentName.Text = table.Rows[0][7].ToString();
            _sensitivityName.Text = table.Rows[0][6].ToString();
            _resultName.Text = table.Rows[0][8].ToString();
            _deptName.Text = table.Rows[0][2].ToString();
            _detectDate.Text = table.Rows[0][1].ToString();
            _detectUserName.Text = table.Rows[0][9].ToString();
            _detectTypeName.Text = table.Rows[0][0].ToString();

            if (reviewflag == "1")
            {
                _reviewUserid.Text = table.Rows[0][14].ToString();
                _reviewReagent_text.Text = table.Rows[0][15].ToString();
                _reviewResult_text.Text = table.Rows[0][16].ToString();
                _reviewDate.Text = table.Rows[0][17].ToString();
                btnSave.Visibility = Visibility.Hidden;
                _reviewReagent.Visibility = Visibility.Hidden;
                _reviewResult.Visibility = Visibility.Hidden;
                _reviewReagent_text.Visibility = Visibility.Visible;
                _reviewResult_text.Visibility = Visibility.Visible;
                _reviewBz.IsEnabled = false;
                
            }
            else
            {
                _reviewUserid.Text = (Application.Current.Resources["User"] as UserInfo).ShowName;
                _reviewDate.Text = DateTime.Now.ToString();
                ComboboxTool.InitComboboxSource(_reviewResult, "SELECT resultId,resultName FROM t_det_result where openFlag = '1' ORDER BY id","lr");
                ComboboxTool.InitComboboxSource(_reviewReagent, "select reagentId,reagentName from t_det_reagent where openFlag = '1' and reagentId <> '1'", "lr");

                btnSave.Visibility = Visibility.Visible;
                _reviewReagent.Visibility = Visibility.Visible;
                _reviewResult.Visibility = Visibility.Visible;
                _reviewReagent_text.Visibility = Visibility.Hidden;
                _reviewResult_text.Visibility = Visibility.Hidden;
                _reviewBz.IsEnabled = true;
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

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (_reviewReagent.SelectedIndex < 1)
            {
                txtMsg.Text = "*请选择检查方法";
                return;
            }

            if (_reviewResult.SelectedIndex < 1)
            {
                txtMsg.Text = "*请选择检查结果";
                return;
            }

            if (_reviewBz.Text == "")
            {
                txtMsg.Text = "*请输入原因说明";
                return;
            }
            
            string strSql ;
            string strSql2;

            strSql = string.Format(@"update t_detect_report set ReviewFlag= '1' where  ORDERID = '{0}'", orderid);
            strSql2 = string.Format(@"insert into t_detect_review(DetectId,ReviewUserid,ReviewReagentid,ReviewResultid,ReviewDate,ReviewReason)
                                      values('{0}','{1}','{2}','{3}','{4}','{5}')", orderid, (Application.Current.Resources["User"] as UserInfo).ID,
                                      (_reviewReagent.SelectedItem as Label).Tag, (_reviewResult.SelectedItem as Label).Tag, DateTime.Now,
                                      _reviewBz.Text);
            try
            {

                int num = dbHelper.ExecuteSql(strSql);
                int num2 = dbHelper.ExecuteSql(strSql2);
                if (num == 1 && num2 ==1)
                {
                    Toolkit.MessageBox.Show("保存成功！", "系统提示", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                    return;
                }
                else
                {
                    Toolkit.MessageBox.Show("保存失败！", "系统提示", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                    return;
                }
            }
            catch (Exception)
            {
                Toolkit.MessageBox.Show("保存失败！", "系统提示", MessageBoxButton.OKCancel, MessageBoxImage.Information);
                return;
            }

            txtMsg.Text = "";
        }
    }
}
