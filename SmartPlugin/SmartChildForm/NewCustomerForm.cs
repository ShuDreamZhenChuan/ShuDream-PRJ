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
    public partial class NewCustomerForm : Smart.Core.StandardForm
    {
        ResourceManager _resc;

        public NewCustomerForm()
        {
            _resc = new ResourceManager(typeof(NewCustomerForm));
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {

            if (!CheckInfo())
                return;

            DAL.DAO.CustomerDao customerdao=new DAL.DAO.CustomerDao();

            customerdao.Sex = this.cmb_CustomerSex.Text;
            customerdao.Name = this.txb_CustomerName.Text;
            customerdao.Nation = this.cmb_Nation.Text;
            customerdao.Address=this.txb_Address.Text ;
            customerdao.Idcard = this.txb_IDCard.Text;
            customerdao.Rfid = this.txb_Rfid.Text;
            customerdao.Remark = this.txb_Remark.Text;
            if (cmb_CustomerType.SelectedIndex == 0)
            {
                customerdao.Istemp = 0;
            }
            else
                customerdao.Istemp = 1;
            
            DAL.DAL_CustomerInfo customerdal = new DAL.DAL_CustomerInfo();

            if (customerdal.insertCustomerInfo(customerdao))
            {
                MessageBox.Show("添加人员成功");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("添加人员失败");
            }
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

            if (cmb_CustomerType.SelectedItem== null)
            {
                MessageBox.Show("请指定用户类型");
                return false;
            }

            return true;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewCustomerForm_Load(object sender, EventArgs e)
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
                this.Text = _resc.GetString("addcustomer");
                this.groupBox1.Text = _resc.GetString("headimgcollect");
                this.btn_takephoto.Text = _resc.GetString("takephoto");
                label8.Text = _resc.GetString("customertype");
                label2.Text = _resc.GetString("customername");
                label7.Text = _resc.GetString("sex");
                lab3.Text = _resc.GetString("nation");
                label4.Text = _resc.GetString("idcard");
                label5.Text = _resc.GetString("address");
                label9.Text = _resc.GetString("entrancecardnum");
                label6.Text = _resc.GetString("remark");
                btn_OK.Text = _resc.GetString("enter");
                btn_Cancel.Text = _resc.GetString("cancel");

            }
            catch (Exception ex)
            {

            }
        }

        private void txb_IDCard_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
