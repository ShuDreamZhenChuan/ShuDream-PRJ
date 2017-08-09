namespace SmartPlugin.SmartChildForm
{
    partial class DeviceVehicleAuthorize
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SelectVehicleGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserIDCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_SearchVehicle = new System.Windows.Forms.Button();
            this.txb_SearchVehicleKey = new System.Windows.Forms.TextBox();
            this.deviceAuthorizeList = new System.Windows.Forms.DataGridView();
            this.authorizeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengerrfid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengeridcard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Del = new System.Windows.Forms.Button();
            this.txb_SearchKey = new System.Windows.Forms.TextBox();
            this.btn_SearchAuthrize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_DeviceName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_DevceType = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lab_Position = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectVehicleGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceAuthorizeList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SelectVehicleGrid);
            this.groupBox2.Controls.Add(this.btn_SearchVehicle);
            this.groupBox2.Controls.Add(this.txb_SearchVehicleKey);
            this.groupBox2.Location = new System.Drawing.Point(12, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(657, 264);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "车辆信息";
            // 
            // SelectVehicleGrid
            // 
            this.SelectVehicleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectVehicleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UserName,
            this.VehicleType,
            this.UserIDCard,
            this.UserGroup});
            this.SelectVehicleGrid.Location = new System.Drawing.Point(7, 20);
            this.SelectVehicleGrid.Name = "SelectVehicleGrid";
            this.SelectVehicleGrid.RowTemplate.Height = 23;
            this.SelectVehicleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectVehicleGrid.Size = new System.Drawing.Size(423, 238);
            this.SelectVehicleGrid.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "vehicle_num";
            this.UserName.HeaderText = "车牌号";
            this.UserName.Name = "UserName";
            this.UserName.Width = 120;
            // 
            // VehicleType
            // 
            this.VehicleType.HeaderText = "车辆类型";
            this.VehicleType.Name = "VehicleType";
            // 
            // UserIDCard
            // 
            this.UserIDCard.DataPropertyName = "vehiclename";
            this.UserIDCard.HeaderText = "车主";
            this.UserIDCard.Name = "UserIDCard";
            this.UserIDCard.Width = 80;
            // 
            // UserGroup
            // 
            this.UserGroup.DataPropertyName = "groupname";
            this.UserGroup.HeaderText = "所在部门";
            this.UserGroup.Name = "UserGroup";
            this.UserGroup.Width = 80;
            // 
            // btn_SearchVehicle
            // 
            this.btn_SearchVehicle.Location = new System.Drawing.Point(554, 62);
            this.btn_SearchVehicle.Name = "btn_SearchVehicle";
            this.btn_SearchVehicle.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchVehicle.TabIndex = 1;
            this.btn_SearchVehicle.Text = "搜索";
            this.btn_SearchVehicle.UseVisualStyleBackColor = true;
            this.btn_SearchVehicle.Click += new System.EventHandler(this.btn_SearchUser_Click);
            // 
            // txb_SearchVehicleKey
            // 
            this.txb_SearchVehicleKey.Location = new System.Drawing.Point(469, 20);
            this.txb_SearchVehicleKey.Name = "txb_SearchVehicleKey";
            this.txb_SearchVehicleKey.Size = new System.Drawing.Size(160, 21);
            this.txb_SearchVehicleKey.TabIndex = 0;
            // 
            // deviceAuthorizeList
            // 
            this.deviceAuthorizeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deviceAuthorizeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorizeid,
            this.passengername,
            this.passengerrfid,
            this.passengeridcard});
            this.deviceAuthorizeList.Location = new System.Drawing.Point(12, 42);
            this.deviceAuthorizeList.Name = "deviceAuthorizeList";
            this.deviceAuthorizeList.RowTemplate.Height = 23;
            this.deviceAuthorizeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deviceAuthorizeList.Size = new System.Drawing.Size(303, 184);
            this.deviceAuthorizeList.TabIndex = 3;
            // 
            // authorizeid
            // 
            this.authorizeid.DataPropertyName = "id";
            this.authorizeid.HeaderText = "id";
            this.authorizeid.Name = "authorizeid";
            this.authorizeid.Visible = false;
            // 
            // passengername
            // 
            this.passengername.DataPropertyName = "Vehiclenum";
            this.passengername.HeaderText = "车牌号码";
            this.passengername.Name = "passengername";
            // 
            // passengerrfid
            // 
            this.passengerrfid.DataPropertyName = "vehicleowner";
            this.passengerrfid.HeaderText = "车主";
            this.passengerrfid.Name = "passengerrfid";
            this.passengerrfid.Width = 80;
            // 
            // passengeridcard
            // 
            this.passengeridcard.DataPropertyName = "vehicletype";
            this.passengeridcard.HeaderText = "车辆类型";
            this.passengeridcard.Name = "passengeridcard";
            this.passengeridcard.Width = 80;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(379, 97);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "添加车辆";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(379, 203);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(75, 23);
            this.btn_Del.TabIndex = 5;
            this.btn_Del.Text = "删除车辆";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // txb_SearchKey
            // 
            this.txb_SearchKey.Location = new System.Drawing.Point(379, 42);
            this.txb_SearchKey.Name = "txb_SearchKey";
            this.txb_SearchKey.Size = new System.Drawing.Size(192, 21);
            this.txb_SearchKey.TabIndex = 6;
            // 
            // btn_SearchAuthrize
            // 
            this.btn_SearchAuthrize.Location = new System.Drawing.Point(592, 40);
            this.btn_SearchAuthrize.Name = "btn_SearchAuthrize";
            this.btn_SearchAuthrize.Size = new System.Drawing.Size(75, 23);
            this.btn_SearchAuthrize.TabIndex = 7;
            this.btn_SearchAuthrize.Text = "搜索";
            this.btn_SearchAuthrize.UseVisualStyleBackColor = true;
            this.btn_SearchAuthrize.Click += new System.EventHandler(this.btn_SearchAuthrize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "设备名称";
            // 
            // lab_DeviceName
            // 
            this.lab_DeviceName.AutoSize = true;
            this.lab_DeviceName.Location = new System.Drawing.Point(74, 17);
            this.lab_DeviceName.Name = "lab_DeviceName";
            this.lab_DeviceName.Size = new System.Drawing.Size(0, 12);
            this.lab_DeviceName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "设备类型";
            // 
            // lab_DevceType
            // 
            this.lab_DevceType.AutoSize = true;
            this.lab_DevceType.Location = new System.Drawing.Point(208, 16);
            this.lab_DevceType.Name = "lab_DevceType";
            this.lab_DevceType.Size = new System.Drawing.Size(0, 12);
            this.lab_DevceType.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(277, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "设备位置";
            // 
            // lab_Position
            // 
            this.lab_Position.AutoSize = true;
            this.lab_Position.Location = new System.Drawing.Point(335, 17);
            this.lab_Position.Name = "lab_Position";
            this.lab_Position.Size = new System.Drawing.Size(0, 12);
            this.lab_Position.TabIndex = 13;
            // 
            // DeviceVehicleAuthorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 514);
            this.Controls.Add(this.lab_Position);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lab_DevceType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_DeviceName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SearchAuthrize);
            this.Controls.Add(this.txb_SearchKey);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.deviceAuthorizeList);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeviceVehicleAuthorize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑设备权限";
            this.Load += new System.EventHandler(this.DeviceAuthorize_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectVehicleGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceAuthorizeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView SelectVehicleGrid;
        private System.Windows.Forms.Button btn_SearchVehicle;
        private System.Windows.Forms.TextBox txb_SearchVehicleKey;
        private System.Windows.Forms.DataGridView deviceAuthorizeList;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.TextBox txb_SearchKey;
        private System.Windows.Forms.Button btn_SearchAuthrize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_DeviceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_DevceType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lab_Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorizeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengername;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerrfid;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengeridcard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleType;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserIDCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGroup;

    }
}