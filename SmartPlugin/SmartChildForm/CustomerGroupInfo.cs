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
    public partial class CustomerGroupInfo : Smart.Core.StandardForm
    {
        private string customerid;

        private string usertype;

        ResourceManager _resc;

        public CustomerGroupInfo(string id,string usertype)
        {
            _resc = new ResourceManager(typeof(AuthorizeTimeForm));

            InitializeComponent();

            this.usertype = usertype;

            customerid = id;
        }

        private void CustomerAuthorize_Load(object sender, EventArgs e)
        {


            DAL.DAL_CustomerInfo customerdal = new DAL.DAL_CustomerInfo();

            DAL.DAO.CustomerDao customerdao = customerdal.selectCustomerInfoID(customerid);

            this.lab_username.Text = customerdao.Name;

            this.lab_rfid.Text = customerdao.Rfid;

            GetCustomerGroup();

            LoadLanguage("");
        }

        private void LoadLanguage(string languagetype)
        {
            try
            {
                this.Text = _resc.GetString("editusergroup");
                label1.Text = _resc.GetString("groupname");
                label2.Text = _resc.GetString("entrancecardnum");
                groupBox1.Text = _resc.GetString("presentbelonggroups");
                groupBox2.Text = _resc.GetString("groupscanjoin");
                GroupCustomerIn.Columns[1].HeaderText = _resc.GetString("groupname");
                GroupCustomerIn.Columns[2].HeaderText = _resc.GetString("groupauthorize");
                GroupCanJoin.Columns[1].HeaderText = _resc.GetString("groupname");
                GroupCanJoin.Columns[2].HeaderText = _resc.GetString("groupauthorize");
                btn_ExitGroup.Text = _resc.GetString("exitgroup");
                btn_JoinGroup.Text = _resc.GetString("joingroup");
            }
            catch (Exception ex)
            { 
            
            }
        }

        private void GetCustomerGroup()
        {
            DAL.DAL_CustomerInfo customerdal = new DAL.DAL_CustomerInfo();

            DataTable _dt = customerdal.SelectGroupWithCustomerID(customerid);

            if (_dt != null)
            {
                GroupCustomerIn.DataSource = _dt;
            }

            _dt = customerdal.SelectGroupCanJoinWithCustomerID(customerid);

            if (_dt != null)
            {
                GroupCanJoin.DataSource = _dt;
            }
        }

        private void btn_AddAuthrize_Click(object sender, EventArgs e)
        {
            if (GroupCanJoin.SelectedRows != null)
            {
                if (MessageBox.Show("你确定要将用户:" + lab_username.Text + "添加到群组:" + GroupCanJoin.SelectedRows[0].Cells[1].Value + "中吗？？", "加入群组", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //string authorizeendtime = "";

                    //if (usertype == "临时用户")
                    //{
                    //    MessageBox.Show("临时用户必须设定权限时间");
                    //    AuthorizeTimeForm _form = new AuthorizeTimeForm();
                    //    if (_form.ShowDialog() == DialogResult.OK)
                    //    {
                    //        authorizeendtime = _form.Selecttime.ToString();
                    //    }
                    //    else
                    //        return;

                    //}
                    //else
                    //    authorizeendtime = "";

                    DAL.DAL_Group groupdal = new DAL.DAL_Group();

                    if (groupdal.InsertCustomerIntoGroupWithId(this.customerid, GroupCanJoin.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("添加成功");
                        GetCustomerGroup();
                    }
                    else
                        MessageBox.Show("添加失败");
                }
             
            }
        }

        private void btn_DeleteAuthrize_Click(object sender, EventArgs e)
        {
            if (GroupCustomerIn.SelectedRows != null)
            {
                if (MessageBox.Show("你确定要将用户:" + lab_username.Text + "从群组:" + GroupCustomerIn.SelectedRows[0].Cells[1].Value + "中删除吗？", "删除群组", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DAL.DAL_Group groupdal = new DAL.DAL_Group();

                    if (groupdal.deleteCustomerfromGroupWithId(GroupCustomerIn.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("删除成功");
                        GetCustomerGroup();
                    }
                    else
                        MessageBox.Show("删除失败");
                }

            }
        }

        private void btn_UpdateAuthirizeTime_Click(object sender, EventArgs e)
        {
            if (GroupCustomerIn.SelectedRows != null)
            {

                AuthorizeTimeForm _from = new AuthorizeTimeForm();

                if (_from.ShowDialog() == DialogResult.OK)
                {
                    if ((new DAL.DAL_Authorize()).updateCustomerAuthrizeTime(GroupCustomerIn.SelectedRows[0].Cells[0].Value.ToString(), _from.Selecttime.ToString()))
                    {
                        MessageBox.Show("修改成功");
                        GetCustomerGroup();
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
