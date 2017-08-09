using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace SmartPlugin
{
    public partial class NewGroupForm : Smart.Core.StandardForm
    {
        public int NodeType = 0;

        public DataTable _dt = null;

        ResourceManager _resc;

        public NewGroupForm()
        {
            _resc = new ResourceManager(typeof(NewGroupForm));
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            if (!CheckInfo())
                return;

            DAL.DAL_Group groupdal = new DAL.DAL_Group();
            DAL.DAO.GroupDao _dao=new DAL.DAO.GroupDao();

            _dao.Grouppname=txb_GroupName.Text;
            _dao.Groupmanager=txb_GroupManager.Text;
            _dao.Managerphone=txb_TelePhone.Text;
            _dao.Describe=txb_Remark.Text;

            if (groupdal.insertGroup(_dao))
            {
                MessageBox.Show("添加成功");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private bool CheckInfo()
        {
            if (txb_GroupName.Text == "")
            {
                MessageBox.Show("请填写部门名称");
                return false;
            }
            if (txb_GroupManager.Text == "")
            {
                MessageBox.Show("请填写部门负责人");
                return false;
            }

            if (txb_TelePhone.Text == "" ||!Smart.ToolUtil.StringControlUtil.CheckPhoneNum(txb_TelePhone.Text))
            {
                MessageBox.Show("请正确填写电话号码");
                return false;
            }
            return true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewGroupForm_Load(object sender, EventArgs e)
        {
            LoadLanguage("");
            _dt = (new DAL.DAL_Group()).selectGroupListInfo();

            if (this.NodeType == 1)
                this.Text = "添加同级部门";
            else if (this.NodeType == 2)
                this.Text = "添加子部门";
        }

        private void LoadLanguage(string languagetype)
        {
            try
            {
                this.Text = _resc.GetString("addgroup");
                this.lab3.Text = _resc.GetString("name");
                this.label4.Text = _resc.GetString("manager");
                this.label5.Text = _resc.GetString("telephone");
                this.label6.Text = _resc.GetString("remark");

                btn_OK.Text = _resc.GetString("enter");
                btn_Cancel.Text = _resc.GetString("cancel");
            }
            catch (Exception ex)
            {

            }
        }

        private void txb_TelePhone_TextChanged(object sender, EventArgs e)
        {

        }

        void txb_GroupName_Leave(object sender, System.EventArgs e)
        {
            TextBox _box = (TextBox)sender;

            if (_box.Text != "")

            {
                foreach (DataRow _row in _dt.Rows)
                {
                    if (_box.Text.Equals(_row[1].ToString()))
                    {
                        MessageBox.Show("部门已存在");
                        _box.Text = "";
                    }

                }
            }
        }
    }
}
