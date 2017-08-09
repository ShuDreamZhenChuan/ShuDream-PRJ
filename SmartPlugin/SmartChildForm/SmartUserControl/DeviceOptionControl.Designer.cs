namespace SmartPlugin.SmartUserControl
{
    partial class DeviceOptionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("A门控制板");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("控制板", new System.Windows.Forms.TreeNode[] {
            treeNode71});
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("摄像头1#");
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("摄像头", new System.Windows.Forms.TreeNode[] {
            treeNode73});
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("A门入口门闸");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("门", new System.Windows.Forms.TreeNode[] {
            treeNode75});
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("A门读头");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("读卡器", new System.Windows.Forms.TreeNode[] {
            treeNode77});
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("A口身份证扫描");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("证件扫描仪", new System.Windows.Forms.TreeNode[] {
            treeNode79});
            this.Device_Tree = new System.Windows.Forms.TreeView();
            this.DeviceTab = new System.Windows.Forms.TabControl();
            this.ParamPage = new System.Windows.Forms.TabPage();
            this.cmb_DeviceType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_SaveDevice = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txb_SN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_Port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_DeviceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeviceInfo_Page = new System.Windows.Forms.TabPage();
            this.DoorInfo_panel = new System.Windows.Forms.Panel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_CardReader_CH2 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.cmb_DoorType_CH2 = new System.Windows.Forms.ComboBox();
            this.cmb_IDScaner_CH2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_CardReader_CH1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_DoorType_CH1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.cmb_IDScaner_CH1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_DoorName = new System.Windows.Forms.TextBox();
            this.lab1 = new System.Windows.Forms.Label();
            this.btn_AddDevice = new System.Windows.Forms.Button();
            this.btn_AddDoor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_IDReaderCom_CH1 = new System.Windows.Forms.ComboBox();
            this.btn_IDReaderChoose_CH1 = new System.Windows.Forms.Button();
            this.btn_IDReaderChoose_CH2 = new System.Windows.Forms.Button();
            this.cmb_IDReaderCom_CH2 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txb_CameraIP_CH1 = new System.Windows.Forms.TextBox();
            this.txb_CameraIP_CH2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txb_CameraUserName_CH1 = new System.Windows.Forms.TextBox();
            this.txb_CameraPwd_CH1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txb_CameraUserName_CH2 = new System.Windows.Forms.TextBox();
            this.txb_CameraPwd_CH2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.DeviceTab.SuspendLayout();
            this.ParamPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.DoorInfo_panel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Device_Tree
            // 
            this.Device_Tree.Location = new System.Drawing.Point(3, 3);
            this.Device_Tree.Name = "Device_Tree";
            treeNode71.Name = "Node5";
            treeNode71.Text = "A门控制板";
            treeNode72.Name = "ControlBoard";
            treeNode72.Text = "控制板";
            treeNode73.Name = "Node6";
            treeNode73.Text = "摄像头1#";
            treeNode74.Name = "Camera";
            treeNode74.Text = "摄像头";
            treeNode75.Name = "Node7";
            treeNode75.Text = "A门入口门闸";
            treeNode76.Name = "DoorControl";
            treeNode76.Text = "门";
            treeNode77.Name = "Node8";
            treeNode77.Text = "A门读头";
            treeNode78.Name = "CardReader";
            treeNode78.Text = "读卡器";
            treeNode79.Name = "Node9";
            treeNode79.Text = "A口身份证扫描";
            treeNode80.Name = "IDScaner";
            treeNode80.Text = "证件扫描仪";
            this.Device_Tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode72,
            treeNode74,
            treeNode76,
            treeNode78,
            treeNode80});
            this.Device_Tree.Size = new System.Drawing.Size(190, 534);
            this.Device_Tree.TabIndex = 0;
            this.Device_Tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Device_Tree_AfterSelect);
            // 
            // DeviceTab
            // 
            this.DeviceTab.Controls.Add(this.ParamPage);
            this.DeviceTab.Controls.Add(this.DeviceInfo_Page);
            this.DeviceTab.Location = new System.Drawing.Point(220, 35);
            this.DeviceTab.Name = "DeviceTab";
            this.DeviceTab.SelectedIndex = 0;
            this.DeviceTab.Size = new System.Drawing.Size(657, 505);
            this.DeviceTab.TabIndex = 1;
            this.DeviceTab.Visible = false;
            // 
            // ParamPage
            // 
            this.ParamPage.Controls.Add(this.cmb_DeviceType);
            this.ParamPage.Controls.Add(this.label5);
            this.ParamPage.Controls.Add(this.btn_SaveDevice);
            this.ParamPage.Controls.Add(this.button1);
            this.ParamPage.Controls.Add(this.btn_Search);
            this.ParamPage.Controls.Add(this.dataGridView1);
            this.ParamPage.Controls.Add(this.txb_SN);
            this.ParamPage.Controls.Add(this.label4);
            this.ParamPage.Controls.Add(this.txb_Port);
            this.ParamPage.Controls.Add(this.label3);
            this.ParamPage.Controls.Add(this.textBox1);
            this.ParamPage.Controls.Add(this.label2);
            this.ParamPage.Controls.Add(this.txb_DeviceName);
            this.ParamPage.Controls.Add(this.label1);
            this.ParamPage.Location = new System.Drawing.Point(4, 22);
            this.ParamPage.Name = "ParamPage";
            this.ParamPage.Padding = new System.Windows.Forms.Padding(3);
            this.ParamPage.Size = new System.Drawing.Size(649, 479);
            this.ParamPage.TabIndex = 0;
            this.ParamPage.Text = "参数设置";
            this.ParamPage.UseVisualStyleBackColor = true;
            // 
            // cmb_DeviceType
            // 
            this.cmb_DeviceType.FormattingEnabled = true;
            this.cmb_DeviceType.Location = new System.Drawing.Point(79, 19);
            this.cmb_DeviceType.Name = "cmb_DeviceType";
            this.cmb_DeviceType.Size = new System.Drawing.Size(140, 20);
            this.cmb_DeviceType.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "设备类型";
            // 
            // btn_SaveDevice
            // 
            this.btn_SaveDevice.Location = new System.Drawing.Point(22, 450);
            this.btn_SaveDevice.Name = "btn_SaveDevice";
            this.btn_SaveDevice.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveDevice.TabIndex = 11;
            this.btn_SaveDevice.Text = "保存设备";
            this.btn_SaveDevice.UseVisualStyleBackColor = true;
            this.btn_SaveDevice.Click += new System.EventHandler(this.btn_SaveDevice_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "搜索参数设置";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(265, 54);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "搜索设备";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(265, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(378, 380);
            this.dataGridView1.TabIndex = 8;
            // 
            // txb_SN
            // 
            this.txb_SN.Location = new System.Drawing.Point(81, 178);
            this.txb_SN.Name = "txb_SN";
            this.txb_SN.Size = new System.Drawing.Size(140, 21);
            this.txb_SN.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "设备序列号";
            // 
            // txb_Port
            // 
            this.txb_Port.Location = new System.Drawing.Point(81, 136);
            this.txb_Port.Name = "txb_Port";
            this.txb_Port.Size = new System.Drawing.Size(140, 21);
            this.txb_Port.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "设备端口";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 21);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "设备IP";
            // 
            // txb_DeviceName
            // 
            this.txb_DeviceName.Location = new System.Drawing.Point(81, 55);
            this.txb_DeviceName.Name = "txb_DeviceName";
            this.txb_DeviceName.Size = new System.Drawing.Size(140, 21);
            this.txb_DeviceName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "设备名称";
            // 
            // DeviceInfo_Page
            // 
            this.DeviceInfo_Page.Location = new System.Drawing.Point(4, 22);
            this.DeviceInfo_Page.Name = "DeviceInfo_Page";
            this.DeviceInfo_Page.Padding = new System.Windows.Forms.Padding(3);
            this.DeviceInfo_Page.Size = new System.Drawing.Size(649, 479);
            this.DeviceInfo_Page.TabIndex = 1;
            this.DeviceInfo_Page.Text = "信息查看";
            this.DeviceInfo_Page.UseVisualStyleBackColor = true;
            // 
            // DoorInfo_panel
            // 
            this.DoorInfo_panel.Controls.Add(this.btn_Delete);
            this.DoorInfo_panel.Controls.Add(this.btn_Save);
            this.DoorInfo_panel.Controls.Add(this.groupBox2);
            this.DoorInfo_panel.Controls.Add(this.groupBox1);
            this.DoorInfo_panel.Controls.Add(this.txb_DoorName);
            this.DoorInfo_panel.Controls.Add(this.lab1);
            this.DoorInfo_panel.Location = new System.Drawing.Point(220, 35);
            this.DoorInfo_panel.Name = "DoorInfo_panel";
            this.DoorInfo_panel.Size = new System.Drawing.Size(657, 505);
            this.DoorInfo_panel.TabIndex = 2;
            this.DoorInfo_panel.Visible = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(432, 472);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 23;
            this.btn_Delete.Text = "删除此门";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(539, 472);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 22;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txb_CameraPwd_CH2);
            this.groupBox2.Controls.Add(this.txb_CameraUserName_CH2);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txb_CameraIP_CH2);
            this.groupBox2.Controls.Add(this.cmb_IDReaderCom_CH2);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btn_IDReaderChoose_CH2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmb_CardReader_CH2);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBox8);
            this.groupBox2.Controls.Add(this.cmb_DoorType_CH2);
            this.groupBox2.Controls.Add(this.cmb_IDScaner_CH2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(292, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 391);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "通道2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "读卡器";
            // 
            // cmb_CardReader_CH2
            // 
            this.cmb_CardReader_CH2.FormattingEnabled = true;
            this.cmb_CardReader_CH2.Location = new System.Drawing.Point(94, 22);
            this.cmb_CardReader_CH2.Name = "cmb_CardReader_CH2";
            this.cmb_CardReader_CH2.Size = new System.Drawing.Size(121, 20);
            this.cmb_CardReader_CH2.TabIndex = 7;
            this.cmb_CardReader_CH2.SelectedIndexChanged += new System.EventHandler(this.cmb_CardReader_CH2_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 19;
            this.label14.Text = "摄像头类型";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 9;
            this.label10.Text = "门方向";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "USB",
            "网络设备"});
            this.comboBox8.Location = new System.Drawing.Point(94, 193);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(121, 20);
            this.comboBox8.TabIndex = 18;
            // 
            // cmb_DoorType_CH2
            // 
            this.cmb_DoorType_CH2.FormattingEnabled = true;
            this.cmb_DoorType_CH2.Location = new System.Drawing.Point(94, 62);
            this.cmb_DoorType_CH2.Name = "cmb_DoorType_CH2";
            this.cmb_DoorType_CH2.Size = new System.Drawing.Size(121, 20);
            this.cmb_DoorType_CH2.TabIndex = 11;
            // 
            // cmb_IDScaner_CH2
            // 
            this.cmb_IDScaner_CH2.FormattingEnabled = true;
            this.cmb_IDScaner_CH2.Location = new System.Drawing.Point(94, 105);
            this.cmb_IDScaner_CH2.Name = "cmb_IDScaner_CH2";
            this.cmb_IDScaner_CH2.Size = new System.Drawing.Size(121, 20);
            this.cmb_IDScaner_CH2.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 12);
            this.label13.TabIndex = 16;
            this.label13.Text = "身份证阅读器";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb_CameraPwd_CH1);
            this.groupBox1.Controls.Add(this.txb_CameraUserName_CH1);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txb_CameraIP_CH1);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btn_IDReaderChoose_CH1);
            this.groupBox1.Controls.Add(this.cmb_IDReaderCom_CH1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmb_CardReader_CH1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmb_DoorType_CH1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.comboBox6);
            this.groupBox1.Controls.Add(this.cmb_IDScaner_CH1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(28, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 391);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通道1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "读卡器";
            // 
            // cmb_CardReader_CH1
            // 
            this.cmb_CardReader_CH1.FormattingEnabled = true;
            this.cmb_CardReader_CH1.Location = new System.Drawing.Point(102, 23);
            this.cmb_CardReader_CH1.Name = "cmb_CardReader_CH1";
            this.cmb_CardReader_CH1.Size = new System.Drawing.Size(121, 20);
            this.cmb_CardReader_CH1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "门方向";
            // 
            // cmb_DoorType_CH1
            // 
            this.cmb_DoorType_CH1.FormattingEnabled = true;
            this.cmb_DoorType_CH1.Location = new System.Drawing.Point(102, 63);
            this.cmb_DoorType_CH1.Name = "cmb_DoorType_CH1";
            this.cmb_DoorType_CH1.Size = new System.Drawing.Size(121, 20);
            this.cmb_DoorType_CH1.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "身份证阅读器";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "USB",
            "网络设备"});
            this.comboBox6.Location = new System.Drawing.Point(102, 193);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 20);
            this.comboBox6.TabIndex = 15;
            // 
            // cmb_IDScaner_CH1
            // 
            this.cmb_IDScaner_CH1.FormattingEnabled = true;
            this.cmb_IDScaner_CH1.Location = new System.Drawing.Point(102, 107);
            this.cmb_IDScaner_CH1.Name = "cmb_IDScaner_CH1";
            this.cmb_IDScaner_CH1.Size = new System.Drawing.Size(121, 20);
            this.cmb_IDScaner_CH1.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 14;
            this.label12.Text = "摄像头类型";
            // 
            // txb_DoorName
            // 
            this.txb_DoorName.Location = new System.Drawing.Point(64, 22);
            this.txb_DoorName.Name = "txb_DoorName";
            this.txb_DoorName.Size = new System.Drawing.Size(100, 21);
            this.txb_DoorName.TabIndex = 1;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(19, 26);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(41, 12);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "门名称";
            // 
            // btn_AddDevice
            // 
            this.btn_AddDevice.Location = new System.Drawing.Point(222, 6);
            this.btn_AddDevice.Name = "btn_AddDevice";
            this.btn_AddDevice.Size = new System.Drawing.Size(75, 23);
            this.btn_AddDevice.TabIndex = 3;
            this.btn_AddDevice.Text = "添加设备";
            this.btn_AddDevice.UseVisualStyleBackColor = true;
            this.btn_AddDevice.Visible = false;
            this.btn_AddDevice.Click += new System.EventHandler(this.btn_AddDevice_Click);
            // 
            // btn_AddDoor
            // 
            this.btn_AddDoor.Location = new System.Drawing.Point(221, 6);
            this.btn_AddDoor.Name = "btn_AddDoor";
            this.btn_AddDoor.Size = new System.Drawing.Size(75, 23);
            this.btn_AddDoor.TabIndex = 4;
            this.btn_AddDoor.Text = "添加门";
            this.btn_AddDoor.UseVisualStyleBackColor = true;
            this.btn_AddDoor.Visible = false;
            this.btn_AddDoor.Click += new System.EventHandler(this.btn_AddDoor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "端口";
            // 
            // cmb_IDReaderCom_CH1
            // 
            this.cmb_IDReaderCom_CH1.FormattingEnabled = true;
            this.cmb_IDReaderCom_CH1.Location = new System.Drawing.Point(102, 148);
            this.cmb_IDReaderCom_CH1.Name = "cmb_IDReaderCom_CH1";
            this.cmb_IDReaderCom_CH1.Size = new System.Drawing.Size(66, 20);
            this.cmb_IDReaderCom_CH1.TabIndex = 17;
            // 
            // btn_IDReaderChoose_CH1
            // 
            this.btn_IDReaderChoose_CH1.Location = new System.Drawing.Point(175, 147);
            this.btn_IDReaderChoose_CH1.Name = "btn_IDReaderChoose_CH1";
            this.btn_IDReaderChoose_CH1.Size = new System.Drawing.Size(48, 23);
            this.btn_IDReaderChoose_CH1.TabIndex = 18;
            this.btn_IDReaderChoose_CH1.Text = "选择";
            this.btn_IDReaderChoose_CH1.UseVisualStyleBackColor = true;
            // 
            // btn_IDReaderChoose_CH2
            // 
            this.btn_IDReaderChoose_CH2.Location = new System.Drawing.Point(167, 144);
            this.btn_IDReaderChoose_CH2.Name = "btn_IDReaderChoose_CH2";
            this.btn_IDReaderChoose_CH2.Size = new System.Drawing.Size(49, 23);
            this.btn_IDReaderChoose_CH2.TabIndex = 20;
            this.btn_IDReaderChoose_CH2.Text = "选择";
            this.btn_IDReaderChoose_CH2.UseVisualStyleBackColor = true;
            // 
            // cmb_IDReaderCom_CH2
            // 
            this.cmb_IDReaderCom_CH2.FormattingEnabled = true;
            this.cmb_IDReaderCom_CH2.Location = new System.Drawing.Point(96, 146);
            this.cmb_IDReaderCom_CH2.Name = "cmb_IDReaderCom_CH2";
            this.cmb_IDReaderCom_CH2.Size = new System.Drawing.Size(66, 20);
            this.cmb_IDReaderCom_CH2.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 21;
            this.label15.Text = "端口";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 233);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 19;
            this.label16.Text = "摄像头IP";
            // 
            // txb_CameraIP_CH1
            // 
            this.txb_CameraIP_CH1.Location = new System.Drawing.Point(102, 233);
            this.txb_CameraIP_CH1.Name = "txb_CameraIP_CH1";
            this.txb_CameraIP_CH1.Size = new System.Drawing.Size(120, 21);
            this.txb_CameraIP_CH1.TabIndex = 20;
            // 
            // txb_CameraIP_CH2
            // 
            this.txb_CameraIP_CH2.Location = new System.Drawing.Point(94, 233);
            this.txb_CameraIP_CH2.Name = "txb_CameraIP_CH2";
            this.txb_CameraIP_CH2.Size = new System.Drawing.Size(120, 21);
            this.txb_CameraIP_CH2.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 233);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 24;
            this.label17.Text = "摄像头IP";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 272);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 12);
            this.label18.TabIndex = 21;
            this.label18.Text = "摄像头用户名";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 305);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 12);
            this.label19.TabIndex = 22;
            this.label19.Text = "摄像头密码";
            // 
            // txb_CameraUserName_CH1
            // 
            this.txb_CameraUserName_CH1.Location = new System.Drawing.Point(102, 272);
            this.txb_CameraUserName_CH1.Name = "txb_CameraUserName_CH1";
            this.txb_CameraUserName_CH1.Size = new System.Drawing.Size(120, 21);
            this.txb_CameraUserName_CH1.TabIndex = 23;
            // 
            // txb_CameraPwd_CH1
            // 
            this.txb_CameraPwd_CH1.Location = new System.Drawing.Point(102, 305);
            this.txb_CameraPwd_CH1.Name = "txb_CameraPwd_CH1";
            this.txb_CameraPwd_CH1.Size = new System.Drawing.Size(120, 21);
            this.txb_CameraPwd_CH1.TabIndex = 24;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 272);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 12);
            this.label20.TabIndex = 25;
            this.label20.Text = "摄像头用户名";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 305);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 26;
            this.label21.Text = "摄像头密码";
            // 
            // txb_CameraUserName_CH2
            // 
            this.txb_CameraUserName_CH2.Location = new System.Drawing.Point(94, 272);
            this.txb_CameraUserName_CH2.Name = "txb_CameraUserName_CH2";
            this.txb_CameraUserName_CH2.Size = new System.Drawing.Size(120, 21);
            this.txb_CameraUserName_CH2.TabIndex = 25;
            // 
            // txb_CameraPwd_CH2
            // 
            this.txb_CameraPwd_CH2.Location = new System.Drawing.Point(94, 305);
            this.txb_CameraPwd_CH2.Name = "txb_CameraPwd_CH2";
            this.txb_CameraPwd_CH2.Size = new System.Drawing.Size(120, 21);
            this.txb_CameraPwd_CH2.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(303, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DeviceOptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_AddDoor);
            this.Controls.Add(this.btn_AddDevice);
            this.Controls.Add(this.DoorInfo_panel);
            this.Controls.Add(this.DeviceTab);
            this.Controls.Add(this.Device_Tree);
            this.Name = "DeviceOptionControl";
            this.Size = new System.Drawing.Size(880, 540);
            this.DeviceTab.ResumeLayout(false);
            this.ParamPage.ResumeLayout(false);
            this.ParamPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.DoorInfo_panel.ResumeLayout(false);
            this.DoorInfo_panel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView Device_Tree;
        private System.Windows.Forms.TabControl DeviceTab;
        private System.Windows.Forms.TabPage ParamPage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txb_SN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_Port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_DeviceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage DeviceInfo_Page;
        private System.Windows.Forms.Button btn_SaveDevice;
        private System.Windows.Forms.Panel DoorInfo_panel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_CardReader_CH2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.ComboBox cmb_DoorType_CH2;
        private System.Windows.Forms.ComboBox cmb_IDScaner_CH2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_CardReader_CH1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_DoorType_CH1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox cmb_IDScaner_CH1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txb_DoorName;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_AddDevice;
        private System.Windows.Forms.Button btn_AddDoor;
        private System.Windows.Forms.ComboBox cmb_DeviceType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_CameraPwd_CH2;
        private System.Windows.Forms.TextBox txb_CameraUserName_CH2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txb_CameraIP_CH2;
        private System.Windows.Forms.ComboBox cmb_IDReaderCom_CH2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_IDReaderChoose_CH2;
        private System.Windows.Forms.TextBox txb_CameraPwd_CH1;
        private System.Windows.Forms.TextBox txb_CameraUserName_CH1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txb_CameraIP_CH1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_IDReaderChoose_CH1;
        private System.Windows.Forms.ComboBox cmb_IDReaderCom_CH1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}
