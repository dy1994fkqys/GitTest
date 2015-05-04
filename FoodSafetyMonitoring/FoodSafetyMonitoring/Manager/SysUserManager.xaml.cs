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
using Toolkit = Microsoft.Windows.Controls;
using DBUtility;
using System.Data;
using FoodSafetyMonitoring.Common;
using FoodSafetyMonitoring.dao;
using System.Security.Cryptography;

namespace FoodSafetyMonitoring.Manager
{
    /// <summary>
    /// Test.xaml 的交互逻辑
    /// </summary>
    public partial class SysUserManager : UserControl
    {
        private DbHelperMySQL dbHelper = null;

        public SysUserManager()
        {
            InitializeComponent();

            this.Loaded += new RoutedEventHandler(Test_Loaded);
        }

        void Test_Loaded(object sender, RoutedEventArgs e)
        {
            BindData();
            Clear();
            ComboboxTool.InitComboboxSource(cmbRoleType, "SELECT NUMB_ROLE,INFO_NAME FROM sys_client_role where cuserid="
                + (Application.Current.Resources["User"] as UserInfo).ID, "lr");
            ComboboxTool.InitComboboxSource(_department, "call p_dept_count(" + (Application.Current.Resources["User"] as UserInfo).ID + ")", "lr");
        }

        /// <summary>
        /// 从数据库获取数据
        /// </summary>
        private void BindData()
        {
            string strSql = "select RECO_PKID,NUMB_USER,INFO_USER from sys_client_user where cuserid = "  + (Application.Current.Resources["User"] as UserInfo).ID ;

            try
            {
                dbHelper = DbHelperMySQL.CreateDbHelper();
                DataTable dt = dbHelper.GetDataSet(strSql).Tables[0];
                lvlist.DataContext = null;
                lvlist.DataContext = dt;
                lvlist.Tag = dt;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void TextboxSearchControl_ImageClick(object sender, EventArgs e)
        {
            SelectUser(txtSearch.Text.Trim(), "");
        }

        /// <summary>
        /// 从内存表中查询用户
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="userType">角色类型</param>
        private void SelectUser(string userName, string userType)
        {
            StringBuilder sbSql = new StringBuilder();
            if (userName != "")
            {
                sbSql.Append("INFO_USER like '%" + userName + "%'");
                if (userType != "")
                {
                    sbSql.Append(" AND ROLE_ID = '" + userType + "'");
                }
            }
            else
            {
                if (userType != "")
                {
                    sbSql.Append(" ROLE_ID = '" + userType + "'");
                }
            }

            if (sbSql.ToString() != "")
            {
                DataRow[] drs = (lvlist.Tag as DataTable).Select(sbSql.ToString());
                DataTable temp = (lvlist.Tag as DataTable).Clone();
                foreach (DataRow row in drs)
                {
                    DataRow dr = temp.NewRow();
                    dr.ItemArray = row.ItemArray;
                    temp.Rows.Add(dr);
                }
                lvlist.DataContext = temp;
            }
            else
            {
                lvlist.DataContext = (lvlist.Tag as DataTable);
            }
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            this.txtUserName.IsEnabled = true;
            this.cmbRoleType.IsEnabled = true;
            //this.txtPwd.IsEnabled = true;
            //this.txtConfirmPwd.IsEnabled = true;
            this.dtpStartDate.IsEnabled = true;
            this.dtpEndDate.IsEnabled = true;
            this.txtComment.IsEnabled = true;
            this._loginName.IsEnabled = true;
            this._department.IsEnabled = true;
        }


        private void FrameworkElement_GotFocus(object sender, RoutedEventArgs e)
        {
            ClearTip(sender);
        }

        private void Clear()
        {
            this._loginName.Text = "";
            this.txtUserName.Text = "";
            this.cmbRoleType.SelectedIndex = 0;
            //this.txtPwd.Password = "";
            //this.txtConfirmPwd.Password = "";
            this.dtpStartDate.Value = DateTime.Now;
            this.dtpEndDate.Value = DateTime.Now;
            this.txtComment.Text = "";

            this.txtUserName.IsEnabled = false;
            this.cmbRoleType.IsEnabled = false;
            this._loginName.IsEnabled = false;
            //this.txtPwd.IsEnabled = false;
            //this.txtConfirmPwd.IsEnabled = false;
            this.dtpStartDate.IsEnabled = false;
            this._department.IsEnabled = false;
            this.dtpEndDate.IsEnabled = false;
            this.txtComment.IsEnabled = false;

            this.txtMsg.Text = "";
            this.btnSave.Tag = null;
            this.txtUserName.Focus();
        }

        #region 删除用户

        private bool DeleteUser(string id)
        {
            bool result = false;
            string strSql = string.Format("delete from sys_client_user where RECO_PKID=" + id);
            try
            {
                int num = dbHelper.ExecuteSql(strSql);
                if (num == 1)
                {
                    result = true;
                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
        #endregion



        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (this.txtUserName.Text.Trim() == "")
            {
                txtMsg.Text = "*用户名不能为空！";
                txtMsg.Tag = "txtUserName";
                return;
            }

            if (this.txtUserName.Text.Trim() == "")
            {
                txtMsg.Text = "*用户名不能为空！";
                txtMsg.Tag = "txtUserName";
                return;
            }

            if (this.cmbRoleType.SelectedIndex <= 0)
            {
                txtMsg.Text = "*角色类型未选择！";
                txtMsg.Tag = "cmbRoleType";
                return;
            }

            //if (this.txtPwd.Password.Trim() == "")
            //{
            //    txtMsg.Text = "*密码不能为空！";
            //    txtMsg.Tag = "txtPwd";
            //    return;
            //}

            //if (this.txtConfirmPwd.Password.Trim() == "")
            //{
            //    txtMsg.Text = "*确认密码不能为空！";
            //    txtMsg.Tag = "txtConfirmPwd";
            //    return;
            //}

            //if (this.txtPwd.Password != this.txtConfirmPwd.Password)
            //{
            //    txtMsg.Text = "*密码和确认密码不一致！";
            //    txtMsg.Tag = "txtConfirmPwd";
            //    return;
            //}

            if (this.dtpStartDate.Value > this.dtpEndDate.Value)
            {
                txtMsg.Text = "*开始日期不能大于停止日期！";
                txtMsg.Tag = "dtpEndDate";
                return;
            }

            if (this._department.SelectedIndex < 1)
            {
                txtMsg.Text = "*选择所属部门！";
                txtMsg.Tag = "_department";
                return;
            }

            if (this.cmbRoleType.SelectedIndex < 1)
            {
                txtMsg.Text = "*选择角色！";
                txtMsg.Tag = "cmbRoleType";
                return;
            }

            //根据btnSave按钮的Tag属性判断是添加还是修改（null为添加，反之为修改）
            string strSql = string.Empty;

            if (btnSave.Tag == null)
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                string password = BitConverter.ToString(md5.ComputeHash(Encoding.Default.GetBytes("123456"))).Replace("-", "");

                strSql = string.Format(@"INSERT INTO sys_client_user(NUMB_USER,INFO_USER,INFO_PASSWORD,fk_dept,FK_CODE_ROLE,INFO_NOTE,START_DATE,END_DATE,ROLE_ID,cuserid) VALUES 
                                      ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                                      _loginName.Text, txtUserName.Text, password, (_department.SelectedItem as Label).Tag.ToString(),
                                      (cmbRoleType.SelectedItem as Label).Tag.ToString(), txtComment.Text, dtpStartDate.Value, dtpEndDate.Value,
                                      (cmbRoleType.SelectedItem as Label).Tag.ToString(), (Application.Current.Resources["User"] as UserInfo).ID);
            }
            else
            {
                strSql = string.Format(@"UPDATE sys_client_user SET NUMB_USER = '{0}', INFO_USER = '{1}', fk_dept = '{2}',FK_CODE_ROLE = '{3}',
                                       INFO_NOTE = '{4}', START_DATE = '{5}',END_DATE = '{6}',ROLE_ID = '{7}' WHERE RECO_PKID = {8}",
                                       _loginName.Text, txtUserName.Text.Trim(), (_department.SelectedItem as Label).Tag.ToString(),
                                      (cmbRoleType.SelectedItem as Label).Tag.ToString(), txtComment.Text, dtpStartDate.Value, dtpEndDate.Value,(cmbRoleType.SelectedItem as Label).Tag.ToString(), btnSave.Tag.ToString());
            }

            try
            {
                int num = dbHelper.ExecuteSql(strSql);
                if (num == 1)
                {
                    
                    Toolkit.MessageBox.Show("保存成功！", "系统提示", MessageBoxButton.OK, MessageBoxImage.Information);
                    if (btnSave.Tag == null)
                    {
                        Common.SysLogEntry.WriteLog("系统用户管理", (Application.Current.Resources["User"] as UserInfo).ShowName, OperationType.Add, "添加系统用户");
                    }
                    else
                    {
                        Common.SysLogEntry.WriteLog("系统用户管理", (Application.Current.Resources["User"] as UserInfo).ShowName, OperationType.Modify, "修改系统用户");
                    }
                    Clear();
                    BindData();
                }
                else
                {
                    Toolkit.MessageBox.Show("保存失败！", "系统提示", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
            }
            catch (Exception)
            {
                Toolkit.MessageBox.Show("保存失败！", "系统提示", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
        }

        /// <summary>
        /// 清除提示信息
        /// </summary>
        /// <param name="sender">控件</param>
        private void ClearTip(object sender)
        {
            string name = (sender as FrameworkElement).Name;
            if (txtMsg.Tag != null)
            {
                if (name == txtMsg.Tag.ToString())
                {
                    txtMsg.Text = "";
                }
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (Toolkit.MessageBox.Show("确定要删除该用户吗？", "系统询问", MessageBoxButton.YesNoCancel, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                string id = (sender as Button).Tag.ToString();
                if (DeleteUser(id))
                {
                    Toolkit.MessageBox.Show("删除成功！", "系统提示", MessageBoxButton.OK, MessageBoxImage.Information);
                    Common.SysLogEntry.WriteLog("系统用户管理", (Application.Current.Resources["User"] as UserInfo).ShowName, OperationType.Delete, "删除系统用户");
                    Clear();
                    BindData();
                }
                else
                {
                    Toolkit.MessageBox.Show("删除失败！", "系统提示", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnModify_Click(object sender, RoutedEventArgs e)
        {
            this.txtUserName.IsEnabled = true;
            this._loginName.IsEnabled = true;
            this.cmbRoleType.IsEnabled = true;
            this._department.IsEnabled = true;
            //this.txtPwd.IsEnabled = true;
            //this.txtConfirmPwd.IsEnabled = true;
            this.dtpStartDate.IsEnabled = true;
            this.dtpEndDate.IsEnabled = true;
            this.txtComment.IsEnabled = true;
            string id = (sender as Button).Tag.ToString();

            DataRow dr = dbHelper.GetDataSet("SELECT RECO_PKID,NUMB_USER,INFO_USER,INFO_PASSWORD,fk_dept,sys_client_sysdept.INFO_NAME,FK_CODE_ROLE,sys_client_user.INFO_NOTE,START_DATE,END_DATE " +
                        "FROM sys_client_user ,sys_client_sysdept " +
                        "WHERE sys_client_user.fk_dept = sys_client_sysdept.INFO_CODE " +
                        "AND sys_client_user.RECO_PKID = " + id).Tables[0].Rows[0];

            this.txtUserName.Text = dr["INFO_USER"].ToString();
            this._loginName.Text = dr["NUMB_USER"].ToString();

            for (int i = 0; i < cmbRoleType.Items.Count; i++)
            {
                if ((cmbRoleType.Items[i] as Label).Tag.ToString() == dr["FK_CODE_ROLE"].ToString())
                {
                    cmbRoleType.SelectedItem = cmbRoleType.Items[i];
                    break;
                }
            }

            for (int i = 0; i < _department.Items.Count; i++)
            {
                if ((_department.Items[i] as Label).Tag.ToString() == dr["fk_dept"].ToString())
                {
                    _department.SelectedItem = _department.Items[i];
                    break;
                }
            }

            //this.txtPwd.Password = dr["INFO_PASSWORD"].ToString();
            //this.txtConfirmPwd.Password = dr["INFO_PASSWORD"].ToString();
            this.dtpStartDate.Value = Convert.ToDateTime(dr["START_DATE"]);
            this.dtpEndDate.Value = Convert.ToDateTime(dr["END_DATE"]);
            this.txtComment.Text = dr["INFO_NOTE"].ToString();

            this.btnSave.Tag = id;
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            string strSql = string.Empty;

            MD5 md5 = new MD5CryptoServiceProvider();
            string password = BitConverter.ToString(md5.ComputeHash(Encoding.Default.GetBytes("123456"))).Replace("-", "");

            strSql = string.Format(@"UPDATE sys_client_user SET INFO_PASSWORD = '{0}' WHERE RECO_PKID = {1}", password, btnSave.Tag.ToString());

            try
            {
                int num = dbHelper.ExecuteSql(strSql);
                if (num == 1)
                {

                    Toolkit.MessageBox.Show("密码重置成功！", "系统提示", MessageBoxButton.OK, MessageBoxImage.Information);
                    Common.SysLogEntry.WriteLog("系统用户管理", (Application.Current.Resources["User"] as UserInfo).ShowName, OperationType.Add, "重置用户密码");
                    Clear();
                    BindData();
                }
                else
                {
                    Toolkit.MessageBox.Show("密码重置失败！", "系统提示", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
            }
            catch (Exception)
            {
                Toolkit.MessageBox.Show("数据处理失败！", "系统提示", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }
        }


    }
}
