using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace SmartPlugin.SmartChildForm
{
    public partial class EditGroupForm : Smart.Core.StandardForm
    {
        string groupid;

        DAL.DAO.GroupDao groupdao = null;

        ResourceManager _resc;

        public EditGroupForm(string groupid)
        {
            _resc = new ResourceManager(typeof(EditDeviceForm));
            this.groupid = groupid;
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            if(!CheckInfo())
                return;
            DAL.DAL_Group groupdal = new DAL.DAL_Group();

            groupdao.Grouppname = txb_GroupName.Text;
            groupdao.Groupmanager = txb_GroupManager.Text;
            groupdao.Managerphone = txb_TelePhone.Text;
            groupdao.Describe = txb_Remark.Text;

            if (groupdal.updateGroupInfo(groupid, groupdao))
            {
                MessageBox.Show("修改成功!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("修改失败!");
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

            if (txb_TelePhone.Text == "" || !Smart.ToolUtil.StringControlUtil.CheckPhoneNum(txb_TelePhone.Text))
            {
                MessageBox.Show("电话号码填写不正确");
                return false;
            }
            return true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditGroupForm_Load(object sender, EventArgs e)
        {
            LoadLanguage("");

            DAL.DAL_Group groupdal = new DAL.DAL_Group();

            groupdao = groupdal.selectGroupInfoWithId(groupid);

            if (groupdao == null)
            {
                MessageBox.Show("获取部门信息失败！");
                this.Close();
            }
            else
            {
                this.txb_GroupName.Text = groupdao.Grouppname;
                this.txb_GroupManager.Text = groupdao.Groupmanager;
                this.txb_TelePhone.Text = groupdao.Managerphone;
                this.txb_Remark.Text = groupdao.Describe;
            }
        }

        private void LoadLanguage(string languagetype)
        {
            try
            {
                this.Text = _resc.GetString("editgroup");
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
    }
}
