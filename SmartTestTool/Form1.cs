using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTestTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable _dt=(new DAL.DAL_Position()).selectPositionListInfo("1");

            if (_dt.Rows.Count > 0)
            {
                foreach (DataRow _row in _dt.Rows)
                {
                    cmb_passpastposition.Items.Add(_row[1]);    
                }
            }

            _dt = (new DAL.DAL_Position()).selectPositionListInfo("2");

            if (_dt.Rows.Count > 0)
            {
                foreach (DataRow _row in _dt.Rows)
                {
                    cmb_vehiclepastposition.Items.Add(_row[1]);
                }
            }

        }

        private void btn_passengerPast_Click(object sender, EventArgs e)
        {
            string deviceaddress = "";

            if (cmb_passpastposition.SelectedItem != null)
            { 
               deviceaddress=(new DAL.DAL_Device()).getdeviceaddressWithpositionname(cmb_passpastposition.Text);
               
               if(deviceaddress=="")
               {
                   MessageBox.Show("此位置尚未安装门禁设备!");
                   return;
               }
            
            }
            
            TcpComunicate _comm = new TcpComunicate("127.0.0.1", 5588);

            if (_comm.connectToServer())
            { 
                _comm.senddata("PNO"+this.txb_passcardnum.Text+"IP"+deviceaddress);     
            }

        }

        private void btn_vehiclepast_Click(object sender, EventArgs e)
        {
            string deviceaddress = "";

            if (cmb_vehiclepastposition.SelectedItem != null)
            {
                deviceaddress = (new DAL.DAL_Device()).getdeviceaddressWithpositionname(cmb_vehiclepastposition.Text);
               
               if(deviceaddress=="")
               {
                   MessageBox.Show("此位置尚未安装门禁设备!");
                   return;
               }
            
            }
            
            TcpComunicate _comm = new TcpComunicate("127.0.0.1", 7788);

            if (_comm.connectToServer())
            {
                _comm.senddata("VNO" + this.txb_vehiclenum.Text + "IP" + deviceaddress);     
            }
        }
    }
}
