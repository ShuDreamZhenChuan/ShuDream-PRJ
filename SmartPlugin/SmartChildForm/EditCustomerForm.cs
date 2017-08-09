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
    public partial class EditCustomerForm : Smart.Core.StandardForm
    {

        string customerid;

        DAL.DAO.CustomerDao userdao = null;

        ResourceManager _resc;

        public EditCustomerForm(string id)
        {
            _resc = new ResourceManager(typeof(AuthorizeTimeForm));
            InitializeComponent();
            customerid = id;
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {

            if (!CheckInfo())
                return;

            userdao.Sex = this.combo_CustomerSex.Text;
            userdao.Name = this.txb_CustomerName.Text;
            userdao.Nation = this.cmb_Nation.Text;
            userdao.Address=this.txb_Address.Text ;
            userdao.Idcard = this.txb_IDCard.Text;
            userdao.Rfid = this.txb_Rfid.Text;
            userdao.Remark = this.txb_Remark.Text;
          
            if (cmb_CustomerType.SelectedIndex == 0)
            {
                userdao.Istemp = 0;
            }
            else
                userdao.Istemp = 1;

            DAL.DAL_CustomerInfo userdal = new DAL.DAL_CustomerInfo();

           bool updateresult=userdal.updateCustomerInfo(customerid, userdao);

           if (updateresult)
           {
               MessageBox.Show("修改成功");
               this.DialogResult = DialogResult.OK;
               this.Close();
           }
           else
               MessageBox.Show("修改失败");
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

            if (combo_CustomerSex.SelectedItem == null)
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {

            LoadLanguage("");

            this.cmb_Nation.Items.Clear();

            DAL.DAL_CustomerInfo userdal = new DAL.DAL_CustomerInfo();

            DataTable _dt = userdal.getNationTable();

            if (_dt.Rows.Count > 0)
            {
                foreach (DataRow _row in _dt.Rows)
                {
                    this.cmb_Nation.Items.Add(_row[1]);
                }
            }

            userdao=userdal.selectCustomerInfoID(customerid);

            if (userdao == null)
            {
                MessageBox.Show("获取用户信息失败！");
                this.Close();
            }
            else
            {
                this.combo_CustomerSex.Text = userdao.Sex;
                this.txb_CustomerName.Text = userdao.Name;
                this.cmb_Nation.Text = userdao.Nation;
                this.txb_Address.Text = userdao.Address;
                this.txb_IDCard.Text = userdao.Idcard;
                this.txb_Rfid.Text= userdao.Rfid;
                this.txb_Remark.Text= userdao.Remark;
                if ( userdao.Istemp == 0)
                {
                    cmb_CustomerType.SelectedIndex = 0;
                }
                else
                    cmb_CustomerType.SelectedIndex = 1;
            }

        }

        private void LoadLanguage(string languagetype)
        {
            try
            {
                this.Text = _resc.GetString("editcustomerdetail");
                this.groupBox1.Text = _resc.GetString("headimgcollect");
                this.btn_TakePhoto.Text = _resc.GetString("takephoto");
                label8.Text = _resc.GetString("customertype");
                label2.Text = _resc.GetString("customername");
                label7.Text = _resc.GetString("sex");
                label3.Text = _resc.GetString("nation");
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
    }
}
