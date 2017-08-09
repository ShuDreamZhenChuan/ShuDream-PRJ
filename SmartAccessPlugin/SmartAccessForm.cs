using Smart.ToolUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartAccessPlugin
{
    public partial class SmartAccessForm : Form
    {
        public SmartAccessForm()
        {
            InitializeComponent();
        }

        private void Panel_TakePhoto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SmartAccessForm_Load(object sender, EventArgs e)
        {
            GetCustomerCheckInfo();
        }

        private void GetCustomerCheckInfo()
        {
            Smart.FrmMain _father = (Smart.FrmMain)this.Parent.Parent;

            if (_father._socket != null)
            {
                _father._socket.Stop();
            }

            _father._socket = new TCPCominication(IPAddress.Any, 5588);

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
            if (recv.Contains("PNO") && recv.Contains("IP"))
            {
                DAL.DAL_Authorize _Authorizedao = new DAL.DAL_Authorize();
                DAL.DAL_Log _logdal = new DAL.DAL_Log();

                string No = recv.Substring(recv.IndexOf("NO") + 2, recv.IndexOf("IP") - recv.IndexOf("NO") - 2);

                string IP = recv.Substring(recv.IndexOf("IP") + 2, recv.Length - recv.IndexOf("IP") - 2);

                if (_Authorizedao.CheckPassengerWithDevice(No, IP))
                {
                    DAL.DAO.CustomerDao customerdao = (new DAL.DAL_CustomerInfo()).selectCustomerInfoWithCardNum(No);
                    DAL.DAO.DeviceDao devcedao = (new DAL.DAL_Device()).selectDeviceInfoWithIP(IP);
                    string positiondirection = (new DAL.DAL_Position()).GetPositionDirection(devcedao.Deviceposition);
                    int positionid = (new DAL.DAL_Position()).GetPositionID(devcedao.Deviceposition);

                    if (positiondirection == "0")
                    {
                        _logdal.Inster_Log(devcedao.Deviceposition + "位置进门", 0, positionid, No, (int)(DateTime.Now - DateTime.Parse("1970-1-1 00:00:00")).TotalSeconds, DateTime.Now, "卡号" + No + "的用户通过验证");
                        this.Invoke(new Action(() =>
                        {
                            peopleGetin(customerdao.Name, customerdao.Idcard);
                        }));
                    }
                    else if (positiondirection == "1")
                    {
                        _logdal.Inster_Log(devcedao.Deviceposition + "位置出门", 1, positionid, No, (int)(DateTime.Now - DateTime.Parse("1970-1-1 00:00:00")).TotalSeconds, DateTime.Now, "卡号" + No + "的用户通过验证");
                    }
                }
            }
        }

        public void peopleGetin(string Name,string CardNum)
        {
            
            this.lab_Name.Text = Name;
            this.lab_rfid.Text = CardNum;
        
            this.lab_Name.Visible=this.lab_rfid.Visible=this.lab_Group.Visible=this.lab_Notice.Visible=true;

            this.pictureBox2.Visible = this.lab_NoticeText.Visible = false;

            //for (int i = 0; i < 100; i++)
            //{
            //    Thread.Sleep(100);
            //}

            //this.lab_Name.Text = "";
            //this.lab_rfid.Text = "";
            //this.lab_Group.Text = "";

            //this.lab_Name.Visible = this.lab_rfid.Visible = this.lab_Group.Visible = this.lab_Notice.Visible = false;

            //this.pictureBox2.Visible = this.lab_NoticeText.Visible = true;
        }
    }
}
