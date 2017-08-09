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
    public partial class GroupAuthorize : Smart.Core.StandardForm
    {
        private string groupid;

        private string usertype;

        ResourceManager _resc;

        public GroupAuthorize(string id, string usertype)
        {

            _resc = new ResourceManager(typeof(GroupAuthorize));
            InitializeComponent();

            this.usertype = usertype;

            groupid = id;
        }

        private void CustomerAuthorize_Load(object sender, EventArgs e)
        {
            LoadLanguage("");

            DAL.DAL_Group groupdal = new DAL.DAL_Group();

            DAL.DAO.GroupDao groupdao = groupdal.selectGroupInfoWithId(groupid);

            this.lab_groupname.Text = groupdao.Grouppname;

            GetGroupAuthrize();
        }

        private void LoadLanguage(string languagetype)
        {
            try
            {
                this.Text = _resc.GetString("editgroupentranceauthorize");
                this.label1.Text = _resc.GetString("groupname");
                this.groupBox1.Text = _resc.GetString("authorizedevicehad");
                this.groupBox2.Text = _resc.GetString("authorizedevicecangive");
                this.AuthrizeGroupHave.Columns[1].HeaderText = _resc.GetString("devicename");
                this.AuthrizeGroupHave.Columns[2].HeaderText = _resc.GetString("devicetyoe");
                this.AuthrizeGroupHave.Columns[3].HeaderText = _resc.GetString("authorizeendtime");

                this.AuthrizeCanGive.Columns[1].HeaderText = _resc.GetString("devicename");
                this.AuthrizeCanGive.Columns[2].HeaderText = _resc.GetString("devicetype");

                this.btn_UpdateAuthirizeTime.Text = _resc.GetString("setauthorizeendtime");
                this.btn_DeleteAuthrize.Text = _resc.GetString("deleteauthorize");
                this.btn_AddAuthrize.Text = _resc.GetString("addauthorize");

            }
            catch (Exception ex)
            {

            }
        }

        private void GetGroupAuthrize()
        {
            DAL.DAL_Authorize authorizedal = new DAL.DAL_Authorize();

            DataTable _dt = authorizedal.GetGroupAuthorize(groupid);

            if (_dt != null)
            {
                AuthrizeGroupHave.DataSource = _dt;
            }

            _dt = authorizedal.GetGroupNotHaveAuthrize(groupid);

            if (_dt != null)
            {
                AuthrizeCanGive.DataSource = _dt;
            }
        }

        private void btn_AddAuthrize_Click(object sender, EventArgs e)
        {
            if (AuthrizeCanGive.SelectedRows != null)
            {
                if (MessageBox.Show("你确定要为分组" + lab_groupname.Text + "添加设备:" + AuthrizeCanGive.SelectedRows[0].Cells[1].Value + "的权限吗？", "添加权限", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string authorizeendtime = "";

                    if (usertype == "临时用户")
                    {
                        MessageBox.Show("临时用户必须设定权限时间");
                        AuthorizeTimeForm _form = new AuthorizeTimeForm();
                        if (_form.ShowDialog() == DialogResult.OK)
                        {
                            authorizeendtime = _form.Selecttime.ToString();
                        }
                        else
                            return;

                    }
                    else
                        authorizeendtime = "";

                    DAL.DAL_Authorize authorizedal = new DAL.DAL_Authorize();

                    if (authorizedal.InsertGroupAuthrize(this.groupid, AuthrizeCanGive.SelectedRows[0].Cells[0].Value.ToString(), authorizeendtime))
                    {
                        MessageBox.Show("添加成功");
                        GetGroupAuthrize();
                    }
                    else
                        MessageBox.Show("添加失败");
                }
             
            }
        }

        private void btn_DeleteAuthrize_Click(object sender, EventArgs e)
        {
            if (AuthrizeGroupHave.SelectedRows != null)
            {
                if (MessageBox.Show("你确定要为分组" + lab_groupname.Text + "删除设备:" + AuthrizeGroupHave.SelectedRows[0].Cells[1].Value + "的权限吗？", "添加权限", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DAL.DAL_Authorize authorizedal = new DAL.DAL_Authorize();

                    if (authorizedal.DeleteGroupAuthrize(AuthrizeGroupHave.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("删除成功");
                        GetGroupAuthrize();
                    }
                    else
                        MessageBox.Show("删除失败");
                }

            }
        }

        private void btn_UpdateAuthirizeTime_Click(object sender, EventArgs e)
        {
            if (AuthrizeGroupHave.SelectedRows != null)
            {

                AuthorizeTimeForm _from = new AuthorizeTimeForm();

                if (_from.ShowDialog() == DialogResult.OK)
                {
                    if ((new DAL.DAL_Authorize()).updateGroupAuthrizeTime(AuthrizeGroupHave.SelectedRows[0].Cells[0].Value.ToString(), _from.Selecttime.ToString()))
                    {
                        MessageBox.Show("修改成功");
                        GetGroupAuthrize();
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择权限!");
            }
        }
    
    }
}
