using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmartPlugin.SmartChildForm
{
    public partial class DeviceVehicleAuthorize : Smart.Core.StandardForm
    {
        public string deviceid;

        public DeviceVehicleAuthorize(string id)
        {
            deviceid = id;
            InitializeComponent();
        }

        private void DeviceAuthorize_Load(object sender, EventArgs e)
        {
            DAL.DAL_Device devicedal = new DAL.DAL_Device();
            DAL.DAO.DeviceDao devicedao=devicedal.selectDeviceInfoWithID(deviceid);

            this.lab_DeviceName.Text = devicedao.Devicename;
            this.lab_DevceType.Text = devicedao.Devicetype;
            this.lab_Position.Text = devicedao.Deviceposition;
            GetDeviceAuthrizeList("");
        }

        private void  GetDeviceAuthrizeList(string Key)
        {

            this.deviceAuthorizeList.DataSource = null;
            DAL.DAL_Authorize authorizedal = new DAL.DAL_Authorize();

            DataTable _dt=authorizedal.GetDeviceVehicleAuthorize(this.deviceid,Key);

            if (_dt != null)
            {
                this.deviceAuthorizeList.DataSource = _dt;
            }
        }

        private void btn_SearchUser_Click(object sender, EventArgs e)
        {
            DAL.DAL_VehicleInfo vehicledal = new DAL.DAL_VehicleInfo();

            DataTable _dt = vehicledal.selectVehicleInfoWithGroupAndKey(this.txb_SearchVehicleKey.Text,"全部");
            this.SelectVehicleGrid.DataSource = _dt;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string authorizeendtime = "";

            string vehicleid = "";

            if (SelectVehicleGrid.SelectedRows.Count<= 0)
            {
                MessageBox.Show("请选择要添加到设备的人员");
                return;
            }
            if (SelectVehicleGrid.SelectedRows != null)
            {
                if (MessageBox.Show("确定要将车辆" + SelectVehicleGrid.SelectedRows[0].Cells[1].Value.ToString() + "添加到设备" + lab_DeviceName.Text + "的权限中吗？", "添加权限", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                if (SelectVehicleGrid.SelectedRows[0].Cells[1].Value.ToString() == "临时车辆")
                {
                    MessageBox.Show("临时车辆必须设定权限时间");
                    AuthorizeTimeForm _form = new AuthorizeTimeForm();
                    if (_form.ShowDialog() == DialogResult.OK)
                    {
                        authorizeendtime = _form.Selecttime.ToString();
                    }
                    else
                        return;
                }


                vehicleid = SelectVehicleGrid.SelectedRows[0].Cells[0].Value.ToString();
            }
           

            DAL.DAL_Authorize authorizedal = new DAL.DAL_Authorize();

            if (authorizedal.InsertVehicleAuthrize(vehicleid, this.deviceid,authorizeendtime))
            {
                MessageBox.Show("添加权限成功!");
                GetDeviceAuthrizeList("");
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
                MessageBox.Show("请选择要删除的车辆");
                return;
            }
            else
            {
                if (MessageBox.Show("确定要将车辆" + deviceAuthorizeList.SelectedRows[0].Cells[1].Value + "从设备" + lab_DeviceName + "删除？", "删除权限", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                DAL.DAL_Authorize authrize = new DAL.DAL_Authorize();

                if (authrize.DeleteCustomerAuthrize(deviceAuthorizeList.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    MessageBox.Show("删除权限成功!");

                    GetDeviceAuthrizeList("");
                }
                else
                    MessageBox.Show("删除权限失败！");
            
            }

        }

        private void btn_SearchAuthrize_Click(object sender, EventArgs e)
        {
            GetDeviceAuthrizeList(this.txb_SearchKey.Text);
        }


    }
}
