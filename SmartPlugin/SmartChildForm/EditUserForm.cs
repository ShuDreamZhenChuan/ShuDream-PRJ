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
    public partial class EditUserForm : Smart.Core.StandardForm
    {
        string userid;

        ResourceManager _resc;

        public EditUserForm(string id)
        {
            _resc = new ResourceManager(typeof(EditUserForm));
            userid=id;
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

            dt = (new DAL.DAL_UserInfo()).getUserStatusList();

            if (dt.Rows.Count > 0)
            {

                cmb_UserStatus.Items.Clear();

                foreach (DataRow _row in dt.Rows)
                {
                    cmb_UserStatus.Items.Add(_row[0].ToString());
                }
            }

            DAL.DAO.UserInfoDao _dao = (new DAL.DAL_UserInfo()).selectUserInfoWithId(userid);

            txb_UserName.Text = _dao.Name;

            cmb_UserType.Text = _dao.Usertype;

            cmb_UserStatus.Text = _dao.State;

        }


        private void LoadLanguage(string languagetype)
        {
            try
            {
                this.Text = _resc.GetString("edituser");
                this.label1.Text = _resc.GetString("account");
                this.label6.Text = _resc.GetString("usertype");
                this.label2.Text = _resc.GetString("userstatus");
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
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (!CheckInfo())
                return;
            else
            {
                DAL.DAO.UserInfoDao userdao = new DAL.DAO.UserInfoDao();

                userdao.Name = txb_UserName.Text;
                userdao.Usertype = cmb_UserType.Text;
                userdao.State = cmb_UserStatus.Text;

                if ((new DAL.DAL_UserInfo()).updateUserInfo(userid,userdao))
                {
                    MessageBox.Show("修改成功!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                    MessageBox.Show("修改失败！");
            }
        }

        private bool CheckInfo()
        {
            if (txb_UserName.Text == "")
            {
                lab_error.Text = "用户名不能为空";
                return false;
            }
      
            if (cmb_UserType.Text == "")
            {
                lab_error.Text = "请选择用户所属类型";
                return false;
            }
            if (cmb_UserStatus.Text == "")
            {
                lab_error.Text = "请选择用户当前的状态";
                return false;
            }

            return true;
        }
    }
}
