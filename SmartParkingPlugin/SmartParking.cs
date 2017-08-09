using Smart.ToolUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SmartParkingPlugin
{
    public partial class SmartParking : Form
    {

        DataTable checklistdt=new DataTable();

        DataTable parkinfodt = new DataTable();

        public SmartParking()
        {


            InitializeComponent();

            checklistdt.Columns.Add("vehiclenum");
            checklistdt.Columns.Add("customername");
            checklistdt.Columns.Add("entertime");
            checklistdt.Columns.Add("leavetime");
            checklistdt.Columns.Add("Paymentnum");
            checklistdt.Columns.Add("Freenum");

            parkinfodt.Columns.Add("parkarea");
            parkinfodt.Columns.Add("parktime");
            parkinfodt.Columns.Add("entertime");
            parkinfodt.Columns.Add("leavetime");
        }

        #region 按钮响应

        private void lab_WorkTurn_Click(object sender, EventArgs e)
        {

        }

        private void lab_ChangePwd_Click(object sender, EventArgs e)
        {

        }

        private void lab_LogOut_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void btn_LetIn_Click(object sender, EventArgs e)
        {

        }

        public void VehicleIN(string vehiclenum)
        {
        
        }
        public void VehicleOut(string vehiclenum)
         {
            txb_CarID.Text=vehiclenum;

            DataTable _dtout = (new DAL.DAL_Log()).search_vehicleLogDetailWithLogType("", DateTime.Now.AddYears(-1).ToString(), DateTime.Now.ToString(), vehiclenum, "3");
            DataTable _dtin = (new DAL.DAL_Log()).search_vehicleLogDetailWithLogType("", DateTime.Now.AddYears(-1).ToString(), DateTime.Now.ToString(), vehiclenum, "2");  
            
            if (_dtout.Rows.Count > 0)
            {

                cmb_CarType.Text = _dtout.Rows[0]["vehiclekind"].ToString();
                lab_ownername.Text = _dtout.Rows[0]["vehicleowner"].ToString();
                
                DataRow _row = parkinfodt.NewRow();
                _row["parkarea"] = "停车场";

                if (_dtin.Rows.Count < 0)
                {
                    _row["parktime"] = "----";
                    _row["entertime"] = "----";
                    lab_ExpenseNum.Text = "0";

                }
                else
                {
                    DateTime entertime=DateTime.Parse(_dtin.Rows[0]["logtime"].ToString());
                    DateTime leavetime=DateTime.Parse(_dtout.Rows[0]["logtime"].ToString());
                    _row["parktime"] = (leavetime - entertime).Hours + "小时" + (leavetime - entertime).Minutes + "分钟";
                    _row["entertime"] = _dtin.Rows[0]["logtime"].ToString();

                    lab_ExpenseNum.Text = (new Payment()).GetPaymentMoney(this.txb_CarID.Text, (leavetime - entertime).Hours).ToString();
                }
                _row["leavetime"] = _dtout.Rows[0]["logtime"].ToString();

                parkinfodt.Rows.Clear();

                parkinfodt.Rows.Add(_row);

                this.dataGrid_ParkInfo.DataSource = parkinfodt;

            }
      
        }


        private void SmartParking_Load(object sender, EventArgs e)
        {
            GetVehicleCheckInfo();
        }

        private void GetVehicleCheckInfo()
        {
            Smart.FrmMain _father = (Smart.FrmMain)this.Parent.Parent;

            if (_father._socket != null)
            {
                _father._socket.Stop();
            }

            _father._socket = new TCPCominication(IPAddress.Any, 7788);

            _father._socket.Start();

            _father._socket.DataReceived += _socket_DataReceived;
        }

        public void _socket_DataReceived(object sender, AsyncEventArgs e)
        {
            if (e._state.Buffer.Length > 10)
            {
                try
                {
                    string recvstring = Encoding.Unicode.GetString(e._state.Buffer);

                    recvstring = recvstring.Remove(recvstring.IndexOf('\0'));

                    if (recvstring != "")
                    {
                        RecvDataDel del = new RecvDataDel(RecvData);

                        del.BeginInvoke(recvstring, null, null);
                    }
                }
                catch (Exception ex)
                {

                }
            }

        }

        delegate void RecvDataDel(string recv);

        public void RecvData(string recv)
        {
            if (recv.Contains("VNO") && recv.Contains("IP"))
            {
                DAL.DAL_Authorize _Authorizedao = new DAL.DAL_Authorize();
                DAL.DAL_Log _logdal = new DAL.DAL_Log();

                string No = recv.Substring(recv.IndexOf("NO") + 2, recv.IndexOf("IP") - recv.IndexOf("NO") - 2);

                string IP = recv.Substring(recv.IndexOf("IP") + 2, recv.Length - recv.IndexOf("IP") - 2);



                if (_Authorizedao.CheckVehicleInfoWithDevice(No, "", IP))
                {

                    DAL.DAO.DeviceDao devcedao = (new DAL.DAL_Device()).selectDeviceInfoWithIP(IP);
                    string positiondirection = (new DAL.DAL_Position()).GetPositionDirection(devcedao.Deviceposition);
                    int positionid = (new DAL.DAL_Position()).GetPositionID(devcedao.Deviceposition);
                    if (positiondirection == "0")
                    {
                        _logdal.Inster_Log(devcedao.Deviceposition + "位置进车", 2, positionid, No, (int)(DateTime.Now - DateTime.Parse("1970-1-1 00:00:00")).TotalSeconds, DateTime.Now, "车牌" + No + "的车辆通过验证");
                    }
                    else if (positiondirection == "1")
                    {
                        _logdal.Inster_Log(devcedao.Deviceposition + "位置出车", 3, positionid, No, (int)(DateTime.Now - DateTime.Parse("1970-1-1 00:00:00")).TotalSeconds, DateTime.Now, "车牌" + No + "的车辆通过验证");
                        this.Invoke(new Action(() =>
                        {
                            VehicleOut(No);
                        }));

                    }
                }
                else
                {


                }
            }
        }

        private void btn_PayOpen_Click(object sender, EventArgs e)
        {
            DataRow _row = checklistdt.NewRow();

            _row["vehiclenum"]=txb_CarID.Text;
            _row["customername"]=lab_ownername.Text;
            _row["entertime"]=parkinfodt.Rows[0]["entertime"].ToString();
            _row["leavetime"]=parkinfodt.Rows[0]["leavetime"].ToString();
            _row["Paymentnum"]=lab_ExpenseNum.Text;

            checklistdt.Rows.Add(_row);

            parkinfodt.Rows.Clear();

            this.dataGrid_ParkInfo.DataSource = parkinfodt;


            lab_ReceiveMoneySum.Text = (Convert.ToInt32(lab_ReceiveMoneySum.Text) + Convert.ToInt32(lab_ExpenseNum.Text)).ToString();
        }

        private void btn_FreeOpen_Click(object sender, EventArgs e)
        {
            DataRow _row = checklistdt.NewRow();

            _row["vehiclenum"] = txb_CarID.Text;
            _row["customername"] = lab_ownername.Text;
            _row["entertime"] = parkinfodt.Rows[0]["entertime"].ToString();
            _row["leavetime"] = parkinfodt.Rows[0]["leavetime"].ToString();
            _row["freeoffnum"] = lab_ExpenseNum.Text;

            checklistdt.Rows.Add(_row);

            parkinfodt.Rows.Clear();

            this.dataGrid_ParkInfo.DataSource = parkinfodt;

            lab_FreeMoneySum.Text = (Convert.ToInt32(lab_FreeMoneySum.Text) + Convert.ToInt32(lab_ExpenseNum.Text)).ToString();
        }

    }
}
