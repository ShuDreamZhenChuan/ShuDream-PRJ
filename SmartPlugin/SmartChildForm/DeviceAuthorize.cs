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
    public partial class DeviceAuthorize : Smart.Core.StandardForm
    {
        public string deviceid;

        ResourceManager _resc;

        public DeviceAuthorize(string id)
        {
            _resc = new ResourceManager(typeof(AuthorizeTimeForm));
            deviceid = id;
            InitializeComponent();
        }

        private void DeviceAuthorize_Load(object sender, EventArgs e)
        {

            LoadLanguage("");

            DAL.DAL_Device devicedal = new DAL.DAL_Device();
            DAL.DAO.DeviceDao devicedao=devicedal.selectDeviceInfoWithID(deviceid);

            this.lab_DeviceName.Text = devicedao.Devicename;
            this.lab_DevceType.Text = devicedao.Devicetype;
            this.lab_Position.Text = devicedao.Deviceposition;

            DAL.DAL_Group groupdal = new DAL.DAL_Group();

            DataTable _dt = groupdal.selectGroupListInfo();

            GetDeviceAuthorizeList("");


        }

        private void LoadLanguage(string languagetype)
        {
            try
            {
                this.Text = _resc.GetString("editusergroup");
                label1.Text = _resc.GetString("devicename");
                label2.Text = _resc.GetString("devicetype");
                label10.Text = _resc.GetString("deviceposition");

                deviceAuthorizeList.Columns[1].HeaderText = _resc.GetString("groupname");
                deviceAuthorizeList.Columns[2].HeaderText = _resc.GetString("groupmembercount");
                btn_Del.Text = _resc.GetString("deletegroupfromdevice");

                groupBox2.Text = _resc.GetString("canrelategroups");
                SelectGroupGrid.Columns[1].HeaderText = _resc.GetString("groupname");
                SelectGroupGrid.Columns[2].HeaderText = _resc.GetString("groupmembercount");
                SelectGroupGrid.Columns[3].HeaderText = _resc.GetString("remark");
                btn_SearchGroup.Text = _resc.GetString("search");

                btn_Add.Text = _resc.GetString("relategroupwithdevice");
               
               
            }
            catch (Exception ex)
            {

            }
        }

        private void  GetDeviceAuthorizeList(string Key)
        {
         
            DAL.DAL_Authorize authorizedal = new DAL.DAL_Authorize();

            DataTable _dt=authorizedal.GetDeviceGroupAuthorize(this.deviceid);

            if (_dt != null)
            {
                this.deviceAuthorizeList.DataSource = _dt;
            }

            _dt = authorizedal.GetDevcieCanRelationGroup(this.deviceid);

            if (_dt != null)
            {
                this.SelectGroupGrid.DataSource = _dt;
            }
        }

        private void btn_SearchUser_Click(object sender, EventArgs e)
        {
            DAL.DAL_CustomerInfo _customerdal = new DAL.DAL_CustomerInfo();

            DataTable _dt = _customerdal.selectCustomerInfoWithGroupAndKey(this.txb_SearchUserKey.Text, "全部","");
            this.SelectGroupGrid.DataSource = _dt;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string selectgroupid = "";
            string authorizeendtime = "";

            if (SelectGroupGrid.SelectedRows.Count<= 0)
            {
                MessageBox.Show("请选择要添加到设备权限的群组");
                return;
            }
            if (SelectGroupGrid.SelectedRows != null)
            {
                if (MessageBox.Show("确定要将群组" + SelectGroupGrid.SelectedRows[0].Cells[1].Value.ToString() + "添加到设备" + lab_DeviceName.Text + "的权限中吗？", "添加权限", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                selectgroupid = this.SelectGroupGrid.SelectedRows[0].Cells[0].ToString();
            }
           
            DAL.DAL_Authorize authorizedal = new DAL.DAL_Authorize();

            if (authorizedal.InsertGroupAuthrize(selectgroupid, this.deviceid, authorizeendtime))
            {
                MessageBox.Show("添加权限成功!");
                GetDeviceAuthorizeList("");
            }
            else
            {
                MessageBox.Show("添加权限失败!");
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (this.deviceAuthorizeList.SelectedRows.Count<= 0)
            {
                MessageBox.Show("请选择要删除的群组");
                return;
            }
            else
            {
                if (MessageBox.Show("确定要将群组" + deviceAuthorizeList.SelectedRows[0].Cells[1].Value + "从设备" + lab_DeviceName.Text + "删除？", "删除权限", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                DAL.DAL_Authorize authrize = new DAL.DAL_Authorize();

                if (authrize.DeleteGroupAuthrize(deviceAuthorizeList.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    MessageBox.Show("删除群组成功!");
                    GetDeviceAuthorizeList("");
                }
                else
                    MessageBox.Show("删除群组失败！");
            
            }

        }

        private void txb_IDCard_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
