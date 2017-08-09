namespace SmartPlugin
{
    partial class SmartMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode86 = new System.Windows.Forms.TreeNode("物业经理");
            System.Windows.Forms.TreeNode treeNode87 = new System.Windows.Forms.TreeNode("保安");
            System.Windows.Forms.TreeNode treeNode88 = new System.Windows.Forms.TreeNode("业主");
            System.Windows.Forms.TreeNode treeNode89 = new System.Windows.Forms.TreeNode("群组管理");
            System.Windows.Forms.TreeNode treeNode90 = new System.Windows.Forms.TreeNode("人员管理");
            System.Windows.Forms.TreeNode treeNode91 = new System.Windows.Forms.TreeNode("道口");
            System.Windows.Forms.TreeNode treeNode92 = new System.Windows.Forms.TreeNode("停车场管理");
            System.Windows.Forms.TreeNode treeNode93 = new System.Windows.Forms.TreeNode("车辆管理");
            System.Windows.Forms.TreeNode treeNode94 = new System.Windows.Forms.TreeNode("统计汇总");
            System.Windows.Forms.TreeNode treeNode95 = new System.Windows.Forms.TreeNode("停车场A口出口");
            System.Windows.Forms.TreeNode treeNode96 = new System.Windows.Forms.TreeNode("出入口", new System.Windows.Forms.TreeNode[] {
            treeNode95});
            System.Windows.Forms.TreeNode treeNode97 = new System.Windows.Forms.TreeNode("小区", new System.Windows.Forms.TreeNode[] {
            treeNode96});
            System.Windows.Forms.TreeNode treeNode98 = new System.Windows.Forms.TreeNode("硬件配置");
            System.Windows.Forms.TreeNode treeNode99 = new System.Windows.Forms.TreeNode("统计汇总");
            System.Windows.Forms.TreeNode treeNode100 = new System.Windows.Forms.TreeNode("出入记录");
            System.Windows.Forms.TreeNode treeNode101 = new System.Windows.Forms.TreeNode("出入口管理");
            System.Windows.Forms.TreeNode treeNode102 = new System.Windows.Forms.TreeNode("系统用户管理");
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CustManagePage = new System.Windows.Forms.TabPage();
            this.CustomerManagePanel = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.cmb_group = new System.Windows.Forms.ComboBox();
            this.btn_Customer_Search = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_Customer_SearchKey = new System.Windows.Forms.TextBox();
            this.btn_CustomerGroup_Edit = new System.Windows.Forms.Button();
            this.btn_Customer_Delete = new System.Windows.Forms.Button();
            this.btn_Customer_Edit = new System.Windows.Forms.Button();
            this.btn_Customer_ADD = new System.Windows.Forms.Button();
            this.CustomerInfoListView = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupManagePanel = new System.Windows.Forms.Panel();
            this.lab_GroupAuthorize = new System.Windows.Forms.Label();
            this.Group_Tree = new System.Windows.Forms.TreeView();
            this.lab_Delete = new System.Windows.Forms.Label();
            this.lab_EditSelectGroup = new System.Windows.Forms.Label();
            this.lab_AddBrotherGroup = new System.Windows.Forms.Label();
            this.CustomerControlItem_tree = new System.Windows.Forms.TreeView();
            this.ParkManagePage = new System.Windows.Forms.TabPage();
            this.CarAuthrizeInfoPanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.cmb_VehicleGroup = new System.Windows.Forms.ComboBox();
            this.btn_Search_Vehicle = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.txb_SearchVehicleKey = new System.Windows.Forms.TextBox();
            this.btn_Vehicle_Delete = new System.Windows.Forms.Button();
            this.btn_VehicleAuthrize_Edit = new System.Windows.Forms.Button();
            this.btn_Vehicle_Add = new System.Windows.Forms.Button();
            this.VehicleInfoGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_ParkManage = new System.Windows.Forms.Panel();
            this.cmb_ParkChannelDirection = new System.Windows.Forms.ComboBox();
            this.btn_ParkChannel_Del = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_ParkChannelName = new System.Windows.Forms.TextBox();
            this.btn_ParkChannel_ADD = new System.Windows.Forms.Button();
            this.ParkPositionInfoTree = new System.Windows.Forms.TreeView();
            this.VehicleRecord_Panel = new System.Windows.Forms.Panel();
            this.reporttab = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_ReportSearch = new System.Windows.Forms.Button();
            this.cmb_TimeType = new System.Windows.Forms.ComboBox();
            this.cmb_ItemType = new System.Windows.Forms.ComboBox();
            this.btn_Export = new System.Windows.Forms.Button();
            this.VehicleReprotGridView = new System.Windows.Forms.DataGridView();
            this.ReportItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Park_ControlItem_tree = new System.Windows.Forms.TreeView();
            this.DeviceManagePage = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DeviceOption_panel = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_DevicePosition = new System.Windows.Forms.ComboBox();
            this.btn_SearchDevice = new System.Windows.Forms.Button();
            this.txb_SearchDeviceKey = new System.Windows.Forms.TextBox();
            this.btn_Device_Authrize_Edit = new System.Windows.Forms.Button();
            this.btn_Device_Delete = new System.Windows.Forms.Button();
            this.btn_Device_Edit = new System.Windows.Forms.Button();
            this.btn_Device_Add = new System.Windows.Forms.Button();
            this.DeviceInfoGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DevicePosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceNetAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.InOutRecordTab = new System.Windows.Forms.TabControl();
            this.PassengerRecordPage = new System.Windows.Forms.TabPage();
            this.btn_PassRecordSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PassRecordEndTime = new System.Windows.Forms.DateTimePicker();
            this.PassRecordStartTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_PassengerPosition = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_SearchPassKey = new System.Windows.Forms.TextBox();
            this.PassengerRecordGrid = new System.Windows.Forms.DataGridView();
            this.PassengerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleRecordPage = new System.Windows.Forms.TabPage();
            this.VehicleRecordGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_VehiRecordSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.VehicleRecordEndTime = new System.Windows.Forms.DateTimePicker();
            this.VehicleRecordStartTime = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_VehiclePosition = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txb_SearchVechicleKey = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel_DoorManage = new System.Windows.Forms.Panel();
            this.btn_DoorChannel_Del = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txb_DoorChannelName = new System.Windows.Forms.TextBox();
            this.btn_DoorChannel_ADD = new System.Windows.Forms.Button();
            this.DoorPositionInfoTree = new System.Windows.Forms.TreeView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.PassengerRecord_panel = new System.Windows.Forms.Panel();
            this.PassRecord_tab = new System.Windows.Forms.TabControl();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.btn_PassengerReportSearch = new System.Windows.Forms.Button();
            this.cmb_TimeType_Passenger = new System.Windows.Forms.ComboBox();
            this.cmb_ItemType_Passenger = new System.Windows.Forms.ComboBox();
            this.btn_PassengerReportExport = new System.Windows.Forms.Button();
            this.PassengerReprotGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Device_ControlItem_View = new System.Windows.Forms.TreeView();
            this.SystemOptionPage = new System.Windows.Forms.TabPage();
            this.UserManagePanel = new System.Windows.Forms.Panel();
            this.btn_SelectUser = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txb_SelectUserKey = new System.Windows.Forms.TextBox();
            this.btn_EditPwd = new System.Windows.Forms.Button();
            this.btn_DeleteUser = new System.Windows.Forms.Button();
            this.btn_EditUser = new System.Windows.Forms.Button();
            this.btn_AddUser = new System.Windows.Forms.Button();
            this.UserInfoListView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.System_ControlItem_tree = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_PresentUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_Time = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.CustManagePage.SuspendLayout();
            this.CustomerManagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerInfoListView)).BeginInit();
            this.GroupManagePanel.SuspendLayout();
            this.ParkManagePage.SuspendLayout();
            this.CarAuthrizeInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleInfoGrid)).BeginInit();
            this.panel_ParkManage.SuspendLayout();
            this.VehicleRecord_Panel.SuspendLayout();
            this.reporttab.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleReprotGridView)).BeginInit();
            this.DeviceManagePage.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.DeviceOption_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceInfoGrid)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.InOutRecordTab.SuspendLayout();
            this.PassengerRecordPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassengerRecordGrid)).BeginInit();
            this.VehicleRecordPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleRecordGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel_DoorManage.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.PassengerRecord_panel.SuspendLayout();
            this.PassRecord_tab.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassengerReprotGridView)).BeginInit();
            this.SystemOptionPage.SuspendLayout();
            this.UserManagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoListView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 586);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CustManagePage);
            this.tabControl1.Controls.Add(this.ParkManagePage);
            this.tabControl1.Controls.Add(this.DeviceManagePage);
            this.tabControl1.Controls.Add(this.SystemOptionPage);
            this.tabControl1.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1080, 580);
            this.tabControl1.TabIndex = 0;
            // 
            // CustManagePage
            // 
            this.CustManagePage.BackColor = System.Drawing.SystemColors.Control;
            this.CustManagePage.Controls.Add(this.CustomerManagePanel);
            this.CustManagePage.Controls.Add(this.GroupManagePanel);
            this.CustManagePage.Controls.Add(this.CustomerControlItem_tree);
            this.CustManagePage.Location = new System.Drawing.Point(4, 29);
            this.CustManagePage.Name = "CustManagePage";
            this.CustManagePage.Padding = new System.Windows.Forms.Padding(3);
            this.CustManagePage.Size = new System.Drawing.Size(1072, 547);
            this.CustManagePage.TabIndex = 0;
            this.CustManagePage.Text = "人员管理";
            // 
            // CustomerManagePanel
            // 
            this.CustomerManagePanel.Controls.Add(this.label16);
            this.CustomerManagePanel.Controls.Add(this.cmb_group);
            this.CustomerManagePanel.Controls.Add(this.btn_Customer_Search);
            this.CustomerManagePanel.Controls.Add(this.label6);
            this.CustomerManagePanel.Controls.Add(this.txb_Customer_SearchKey);
            this.CustomerManagePanel.Controls.Add(this.btn_CustomerGroup_Edit);
            this.CustomerManagePanel.Controls.Add(this.btn_Customer_Delete);
            this.CustomerManagePanel.Controls.Add(this.btn_Customer_Edit);
            this.CustomerManagePanel.Controls.Add(this.btn_Customer_ADD);
            this.CustomerManagePanel.Controls.Add(this.CustomerInfoListView);
            this.CustomerManagePanel.Location = new System.Drawing.Point(209, 4);
            this.CustomerManagePanel.Name = "CustomerManagePanel";
            this.CustomerManagePanel.Size = new System.Drawing.Size(863, 543);
            this.CustomerManagePanel.TabIndex = 7;
            this.CustomerManagePanel.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(50, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 19);
            this.label16.TabIndex = 17;
            this.label16.Text = "所在群组";
            // 
            // cmb_group
            // 
            this.cmb_group.FormattingEnabled = true;
            this.cmb_group.Location = new System.Drawing.Point(140, 19);
            this.cmb_group.Name = "cmb_group";
            this.cmb_group.Size = new System.Drawing.Size(121, 27);
            this.cmb_group.TabIndex = 16;
            // 
            // btn_Customer_Search
            // 
            this.btn_Customer_Search.Location = new System.Drawing.Point(579, 14);
            this.btn_Customer_Search.Name = "btn_Customer_Search";
            this.btn_Customer_Search.Size = new System.Drawing.Size(100, 35);
            this.btn_Customer_Search.TabIndex = 15;
            this.btn_Customer_Search.Text = "查询";
            this.btn_Customer_Search.UseVisualStyleBackColor = true;
            this.btn_Customer_Search.Click += new System.EventHandler(this.btn_Customer_Search_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "关键字";
            // 
            // txb_Customer_SearchKey
            // 
            this.txb_Customer_SearchKey.Location = new System.Drawing.Point(408, 18);
            this.txb_Customer_SearchKey.Name = "txb_Customer_SearchKey";
            this.txb_Customer_SearchKey.Size = new System.Drawing.Size(136, 29);
            this.txb_Customer_SearchKey.TabIndex = 13;
            // 
            // btn_CustomerGroup_Edit
            // 
            this.btn_CustomerGroup_Edit.Location = new System.Drawing.Point(231, 476);
            this.btn_CustomerGroup_Edit.Name = "btn_CustomerGroup_Edit";
            this.btn_CustomerGroup_Edit.Size = new System.Drawing.Size(135, 49);
            this.btn_CustomerGroup_Edit.TabIndex = 12;
            this.btn_CustomerGroup_Edit.Text = "编辑人员群组";
            this.btn_CustomerGroup_Edit.UseVisualStyleBackColor = true;
            this.btn_CustomerGroup_Edit.Click += new System.EventHandler(this.btn_CustomerAuthrize_Edit_Click);
            // 
            // btn_Customer_Delete
            // 
            this.btn_Customer_Delete.Location = new System.Drawing.Point(676, 476);
            this.btn_Customer_Delete.Name = "btn_Customer_Delete";
            this.btn_Customer_Delete.Size = new System.Drawing.Size(123, 49);
            this.btn_Customer_Delete.TabIndex = 11;
            this.btn_Customer_Delete.Text = "删除人员";
            this.btn_Customer_Delete.UseVisualStyleBackColor = true;
            this.btn_Customer_Delete.Click += new System.EventHandler(this.btn_Customer_Delete_Click);
            // 
            // btn_Customer_Edit
            // 
            this.btn_Customer_Edit.Location = new System.Drawing.Point(443, 476);
            this.btn_Customer_Edit.Name = "btn_Customer_Edit";
            this.btn_Customer_Edit.Size = new System.Drawing.Size(133, 49);
            this.btn_Customer_Edit.TabIndex = 10;
            this.btn_Customer_Edit.Text = "编辑人员详情";
            this.btn_Customer_Edit.UseVisualStyleBackColor = true;
            this.btn_Customer_Edit.Click += new System.EventHandler(this.btn_Customer_Edit_Click);
            // 
            // btn_Customer_ADD
            // 
            this.btn_Customer_ADD.Location = new System.Drawing.Point(42, 476);
            this.btn_Customer_ADD.Name = "btn_Customer_ADD";
            this.btn_Customer_ADD.Size = new System.Drawing.Size(100, 49);
            this.btn_Customer_ADD.TabIndex = 9;
            this.btn_Customer_ADD.Text = "添加人员";
            this.btn_Customer_ADD.UseVisualStyleBackColor = true;
            this.btn_Customer_ADD.Click += new System.EventHandler(this.btn_Customer_ADD_Click);
            // 
            // CustomerInfoListView
            // 
            this.CustomerInfoListView.AllowUserToAddRows = false;
            this.CustomerInfoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerInfoListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.name,
            this.idcard,
            this.rfid,
            this.CustomerType});
            this.CustomerInfoListView.Location = new System.Drawing.Point(17, 65);
            this.CustomerInfoListView.Name = "CustomerInfoListView";
            this.CustomerInfoListView.RowTemplate.Height = 23;
            this.CustomerInfoListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerInfoListView.Size = new System.Drawing.Size(835, 398);
            this.CustomerInfoListView.TabIndex = 8;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "id";
            this.CustomerId.HeaderText = "Id";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "人员名称";
            this.name.Name = "name";
            this.name.Width = 120;
            // 
            // idcard
            // 
            this.idcard.DataPropertyName = "idcard";
            this.idcard.HeaderText = "身份证";
            this.idcard.Name = "idcard";
            this.idcard.Width = 200;
            // 
            // rfid
            // 
            this.rfid.DataPropertyName = "rfid";
            this.rfid.HeaderText = "门禁卡号";
            this.rfid.Name = "rfid";
            this.rfid.Width = 150;
            // 
            // CustomerType
            // 
            this.CustomerType.DataPropertyName = "customertype";
            this.CustomerType.HeaderText = "人员类型";
            this.CustomerType.Name = "CustomerType";
            this.CustomerType.Width = 120;
            // 
            // GroupManagePanel
            // 
            this.GroupManagePanel.Controls.Add(this.lab_GroupAuthorize);
            this.GroupManagePanel.Controls.Add(this.Group_Tree);
            this.GroupManagePanel.Controls.Add(this.lab_Delete);
            this.GroupManagePanel.Controls.Add(this.lab_EditSelectGroup);
            this.GroupManagePanel.Controls.Add(this.lab_AddBrotherGroup);
            this.GroupManagePanel.Location = new System.Drawing.Point(209, 4);
            this.GroupManagePanel.Name = "GroupManagePanel";
            this.GroupManagePanel.Size = new System.Drawing.Size(863, 543);
            this.GroupManagePanel.TabIndex = 1;
            this.GroupManagePanel.Visible = false;
            // 
            // lab_GroupAuthorize
            // 
            this.lab_GroupAuthorize.AutoSize = true;
            this.lab_GroupAuthorize.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_GroupAuthorize.Location = new System.Drawing.Point(478, 17);
            this.lab_GroupAuthorize.Name = "lab_GroupAuthorize";
            this.lab_GroupAuthorize.Size = new System.Drawing.Size(136, 16);
            this.lab_GroupAuthorize.TabIndex = 7;
            this.lab_GroupAuthorize.Text = "编辑群组门禁权限";
            this.lab_GroupAuthorize.Click += new System.EventHandler(this.label_GroupAuthorize_Click);
            // 
            // Group_Tree
            // 
            this.Group_Tree.Location = new System.Drawing.Point(4, 53);
            this.Group_Tree.Name = "Group_Tree";
            treeNode86.Name = "Node0";
            treeNode86.Text = "物业经理";
            treeNode87.Name = "Node1";
            treeNode87.Text = "保安";
            treeNode88.Name = "Node2";
            treeNode88.Text = "业主";
            this.Group_Tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode86,
            treeNode87,
            treeNode88});
            this.Group_Tree.Size = new System.Drawing.Size(849, 484);
            this.Group_Tree.TabIndex = 6;
            // 
            // lab_Delete
            // 
            this.lab_Delete.AutoSize = true;
            this.lab_Delete.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Delete.Location = new System.Drawing.Point(321, 17);
            this.lab_Delete.Name = "lab_Delete";
            this.lab_Delete.Size = new System.Drawing.Size(72, 16);
            this.lab_Delete.TabIndex = 5;
            this.lab_Delete.Text = "删除群组";
            this.lab_Delete.Click += new System.EventHandler(this.lab_Delete_Click);
            // 
            // lab_EditSelectGroup
            // 
            this.lab_EditSelectGroup.AutoSize = true;
            this.lab_EditSelectGroup.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_EditSelectGroup.Location = new System.Drawing.Point(151, 17);
            this.lab_EditSelectGroup.Name = "lab_EditSelectGroup";
            this.lab_EditSelectGroup.Size = new System.Drawing.Size(104, 16);
            this.lab_EditSelectGroup.TabIndex = 4;
            this.lab_EditSelectGroup.Text = "编辑群组信息";
            this.lab_EditSelectGroup.Click += new System.EventHandler(this.lab_EditSelectGroup_Click);
            // 
            // lab_AddBrotherGroup
            // 
            this.lab_AddBrotherGroup.AutoSize = true;
            this.lab_AddBrotherGroup.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_AddBrotherGroup.Location = new System.Drawing.Point(24, 17);
            this.lab_AddBrotherGroup.Name = "lab_AddBrotherGroup";
            this.lab_AddBrotherGroup.Size = new System.Drawing.Size(72, 16);
            this.lab_AddBrotherGroup.TabIndex = 2;
            this.lab_AddBrotherGroup.Text = "新增群组";
            this.lab_AddBrotherGroup.Click += new System.EventHandler(this.lab_AddBrotherGroup_Click);
            // 
            // CustomerControlItem_tree
            // 
            this.CustomerControlItem_tree.Location = new System.Drawing.Point(4, 4);
            this.CustomerControlItem_tree.Name = "CustomerControlItem_tree";
            treeNode89.Name = "GroupManage";
            treeNode89.Text = "群组管理";
            treeNode90.Name = "CustomerManage";
            treeNode90.Text = "人员管理";
            this.CustomerControlItem_tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode89,
            treeNode90});
            this.CustomerControlItem_tree.Size = new System.Drawing.Size(199, 543);
            this.CustomerControlItem_tree.TabIndex = 0;
            this.CustomerControlItem_tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CustomerControlItem_tree_AfterSelect);
            // 
            // ParkManagePage
            // 
            this.ParkManagePage.Controls.Add(this.CarAuthrizeInfoPanel);
            this.ParkManagePage.Controls.Add(this.panel_ParkManage);
            this.ParkManagePage.Controls.Add(this.VehicleRecord_Panel);
            this.ParkManagePage.Controls.Add(this.Park_ControlItem_tree);
            this.ParkManagePage.Location = new System.Drawing.Point(4, 29);
            this.ParkManagePage.Name = "ParkManagePage";
            this.ParkManagePage.Padding = new System.Windows.Forms.Padding(3);
            this.ParkManagePage.Size = new System.Drawing.Size(1072, 547);
            this.ParkManagePage.TabIndex = 1;
            this.ParkManagePage.Text = "停车场";
            this.ParkManagePage.UseVisualStyleBackColor = true;
            // 
            // CarAuthrizeInfoPanel
            // 
            this.CarAuthrizeInfoPanel.Controls.Add(this.label17);
            this.CarAuthrizeInfoPanel.Controls.Add(this.cmb_VehicleGroup);
            this.CarAuthrizeInfoPanel.Controls.Add(this.btn_Search_Vehicle);
            this.CarAuthrizeInfoPanel.Controls.Add(this.label18);
            this.CarAuthrizeInfoPanel.Controls.Add(this.txb_SearchVehicleKey);
            this.CarAuthrizeInfoPanel.Controls.Add(this.btn_Vehicle_Delete);
            this.CarAuthrizeInfoPanel.Controls.Add(this.btn_VehicleAuthrize_Edit);
            this.CarAuthrizeInfoPanel.Controls.Add(this.btn_Vehicle_Add);
            this.CarAuthrizeInfoPanel.Controls.Add(this.VehicleInfoGrid);
            this.CarAuthrizeInfoPanel.Location = new System.Drawing.Point(188, 0);
            this.CarAuthrizeInfoPanel.Name = "CarAuthrizeInfoPanel";
            this.CarAuthrizeInfoPanel.Size = new System.Drawing.Size(881, 544);
            this.CarAuthrizeInfoPanel.TabIndex = 8;
            this.CarAuthrizeInfoPanel.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(26, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 19);
            this.label17.TabIndex = 17;
            this.label17.Text = "所在部门";
            // 
            // cmb_VehicleGroup
            // 
            this.cmb_VehicleGroup.FormattingEnabled = true;
            this.cmb_VehicleGroup.Location = new System.Drawing.Point(140, 19);
            this.cmb_VehicleGroup.Name = "cmb_VehicleGroup";
            this.cmb_VehicleGroup.Size = new System.Drawing.Size(121, 27);
            this.cmb_VehicleGroup.TabIndex = 16;
            // 
            // btn_Search_Vehicle
            // 
            this.btn_Search_Vehicle.Location = new System.Drawing.Point(600, 13);
            this.btn_Search_Vehicle.Name = "btn_Search_Vehicle";
            this.btn_Search_Vehicle.Size = new System.Drawing.Size(100, 35);
            this.btn_Search_Vehicle.TabIndex = 15;
            this.btn_Search_Vehicle.Text = "查询";
            this.btn_Search_Vehicle.UseVisualStyleBackColor = true;
            this.btn_Search_Vehicle.Click += new System.EventHandler(this.btn_Search_Vehicle_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(375, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 19);
            this.label18.TabIndex = 14;
            this.label18.Text = "关键字:";
            // 
            // txb_SearchVehicleKey
            // 
            this.txb_SearchVehicleKey.Location = new System.Drawing.Point(458, 17);
            this.txb_SearchVehicleKey.Name = "txb_SearchVehicleKey";
            this.txb_SearchVehicleKey.Size = new System.Drawing.Size(136, 29);
            this.txb_SearchVehicleKey.TabIndex = 13;
            // 
            // btn_Vehicle_Delete
            // 
            this.btn_Vehicle_Delete.Location = new System.Drawing.Point(480, 483);
            this.btn_Vehicle_Delete.Name = "btn_Vehicle_Delete";
            this.btn_Vehicle_Delete.Size = new System.Drawing.Size(100, 35);
            this.btn_Vehicle_Delete.TabIndex = 11;
            this.btn_Vehicle_Delete.Text = "删除车辆";
            this.btn_Vehicle_Delete.UseVisualStyleBackColor = true;
            this.btn_Vehicle_Delete.Click += new System.EventHandler(this.btn_Vehicle_Delete_Click);
            // 
            // btn_VehicleAuthrize_Edit
            // 
            this.btn_VehicleAuthrize_Edit.Location = new System.Drawing.Point(265, 483);
            this.btn_VehicleAuthrize_Edit.Name = "btn_VehicleAuthrize_Edit";
            this.btn_VehicleAuthrize_Edit.Size = new System.Drawing.Size(100, 35);
            this.btn_VehicleAuthrize_Edit.TabIndex = 10;
            this.btn_VehicleAuthrize_Edit.Text = "编辑权限";
            this.btn_VehicleAuthrize_Edit.UseVisualStyleBackColor = true;
            this.btn_VehicleAuthrize_Edit.Click += new System.EventHandler(this.btn_VehicleAuthrize_Edit_Click);
            // 
            // btn_Vehicle_Add
            // 
            this.btn_Vehicle_Add.Location = new System.Drawing.Point(42, 483);
            this.btn_Vehicle_Add.Name = "btn_Vehicle_Add";
            this.btn_Vehicle_Add.Size = new System.Drawing.Size(100, 35);
            this.btn_Vehicle_Add.TabIndex = 9;
            this.btn_Vehicle_Add.Text = "添加车辆";
            this.btn_Vehicle_Add.UseVisualStyleBackColor = true;
            this.btn_Vehicle_Add.Click += new System.EventHandler(this.btn_Vehicle_Add_Click);
            // 
            // VehicleInfoGrid
            // 
            this.VehicleInfoGrid.AllowUserToAddRows = false;
            this.VehicleInfoGrid.AllowUserToDeleteRows = false;
            this.VehicleInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehicleInfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.VehicleType});
            this.VehicleInfoGrid.Location = new System.Drawing.Point(18, 66);
            this.VehicleInfoGrid.Name = "VehicleInfoGrid";
            this.VehicleInfoGrid.RowTemplate.Height = 23;
            this.VehicleInfoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VehicleInfoGrid.Size = new System.Drawing.Size(835, 368);
            this.VehicleInfoGrid.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "vehicle_num";
            this.dataGridViewTextBoxColumn6.HeaderText = "车牌号";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "vehiclename";
            this.dataGridViewTextBoxColumn7.HeaderText = "车主";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // VehicleType
            // 
            this.VehicleType.DataPropertyName = "vehiclekind";
            this.VehicleType.HeaderText = "车辆类型";
            this.VehicleType.Name = "VehicleType";
            this.VehicleType.Width = 200;
            // 
            // panel_ParkManage
            // 
            this.panel_ParkManage.Controls.Add(this.cmb_ParkChannelDirection);
            this.panel_ParkManage.Controls.Add(this.btn_ParkChannel_Del);
            this.panel_ParkManage.Controls.Add(this.label4);
            this.panel_ParkManage.Controls.Add(this.txb_ParkChannelName);
            this.panel_ParkManage.Controls.Add(this.btn_ParkChannel_ADD);
            this.panel_ParkManage.Controls.Add(this.ParkPositionInfoTree);
            this.panel_ParkManage.Location = new System.Drawing.Point(188, 0);
            this.panel_ParkManage.Name = "panel_ParkManage";
            this.panel_ParkManage.Size = new System.Drawing.Size(881, 544);
            this.panel_ParkManage.TabIndex = 3;
            this.panel_ParkManage.Visible = false;
            // 
            // cmb_ParkChannelDirection
            // 
            this.cmb_ParkChannelDirection.FormattingEnabled = true;
            this.cmb_ParkChannelDirection.Items.AddRange(new object[] {
            "入口",
            "出口"});
            this.cmb_ParkChannelDirection.Location = new System.Drawing.Point(720, 74);
            this.cmb_ParkChannelDirection.Name = "cmb_ParkChannelDirection";
            this.cmb_ParkChannelDirection.Size = new System.Drawing.Size(121, 27);
            this.cmb_ParkChannelDirection.TabIndex = 5;
            // 
            // btn_ParkChannel_Del
            // 
            this.btn_ParkChannel_Del.Location = new System.Drawing.Point(250, 29);
            this.btn_ParkChannel_Del.Name = "btn_ParkChannel_Del";
            this.btn_ParkChannel_Del.Size = new System.Drawing.Size(102, 28);
            this.btn_ParkChannel_Del.TabIndex = 4;
            this.btn_ParkChannel_Del.Text = "删除道口";
            this.btn_ParkChannel_Del.UseVisualStyleBackColor = true;
            this.btn_ParkChannel_Del.Click += new System.EventHandler(this.btn_Channel_Del_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(527, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "道口名称";
            // 
            // txb_ParkChannelName
            // 
            this.txb_ParkChannelName.Location = new System.Drawing.Point(629, 33);
            this.txb_ParkChannelName.Name = "txb_ParkChannelName";
            this.txb_ParkChannelName.Size = new System.Drawing.Size(212, 29);
            this.txb_ParkChannelName.TabIndex = 2;
            // 
            // btn_ParkChannel_ADD
            // 
            this.btn_ParkChannel_ADD.Location = new System.Drawing.Point(729, 119);
            this.btn_ParkChannel_ADD.Name = "btn_ParkChannel_ADD";
            this.btn_ParkChannel_ADD.Size = new System.Drawing.Size(112, 39);
            this.btn_ParkChannel_ADD.TabIndex = 1;
            this.btn_ParkChannel_ADD.Text = "增加道口";
            this.btn_ParkChannel_ADD.UseVisualStyleBackColor = true;
            this.btn_ParkChannel_ADD.Click += new System.EventHandler(this.btn_Channel_ADD_Click);
            // 
            // ParkPositionInfoTree
            // 
            this.ParkPositionInfoTree.Location = new System.Drawing.Point(3, 3);
            this.ParkPositionInfoTree.Name = "ParkPositionInfoTree";
            treeNode91.Name = "ChannelNode";
            treeNode91.Text = "道口";
            this.ParkPositionInfoTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode91});
            this.ParkPositionInfoTree.Size = new System.Drawing.Size(235, 535);
            this.ParkPositionInfoTree.TabIndex = 0;
            // 
            // VehicleRecord_Panel
            // 
            this.VehicleRecord_Panel.Controls.Add(this.reporttab);
            this.VehicleRecord_Panel.Location = new System.Drawing.Point(188, 0);
            this.VehicleRecord_Panel.Name = "VehicleRecord_Panel";
            this.VehicleRecord_Panel.Size = new System.Drawing.Size(881, 544);
            this.VehicleRecord_Panel.TabIndex = 18;
            this.VehicleRecord_Panel.Visible = false;
            // 
            // reporttab
            // 
            this.reporttab.Controls.Add(this.tabPage4);
            this.reporttab.Location = new System.Drawing.Point(4, 7);
            this.reporttab.Name = "reporttab";
            this.reporttab.SelectedIndex = 0;
            this.reporttab.Size = new System.Drawing.Size(877, 534);
            this.reporttab.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkBox2);
            this.tabPage4.Controls.Add(this.checkBox1);
            this.tabPage4.Controls.Add(this.btn_ReportSearch);
            this.tabPage4.Controls.Add(this.cmb_TimeType);
            this.tabPage4.Controls.Add(this.cmb_ItemType);
            this.tabPage4.Controls.Add(this.btn_Export);
            this.tabPage4.Controls.Add(this.VehicleReprotGridView);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(869, 501);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "车辆出入信息汇总";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(55, 32);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(123, 23);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "按项目统计";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(356, 33);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 23);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "按时间统计";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_ReportSearch
            // 
            this.btn_ReportSearch.Location = new System.Drawing.Point(692, 30);
            this.btn_ReportSearch.Name = "btn_ReportSearch";
            this.btn_ReportSearch.Size = new System.Drawing.Size(99, 38);
            this.btn_ReportSearch.TabIndex = 6;
            this.btn_ReportSearch.Text = "统计";
            this.btn_ReportSearch.UseVisualStyleBackColor = true;
            this.btn_ReportSearch.Click += new System.EventHandler(this.btn_ReportSearch_Click);
            // 
            // cmb_TimeType
            // 
            this.cmb_TimeType.Enabled = false;
            this.cmb_TimeType.FormattingEnabled = true;
            this.cmb_TimeType.Items.AddRange(new object[] {
            "年",
            "月",
            "日"});
            this.cmb_TimeType.Location = new System.Drawing.Point(483, 30);
            this.cmb_TimeType.Name = "cmb_TimeType";
            this.cmb_TimeType.Size = new System.Drawing.Size(121, 27);
            this.cmb_TimeType.TabIndex = 5;
            // 
            // cmb_ItemType
            // 
            this.cmb_ItemType.FormattingEnabled = true;
            this.cmb_ItemType.Items.AddRange(new object[] {
            "车辆",
            "位置"});
            this.cmb_ItemType.Location = new System.Drawing.Point(178, 30);
            this.cmb_ItemType.Name = "cmb_ItemType";
            this.cmb_ItemType.Size = new System.Drawing.Size(121, 27);
            this.cmb_ItemType.TabIndex = 2;
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(667, 457);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(175, 36);
            this.btn_Export.TabIndex = 1;
            this.btn_Export.Text = "导出";
            this.btn_Export.UseVisualStyleBackColor = true;
            // 
            // VehicleReprotGridView
            // 
            this.VehicleReprotGridView.AllowUserToAddRows = false;
            this.VehicleReprotGridView.AllowUserToDeleteRows = false;
            this.VehicleReprotGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehicleReprotGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReportItem,
            this.InCount,
            this.OutCount});
            this.VehicleReprotGridView.Location = new System.Drawing.Point(22, 86);
            this.VehicleReprotGridView.Name = "VehicleReprotGridView";
            this.VehicleReprotGridView.RowTemplate.Height = 23;
            this.VehicleReprotGridView.Size = new System.Drawing.Size(823, 355);
            this.VehicleReprotGridView.TabIndex = 0;
            // 
            // ReportItem
            // 
            this.ReportItem.DataPropertyName = "reportitem";
            this.ReportItem.HeaderText = "统计项";
            this.ReportItem.Name = "ReportItem";
            this.ReportItem.Width = 300;
            // 
            // InCount
            // 
            this.InCount.DataPropertyName = "incount";
            this.InCount.HeaderText = "进门次数";
            this.InCount.Name = "InCount";
            this.InCount.Width = 300;
            // 
            // OutCount
            // 
            this.OutCount.DataPropertyName = "outcount";
            this.OutCount.HeaderText = "出门次数";
            this.OutCount.Name = "OutCount";
            this.OutCount.Width = 200;
            // 
            // Park_ControlItem_tree
            // 
            this.Park_ControlItem_tree.Location = new System.Drawing.Point(0, 0);
            this.Park_ControlItem_tree.Name = "Park_ControlItem_tree";
            treeNode92.Name = "Node0";
            treeNode92.Text = "停车场管理";
            treeNode93.Name = "Node1";
            treeNode93.Text = "车辆管理";
            treeNode94.Name = "Node2";
            treeNode94.Text = "统计汇总";
            this.Park_ControlItem_tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode92,
            treeNode93,
            treeNode94});
            this.Park_ControlItem_tree.Size = new System.Drawing.Size(182, 547);
            this.Park_ControlItem_tree.TabIndex = 0;
            this.Park_ControlItem_tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Park_ControlItem_tree_AfterSelect);
            // 
            // DeviceManagePage
            // 
            this.DeviceManagePage.Controls.Add(this.tabControl2);
            this.DeviceManagePage.Controls.Add(this.Device_ControlItem_View);
            this.DeviceManagePage.Location = new System.Drawing.Point(4, 29);
            this.DeviceManagePage.Name = "DeviceManagePage";
            this.DeviceManagePage.Size = new System.Drawing.Size(1072, 547);
            this.DeviceManagePage.TabIndex = 2;
            this.DeviceManagePage.Text = "门禁设备";
            this.DeviceManagePage.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Location = new System.Drawing.Point(158, 3);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(919, 541);
            this.tabControl2.TabIndex = 6;
            this.tabControl2.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DeviceOption_panel);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DeviceOption_panel
            // 
            this.DeviceOption_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeviceOption_panel.Controls.Add(this.label20);
            this.DeviceOption_panel.Controls.Add(this.label5);
            this.DeviceOption_panel.Controls.Add(this.cmb_DevicePosition);
            this.DeviceOption_panel.Controls.Add(this.btn_SearchDevice);
            this.DeviceOption_panel.Controls.Add(this.txb_SearchDeviceKey);
            this.DeviceOption_panel.Controls.Add(this.btn_Device_Authrize_Edit);
            this.DeviceOption_panel.Controls.Add(this.btn_Device_Delete);
            this.DeviceOption_panel.Controls.Add(this.btn_Device_Edit);
            this.DeviceOption_panel.Controls.Add(this.btn_Device_Add);
            this.DeviceOption_panel.Controls.Add(this.DeviceInfoGrid);
            this.DeviceOption_panel.Location = new System.Drawing.Point(0, 0);
            this.DeviceOption_panel.Name = "DeviceOption_panel";
            this.DeviceOption_panel.Size = new System.Drawing.Size(910, 533);
            this.DeviceOption_panel.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(326, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 19);
            this.label20.TabIndex = 27;
            this.label20.Text = "关键字";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "所在位置";
            // 
            // cmb_DevicePosition
            // 
            this.cmb_DevicePosition.FormattingEnabled = true;
            this.cmb_DevicePosition.Location = new System.Drawing.Point(143, 25);
            this.cmb_DevicePosition.Name = "cmb_DevicePosition";
            this.cmb_DevicePosition.Size = new System.Drawing.Size(121, 27);
            this.cmb_DevicePosition.TabIndex = 25;
            // 
            // btn_SearchDevice
            // 
            this.btn_SearchDevice.Location = new System.Drawing.Point(582, 20);
            this.btn_SearchDevice.Name = "btn_SearchDevice";
            this.btn_SearchDevice.Size = new System.Drawing.Size(100, 35);
            this.btn_SearchDevice.TabIndex = 24;
            this.btn_SearchDevice.Text = "查询";
            this.btn_SearchDevice.UseVisualStyleBackColor = true;
            this.btn_SearchDevice.Click += new System.EventHandler(this.btn_SearchDevice_Click);
            // 
            // txb_SearchDeviceKey
            // 
            this.txb_SearchDeviceKey.Location = new System.Drawing.Point(411, 24);
            this.txb_SearchDeviceKey.Name = "txb_SearchDeviceKey";
            this.txb_SearchDeviceKey.Size = new System.Drawing.Size(136, 29);
            this.txb_SearchDeviceKey.TabIndex = 23;
            // 
            // btn_Device_Authrize_Edit
            // 
            this.btn_Device_Authrize_Edit.Location = new System.Drawing.Point(246, 481);
            this.btn_Device_Authrize_Edit.Name = "btn_Device_Authrize_Edit";
            this.btn_Device_Authrize_Edit.Size = new System.Drawing.Size(100, 35);
            this.btn_Device_Authrize_Edit.TabIndex = 22;
            this.btn_Device_Authrize_Edit.Text = "编辑权限";
            this.btn_Device_Authrize_Edit.UseVisualStyleBackColor = true;
            this.btn_Device_Authrize_Edit.Click += new System.EventHandler(this.btn_Device_Authrize_Edit_Click);
            // 
            // btn_Device_Delete
            // 
            this.btn_Device_Delete.Location = new System.Drawing.Point(703, 479);
            this.btn_Device_Delete.Name = "btn_Device_Delete";
            this.btn_Device_Delete.Size = new System.Drawing.Size(100, 35);
            this.btn_Device_Delete.TabIndex = 21;
            this.btn_Device_Delete.Text = "删除设备";
            this.btn_Device_Delete.UseVisualStyleBackColor = true;
            this.btn_Device_Delete.Click += new System.EventHandler(this.btn_Device_Delete_Click);
            // 
            // btn_Device_Edit
            // 
            this.btn_Device_Edit.Location = new System.Drawing.Point(481, 481);
            this.btn_Device_Edit.Name = "btn_Device_Edit";
            this.btn_Device_Edit.Size = new System.Drawing.Size(100, 35);
            this.btn_Device_Edit.TabIndex = 20;
            this.btn_Device_Edit.Text = "编辑设备";
            this.btn_Device_Edit.UseVisualStyleBackColor = true;
            this.btn_Device_Edit.Click += new System.EventHandler(this.btn_Device_Edit_Click);
            // 
            // btn_Device_Add
            // 
            this.btn_Device_Add.Location = new System.Drawing.Point(45, 481);
            this.btn_Device_Add.Name = "btn_Device_Add";
            this.btn_Device_Add.Size = new System.Drawing.Size(100, 35);
            this.btn_Device_Add.TabIndex = 19;
            this.btn_Device_Add.Text = "添加设备";
            this.btn_Device_Add.UseVisualStyleBackColor = true;
            this.btn_Device_Add.Click += new System.EventHandler(this.btn_Device_Add_Click);
            // 
            // DeviceInfoGrid
            // 
            this.DeviceInfoGrid.AllowUserToAddRows = false;
            this.DeviceInfoGrid.AllowUserToDeleteRows = false;
            this.DeviceInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeviceInfoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.DeviceName,
            this.DeviceType,
            this.DeviceCode,
            this.DevicePosition,
            this.DeviceNetAddress});
            this.DeviceInfoGrid.Location = new System.Drawing.Point(17, 81);
            this.DeviceInfoGrid.Name = "DeviceInfoGrid";
            this.DeviceInfoGrid.RowTemplate.Height = 23;
            this.DeviceInfoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeviceInfoGrid.Size = new System.Drawing.Size(834, 375);
            this.DeviceInfoGrid.TabIndex = 18;
            this.DeviceInfoGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeviceInfoGrid_CellContentClick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn8.HeaderText = "Id";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // DeviceName
            // 
            this.DeviceName.DataPropertyName = "devicename";
            this.DeviceName.HeaderText = "设备名称";
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Width = 120;
            // 
            // DeviceType
            // 
            this.DeviceType.DataPropertyName = "devicetype";
            this.DeviceType.HeaderText = "设备类型";
            this.DeviceType.Name = "DeviceType";
            this.DeviceType.Width = 200;
            // 
            // DeviceCode
            // 
            this.DeviceCode.DataPropertyName = "code";
            this.DeviceCode.HeaderText = "设备序列号";
            this.DeviceCode.Name = "DeviceCode";
            this.DeviceCode.Width = 150;
            // 
            // DevicePosition
            // 
            this.DevicePosition.DataPropertyName = "position";
            this.DevicePosition.HeaderText = "所在位置";
            this.DevicePosition.Name = "DevicePosition";
            this.DevicePosition.Width = 120;
            // 
            // DeviceNetAddress
            // 
            this.DeviceNetAddress.DataPropertyName = "netaddress";
            this.DeviceNetAddress.HeaderText = "通信地址";
            this.DeviceNetAddress.Name = "DeviceNetAddress";
            this.DeviceNetAddress.Width = 200;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.InOutRecordTab);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // InOutRecordTab
            // 
            this.InOutRecordTab.Controls.Add(this.PassengerRecordPage);
            this.InOutRecordTab.Controls.Add(this.VehicleRecordPage);
            this.InOutRecordTab.Location = new System.Drawing.Point(6, 6);
            this.InOutRecordTab.Name = "InOutRecordTab";
            this.InOutRecordTab.SelectedIndex = 0;
            this.InOutRecordTab.Size = new System.Drawing.Size(904, 527);
            this.InOutRecordTab.TabIndex = 0;
            // 
            // PassengerRecordPage
            // 
            this.PassengerRecordPage.Controls.Add(this.btn_PassRecordSearch);
            this.PassengerRecordPage.Controls.Add(this.label10);
            this.PassengerRecordPage.Controls.Add(this.label9);
            this.PassengerRecordPage.Controls.Add(this.PassRecordEndTime);
            this.PassengerRecordPage.Controls.Add(this.PassRecordStartTime);
            this.PassengerRecordPage.Controls.Add(this.label8);
            this.PassengerRecordPage.Controls.Add(this.label7);
            this.PassengerRecordPage.Controls.Add(this.cmb_PassengerPosition);
            this.PassengerRecordPage.Controls.Add(this.label3);
            this.PassengerRecordPage.Controls.Add(this.txb_SearchPassKey);
            this.PassengerRecordPage.Controls.Add(this.PassengerRecordGrid);
            this.PassengerRecordPage.Location = new System.Drawing.Point(4, 29);
            this.PassengerRecordPage.Name = "PassengerRecordPage";
            this.PassengerRecordPage.Padding = new System.Windows.Forms.Padding(3);
            this.PassengerRecordPage.Size = new System.Drawing.Size(896, 494);
            this.PassengerRecordPage.TabIndex = 0;
            this.PassengerRecordPage.Text = "人员出入记录";
            this.PassengerRecordPage.UseVisualStyleBackColor = true;
            // 
            // btn_PassRecordSearch
            // 
            this.btn_PassRecordSearch.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_PassRecordSearch.Location = new System.Drawing.Point(660, 50);
            this.btn_PassRecordSearch.Name = "btn_PassRecordSearch";
            this.btn_PassRecordSearch.Size = new System.Drawing.Size(100, 30);
            this.btn_PassRecordSearch.TabIndex = 10;
            this.btn_PassRecordSearch.Text = "检索";
            this.btn_PassRecordSearch.UseVisualStyleBackColor = true;
            this.btn_PassRecordSearch.Click += new System.EventHandler(this.btn_RecordSearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(322, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 14);
            this.label10.TabIndex = 9;
            this.label10.Text = "到";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(322, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "从";
            // 
            // PassRecordEndTime
            // 
            this.PassRecordEndTime.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PassRecordEndTime.Location = new System.Drawing.Point(347, 50);
            this.PassRecordEndTime.Name = "PassRecordEndTime";
            this.PassRecordEndTime.Size = new System.Drawing.Size(186, 23);
            this.PassRecordEndTime.TabIndex = 7;
            // 
            // PassRecordStartTime
            // 
            this.PassRecordStartTime.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PassRecordStartTime.Location = new System.Drawing.Point(347, 19);
            this.PassRecordStartTime.Name = "PassRecordStartTime";
            this.PassRecordStartTime.Size = new System.Drawing.Size(186, 23);
            this.PassRecordStartTime.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(232, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 14);
            this.label8.TabIndex = 5;
            this.label8.Text = "出入时间";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(593, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = "人员名称";
            // 
            // cmb_PassengerPosition
            // 
            this.cmb_PassengerPosition.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_PassengerPosition.FormattingEnabled = true;
            this.cmb_PassengerPosition.Location = new System.Drawing.Point(90, 32);
            this.cmb_PassengerPosition.Name = "cmb_PassengerPosition";
            this.cmb_PassengerPosition.Size = new System.Drawing.Size(121, 20);
            this.cmb_PassengerPosition.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(21, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "出入位置";
            // 
            // txb_SearchPassKey
            // 
            this.txb_SearchPassKey.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_SearchPassKey.Location = new System.Drawing.Point(660, 19);
            this.txb_SearchPassKey.Name = "txb_SearchPassKey";
            this.txb_SearchPassKey.Size = new System.Drawing.Size(100, 23);
            this.txb_SearchPassKey.TabIndex = 1;
            // 
            // PassengerRecordGrid
            // 
            this.PassengerRecordGrid.AllowUserToAddRows = false;
            this.PassengerRecordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PassengerRecordGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PassengerName,
            this.PassPosition,
            this.PassTime,
            this.PassDescription});
            this.PassengerRecordGrid.Location = new System.Drawing.Point(9, 97);
            this.PassengerRecordGrid.Name = "PassengerRecordGrid";
            this.PassengerRecordGrid.RowTemplate.Height = 23;
            this.PassengerRecordGrid.Size = new System.Drawing.Size(881, 377);
            this.PassengerRecordGrid.TabIndex = 0;
            // 
            // PassengerName
            // 
            this.PassengerName.DataPropertyName = "logname";
            this.PassengerName.HeaderText = "人员名称";
            this.PassengerName.Name = "PassengerName";
            this.PassengerName.Width = 120;
            // 
            // PassPosition
            // 
            this.PassPosition.DataPropertyName = "positionname";
            this.PassPosition.HeaderText = "出入位置";
            this.PassPosition.Name = "PassPosition";
            this.PassPosition.Width = 120;
            // 
            // PassTime
            // 
            this.PassTime.DataPropertyName = "logtime";
            this.PassTime.HeaderText = "出入时间";
            this.PassTime.Name = "PassTime";
            this.PassTime.Width = 150;
            // 
            // PassDescription
            // 
            this.PassDescription.DataPropertyName = "logdesc";
            this.PassDescription.HeaderText = "记录描述";
            this.PassDescription.Name = "PassDescription";
            this.PassDescription.Width = 400;
            // 
            // VehicleRecordPage
            // 
            this.VehicleRecordPage.Controls.Add(this.VehicleRecordGrid);
            this.VehicleRecordPage.Controls.Add(this.btn_VehiRecordSearch);
            this.VehicleRecordPage.Controls.Add(this.label11);
            this.VehicleRecordPage.Controls.Add(this.label12);
            this.VehicleRecordPage.Controls.Add(this.VehicleRecordEndTime);
            this.VehicleRecordPage.Controls.Add(this.VehicleRecordStartTime);
            this.VehicleRecordPage.Controls.Add(this.label13);
            this.VehicleRecordPage.Controls.Add(this.label14);
            this.VehicleRecordPage.Controls.Add(this.cmb_VehiclePosition);
            this.VehicleRecordPage.Controls.Add(this.label15);
            this.VehicleRecordPage.Controls.Add(this.txb_SearchVechicleKey);
            this.VehicleRecordPage.Location = new System.Drawing.Point(4, 29);
            this.VehicleRecordPage.Name = "VehicleRecordPage";
            this.VehicleRecordPage.Padding = new System.Windows.Forms.Padding(3);
            this.VehicleRecordPage.Size = new System.Drawing.Size(896, 494);
            this.VehicleRecordPage.TabIndex = 1;
            this.VehicleRecordPage.Text = "车辆出入记录";
            this.VehicleRecordPage.UseVisualStyleBackColor = true;
            // 
            // VehicleRecordGrid
            // 
            this.VehicleRecordGrid.AllowUserToAddRows = false;
            this.VehicleRecordGrid.AllowUserToDeleteRows = false;
            this.VehicleRecordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VehicleRecordGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.VehicleOwner,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.VehicleRecordGrid.Location = new System.Drawing.Point(5, 97);
            this.VehicleRecordGrid.Name = "VehicleRecordGrid";
            this.VehicleRecordGrid.RowTemplate.Height = 23;
            this.VehicleRecordGrid.Size = new System.Drawing.Size(855, 399);
            this.VehicleRecordGrid.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "logsubject";
            this.dataGridViewTextBoxColumn1.HeaderText = "车辆名称";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // VehicleOwner
            // 
            this.VehicleOwner.DataPropertyName = "vehicleowner";
            this.VehicleOwner.HeaderText = "车主名称";
            this.VehicleOwner.Name = "VehicleOwner";
            this.VehicleOwner.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "positionname";
            this.dataGridViewTextBoxColumn2.HeaderText = "出入位置";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "logtime";
            this.dataGridViewTextBoxColumn3.HeaderText = "出入时间";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "logdesc";
            this.dataGridViewTextBoxColumn4.HeaderText = "记录描述";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 300;
            // 
            // btn_VehiRecordSearch
            // 
            this.btn_VehiRecordSearch.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_VehiRecordSearch.Location = new System.Drawing.Point(654, 39);
            this.btn_VehiRecordSearch.Name = "btn_VehiRecordSearch";
            this.btn_VehiRecordSearch.Size = new System.Drawing.Size(100, 30);
            this.btn_VehiRecordSearch.TabIndex = 20;
            this.btn_VehiRecordSearch.Text = "检索";
            this.btn_VehiRecordSearch.UseVisualStyleBackColor = true;
            this.btn_VehiRecordSearch.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(316, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 14);
            this.label11.TabIndex = 19;
            this.label11.Text = "到";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(316, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 14);
            this.label12.TabIndex = 18;
            this.label12.Text = "从";
            // 
            // VehicleRecordEndTime
            // 
            this.VehicleRecordEndTime.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VehicleRecordEndTime.Location = new System.Drawing.Point(341, 39);
            this.VehicleRecordEndTime.Name = "VehicleRecordEndTime";
            this.VehicleRecordEndTime.Size = new System.Drawing.Size(186, 23);
            this.VehicleRecordEndTime.TabIndex = 17;
            // 
            // VehicleRecordStartTime
            // 
            this.VehicleRecordStartTime.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.VehicleRecordStartTime.Location = new System.Drawing.Point(341, 8);
            this.VehicleRecordStartTime.Name = "VehicleRecordStartTime";
            this.VehicleRecordStartTime.Size = new System.Drawing.Size(186, 23);
            this.VehicleRecordStartTime.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(239, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 14);
            this.label13.TabIndex = 15;
            this.label13.Text = "出入时间";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(587, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 14);
            this.label14.TabIndex = 14;
            this.label14.Text = "车牌号";
            // 
            // cmb_VehiclePosition
            // 
            this.cmb_VehiclePosition.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmb_VehiclePosition.FormattingEnabled = true;
            this.cmb_VehiclePosition.Location = new System.Drawing.Point(84, 21);
            this.cmb_VehiclePosition.Name = "cmb_VehiclePosition";
            this.cmb_VehiclePosition.Size = new System.Drawing.Size(121, 20);
            this.cmb_VehiclePosition.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(15, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 14);
            this.label15.TabIndex = 12;
            this.label15.Text = "出入位置";
            // 
            // txb_SearchVechicleKey
            // 
            this.txb_SearchVechicleKey.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txb_SearchVechicleKey.Location = new System.Drawing.Point(654, 8);
            this.txb_SearchVechicleKey.Name = "txb_SearchVechicleKey";
            this.txb_SearchVechicleKey.Size = new System.Drawing.Size(100, 23);
            this.txb_SearchVechicleKey.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel_DoorManage);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(886, 533);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel_DoorManage
            // 
            this.panel_DoorManage.Controls.Add(this.btn_DoorChannel_Del);
            this.panel_DoorManage.Controls.Add(this.label19);
            this.panel_DoorManage.Controls.Add(this.txb_DoorChannelName);
            this.panel_DoorManage.Controls.Add(this.btn_DoorChannel_ADD);
            this.panel_DoorManage.Controls.Add(this.DoorPositionInfoTree);
            this.panel_DoorManage.Location = new System.Drawing.Point(6, 5);
            this.panel_DoorManage.Name = "panel_DoorManage";
            this.panel_DoorManage.Size = new System.Drawing.Size(902, 528);
            this.panel_DoorManage.TabIndex = 4;
            // 
            // btn_DoorChannel_Del
            // 
            this.btn_DoorChannel_Del.Location = new System.Drawing.Point(270, 8);
            this.btn_DoorChannel_Del.Name = "btn_DoorChannel_Del";
            this.btn_DoorChannel_Del.Size = new System.Drawing.Size(115, 39);
            this.btn_DoorChannel_Del.TabIndex = 4;
            this.btn_DoorChannel_Del.Text = "删除道口";
            this.btn_DoorChannel_Del.UseVisualStyleBackColor = true;
            this.btn_DoorChannel_Del.Click += new System.EventHandler(this.btn_DoorChannel_Del_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(527, 87);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 19);
            this.label19.TabIndex = 3;
            this.label19.Text = "道口名称";
            // 
            // txb_DoorChannelName
            // 
            this.txb_DoorChannelName.Location = new System.Drawing.Point(629, 84);
            this.txb_DoorChannelName.Name = "txb_DoorChannelName";
            this.txb_DoorChannelName.Size = new System.Drawing.Size(212, 29);
            this.txb_DoorChannelName.TabIndex = 2;
            // 
            // btn_DoorChannel_ADD
            // 
            this.btn_DoorChannel_ADD.Location = new System.Drawing.Point(729, 142);
            this.btn_DoorChannel_ADD.Name = "btn_DoorChannel_ADD";
            this.btn_DoorChannel_ADD.Size = new System.Drawing.Size(112, 39);
            this.btn_DoorChannel_ADD.TabIndex = 1;
            this.btn_DoorChannel_ADD.Text = "增加道口";
            this.btn_DoorChannel_ADD.UseVisualStyleBackColor = true;
            this.btn_DoorChannel_ADD.Click += new System.EventHandler(this.btn_DoorChannel_ADD_Click);
            // 
            // DoorPositionInfoTree
            // 
            this.DoorPositionInfoTree.Location = new System.Drawing.Point(5, 3);
            this.DoorPositionInfoTree.Name = "DoorPositionInfoTree";
            treeNode95.Name = "Node2";
            treeNode95.Text = "停车场A口出口";
            treeNode96.Name = "ChannelNode";
            treeNode96.Text = "出入口";
            treeNode97.Name = "rootName";
            treeNode97.Text = "小区";
            this.DoorPositionInfoTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode97});
            this.DoorPositionInfoTree.Size = new System.Drawing.Size(238, 509);
            this.DoorPositionInfoTree.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.PassengerRecord_panel);
            this.tabPage6.Location = new System.Drawing.Point(4, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(886, 533);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            this.tabPage6.Click += new System.EventHandler(this.tabPage6_Click);
            // 
            // PassengerRecord_panel
            // 
            this.PassengerRecord_panel.Controls.Add(this.PassRecord_tab);
            this.PassengerRecord_panel.Location = new System.Drawing.Point(-7, -6);
            this.PassengerRecord_panel.Name = "PassengerRecord_panel";
            this.PassengerRecord_panel.Size = new System.Drawing.Size(881, 544);
            this.PassengerRecord_panel.TabIndex = 19;
            // 
            // PassRecord_tab
            // 
            this.PassRecord_tab.Controls.Add(this.tabPage7);
            this.PassRecord_tab.Location = new System.Drawing.Point(4, 7);
            this.PassRecord_tab.Name = "PassRecord_tab";
            this.PassRecord_tab.SelectedIndex = 0;
            this.PassRecord_tab.Size = new System.Drawing.Size(867, 534);
            this.PassRecord_tab.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.checkBox3);
            this.tabPage7.Controls.Add(this.checkBox4);
            this.tabPage7.Controls.Add(this.btn_PassengerReportSearch);
            this.tabPage7.Controls.Add(this.cmb_TimeType_Passenger);
            this.tabPage7.Controls.Add(this.cmb_ItemType_Passenger);
            this.tabPage7.Controls.Add(this.btn_PassengerReportExport);
            this.tabPage7.Controls.Add(this.PassengerReprotGridView);
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(859, 501);
            this.tabPage7.TabIndex = 0;
            this.tabPage7.Text = "人员出入信息汇总";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(55, 32);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(123, 23);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "按项目统计";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(356, 33);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(123, 23);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "按时间统计";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // btn_PassengerReportSearch
            // 
            this.btn_PassengerReportSearch.Location = new System.Drawing.Point(692, 30);
            this.btn_PassengerReportSearch.Name = "btn_PassengerReportSearch";
            this.btn_PassengerReportSearch.Size = new System.Drawing.Size(99, 38);
            this.btn_PassengerReportSearch.TabIndex = 6;
            this.btn_PassengerReportSearch.Text = "统计";
            this.btn_PassengerReportSearch.UseVisualStyleBackColor = true;
            this.btn_PassengerReportSearch.Click += new System.EventHandler(this.btn_PassengerReportSearch_Click);
            // 
            // cmb_TimeType_Passenger
            // 
            this.cmb_TimeType_Passenger.Enabled = false;
            this.cmb_TimeType_Passenger.FormattingEnabled = true;
            this.cmb_TimeType_Passenger.Items.AddRange(new object[] {
            "年",
            "月",
            "日"});
            this.cmb_TimeType_Passenger.Location = new System.Drawing.Point(483, 30);
            this.cmb_TimeType_Passenger.Name = "cmb_TimeType_Passenger";
            this.cmb_TimeType_Passenger.Size = new System.Drawing.Size(121, 27);
            this.cmb_TimeType_Passenger.TabIndex = 5;
            // 
            // cmb_ItemType_Passenger
            // 
            this.cmb_ItemType_Passenger.FormattingEnabled = true;
            this.cmb_ItemType_Passenger.Items.AddRange(new object[] {
            "人员",
            "位置"});
            this.cmb_ItemType_Passenger.Location = new System.Drawing.Point(178, 30);
            this.cmb_ItemType_Passenger.Name = "cmb_ItemType_Passenger";
            this.cmb_ItemType_Passenger.Size = new System.Drawing.Size(121, 27);
            this.cmb_ItemType_Passenger.TabIndex = 2;
            // 
            // btn_PassengerReportExport
            // 
            this.btn_PassengerReportExport.Location = new System.Drawing.Point(721, 459);
            this.btn_PassengerReportExport.Name = "btn_PassengerReportExport";
            this.btn_PassengerReportExport.Size = new System.Drawing.Size(124, 36);
            this.btn_PassengerReportExport.TabIndex = 1;
            this.btn_PassengerReportExport.Text = "导出";
            this.btn_PassengerReportExport.UseVisualStyleBackColor = true;
            // 
            // PassengerReprotGridView
            // 
            this.PassengerReprotGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PassengerReprotGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.PassengerReprotGridView.Location = new System.Drawing.Point(22, 86);
            this.PassengerReprotGridView.Name = "PassengerReprotGridView";
            this.PassengerReprotGridView.RowTemplate.Height = 23;
            this.PassengerReprotGridView.Size = new System.Drawing.Size(823, 355);
            this.PassengerReprotGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "reportitem";
            this.dataGridViewTextBoxColumn13.HeaderText = "统计项";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 200;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "incount";
            this.dataGridViewTextBoxColumn15.HeaderText = "进门次数";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 120;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "outcount";
            this.dataGridViewTextBoxColumn16.HeaderText = "出门次数";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 120;
            // 
            // Device_ControlItem_View
            // 
            this.Device_ControlItem_View.Location = new System.Drawing.Point(3, 3);
            this.Device_ControlItem_View.Name = "Device_ControlItem_View";
            treeNode98.Name = "Node0";
            treeNode98.Text = "硬件配置";
            treeNode99.Name = "Node3";
            treeNode99.Text = "统计汇总";
            treeNode100.Name = "Node1";
            treeNode100.Text = "出入记录";
            treeNode101.Name = "Node0";
            treeNode101.Text = "出入口管理";
            this.Device_ControlItem_View.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode98,
            treeNode99,
            treeNode100,
            treeNode101});
            this.Device_ControlItem_View.Size = new System.Drawing.Size(153, 541);
            this.Device_ControlItem_View.TabIndex = 0;
            this.Device_ControlItem_View.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Device_ControlItem_View_AfterSelect);
            // 
            // SystemOptionPage
            // 
            this.SystemOptionPage.Controls.Add(this.UserManagePanel);
            this.SystemOptionPage.Controls.Add(this.System_ControlItem_tree);
            this.SystemOptionPage.Location = new System.Drawing.Point(4, 29);
            this.SystemOptionPage.Name = "SystemOptionPage";
            this.SystemOptionPage.Size = new System.Drawing.Size(1072, 547);
            this.SystemOptionPage.TabIndex = 3;
            this.SystemOptionPage.Text = "系统管理";
            this.SystemOptionPage.UseVisualStyleBackColor = true;
            // 
            // UserManagePanel
            // 
            this.UserManagePanel.Controls.Add(this.btn_SelectUser);
            this.UserManagePanel.Controls.Add(this.label21);
            this.UserManagePanel.Controls.Add(this.txb_SelectUserKey);
            this.UserManagePanel.Controls.Add(this.btn_EditPwd);
            this.UserManagePanel.Controls.Add(this.btn_DeleteUser);
            this.UserManagePanel.Controls.Add(this.btn_EditUser);
            this.UserManagePanel.Controls.Add(this.btn_AddUser);
            this.UserManagePanel.Controls.Add(this.UserInfoListView);
            this.UserManagePanel.Location = new System.Drawing.Point(194, 4);
            this.UserManagePanel.Name = "UserManagePanel";
            this.UserManagePanel.Size = new System.Drawing.Size(875, 540);
            this.UserManagePanel.TabIndex = 1;
            this.UserManagePanel.Visible = false;
            // 
            // btn_SelectUser
            // 
            this.btn_SelectUser.Location = new System.Drawing.Point(581, 19);
            this.btn_SelectUser.Name = "btn_SelectUser";
            this.btn_SelectUser.Size = new System.Drawing.Size(100, 35);
            this.btn_SelectUser.TabIndex = 25;
            this.btn_SelectUser.Text = "查询";
            this.btn_SelectUser.UseVisualStyleBackColor = true;
            this.btn_SelectUser.Click += new System.EventHandler(this.btn_SelectUser_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(328, 30);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 19);
            this.label21.TabIndex = 24;
            this.label21.Text = "关键字:";
            // 
            // txb_SelectUserKey
            // 
            this.txb_SelectUserKey.Location = new System.Drawing.Point(410, 24);
            this.txb_SelectUserKey.Name = "txb_SelectUserKey";
            this.txb_SelectUserKey.Size = new System.Drawing.Size(136, 29);
            this.txb_SelectUserKey.TabIndex = 23;
            // 
            // btn_EditPwd
            // 
            this.btn_EditPwd.Location = new System.Drawing.Point(726, 490);
            this.btn_EditPwd.Name = "btn_EditPwd";
            this.btn_EditPwd.Size = new System.Drawing.Size(100, 35);
            this.btn_EditPwd.TabIndex = 22;
            this.btn_EditPwd.Text = "修改密码";
            this.btn_EditPwd.UseVisualStyleBackColor = true;
            this.btn_EditPwd.Click += new System.EventHandler(this.btn_EditPwd_Click);
            // 
            // btn_DeleteUser
            // 
            this.btn_DeleteUser.Location = new System.Drawing.Point(496, 490);
            this.btn_DeleteUser.Name = "btn_DeleteUser";
            this.btn_DeleteUser.Size = new System.Drawing.Size(100, 35);
            this.btn_DeleteUser.TabIndex = 21;
            this.btn_DeleteUser.Text = "删除用户";
            this.btn_DeleteUser.UseVisualStyleBackColor = true;
            this.btn_DeleteUser.Click += new System.EventHandler(this.btn_DeleteUser_Click);
            // 
            // btn_EditUser
            // 
            this.btn_EditUser.Location = new System.Drawing.Point(265, 490);
            this.btn_EditUser.Name = "btn_EditUser";
            this.btn_EditUser.Size = new System.Drawing.Size(100, 35);
            this.btn_EditUser.TabIndex = 20;
            this.btn_EditUser.Text = "编辑用户";
            this.btn_EditUser.UseVisualStyleBackColor = true;
            this.btn_EditUser.Click += new System.EventHandler(this.btn_EditUser_Click);
            // 
            // btn_AddUser
            // 
            this.btn_AddUser.Location = new System.Drawing.Point(32, 490);
            this.btn_AddUser.Name = "btn_AddUser";
            this.btn_AddUser.Size = new System.Drawing.Size(100, 35);
            this.btn_AddUser.TabIndex = 19;
            this.btn_AddUser.Text = "添加用户";
            this.btn_AddUser.UseVisualStyleBackColor = true;
            this.btn_AddUser.Click += new System.EventHandler(this.btn_AddUser_Click);
            // 
            // UserInfoListView
            // 
            this.UserInfoListView.AllowUserToAddRows = false;
            this.UserInfoListView.AllowUserToDeleteRows = false;
            this.UserInfoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserInfoListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.UserType,
            this.dataGridViewTextBoxColumn12});
            this.UserInfoListView.Location = new System.Drawing.Point(19, 72);
            this.UserInfoListView.Name = "UserInfoListView";
            this.UserInfoListView.RowTemplate.Height = 23;
            this.UserInfoListView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserInfoListView.Size = new System.Drawing.Size(834, 398);
            this.UserInfoListView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn10.HeaderText = "Id";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn11.HeaderText = "用户名";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // UserType
            // 
            this.UserType.DataPropertyName = "usertypename";
            this.UserType.HeaderText = "用户类型";
            this.UserType.Name = "UserType";
            this.UserType.Width = 200;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "userstatus";
            this.dataGridViewTextBoxColumn12.HeaderText = "用户状态";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 400;
            // 
            // System_ControlItem_tree
            // 
            this.System_ControlItem_tree.Location = new System.Drawing.Point(5, 3);
            this.System_ControlItem_tree.Name = "System_ControlItem_tree";
            treeNode102.Name = "UserManage";
            treeNode102.Text = "系统用户管理";
            this.System_ControlItem_tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode102});
            this.System_ControlItem_tree.Size = new System.Drawing.Size(182, 541);
            this.System_ControlItem_tree.TabIndex = 0;
            this.System_ControlItem_tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.System_ControlItem_tree_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "当前用户:";
            // 
            // lab_PresentUser
            // 
            this.lab_PresentUser.AutoSize = true;
            this.lab_PresentUser.Location = new System.Drawing.Point(78, 595);
            this.lab_PresentUser.Name = "lab_PresentUser";
            this.lab_PresentUser.Size = new System.Drawing.Size(35, 12);
            this.lab_PresentUser.TabIndex = 2;
            this.lab_PresentUser.Text = "admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "登陆时间：";
            // 
            // lab_Time
            // 
            this.lab_Time.AutoSize = true;
            this.lab_Time.Location = new System.Drawing.Point(205, 595);
            this.lab_Time.Name = "lab_Time";
            this.lab_Time.Size = new System.Drawing.Size(53, 12);
            this.lab_Time.TabIndex = 4;
            this.lab_Time.Text = "17:00:00";
            // 
            // SmartMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 619);
            this.Controls.Add(this.lab_Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_PresentUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SmartMainForm";
            this.Load += new System.EventHandler(this.SmartMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.CustManagePage.ResumeLayout(false);
            this.CustomerManagePanel.ResumeLayout(false);
            this.CustomerManagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerInfoListView)).EndInit();
            this.GroupManagePanel.ResumeLayout(false);
            this.GroupManagePanel.PerformLayout();
            this.ParkManagePage.ResumeLayout(false);
            this.CarAuthrizeInfoPanel.ResumeLayout(false);
            this.CarAuthrizeInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleInfoGrid)).EndInit();
            this.panel_ParkManage.ResumeLayout(false);
            this.panel_ParkManage.PerformLayout();
            this.VehicleRecord_Panel.ResumeLayout(false);
            this.reporttab.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleReprotGridView)).EndInit();
            this.DeviceManagePage.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.DeviceOption_panel.ResumeLayout(false);
            this.DeviceOption_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeviceInfoGrid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.InOutRecordTab.ResumeLayout(false);
            this.PassengerRecordPage.ResumeLayout(false);
            this.PassengerRecordPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassengerRecordGrid)).EndInit();
            this.VehicleRecordPage.ResumeLayout(false);
            this.VehicleRecordPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VehicleRecordGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel_DoorManage.ResumeLayout(false);
            this.panel_DoorManage.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.PassengerRecord_panel.ResumeLayout(false);
            this.PassRecord_tab.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassengerReprotGridView)).EndInit();
            this.SystemOptionPage.ResumeLayout(false);
            this.UserManagePanel.ResumeLayout(false);
            this.UserManagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfoListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CustManagePage;
        private System.Windows.Forms.TreeView CustomerControlItem_tree;
        private System.Windows.Forms.TabPage ParkManagePage;
        private System.Windows.Forms.TabPage DeviceManagePage;
        private System.Windows.Forms.TabPage SystemOptionPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_PresentUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_Time;
        private System.Windows.Forms.Panel GroupManagePanel;
        private System.Windows.Forms.Label lab_Delete;
        private System.Windows.Forms.Label lab_EditSelectGroup;
        private System.Windows.Forms.Label lab_AddBrotherGroup;
        private System.Windows.Forms.TreeView Group_Tree;
        private System.Windows.Forms.Panel CustomerManagePanel;
        private System.Windows.Forms.TreeView Park_ControlItem_tree;
        private System.Windows.Forms.Panel panel_ParkManage;
        private System.Windows.Forms.TreeView Device_ControlItem_View;
        private System.Windows.Forms.TreeView System_ControlItem_tree;
        private System.Windows.Forms.Panel DeviceOption_panel;
        private System.Windows.Forms.TabControl InOutRecordTab;
        private System.Windows.Forms.TabPage PassengerRecordPage;
        private System.Windows.Forms.Button btn_PassRecordSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker PassRecordEndTime;
        private System.Windows.Forms.DateTimePicker PassRecordStartTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_PassengerPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_SearchPassKey;
        private System.Windows.Forms.DataGridView PassengerRecordGrid;
        private System.Windows.Forms.TabPage VehicleRecordPage;
        private System.Windows.Forms.Button btn_VehiRecordSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker VehicleRecordEndTime;
        private System.Windows.Forms.DateTimePicker VehicleRecordStartTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_VehiclePosition;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txb_SearchVechicleKey;
        private System.Windows.Forms.DataGridView VehicleRecordGrid;
        private System.Windows.Forms.Button btn_Customer_Search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_Customer_SearchKey;
        private System.Windows.Forms.Button btn_CustomerGroup_Edit;
        private System.Windows.Forms.Button btn_Customer_Delete;
        private System.Windows.Forms.Button btn_Customer_Edit;
        private System.Windows.Forms.Button btn_Customer_ADD;
        private System.Windows.Forms.DataGridView CustomerInfoListView;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmb_group;
        private System.Windows.Forms.Panel CarAuthrizeInfoPanel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmb_VehicleGroup;
        private System.Windows.Forms.Button btn_Search_Vehicle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txb_SearchVehicleKey;
        private System.Windows.Forms.Button btn_Vehicle_Delete;
        private System.Windows.Forms.Button btn_VehicleAuthrize_Edit;
        private System.Windows.Forms.Button btn_Vehicle_Add;
        private System.Windows.Forms.DataGridView VehicleInfoGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_ParkChannelName;
        private System.Windows.Forms.Button btn_ParkChannel_ADD;
        private System.Windows.Forms.TreeView ParkPositionInfoTree;
        private System.Windows.Forms.Button btn_ParkChannel_Del;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_DevicePosition;
        private System.Windows.Forms.Button btn_SearchDevice;
        private System.Windows.Forms.TextBox txb_SearchDeviceKey;
        private System.Windows.Forms.Button btn_Device_Authrize_Edit;
        private System.Windows.Forms.Button btn_Device_Delete;
        private System.Windows.Forms.Button btn_Device_Edit;
        private System.Windows.Forms.Button btn_Device_Add;
        private System.Windows.Forms.DataGridView DeviceInfoGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevicePosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceNetAddress;
        private System.Windows.Forms.Panel panel_DoorManage;
        private System.Windows.Forms.Button btn_DoorChannel_Del;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txb_DoorChannelName;
        private System.Windows.Forms.Button btn_DoorChannel_ADD;
        private System.Windows.Forms.TreeView DoorPositionInfoTree;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassengerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassDescription;
        private System.Windows.Forms.Panel UserManagePanel;
        private System.Windows.Forms.Button btn_SelectUser;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txb_SelectUserKey;
        private System.Windows.Forms.Button btn_EditPwd;
        private System.Windows.Forms.Button btn_DeleteUser;
        private System.Windows.Forms.Button btn_EditUser;
        private System.Windows.Forms.Button btn_AddUser;
        private System.Windows.Forms.DataGridView UserInfoListView;
        private System.Windows.Forms.Panel VehicleRecord_Panel;
        private System.Windows.Forms.TabControl reporttab;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_ReportSearch;
        private System.Windows.Forms.ComboBox cmb_TimeType;
        private System.Windows.Forms.ComboBox cmb_ItemType;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.DataGridView VehicleReprotGridView;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Panel PassengerRecord_panel;
        private System.Windows.Forms.TabControl PassRecord_tab;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button btn_PassengerReportSearch;
        private System.Windows.Forms.ComboBox cmb_TimeType_Passenger;
        private System.Windows.Forms.ComboBox cmb_ItemType_Passenger;
        private System.Windows.Forms.Button btn_PassengerReportExport;
        private System.Windows.Forms.DataGridView PassengerReprotGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReportItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn InCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutCount;
        private System.Windows.Forms.ComboBox cmb_ParkChannelDirection;
        private System.Windows.Forms.Label lab_GroupAuthorize;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcard;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Label label20;
    }
}