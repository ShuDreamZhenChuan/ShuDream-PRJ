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
    public partial class NewUserForm : Smart.Core.StandardForm
    {
        ResourceManager _resc;

        public NewUserForm()
        {
            _resc = new ResourceManager(typeof(NewUserForm));
            InitializeComponent();
        }

        private void NewUserForm_Load(object sender, EventArgs e)
        {
            LoadLanguage("");

            DataTable dt = (new DAL.DAL_UserInfo()).getUserTypeList();

            if (dt.Rows.Count > 0)
            {
                cmb_UserType.Items.Clear();

                foreach(DataRow _row in dt.Rows)
                {
                    cmb_UserType.Items.Add(_row[0].ToString());
                }
            }
        }

        private void LoadLanguage(string languagetype)
        {
            try
            {
                this.Text = _resc.GetString("adduser");
                this.label1.Text = _resc.GetString("account");
                this.label2.Text = _resc.GetString("password");
                this.label3.Text = _resc.GetString("passwordconfirm");
                this.label6.Text = _resc.GetString("usertype");
              
                this.btn_CheckUserName.Text = _resc.GetString("check");
                this.btn_OK.Text = _resc.GetString("enter");
                this.btn_Cancel.Text = _resc.GetString("cancel");
            }
            catch (Exception ex)
            {

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (txb_UserName.Text != "")
            {
                DataTable _dt = (new DAL.DAL_UserInfo()).checkUserName(this.txb_UserName.Text);

                if (_dt.Rows.Count > 0)
                {
                    MessageBox.Show("用户名已存在,请选择其他用户名！");
                    txb_UserName.Text = "";
                }
                else
                {
                    MessageBox.Show("用户名可以使用！");
                }
            }
            else
            {
                MessageBox.Show("用户名不能为空！");
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (!CheckInfo())
                return;
            else
            {
                DAL.DAO.UserInfoDao userdao = new DAL.DAO.UserInfoDao();

                userdao.Name = txb_UserName.Text;
                userdao.Pwd = txb_Pwd.Text;
                userdao.Usertype = cmb_UserType.Text;

                if ((new DAL.DAL_UserInfo()).insertUserInfo(userdao))
                {
                    MessageBox.Show("添加成功!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("添加失败！");
            }
        }

        private bool CheckInfo()
        {
            if (txb_UserName.Text == "")
            {
                lab_error.Text = "用户名不能为空";
                return false;
            }

            if (txb_Pwd.Text == "")
            {
                lab_error.Text = "密码不能为空";
                return false;
            }

            if (txb_ConfirmPwd.Text!=txb_Pwd.Text)
            {
                lab_error.Text = "确认密码与密码不一致";
                return false;
            }

            if (cmb_UserType.Text == "")
            {
                lab_error.Text = "请选择用户所属类型";
                return false;
            }

            return true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_Pwd_TextChanged(object sender, EventArgs e)
        {
            if (txb_ConfirmPwd.Text != txb_Pwd.Text)
            {
                lab_error.Text = "确认密码与密码不一致";

            }
            else
                lab_error.Text = "";
        }

        private void txb_ConfirmPwd_TextChanged(object sender, EventArgs e)
        {
            if (txb_ConfirmPwd.Text != txb_Pwd.Text)
            {
                lab_error.Text = "确认密码与密码不一致";

            }
            else
                lab_error.Text = "";
        }

        private void cmb_UserType_TextChanged(object sender, EventArgs e)
        {
            if (cmb_UserType.Text!="")
            {
                lab_error.Text = "";
            }
        }
    }
}
