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
    public partial class VehicleAuthorize : Smart.Core.StandardForm
    {
        private string vehicleid;

        private string vehicletype;

        public VehicleAuthorize(string id,string vehicletype)
        {
            InitializeComponent();

            this.vehicletype = vehicletype;

            vehicleid = id;
        }

        private void CustomerAuthorize_Load(object sender, EventArgs e)
        {
            DAL.DAL_VehicleInfo vehicledal = new DAL.DAL_VehicleInfo();

            DAL.DAO.VehicleInfoDao Vehicledao = vehicledal.selectVehicleInfoID(vehicleid);

            this.lab_vehiclenum.Text = Vehicledao.Vehiclenum;

            this.lab_vehicleowner.Text = Vehicledao.Vehicleowner;

            GetVehicleAuthrize();
        }

        private void GetVehicleAuthrize()
        {
            DAL.DAL_Authorize authorizedal = new DAL.DAL_Authorize();

            DataTable _dt = authorizedal.GetVehicleAuthorize(vehicleid);

            if (_dt != null)
            {
                AuthrizeUserHave.DataSource = _dt;
            }

            _dt = authorizedal.GetVehicleNotHaveAuthrize(vehicleid);

            if (_dt != null)
            {
                AuthrizeCanGive.DataSource = _dt;
            }
        }

        private void btn_AddAuthrize_Click(object sender, EventArgs e)
        {
            if (AuthrizeCanGive.SelectedRows != null)
            {
                if (MessageBox.Show("你确定要为车辆" + lab_vehiclenum.Text + "添加设备:" + AuthrizeCanGive.SelectedRows[0].Cells[1].Value + "的权限吗？", "添加权限", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string authorizeendtime = "";

                    if (vehicletype == "临时车辆")
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

                    if (authorizedal.InsertVehicleAuthrize(this.vehicleid, AuthrizeCanGive.SelectedRows[0].Cells[0].Value.ToString(), authorizeendtime))
                    {
                        MessageBox.Show("添加成功");
                        GetVehicleAuthrize();
                    }
                    else
                        MessageBox.Show("添加失败");
                }
             
            }
        }

        private void btn_DeleteAuthrize_Click(object sender, EventArgs e)
        {
            if (AuthrizeUserHave.SelectedRows != null)
            {
                if (MessageBox.Show("你确定要为车辆" + lab_vehiclenum.Text + "删除设备:" + AuthrizeUserHave.SelectedRows[0].Cells[1].Value + "的权限吗？", "添加权限", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DAL.DAL_Authorize authorizedal = new DAL.DAL_Authorize();

                    if (authorizedal.DeleteVehicleAuthrize(AuthrizeUserHave.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("删除成功");
                        GetVehicleAuthrize();
                    }
                    else
                        MessageBox.Show("删除失败");
                }

            }
        }

        private void btn_UpdateAuthirizeTime_Click(object sender, EventArgs e)
        {
            if (AuthrizeUserHave.SelectedRows != null)
            {

                AuthorizeTimeForm _from = new AuthorizeTimeForm();

                if (_from.ShowDialog() == DialogResult.OK)
                {
                    if ((new DAL.DAL_Authorize()).updateVehicleAuthrizeTime(AuthrizeUserHave.SelectedRows[0].Cells[0].Value.ToString(), _from.Selecttime.ToString()))
                    {
                        MessageBox.Show("修改成功");
                        GetVehicleAuthrize();
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
