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
    public partial class EditDeviceForm : Smart.Core.StandardForm
    {
        public string deviceid;
        DAL.DAO.DeviceDao devicedao;
        ResourceManager _resc;
        

        public EditDeviceForm(string id)
        {
            _resc = new ResourceManager(typeof(EditDeviceForm));
            InitializeComponent();
            this.deviceid = id;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            DAL.DAL_Device devicedal= new DAL.DAL_Device();

            devicedao = new DAL.DAO.DeviceDao();

            devicedao.Devicename = txb_DeviceName.Text;
            devicedao.Code = txb_DeviceCode.Text;
            devicedao.Deviceposition = cmb_DevicePosition.Text;
            devicedao.Netaddress = txb_addr_part1.Text + "." + txb_addr_part2.Text + "." + txb_addr_part3.Text + "." + txb_addr_part4.Text;

            if (devicedal.updateDeviceInfo(deviceid, devicedao))
            {
                MessageBox.Show("修改成功");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private bool CheckInfo()
        {
            if (txb_DeviceName.Text == "")
            {
                MessageBox.Show("请填写设备名称");
                return false;
            }
            if (txb_DeviceCode.Text == "")
            {
                MessageBox.Show("请正确设备条码号");
                return false;
            }
            if (cmb_DevicePosition.Text == "")
            {
                MessageBox.Show("请选择设备所在位置");
                return false;
            }

            return true;
        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditDeviceForm_Load(object sender, EventArgs e)
        {
            LoadLanguage("");

            this.txb_addr_part1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(new Smart.ToolUtil.StringControlUtil().NumTextKeyPress);
            this.txb_addr_part2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(new Smart.ToolUtil.StringControlUtil().NumTextKeyPress);
            this.txb_addr_part3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(new Smart.ToolUtil.StringControlUtil().NumTextKeyPress);
            this.txb_addr_part4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(new Smart.ToolUtil.StringControlUtil().NumTextKeyPress);

            DAL.DAL_Device devicedal = new DAL.DAL_Device();

            DAL.DAO.DeviceDao devicedao = devicedal.selectDeviceInfoWithID(deviceid);

            if (devicedao == null)
            {
                MessageBox.Show("获取设备信息失败！");
                this.Close();
            }
            else
            {
                this.txb_DeviceName.Text = devicedao.Devicename;
                this.txb_DeviceCode.Text = devicedao.Code;

                string[] address = devicedao.Netaddress.Split('.');

                this.txb_addr_part1.Text = address[0];
                this.txb_addr_part2.Text = address[1];
                this.txb_addr_part3.Text = address[2];
                this.txb_addr_part4.Text = address[3];
               
                this.cmb_DevicePosition.Text = devicedao.Deviceposition;
            }
            DAL.DAL_Position positiondal = new DAL.DAL_Position();

            //DataTable _dt = devicedal.GetDeviceTypeList();
            //if (_dt != null)
            //{
            //    cmb_DeviceType.Items.Clear();

            //    foreach (DataRow _row in _dt.Rows)
            //    {
            //        cmb_DeviceType.Items.Add(_row[0]);
            //    }

            //}
            DataTable _dt = positiondal.selectPositionListInfo("");
            if (_dt != null)
            {
                cmb_DevicePosition.Items.Clear();

                foreach (DataRow _row in _dt.Rows)
                {
                    cmb_DevicePosition.Items.Add(_row[1]);
                }

            }
        }


        private void LoadLanguage(string languagetype)
        {
            try
            {
                this.Text = _resc.GetString("editdevice");
                this.lab3.Text = _resc.GetString("name");
                this.label2.Text = _resc.GetString("deviceserialnum");
                this.label5.Text = _resc.GetString("position");
                this.label6.Text = _resc.GetString("communicateaddress");

                btn_OK.Text = _resc.GetString("enter");
                btn_Cancel.Text = _resc.GetString("cancel");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
