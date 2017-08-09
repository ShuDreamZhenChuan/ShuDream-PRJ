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
    public partial class EditPassword : Smart.Core.StandardForm
    {
        private string userid;

        ResourceManager _resc;

        public EditPassword(string id)
        {
            _resc = new ResourceManager(typeof(EditPassword));
            userid = id;
            InitializeComponent();
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {

            if (!checkinfo())
                return;

            if ((new DAL.DAL_UserInfo()).editpwdwithuserid(userid, this.txb_newpwd.Text))
            {
                MessageBox.Show("修改成功");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("修改失败");
        }

        private bool checkinfo()
        {
            if (!(new DAL.DAL_UserInfo()).checkpwdwithuserid(userid, this.txb_oldpwd.Text))
            {
                MessageBox.Show("旧密码错误");
                return false;
            }
            if (this.txb_newpwd.Text == "" || this.txb_confirmpwd.Text == "" || this.txb_newpwd.Text != this.txb_confirmpwd.Text)
            {
                MessageBox.Show("请正确设置新密码");
                return false;
            }

            return true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_newpwd_TextChanged(object sender, EventArgs e)
        {
            if (txb_newpwd.Text != txb_confirmpwd.Text)
            {
                lab_error.Text = "确认密码与新密码不一致";
            }
            else
                lab_error.Text = "";
        }

        private void txb_confirmpwd_TextChanged(object sender, EventArgs e)
        {
            if (txb_newpwd.Text != txb_confirmpwd.Text)
            {
                lab_error.Text = "确认密码与新密码不一致";
            }
            else
                lab_error.Text = "";
        }

        private void EditPassword_Load(object sender, EventArgs e)
        {
            LoadLanguage("");
        }

        private void LoadLanguage(string languagetype)
        {
            try
            {
                this.Text = _resc.GetString("editpassword");
                this.label1.Text = _resc.GetString("oldpassword");
                this.label2.Text = _resc.GetString("newpassword");
                this.label3.Text = _resc.GetString("newpasswordconfirm");
                this.btn_enter.Text = _resc.GetString("enter");
                this.btn_cancel.Text = _resc.GetString("cancel");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
