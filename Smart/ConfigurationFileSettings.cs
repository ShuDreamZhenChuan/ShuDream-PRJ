using System;
using System.Windows.Forms;
using System.Xml;

namespace Smart
{
    public partial class ConfigurationFileSettings : Form
    {
        private XmlDocument mDocument;    // 读取配置文件
        public int flag = 0;              // 判断用户怎么退出窗口，修改(1)或放弃(2)

        #region public ConfigurationFileSettings()
        public ConfigurationFileSettings()
        {
            InitializeComponent();
        }
        #endregion

        #region private void ConfigurationFileSettings_Load(object sender, EventArgs e)
        private void ConfigurationFileSettings_Load(object sender, EventArgs e) // 读出配置文件
        {
            mDocument = new XmlDocument();
            string configFileLocation = Application.StartupPath + "\\ConfigFile.xml";
            mDocument.Load(configFileLocation);
            XmlNode mCurrentNode = mDocument.DocumentElement.FirstChild;

            XmlNode node;
            node = mCurrentNode.SelectSingleNode("//ServerIP");
            this.textBox_IP.Text = node.InnerText;
                
            node = mCurrentNode.SelectSingleNode("//Port");
            this.textBox_Port.Text = node.InnerText;

            node = mCurrentNode.SelectSingleNode("//Database");
            this.textBox_DataBase.Text = node.InnerText;
             
            node = mCurrentNode.SelectSingleNode("//UserID");
            this.textBox_Use.Text = node.InnerText;

            node = mCurrentNode.SelectSingleNode("//password");
            this.textBox_PassWord.Text = node.InnerText;
            
            node = mCurrentNode.SelectSingleNode("//ConnectionTimeout");
            this.textBox_Connection_TimeOut.Text = node.InnerText; 
        }
        #endregion

        #region private void button_OK_Click(object sender, EventArgs e)
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (this.textBox_IP.Text == "" &&
                this.textBox_Port.Text == "" &&
                this.textBox_DataBase.Text == "" &&
                this.textBox_Use.Text == "" &&
                this.textBox_PassWord.Text == "" &&
                this.textBox_Connection_TimeOut.Text == "" )
            {
                MessageBox.Show("请输入要修改的数据！","提示");
                return;
            }
             mDocument = new XmlDocument();
             string configFileLocation = System.Windows.Forms.Application.StartupPath + "\\ConfigFile.xml";
             mDocument.Load(configFileLocation);
             XmlNode  mCurrentNode = mDocument.DocumentElement.FirstChild;

             if (this.textBox_IP.Text != "")
             {
                 XmlNode node = mCurrentNode.SelectSingleNode("//ServerIP");
                 node.InnerText = this.textBox_IP.Text;
             }

             if (this.textBox_Port.Text != "")
             {
                 XmlNode node = mCurrentNode.SelectSingleNode("//Port");
                 node.InnerText = this.textBox_Port.Text;
             }

             if (this.textBox_DataBase.Text != "")
             {
                 XmlNode node = mCurrentNode.SelectSingleNode("//Database");
                 node.InnerText = this.textBox_DataBase.Text;
             }

             if (this.textBox_Use.Text != "")
             {
                 XmlNode node = mCurrentNode.SelectSingleNode("//UserID");
                 node.InnerText = this.textBox_Use.Text;
             }

             if (this.textBox_PassWord.Text != "")
             {
                 XmlNode node = mCurrentNode.SelectSingleNode("//password");
                 node.InnerText = this.textBox_PassWord.Text;
             }

             if (this.textBox_Connection_TimeOut.Text != "")
             {
                 XmlNode node = mCurrentNode.SelectSingleNode("//ConnectionTimeout");
                 node.InnerText = this.textBox_Connection_TimeOut.Text;
             }

            mDocument.Save(configFileLocation);

            MessageBox.Show("保存成功！", "提示");
            flag = 1;
            this.Dispose();
        }
        #endregion

        #region private void button_Cancel_Click(object sender, EventArgs e)
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            flag = 2;
            this.Dispose();
        }
        #endregion

    }
}