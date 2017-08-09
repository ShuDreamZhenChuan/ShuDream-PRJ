using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Smart
{
    public class ProcessingConfigurationfile
    {
        private XmlDocument mDocument = new XmlDocument ();      // 读取配置文件
        private string configFileLocation;  // 配置文件物理位置
        private static string language;

        public static string Language
        {
            get { return ProcessingConfigurationfile.language; }
            set { ProcessingConfigurationfile.language = value; }
        }

       
        public ProcessingConfigurationfile()
        {
            configFileLocation = Application.StartupPath + "\\ConfigFile.xml";
            mDocument.Load(configFileLocation);
            XmlNode mCurrentNode;
            mCurrentNode = mDocument.DocumentElement.SelectSingleNode("//languageSetting");
            XmlNodeList nodeList = mCurrentNode.SelectNodes("*");
           if(nodeList.Count>0)
               ProcessingConfigurationfile.Language = nodeList[0].InnerText;
        }

        #region TestConnectionDatabase
        // 测试数据库
        public bool TestConnectionDatabase()
        {
            while (true)
            {
                bool ret = GenerateConnectionString();
                if (ret == false)
                {
                    if (DialogResult.Yes == MessageBox.Show("连接数据库失败，是否要配置连接参数！", "提问",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question,
                                                  MessageBoxDefaultButton.Button1
                                                  ))
                    {
                        ConfigurationFileSettings configFileset = new ConfigurationFileSettings();
                        configFileset.ShowDialog();
                        if (configFileset.flag == 2)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                    continue;
                }
                break;
            }
            return true;
        }
        #endregion

        #region GenerateConnectionString
        // 从配置文件中读取数据，生成连接字符串, 并测试能否连接数据库
        private bool GenerateConnectionString()
        {
            try
            {
                mDocument.Load(configFileLocation);
                XmlNode mCurrentNode;
                mCurrentNode = mDocument.DocumentElement.SelectSingleNode("//connectionStrings");
                XmlNodeList nodeList = mCurrentNode.SelectNodes("*");

                // 通过配置文件，生成连接字符串
                DAL.SqlHelper.globeSqlConnString = @"Database='"+nodeList[2].InnerText+"';" +
                 "Data Source='" + nodeList[0].InnerText + "';" +
                 "User Id='" + nodeList[3].InnerText + "';" +
                 "Password='" + nodeList[4].InnerText + "';" +
                 "charset='utf8'";

                //Comm.GlobalVariables.connectionString = "Server=.\\SQLEXPRESS;DataBase=BTV7DB;User ID=sa;Password=111111;Connect Timeout=15";
            }
            catch (Exception ee)
            {
                MessageBox.Show("错误信息:" + ee.Message);
            }

            MySqlConnection testConnection = new MySqlConnection();
            try
            {
                // 测试是否能连接数据库
                testConnection.ConnectionString = DAL.SqlHelper.globeSqlConnString;              
                testConnection.Open();
            }
            catch 
            {
                return false;
            }

            testConnection.Close();
            return true;
        }
        #endregion
    }
}
