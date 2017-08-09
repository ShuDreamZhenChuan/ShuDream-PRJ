using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Smart.Core;
using Smart.ToolUtil;
using System.Net;

namespace Smart
{
    public partial class FrmMain : Smart.Core.StandardForm, ILoadForm
    {
        DAL.DAO.UserInfoDao userinfo = null;

        public TCPCominication _socket;
        List<Button> _Buttonlist = new List<Button>();
        //public int[] SmartFormSize = { 1080, 620 };
        //public int[] SmartParkingFormSize = { 1115, 618 };
        //public int[] SmartAccessFormSize = { 822, 400 };

        //SmartPlugin.SmartMainForm smartmainform;
        //SmartParkingPlugin.SmartParking smartparkingform;
        //SmartAccessPlugin.SmartAccessForm smartaccessform;


        public FrmMain(DAL.DAO.UserInfoDao dao)
        {
            userinfo = dao;
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Mainmenu.Items.Clear();
            PluginLoader.LoadAllPlugins();

            string[] userright = (new DAL.DAL_UserInfo()).selectUserPermissionWithId(userinfo.Id.ToString()).Split(';');

            InitPlugin(userright);

            if (Mainmenu.Items.Count < 2)
            {
                Mainmenu.Visible = false;

                Mainmenu.Items[0].PerformClick();
            }

        }
        private void InitModule(Iplugin plugin)
        {
            List<Button> _list=new List<Button>();

            //PictureBox picture = new PictureBox();
            //picture.BackColor = System.Drawing.Color.Transparent;
            //picture.Image = plugin.ModulePicture;
            //picture.InitialImage = null;
            //picture.Dock = DockStyle.Left;
            //// picture.Location = new System.Drawing.Point(42, 12);
            //picture.Size = new System.Drawing.Size(65, 71);
            //picture.TabStop = false;
            //panelTop.Controls.Add(picture);
            //picture.MouseEnter += (sender, e) =>
            //{
            //    picture.Image = plugin.ModulePictureEnter;
            //};
            //picture.MouseLeave += (sender, e) =>
            //{
            //    picture.Image = plugin.ModulePicture;
            //};
            //picture.MouseDown += (sender, e) =>
            //{
            //    picture.Image = plugin.ModulePictureClick;
            //};
            //picture.MouseUp += (sender, e) =>
            //{
            //    picture.Image = plugin.ModulePictureEnter;
            //};
            //picture.Click += (sender, e) =>
            //{
            //    InitChildNodes(plugin);
            //};
            KeyValuePair<string, EventHandler> item = plugin.ChildNodes.First();

            ToolStripMenuItem _menuitem = new ToolStripMenuItem();

            _menuitem.Text = item.Key;

            _menuitem.Click += item.Value;

            Mainmenu.Items.Add(_menuitem);
        }

        void _btn_Click(object sender, EventArgs e)
        {
           
        }

        private void InitChildNodes(Iplugin plugin)
        {
            panelMain.Controls.Clear();
            foreach (KeyValuePair<string, EventHandler> item in plugin.ChildNodes)
            {
                Button btn = new Button();
                btn.Text = item.Key;
                btn.Click += item.Value;
                btn.Dock = DockStyle.Left;
                btn.BackColor = System.Drawing.Color.White;
                //btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.Font = new System.Drawing.Font("宋体", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                btn.ForeColor = System.Drawing.Color.SteelBlue;
                btn.UseVisualStyleBackColor = false;
            }

        }

        public void InitPlugin(string[] userright)
        {
            _Buttonlist.Clear();

            foreach (Iplugin plugin in PluginLoader.plugins)
            {
                foreach(string str in userright)
                {
                  if(str==plugin.PluginInfo.Name)
                  {
                        plugin.FormLoader = this;
                        InitModule(plugin);
                  }  
                }
            }
        }

        public void LoadFrm(Form frm)
        {
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.ShowIcon = false;
            frm.ShowInTaskbar = false;
            frm.BackColor = Color.White;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            frm.BringToFront();
            frm.Focus();
        }



        public void LoadNavFrm(Form frm)
        {
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.ShowIcon = false;
            frm.ShowInTaskbar = false;
            frm.BackColor = Color.White;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            frm.BringToFront();
            frm.Focus();
        }

        public void LoadContentFrm(Form frm)
        {
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.ShowIcon = false;
            frm.ShowInTaskbar = false;
            //frm.BackColor = Color.Blue;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.Width = frm.Width + 30;
            this.Height = frm.Height + 80;
            
            panelMain.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
            frm.Focus();
        }
        private void GetCustomerCheckInfo()
        {
            if (_socket != null)
            {
                _socket.Stop();
            }

            _socket = new TCPCominication(IPAddress.Any, 5588);

            _socket.Start();

            _socket.DataReceived += _socket_DataReceived;
        }


        private void GetVehicleCheckInfo()
        {
            if (_socket != null)
            {
                _socket.Stop();
            }

            _socket = new TCPCominication(IPAddress.Any, 7788);

            _socket.Start();

            _socket.DataReceived += _socket_DataReceived;
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
                            //smartaccessform.peopleGetin(customerdao.Name, customerdao.Rfid, customerdao.Group);
                        }));
                    }
                    else if (positiondirection == "1")
                    {
                        _logdal.Inster_Log(devcedao.Deviceposition + "位置出门", 1, positionid, No, (int)(DateTime.Now - DateTime.Parse("1970-1-1 00:00:00")).TotalSeconds, DateTime.Now, "卡号" + No + "的用户通过验证");
                    }
                }
            }


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
                                //smartparkingform.VehicleOut(No);
                            }));

                        }
                    }
                    else
                    {


                    }
                }
            }

        private void 测试按钮ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SmartPlugin.SmartMainForm _form = new SmartPlugin.SmartMainForm();
            _form.TopLevel = false;

            this.panelMain.Controls.Add(_form);
            _form.Show();

        }

        }
    }

