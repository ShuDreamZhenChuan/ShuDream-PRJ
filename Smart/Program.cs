using Smart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DAL;

namespace WinDemo
{
    static class Program
    {

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
      {
          try
          {

              Application.EnableVisualStyles();
              Application.SetCompatibleTextRenderingDefault(false);

              bool gonoOrQuit = true;  // 用户注销，或退出

              while (gonoOrQuit)
              {
                  ProcessingConfigurationfile pConfingFile = new ProcessingConfigurationfile();
                  if (!pConfingFile.TestConnectionDatabase())  // 测试是否可以连接数据库 
                      return;
                  /*Comm.GlobalVariables.connectionString = "Data Source=localhost;Initial Catalog=BTV7DB_2014_2;Integrated Security=True;Trusted_Connection=True;";*/
                  // 登录窗口
                  LoginForm loginWindow = new LoginForm();
                  loginWindow.ShowDialog();

                  if (loginWindow.isLoginSuccess)
                  {
                      Application.Run(new FrmMain(loginWindow._userinfodao));
                  }
                  else
                  {
                      gonoOrQuit = false;
                      Application.Exit();
                  }
              }
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message);
          }
        }
    }
}
