using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SmartPlugin.SmartChildForm;
using SmartPlugin.SmartUserControl;
using Smart.ToolUtil;
using System.Net;
using System.Resources;
using System.Threading;
using System.Globalization;

namespace SmartPlugin
{
    public partial class SmartMainForm : Form
    {
        DataTable userlisttable = new DataTable();

        ResourceManager _resc;
        public SmartMainForm()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Smart.ProcessingConfigurationfile.Language);
            _resc = new ResourceManager(typeof(SmartMainForm));
            InitializeComponent();
            userlisttable.Columns.Add("Name");
            userlisttable.Columns.Add("Sex");
            userlisttable.Columns.Add("IDCard");
            userlisttable.Columns.Add("Group");
        }
        void SmartMainForm_Load(object sender, System.EventArgs e)
        {
            LoadLanguage("");
        }

        private void LoadLanguage(string languagetype)
        {
            try
            {

                tabControl1.TabPages[0].Text = _resc.GetString("customermanage");
                tabControl1.TabPages[1].Text = _resc.GetString("parkmanage");
                tabControl1.TabPages[2].Text = _resc.GetString("entrancedevice");
                tabControl1.TabPages[3].Text = _resc.GetString("systemmanage");
                //人员管理
                CustomerControlItem_tree.Nodes[0].Text = _resc.GetString("groupmanage");
                CustomerControlItem_tree.Nodes[1].Text = _resc.GetString("customermanage");
                //人员管理
                label16.Text = _resc.GetString("groupbelong");
                label6.Text = _resc.GetString("key");
                btn_Customer_Search.Text = _resc.GetString("search");
                CustomerInfoListView.Columns[1].HeaderText = _resc.GetString("customername");
                CustomerInfoListView.Columns[2].HeaderText = _resc.GetString("idcard");
                CustomerInfoListView.Columns[3].HeaderText = _resc.GetString("entrancecardnum");
                CustomerInfoListView.Columns[4].HeaderText = _resc.GetString("customertype");
                btn_Customer_ADD.Text = _resc.GetString("addcustomer");
                btn_CustomerGroup_Edit.Text = _resc.GetString("editcustomergroup");
                btn_Customer_Edit.Text = _resc.GetString("editcustomerdetail");
                btn_Customer_Delete.Text = _resc.GetString("deletecustomer");
                //群组管理
                lab_AddBrotherGroup.Text = _resc.GetString("addgroup");
                lab_EditSelectGroup.Text = _resc.GetString("editgroup");
                lab_Delete.Text = _resc.GetString("deletegroup");
                lab_GroupAuthorize.Text = _resc.GetString("editgroupentranceauthorize");
                //停车场
                Park_ControlItem_tree.Nodes[0].Text = _resc.GetString("parkmanage");
                Park_ControlItem_tree.Nodes[1].Text = _resc.GetString("vehiclemanage");
                Park_ControlItem_tree.Nodes[2].Text = _resc.GetString("summary");
                //车辆管理
                label17.Text = _resc.GetString("groupbelong");
                label18.Text = _resc.GetString("key");
                btn_Search_Vehicle.Text = _resc.GetString("search");
                VehicleInfoGrid.Columns[1].HeaderText = _resc.GetString("vehiclenum");
                VehicleInfoGrid.Columns[2].HeaderText = _resc.GetString("vehicleowner");
                VehicleInfoGrid.Columns[3].HeaderText = _resc.GetString("vehicletype");
                btn_Vehicle_Add.Text = _resc.GetString("addvehicle");
                btn_VehicleAuthrize_Edit.Text = _resc.GetString("userlogin");
                btn_Vehicle_Delete.Text = _resc.GetString("deletevehicle");
                //停车场管理
                ParkPositionInfoTree.Nodes[0].Text = _resc.GetString("accessdoor");
                btn_ParkChannel_ADD.Text = _resc.GetString("addaccessdoor");
                label4.Text = _resc.GetString("accessdoorname");
                btn_ParkChannel_Del.Text = _resc.GetString("deleteaccessdoor");
                //统计汇总
                reporttab.TabPages[0].Text = _resc.GetString("vehicleaccessstatistical");
                checkBox2.Text = _resc.GetString("accordingitemstatistical");
                checkBox1.Text = _resc.GetString("accordingtimetatistical");
                btn_ReportSearch.Text = _resc.GetString("statistical");
                VehicleRecordGrid.Columns[0].HeaderText = _resc.GetString("statisticalitem");
                VehicleRecordGrid.Columns[1].HeaderText = _resc.GetString("getincount");
                VehicleRecordGrid.Columns[2].HeaderText = _resc.GetString("getoutcount");
                btn_Export.Text = _resc.GetString("export");
                //门禁设备
                Device_ControlItem_View.Nodes[0].Text = _resc.GetString("deviceoption");
                Device_ControlItem_View.Nodes[1].Text = _resc.GetString("summary");
                Device_ControlItem_View.Nodes[2].Text = _resc.GetString("accessrecord");
                Device_ControlItem_View.Nodes[4].Text = _resc.GetString("accessdoormanage");
                //硬件配置
                label5.Text = _resc.GetString("position");
                label20.Text = _resc.GetString("key");
                DeviceInfoGrid.Columns[0].HeaderText = _resc.GetString("devicename");
                DeviceInfoGrid.Columns[1].HeaderText = _resc.GetString("devicetype");
                DeviceInfoGrid.Columns[2].HeaderText = _resc.GetString("deviceserialnum");
                DeviceInfoGrid.Columns[3].HeaderText = _resc.GetString("position");
                DeviceInfoGrid.Columns[4].HeaderText = _resc.GetString("communicateaddress");
                btn_Device_Add.Text = _resc.GetString("adddevice");
                btn_Device_Authrize_Edit.Text = _resc.GetString("editgroupentranceauthorize");
                btn_Device_Edit.Text = _resc.GetString("editdevicedetail");
                btn_Device_Delete.Text = _resc.GetString("deletedevice");
                //统计汇总
                PassRecord_tab.TabPages[0].Text = _resc.GetString("customeraccessstatistical");
                checkBox3.Text = _resc.GetString("accordingitemstatistical");
                checkBox4.Text = _resc.GetString("accordingtimetatistical");
                btn_PassengerReportSearch.Text = _resc.GetString("statistical");
                PassengerRecordGrid.Columns[0].HeaderText = _resc.GetString("statisticalitem");
                PassengerRecordGrid.Columns[0].HeaderText = _resc.GetString("getincount");
                PassengerRecordGrid.Columns[0].HeaderText = _resc.GetString("getoutcount");
                btn_PassengerReportExport.Text = _resc.GetString("export");
                InOutRecordTab.TabPages[0].Text = _resc.GetString("customeraccessrecord");
                InOutRecordTab.TabPages[1].Text = _resc.GetString("vehicleaccessrecord");
                label3.Text = _resc.GetString("accessposition");
                label8.Text = _resc.GetString("accesstime");
                label7.Text = _resc.GetString("customername");
                btn_PassengerReportSearch.Text = _resc.GetString("search");
                PassengerRecordGrid.Columns[0].HeaderText = _resc.GetString("customername");
                PassengerRecordGrid.Columns[1].HeaderText = _resc.GetString("accessposition");
                PassengerRecordGrid.Columns[2].HeaderText = _resc.GetString("accesstime");
                PassengerRecordGrid.Columns[3].HeaderText = _resc.GetString("recordremark");
                label15.Text = _resc.GetString("accessposition");
                label13.Text = _resc.GetString("accesstime");
                label14.Text = _resc.GetString("customername");
                btn_VehiRecordSearch.Text = _resc.GetString("search");
                VehicleRecordGrid.Columns[0].HeaderText = _resc.GetString("vehicle");
                VehicleRecordGrid.Columns[1].HeaderText = _resc.GetString("vehicleowner");
                VehicleRecordGrid.Columns[2].HeaderText = _resc.GetString("accessposition");
                VehicleRecordGrid.Columns[3].HeaderText = _resc.GetString("accesstime");
                VehicleRecordGrid.Columns[4].HeaderText = _resc.GetString("recordremark");
                //出入口管理
                DoorPositionInfoTree.Nodes[0].Text = _resc.GetString("accessdoor");
                btn_DoorChannel_ADD.Text = _resc.GetString("addaccessdoor");
                label19.Text = _resc.GetString("accessdoorname");
                btn_DoorChannel_Del.Text = _resc.GetString("deleteaccessdoor");
                //系统管理
                System_ControlItem_tree.Nodes[0].Text = _resc.GetString("systemusermanage");
                //系统用户管理
                label21.Text = _resc.GetString("key");
                btn_SelectUser.Text = _resc.GetString("search");
                UserInfoListView.Columns[0].HeaderText = _resc.GetString("account");
                UserInfoListView.Columns[1].HeaderText = _resc.GetString("usertype");
                UserInfoListView.Columns[2].HeaderText = _resc.GetString("usertstatus");
                btn_AddUser.Text = _resc.GetString("addcustomer");
                btn_EditUser.Text = _resc.GetString("edituser");
                btn_DeleteUser.Text = _resc.GetString("deleteuser");
                btn_EditPwd.Text = _resc.GetString("editpassword");
            
            }
            catch (Exception ex)
            {



            }
        }
       



        private void lab_AddBrotherGroup_Click(object sender, EventArgs e)
        {
            NewGroupForm _Form = new NewGroupForm();

            _Form.NodeType = 1;

            if (_Form.ShowDialog() == DialogResult.OK) 
            {
                this.Group_Tree.Nodes.Clear();

                DAL.DAL_Group groupdal = new DAL.DAL_Group();

                DataTable _dt = groupdal.selectGroupListInfo();

                if (_dt.Rows.Count > 0)
                {
                    foreach (DataRow _row in _dt.Rows)
                    {
                        TreeNode _node = new TreeNode();
                        _node.Name = _row[0].ToString();
                        _node.Text = _row[1].ToString();
                        this.Group_Tree.Nodes.Add(_node);
                    }
                }
            }
        }

        private void lab_AddChildGroup_Click(object sender, EventArgs e)
        {
            if (Group_Tree.SelectedNode == null)
                MessageBox.Show("未选择任何部门");
            NewGroupForm _Form = new NewGroupForm();
            _Form.NodeType = 2;
            if (_Form.ShowDialog() == DialogResult.OK)
            { 
            
            }
            TreeNode _node = Group_Tree.SelectedNode;
            _node.Nodes.Add("子部门");
        }

        private void lab_EditSelectGroup_Click(object sender, EventArgs e)
        {
            if (Group_Tree.SelectedNode == null)
            {
                MessageBox.Show("请选择要编辑的部门");
            }
            else
            {
                EditGroupForm groupform = new EditGroupForm(Group_Tree.SelectedNode.Name);
                if (groupform.ShowDialog() == DialogResult.OK)
                { 
                
                }
                   
            }
        }

        private void lab_Delete_Click(object sender, EventArgs e)
        {
            if (Group_Tree.SelectedNode == null)
            {
                MessageBox.Show("请选择要删除的部门");
            }

            if (MessageBox.Show("你确定要删除这个部门吗？", "删除", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DAL.DAL_Group groupdal = new DAL.DAL_Group();

                if (groupdal.deleteGroupWithId(Group_Tree.SelectedNode.Name))
                {
                    MessageBox.Show("删除成功");
                    {
                        this.Group_Tree.Nodes.Clear();

                        groupdal = new DAL.DAL_Group();

                        DataTable _dt = groupdal.selectGroupListInfo();

                        if (_dt.Rows.Count > 0)
                        {
                            foreach (DataRow _row in _dt.Rows)
                            {
                                TreeNode _node = new TreeNode();
                                _node.Name = _row[0].ToString();
                                _node.Text = _row[1].ToString();
                                this.Group_Tree.Nodes.Add(_node);
                            }
                        }

                    }  
                }
                else
                    MessageBox.Show("删除失败");
            }
        }

        private void btn_DeleteChannel_Click(object sender, EventArgs e)
        {

        }

        private void btn_SaveChannel_Click(object sender, EventArgs e)
        {

        }

        private void CustomerControlItem_tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int i = 0;
            var tree = (TreeView)sender;

            if (tree.SelectedNode.Text == "群组管理")
            {
                this.CustomerManagePanel.Visible = this.GroupManagePanel.Visible = false;
                this.GroupManagePanel.Visible = true;
                {
                    this.Group_Tree.Nodes.Clear();

                    DAL.DAL_Group groupdal = new DAL.DAL_Group();

                    DataTable _dt = groupdal.selectGroupListInfo();

                    if (_dt.Rows.Count > 0)
                    {
                        foreach (DataRow _row in _dt.Rows)
                        {
                            TreeNode _node = new TreeNode();
                            _node.Name = _row[0].ToString();
                            _node.Text = _row[1].ToString();
                            this.Group_Tree.Nodes.Add(_node);
                        }
                    }

                }

            }
            else if (tree.SelectedNode.Text == "人员管理")
            {
                this.CustomerManagePanel.Visible = this.GroupManagePanel.Visible = false;
                this.CustomerManagePanel.Visible = true;

                {
                    this.cmb_group.Items.Clear();

                    this.cmb_group.Items.Add("全部");

                    this.cmb_group.SelectedIndex = 0;

                    DAL.DAL_Group groupdal = new DAL.DAL_Group();

                    DataTable _dt = groupdal.selectGroupListInfo();

                    if (_dt.Rows.Count > 0)
                    {
                        foreach (DataRow _row in _dt.Rows)
                        {
                            this.cmb_group.Items.Add(_row[1]);
                        }
                    }

                    {
                        _dt = (new DAL.DAL_CustomerInfo()).selectCustomerInfoWithGroupAndKey("","全部", "");

                        if (_dt != null)
                        {
                            CustomerInfoListView.DataSource = _dt;
                        }
                    }

                }
            }
            else
            {
                this.CustomerManagePanel.Visible = this.GroupManagePanel.Visible = false;
            }
        }

        private void Park_ControlItem_tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int i = 0;
            var tree = (TreeView)sender;

            if (tree.SelectedNode.Text == "停车场管理")
            {
                this.panel_ParkManage.Visible = this.CarAuthrizeInfoPanel.Visible = this.VehicleRecord_Panel.Visible=false;
                this.panel_ParkManage.Visible = true;
                ParkPositionTreeView_Init();

            }
            else if (tree.SelectedNode.Text == "车辆管理")
            {
                this.panel_ParkManage.Visible = this.CarAuthrizeInfoPanel.Visible = this.VehicleRecord_Panel.Visible = false;
                this.CarAuthrizeInfoPanel.Visible = true;

                this.cmb_VehicleGroup.Items.Clear();

                this.cmb_VehicleGroup.Items.Add("全部");

                DAL.DAL_Group groupdal = new DAL.DAL_Group();

                DataTable _dt = groupdal.selectGroupListInfo();

                if (_dt.Rows.Count > 0)
                {
                    foreach (DataRow _row in _dt.Rows)
                    {
                        this.cmb_VehicleGroup.Items.Add(_row[1]);
                    }
                }

                this.cmb_VehicleGroup.SelectedIndex = 0;

                {
                    _dt = (new DAL.DAL_VehicleInfo()).selectVehicleInfoWithGroupAndKey("","全部"); 

                    if (_dt != null)
                    {
                        this.VehicleInfoGrid.DataSource = _dt;
                    }
                }

            }
            else if(tree.SelectedNode.Text == "统计汇总")
            {
                this.panel_ParkManage.Visible = this.CarAuthrizeInfoPanel.Visible = this.VehicleRecord_Panel.Visible = false;
                this.VehicleRecord_Panel.Visible=true;
            }
            else
            {
                this.panel_ParkManage.Visible = this.CarAuthrizeInfoPanel.Visible = this.VehicleRecord_Panel.Visible = false;
            }
        }

        private void ParkPositionTreeView_Init()
        {
           this.ParkPositionInfoTree.Nodes[0].Nodes.Clear();

           DAL.DAL_Position positiondal = new DAL.DAL_Position();

           DataTable _dt=positiondal.selectPositionListInfo("2");

           if (_dt.Rows.Count > 0)
           {
               foreach (DataRow _row in _dt.Rows)
               { 
               
                    TreeNode _node=new TreeNode();
                    _node.Name=_row[0].ToString();
                    _node.Text=_row[1].ToString();
                    this.ParkPositionInfoTree.Nodes[0].Nodes.Add(_node);
               }
           }

        }

        private void DoorPositionTreeView_Init()
        {
            this.DoorPositionInfoTree.Nodes[0].Nodes[0].Nodes.Clear();

            DAL.DAL_Position positiondal = new DAL.DAL_Position();

            DataTable _dt = positiondal.selectPositionListInfo("1");

            if (_dt.Rows.Count > 0)
            {
                foreach (DataRow _row in _dt.Rows)
                {

                    TreeNode _node = new TreeNode();
                    _node.Name = _row[0].ToString();
                    _node.Text = _row[1].ToString();
                    this.DoorPositionInfoTree.Nodes[0].Nodes[0].Nodes.Add(_node);
                }
            }

        }

        private void PositionCmb_Init()
        {
            this.cmb_PassengerPosition.Items.Clear();

            this.cmb_PassengerPosition.Items.Add("全部");

            this.cmb_PassengerPosition.SelectedIndex = 0;

            DAL.DAL_Position positiondal = new DAL.DAL_Position();

            DataTable _dt = positiondal.selectPositionListInfo("1");

            if (_dt.Rows.Count > 0)
            {
                foreach (DataRow _row in _dt.Rows)
                {
                    this.cmb_PassengerPosition.Items.Add(_row[1].ToString());
                }
            }

            this.cmb_VehiclePosition.Items.Clear();

            this.cmb_VehiclePosition.Items.Add("全部");

            this.cmb_VehiclePosition.SelectedIndex = 0;

            positiondal = new DAL.DAL_Position();

            _dt = positiondal.selectPositionListInfo("2");

            if (_dt.Rows.Count > 0)
            {
                foreach (DataRow _row in _dt.Rows)
                {
                    this.cmb_VehiclePosition.Items.Add(_row[1].ToString());
                }
            }

        }

        private void Device_ControlItem_View_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int i = 0;
            var tree = (TreeView)sender;

            this.tabControl2.Visible = true;

            if (tree.SelectedNode.Text == "出入记录")
            {
                tabControl2.SelectedIndex = 1;
                PositionCmb_Init();
            }

            if (tree.SelectedNode.Text == "出入口管理")
            {
                tabControl2.SelectedIndex = 2;
                DoorPositionTreeView_Init();
            }
            if (tree.SelectedNode.Text == "硬件配置")
            {
                //容器

                tabControl2.SelectedIndex = 0;
                
                {
                    DAL.DAL_Position positiondal = new DAL.DAL_Position();

                    DataTable _dt = positiondal.selectPositionListInfo("");

                    if (_dt.Rows.Count > 0)
                    {
                        this.cmb_DevicePosition.Items.Clear();
                        this.cmb_DevicePosition.Items.Add("全部");
                        this.cmb_DevicePosition.SelectedIndex=0;

                        foreach (DataRow _row in _dt.Rows)
                        {
                            this.cmb_DevicePosition.Items.Add(_row[1]);
                        }
                    }
                
                }

            }
            else if (tree.SelectedNode.Text == "部门权限")
            {
                //DeviceOption_panel.Controls.Clear();
                //DeviceOptionControl devicecontrol = new DeviceOptionControl();
                //DeviceOption_panel.Controls.Add(devicecontrol);
                //devicecontrol.Show();
            }
            else if (tree.SelectedNode.Text == "统计汇总")
            {
                tabControl2.SelectedIndex = 3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           MessageBox.Show(DeviceOption_panel.Controls[0].Width.ToString()+" "+DeviceOption_panel.Controls[0].Height.ToString()+"and"+DeviceOption_panel.Width+" "+DeviceOption_panel.Height);
        }

        //查询人员出入记录
        private void btn_RecordSearch_Click(object sender, EventArgs e)
        {
            DAL.DAL_Log _log = new DAL.DAL_Log();

            string eventposition="";

            if(cmb_PassengerPosition.Text!="全部")
                eventposition=cmb_PassengerPosition.Text;
          
            DataTable dt=_log.search_PassengerLog(eventposition, PassRecordStartTime.Value.ToString(),PassRecordEndTime.Value.ToString(),txb_SearchPassKey.Text);

            if (dt != null)
            {
                PassengerRecordGrid.DataSource = dt;
            }
        }

        //查询车辆出入记录
        private void button2_Click(object sender, EventArgs e)
        {
            DAL.DAL_Log _log = new DAL.DAL_Log();

            string eventposition = "";

            if (cmb_VehiclePosition.Text != "全部")
                eventposition = cmb_VehiclePosition.Text;

            DataTable dt = _log.search_vehicleLog(eventposition, VehicleRecordStartTime.Value.ToString(), VehicleRecordEndTime.Value.ToString(), this.txb_SearchPassKey.Text);

            if (dt != null)
            {
                VehicleRecordGrid.DataSource = dt;
            }
        }

        private void btn_Customer_Search_Click(object sender, EventArgs e)
        {
           DAL.DAL_CustomerInfo customerdal = new DAL.DAL_CustomerInfo();

           DataTable _dt=customerdal.selectCustomerInfoWithGroupAndKey(this.txb_SearchPassKey.Text, this.cmb_group.Text,"");

           if (_dt != null)
           {
               this.CustomerInfoListView.DataSource = _dt;
           }
        }

        private void btn_Customer_Edit_Click(object sender, EventArgs e)
        {

            if (this.CustomerInfoListView.SelectedRows.Count<= 0)
            {
                MessageBox.Show("请选择要编辑的人员信息");
            }

            EditCustomerForm editcutomerform = new EditCustomerForm(this.CustomerInfoListView.SelectedRows[0].Cells[0].Value.ToString());

            if (editcutomerform.ShowDialog() == DialogResult.OK)
            { 
            
            }
        }

        private void btn_Customer_ADD_Click(object sender, EventArgs e)
        {
            NewCustomerForm newcutomerform = new NewCustomerForm();
            if (newcutomerform.ShowDialog() == DialogResult.OK)
            {
                {
                    DAL.DAL_CustomerInfo customerdal = new DAL.DAL_CustomerInfo();

                    DataTable _dt = customerdal.selectCustomerInfoWithGroupAndKey(this.txb_SearchPassKey.Text, this.cmb_group.Text, "");

                    if (_dt != null)
                    {
                        this.CustomerInfoListView.DataSource = _dt;
                    }
                }

            }
        }

        private void btn_Vehicle_Add_Click(object sender, EventArgs e)
        {
            NewVehicleForm _form = new NewVehicleForm();

            if (_form.ShowDialog() == DialogResult.OK)
            {
                {
                    DataTable _dt = (new DAL.DAL_VehicleInfo()).selectVehicleInfoWithGroupAndKey("", this.cmb_VehicleGroup.Text);

                    if (_dt != null)
                    {
                        this.VehicleInfoGrid.DataSource = _dt;
                    }
                }
            
            }
        }

        private void btn_Vehicle_Delete_Click(object sender, EventArgs e)
        {
            if (this.VehicleInfoGrid.SelectedRows.Count<=0)
            {
                MessageBox.Show("请选择要删除的车辆信息");
            }
            else if(MessageBox.Show("你确定要删除车牌号为"+VehicleInfoGrid.SelectedRows[0].Cells[1].Value+"的车辆吗？","删除",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                DAL.DAL_VehicleInfo vehicle = new DAL.DAL_VehicleInfo();

                if (vehicle.deleteVehicleWithId(VehicleInfoGrid.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    MessageBox.Show("删除成功！");
                    {
                        DataTable _dt = (new DAL.DAL_VehicleInfo()).selectVehicleInfoWithGroupAndKey("", this.cmb_VehicleGroup.Text);

                        if (_dt != null)
                        {
                            this.VehicleInfoGrid.DataSource = _dt;
                        }
                    }
                }
                else
                    MessageBox.Show("删除失败！");
            }
        }

        private void btn_Channel_ADD_Click(object sender, EventArgs e)
        {
            if (this.txb_ParkChannelName.Text != "" && this.cmb_ParkChannelDirection.Text != "")
            {
                DAL.DAL_Position positiondal = new DAL.DAL_Position();

                DAL.DAO.PositionDao positiondao = new DAL.DAO.PositionDao();

                positiondao.Position = this.txb_ParkChannelName.Text;

                positiondao.Positiontype = "2";

                if (this.cmb_ParkChannelDirection.Text == "入口")
                    positiondao.Positiondirection = "0";
                else if(this.cmb_ParkChannelDirection.Text == "出口")
                    positiondao.Positiondirection = "1";
                if (positiondal.insertPositionInfo(positiondao))
                {
                    MessageBox.Show("添加成功!");
                    ParkPositionTreeView_Init();
                }
                else
                    MessageBox.Show("添加失败!");

                this.txb_ParkChannelName.Text = "";

            }
            else
            {
                MessageBox.Show("道口信息填写不正确");
            }
        }

        private void btn_Channel_Del_Click(object sender, EventArgs e)
        {
            if (this.ParkPositionInfoTree.SelectedNode == null)
            {
                MessageBox.Show("请选择要删除的道口");
            }
            else
            {
                DAL.DAL_Position positiondal = new DAL.DAL_Position();

                if (positiondal.deletePositionWithId(this.ParkPositionInfoTree.SelectedNode.Name))
                {
                    MessageBox.Show("删除成功!");
                    ParkPositionTreeView_Init();
                }
                else
                    MessageBox.Show("删除失败!");

                this.txb_ParkChannelName.Text = "";
            
            }
        }

        private void btn_Customer_Delete_Click(object sender, EventArgs e)
        {
            if (this.CustomerInfoListView.SelectedRows.Count<= 0)
            {
                MessageBox.Show("请选择要删除的人员");
            }
            else
            {
                DAL.DAL_CustomerInfo customerdal = new DAL.DAL_CustomerInfo();

                if (customerdal.deleteCustomerWithId(this.CustomerInfoListView.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    MessageBox.Show("删除成功!");
                    {
                        DataTable _dt = customerdal.selectCustomerInfoWithGroupAndKey(this.txb_SearchPassKey.Text, this.cmb_group.Text, "");

                        if (_dt != null)
                        {
                            this.CustomerInfoListView.DataSource = _dt;
                        }
                    }
                }
                else
                    MessageBox.Show("删除失败!");
            }
        }

        private void btn_Search_Vehicle_Click(object sender, EventArgs e)
        {
           DAL.DAL_VehicleInfo vehicleinfo = new DAL.DAL_VehicleInfo();

           DataTable _dt=vehicleinfo.selectVehicleInfoWithGroupAndKey(txb_SearchVehicleKey.Text, this.cmb_VehicleGroup.Text);

           if (_dt != null)
           {
               this.VehicleInfoGrid.DataSource = _dt;
           }


        }

        private void btn_SearchDevice_Click(object sender, EventArgs e)
        {
            DAL.DAL_Device devicedal = new DAL.DAL_Device();

            DataTable _dt=devicedal.selectDeviceInfoWithPositionAndKey(this.txb_SearchDeviceKey.Text, cmb_DevicePosition.Text);

            if (_dt != null)
            {
                this.DeviceInfoGrid.DataSource = _dt;
            }
        }

        private void btn_Device_Add_Click(object sender, EventArgs e)
        {
            NewDeviceForm _form = new NewDeviceForm();
            if (_form.ShowDialog() == DialogResult.OK)
            { 
            
            }

        }

        private void btn_Device_Edit_Click(object sender, EventArgs e)
        {
            if (DeviceInfoGrid.SelectedRows.Count<= 0)
            {
                MessageBox.Show("请选择需要编辑的设备");
            }
            else
            {
                EditDeviceForm _form = new EditDeviceForm(this.DeviceInfoGrid.SelectedRows[0].Cells[0].Value.ToString());
                if (_form.ShowDialog() == DialogResult.OK)
                { 
                
                }
            }
        }

        private void btn_Device_Delete_Click(object sender, EventArgs e)
        {
            if (this.DeviceInfoGrid.SelectedRows.Count<= 0)
            {
                MessageBox.Show("请选择要删除的设备");
            }
            else if (MessageBox.Show("你确定要删除名称为" + DeviceInfoGrid.SelectedRows[0].Cells[1].Value + "的设备吗？", "删除", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DAL.DAL_Device vehicle = new DAL.DAL_Device();

                if (vehicle.deleteDeviceWithId(DeviceInfoGrid.SelectedRows[0].Cells[0].Value.ToString()))
                    MessageBox.Show("删除成功！");
                else
                    MessageBox.Show("删除失败！");
            }
        }

        private void DeviceInfoGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_CustomerAuthrize_Edit_Click(object sender, EventArgs e)
        {
            if(CustomerInfoListView.SelectedRows.Count<=0)
            {
              MessageBox.Show("未选择用户！");
              return;
            }

            CustomerGroupInfo _form = new CustomerGroupInfo(CustomerInfoListView.SelectedRows[0].Cells[0].Value.ToString(), CustomerInfoListView.SelectedRows[0].Cells["CustomerType"].Value.ToString());
            if (_form.ShowDialog()== DialogResult.OK)
            { 

            }
        }

        private void btn_VehicleAuthrize_Edit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("功能暂时不可用");

            //if (VehicleInfoGrid.SelectedRows == null)
            //{
            //    MessageBox.Show("未选择车辆！");
            //    return;
            //}

            //VehicleAuthorize _form = new VehicleAuthorize(VehicleInfoGrid.SelectedRows[0].Cells[0].Value.ToString(), VehicleInfoGrid.SelectedRows[0].Cells["vehicletype"].Value.ToString());
            //if(_form.ShowDialog()==DialogResult.OK)
            //{
              
            
            //}
        }

        private void btn_Device_Authrize_Edit_Click(object sender, EventArgs e)
        {
            if (this.DeviceInfoGrid.SelectedRows.Count <=0)
            {
                MessageBox.Show("请选择设备！");
                return;
            }

            if (this.DeviceInfoGrid.SelectedRows[0].Cells[2].Value.ToString() != "门禁控制板")
            {
                MessageBox.Show("该设备类型无法配置权限！");
                return;
            }



            string positiontype = (new DAL.DAL_Position()).GetPositionType(this.DeviceInfoGrid.SelectedRows[0].Cells["DevicePosition"].Value.ToString());

            if (positiontype == "1")
            {
                DeviceAuthorize deviceauthorizeform = new DeviceAuthorize(this.DeviceInfoGrid.SelectedRows[0].Cells[0].Value.ToString());

                if(deviceauthorizeform.ShowDialog()==DialogResult.OK)
                { 
                
                }
            }

            if(positiontype == "2")
            {  
                DeviceVehicleAuthorize deviceauthorizeform = new DeviceVehicleAuthorize(this.DeviceInfoGrid.SelectedRows[0].Cells[0].Value.ToString());
                if (deviceauthorizeform.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void btn_DoorChannel_Del_Click(object sender, EventArgs e)
        {
            if (this.DoorPositionInfoTree.SelectedNode == null)
            {
                MessageBox.Show("请选择要删除的道口");
            }
            else
            {
                DAL.DAL_Position positiondal = new DAL.DAL_Position();

                if (positiondal.deletePositionWithId(this.DoorPositionInfoTree.SelectedNode.Name))
                    MessageBox.Show("删除成功!");
                else
                    MessageBox.Show("删除失败!");

                this.txb_DoorChannelName.Text = "";

            }
        }

        private void btn_DoorChannel_ADD_Click(object sender, EventArgs e)
        {
            if (this.txb_DoorChannelName.Text != "")
            {
                DAL.DAL_Position positiondal = new DAL.DAL_Position();

                DAL.DAO.PositionDao positiondao = new DAL.DAO.PositionDao();

                positiondao.Position = this.txb_DoorChannelName.Text;

                positiondao.Positiontype = "1";

                if (positiondal.insertPositionInfo(positiondao))
                    MessageBox.Show("添加成功!");
                else
                    MessageBox.Show("添加失败!");

                this.txb_DoorChannelName.Text = "";

            }
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            NewUserForm _form = new NewUserForm();
            if (_form.ShowDialog()==DialogResult.OK )
            {
                {
                    DataTable _dt = (new DAL.DAL_UserInfo()).selectUserInfoListWithKeyAndGroup("");

                    if (_dt != null)
                    {
                        this.UserInfoListView.DataSource = _dt;
                    }
                }
            }
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            if (UserInfoListView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择用户");
                return;
            }

            EditUserForm _form = new EditUserForm(UserInfoListView.SelectedRows[0].Cells[0].Value.ToString());
            if (_form.ShowDialog() == DialogResult.OK)
            { 
            
            }
        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            if (UserInfoListView.SelectedRows.Count<=0)
            {
                MessageBox.Show("请选择用户");
                return;
            }
            if (MessageBox.Show("确定要删除用户名为" + UserInfoListView.SelectedRows[0].Cells[1].Value + "的用户吗？", "用户删除", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            if ((new DAL.DAL_UserInfo()).deleteUserWithId(UserInfoListView.SelectedRows[0].Cells[0].Value.ToString()))
            {
                MessageBox.Show("删除成功");
                {
                    {
                        DataTable _dt = (new DAL.DAL_UserInfo()).selectUserInfoListWithKeyAndGroup("");

                        if (_dt != null)
                        {
                            this.UserInfoListView.DataSource = _dt;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void btn_ReportSearch_Click(object sender, EventArgs e)
        {
            string reportway;

            if (checkBox1.Checked)
            {
                reportway = cmb_TimeType.Text;
            }
            else
                reportway = cmb_ItemType.Text;

            if (reportway == "")
            {
                MessageBox.Show("请选择统计方式");
                return;
            }

           DataTable _dt=(new DAL.DAL_Log()).getLogVehicleReport("", "", reportway);

           if (_dt != null)
           {
               this.VehicleReprotGridView.DataSource = _dt;
           }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                if (checkBox1.Checked == true)
                checkBox1.Checked = false;
                cmb_ItemType.Enabled = true;
                cmb_ItemType.SelectedIndex = 0;
                cmb_TimeType.Enabled = false;
                cmb_TimeType.Text = "";
            }
            else
            {
                if (checkBox1.Checked == false)
                checkBox1.Checked = true;
                cmb_TimeType.Enabled = true;
                cmb_TimeType.SelectedIndex = 0;
                cmb_ItemType.Enabled = false;
                cmb_ItemType.Text = "";   
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if( checkBox2.Checked ==true)
                checkBox2.Checked = false;
            }
            else
            {
                if (checkBox2.Checked == false)
                checkBox2.Checked = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                if (checkBox4.Checked == true)
                    checkBox4.Checked = false;
                cmb_ItemType_Passenger.Enabled = true;
                cmb_ItemType_Passenger.SelectedIndex = 0;
                cmb_TimeType_Passenger.Enabled = false;
                cmb_TimeType_Passenger.Text = "";
            }
            else
            {
                if (checkBox4.Checked == false)
                    checkBox4.Checked = true;
                cmb_TimeType_Passenger.Enabled = true;
                cmb_TimeType_Passenger.SelectedIndex = 0;
                cmb_ItemType_Passenger.Enabled = false;
                cmb_ItemType_Passenger.Text = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                if (checkBox3.Checked == true)
                    checkBox3.Checked = false;
            }
            else
            {
                if (checkBox3.Checked == false)
                    checkBox3.Checked = true;
            }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void btn_PassengerReportSearch_Click(object sender, EventArgs e)
        {
            string reportway;

            if (checkBox4.Checked)
            {
                reportway = cmb_TimeType_Passenger.Text;
            }
            else
                reportway = cmb_ItemType_Passenger.Text;

            if (reportway == "")
            {
                MessageBox.Show("请选择统计方式");
                return;
            }

            DataTable _dt = (new DAL.DAL_Log()).getLogPassengerReport("", "", reportway);

            if (_dt != null)
            {
                this.PassengerReprotGridView.DataSource = _dt;
            }
        }

        private void System_ControlItem_tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int i = 0;
            var tree = (TreeView)sender;

            if (tree.SelectedNode.Text == "系统用户管理")
            {
                UserManagePanel.Visible = true;
                {
                    DataTable _dt = (new DAL.DAL_UserInfo()).selectUserInfoListWithKeyAndGroup("");

                    if (_dt != null)
                    {
                        this.UserInfoListView.DataSource = _dt;
                    }
                }
            }
        }

        private void btn_SelectUser_Click(object sender, EventArgs e)
        {
            DataTable _dt = (new DAL.DAL_UserInfo()).selectUserInfoListWithKeyAndGroup(this.txb_SelectUserKey.Text);

            if (_dt != null)
            {
                this.UserInfoListView.DataSource = _dt;
            }

        
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btn_EditPwd_Click(object sender, EventArgs e)
        {
            if (UserInfoListView.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择用户");
                return;
            }

            EditPassword _pwdform = new EditPassword(UserInfoListView.SelectedRows[0].Cells[0].Value.ToString());

            if (_pwdform.ShowDialog() == DialogResult.OK)
            { 
            
            }

        }

        private void label_GroupAuthorize_Click(object sender, EventArgs e)
        {
            if (Group_Tree.SelectedNode == null)
            {
                MessageBox.Show("请选择要操作的部门");
            }
            else
            {
                GroupAuthorize groupform = new GroupAuthorize(Group_Tree.SelectedNode.Name,"");
                if (groupform.ShowDialog() == DialogResult.OK)
                {

                }

            }
        }

      
       
    }
}
