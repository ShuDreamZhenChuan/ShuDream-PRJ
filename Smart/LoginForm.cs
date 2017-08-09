using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Smart
{
    public partial class LoginForm : Smart.Core.StandardForm
    {
        public DAL.DAO.UserInfoDao _userinfodao = null;

        ResourceManager _resc;

        public bool isLoginSuccess;
        public LoginForm()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Smart.ProcessingConfigurationfile.Language);
            _resc = new ResourceManager(typeof(LoginForm));
            InitializeComponent();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {

            if (UserLogin(this.txb_Account.Text, this.txb_Pwd.Text))
            {
                this.isLoginSuccess = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("登录失败!");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.isLoginSuccess = false;
            this.Close();
        }

        private bool UserLogin(string userName, string Pwd)
        { 
          //验证数据库用户信息
          DAL.DAO.UserInfoDao info=(new DAL.DAL_UserInfo()).selectUserInfoWithNameAndPwd(userName, Pwd);
          if (info != null)
          {
              _userinfodao = info;
              return true;
          }
          else
              return false;
          
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            LoadLanguage("");
        }

        private void LoadLanguage(string languagetype)
        {
            try
            {
              
                this.Text = _resc.GetString("userlogin");
                this.label1.Text = _resc.GetString("account");
                this.label2.Text = _resc.GetString("password");
                this.btn_Login.Text = _resc.GetString("login");
                this.btn_Exit.Text = _resc.GetString("exit");
            }
            catch(Exception ex)
            {
               
            
            
            }
        }
    }
}
