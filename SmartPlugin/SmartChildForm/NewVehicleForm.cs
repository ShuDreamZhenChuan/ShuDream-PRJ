using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SmartPlugin.SmartChildForm
{
    public partial class NewVehicleForm : Smart.Core.StandardForm
    {

        DAL.DAL_CustomerInfo _customerdal;

        string vehicle_ownerid="";

        ResourceManager _resc;

        public NewVehicleForm()
        {
            _resc = new ResourceManager(typeof(NewVehicleForm));
            _customerdal = new DAL.DAL_CustomerInfo();
            InitializeComponent();
        }

        private void btn_SearchUser_Click(object sender, EventArgs e)
        {
             DataTable _dt=_customerdal.selectCustomerInfoWithGroupAndKey(this.txb_SearchUserKey.Text, "全部","");
             this.SelectUserGrid.DataSource = _dt;
        }

        private void cbx_IsNewCustomer_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox _cbx = (CheckBox)sender;

            if (_cbx.Checked)
            {
                this.txb_CustomerName.Enabled = this.cmb_CustomerSex.Enabled = this.cmb_Nation.Enabled = this.cmb_CustomerType.Enabled = this.txb_IDCard.Enabled = this.txb_Address.Enabled = true;
            }
            else
            {
                this.txb_CustomerName.Enabled = this.cmb_CustomerSex.Enabled = this.cmb_Nation.Enabled = this.cmb_CustomerType.Enabled = this.txb_IDCard.Enabled = this.txb_Address.Enabled = false;
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (CheckInfoBeforeAdd())
            {
                DAL.DAL_VehicleInfo vehicledal = new DAL.DAL_VehicleInfo();
                DAL.DAO.VehicleInfoDao vehicleDao = new DAL.DAO.VehicleInfoDao();
                vehicleDao.Vehiclenum = this.txb_VehicleNum.Text;
                vehicleDao.Vehiclegrand= this.txb_VehicleGrand.Text;
                vehicleDao.Vehiclekind= this.cmb_VehicleKind.Text;
                if (cmb_VehicleType.SelectedIndex == 0)
                    vehicleDao.Istemp = 0;
                else
                    vehicleDao.Istemp = 1;
                vehicleDao.Vehiclecolor = this.txb_VehicleColor.Text;
                vehicleDao.Vehicleowner = this.SelectUserGrid.SelectedRows[0].Cells["Id"].Value.ToString();

                if (vehicledal.insertVehicleInfo(vehicleDao))
                {
                    MessageBox.Show("添加车辆成功");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加车辆失败");
                }
            }
        }


        private bool CheckInfoBeforeAdd()
        {
            if (!Regex.IsMatch(txb_VehicleNum.Text, @"^[京津沪渝冀豫云辽黑湘皖鲁新苏浙赣鄂桂甘晋蒙陕吉闽贵粤青藏川宁琼使领A-Z]{1}[A-Z]{1}[A-Z0-9]{4}[A-Z0-9挂学警港澳]{1}$"))
            {
                MessageBox.Show("请填写正确的车牌号");
                return false;
            }

            if (cmb_VehicleKind.Text=="")
            {
                MessageBox.Show("请选择车辆类型");
                return false;
            }

            if (cmb_VehicleType.Text=="")
            {
                MessageBox.Show("请填写正确的车牌号");
                return false;
            }

            if (cbx_IsNewCustomer.Checked == false && SelectUserGrid.SelectedRows.Count<= 0)
            {
                MessageBox.Show("请选择车辆的所属人员");
                return false;
            }

            if (cbx_IsNewCustomer.Checked == true && !CheckInfo())
            {
                MessageBox.Show("新增人员信息填写不正确");
                return false;
            }
            if (cbx_IsNewCustomer.Checked == true && txb_CustomerName.Text != "" && txb_IDCard.Text != "")
            {
                DAL.DAL_CustomerInfo customerdal = new DAL.DAL_CustomerInfo();
                DAL.DAO.CustomerDao  customerdao=new DAL.DAO.CustomerDao();

                customerdao.Name=this.txb_CustomerName.Text;
                customerdao.Sex=this.cmb_CustomerSex.Text;
                customerdao.Nation=this.cmb_Nation.Text;
                if (cmb_CustomerType.SelectedIndex == 0)
                    customerdao.Istemp = 0;
                else
                    customerdao.Istemp = 1;
                customerdao.Idcard=this.txb_IDCard.Text;
                customerdao.Address=this.txb_Address.Text;
              
                if (!customerdal.insertCustomerInfo(customerdao))
                {
                    MessageBox.Show("新增人员时出现错误！添加车辆失败");
                    return false;
                }
                vehicle_ownerid= customerdal.GetCustomerIDWithIDCard(customerdao.Idcard);
            }
            return true;
        }

        private bool CheckInfo()
        {
            if (txb_CustomerName.Text == "")
            {
                MessageBox.Show("请填写用户名");
                return false;
            }

            if (txb_IDCard.Text == "" || !Smart.ToolUtil.StringControlUtil.CheckIDCardNum(txb_IDCard.Text))
            {
                MessageBox.Show("请正确填写用户身份证号");
                return false;
            }

            if ((new DAL.DAL_CustomerInfo()).GetCustomerIDWithIDCard(txb_IDCard.Text) != "")
            {
                MessageBox.Show("该身份证信息在系统中已存在");
                return false;
            }

            if (cmb_CustomerSex.SelectedItem == null)
            {
                MessageBox.Show("请选择用户性别");
                return false;
            }

            if (cmb_Nation.SelectedItem == null)
            {
                MessageBox.Show("请选择用户的民族");
                return false;
            }

            if (cmb_CustomerType.SelectedItem == null)
            {
                MessageBox.Show("请指定用户类型");
                return false;
            }

            return true;
        }

        private void NewVehicleForm_Load(object sender, EventArgs e)
        {
            LoadLanguage("");
            this.cmb_Nation.Items.Clear();
            DAL.DAL_CustomerInfo customerdal = new DAL.DAL_CustomerInfo();

            DataTable _dt = customerdal.getNationTable();

            if (_dt.Rows.Count > 0)
            {
                foreach (DataRow _row in _dt.Rows)
                {
                    this.cmb_Nation.Items.Add(_row[1]);
                }
            }
        }

        private void LoadLanguage(string languagetype)
        {
            try
            {
                this.Text = _resc.GetString("addvehicle");
                this.groupBox2.Text = _resc.GetString("customerinfo");
                this.btn_SearchUser.Text = _resc.GetString("search");
                this.SelectUserGrid.Columns[1].HeaderText = _resc.GetString("customername");
                this.SelectUserGrid.Columns[2].HeaderText = _resc.GetString("idcard");
                this.cbx_IsNewCustomer.Text = _resc.GetString("addcustomer");

                this.label3.Text = _resc.GetString("name");
                this.label4.Text = _resc.GetString("sex");
                this.label5.Text = _resc.GetString("nation");
                this.label6.Text = _resc.GetString("usertype");
                this.label7.Text = _resc.GetString("idcard");
                this.label8.Text = _resc.GetString("address");

                this.groupBox3.Text = _resc.GetString("vehicleinfo");

                this.label10.Text = _resc.GetString("vehiclenum");
                this.label14.Text = _resc.GetString("vehiclekind");
                this.label1.Text = _resc.GetString("vehicletype");
                this.label12.Text = _resc.GetString("vehiclegrand");
                this.label13.Text = _resc.GetString("vehiclecolor");

                this.btn_OK.Text=_resc.GetString("enter");
                this.btn_Cancel.Text = _resc.GetString("cancel");

            }
            catch (Exception ex)
            {

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
