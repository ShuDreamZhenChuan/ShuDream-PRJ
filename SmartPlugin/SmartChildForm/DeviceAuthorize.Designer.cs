namespace SmartPlugin.SmartChildForm
{
    partial class DeviceAuthorize
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
            this.SelectGroupGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_SearchGroup = new System.Windows.Forms.Button();
            this.txb_SearchUserKey = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.deviceAuthorizeList = new System.Windows.Forms.DataGridView();
            this.authorizeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengeridcard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Del = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_DeviceName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_DevceType = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lab_Position = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectGroupGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceAuthorizeList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SelectGroupGrid);
            this.groupBox2.Controls.Add(this.btn_SearchGroup);
            this.groupBox2.Controls.Add(this.txb_SearchUserKey);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Location = new System.Drawing.Point(12, 244);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 249);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "可关联群组信息";
            // 
            // SelectGroupGrid
            // 
            this.SelectGroupGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectGroupGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.UserName,
            this.UserGroup,
            this.UserType});
            this.SelectGroupGrid.Location = new System.Drawing.Point(7, 20);
            this.SelectGroupGrid.Name = "SelectGroupGrid";
            this.SelectGroupGrid.RowTemplate.Height = 23;
            this.SelectGroupGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectGroupGrid.Size = new System.Drawing.Size(324, 223);
            this.SelectGroupGrid.TabIndex = 4;
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
            this.UserName.DataPropertyName = "groupname";
            this.UserName.HeaderText = "群组名称";
            this.UserName.Name = "UserName";
            this.UserName.Width = 80;
            // 
            // UserGroup
            // 
            this.UserGroup.DataPropertyName = "groupcount";
            this.UserGroup.HeaderText = "群组人数";
            this.UserGroup.Name = "UserGroup";
            // 
            // UserType
            // 
            this.UserType.DataPropertyName = "groupremark";
            this.UserType.HeaderText = "备注说明";
            this.UserType.Name = "UserType";
            // 
            // btn_SearchGroup
            // 
            this.btn_SearchGroup.Location = new System.Drawing.Point(347, 58);
            this.btn_SearchGroup.Name = "btn_SearchGroup";
            this.btn_SearchGroup.Size = new System.Drawing.Size(108, 33);
            this.btn_SearchGroup.TabIndex = 1;
            this.btn_SearchGroup.Text = "搜索群组";
            this.btn_SearchGroup.UseVisualStyleBackColor = true;
            this.btn_SearchGroup.Click += new System.EventHandler(this.btn_SearchUser_Click);
            // 
            // txb_SearchUserKey
            // 
            this.txb_SearchUserKey.Location = new System.Drawing.Point(347, 20);
            this.txb_SearchUserKey.MaxLength = 20;
            this.txb_SearchUserKey.Name = "txb_SearchUserKey";
            this.txb_SearchUserKey.Size = new System.Drawing.Size(108, 21);
            this.txb_SearchUserKey.TabIndex = 0;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(350, 192);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(99, 42);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "关联权限到群组";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // deviceAuthorizeList
            // 
            this.deviceAuthorizeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deviceAuthorizeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.authorizeid,
            this.passengername,
            this.passengeridcard});
            this.deviceAuthorizeList.Location = new System.Drawing.Point(12, 42);
            this.deviceAuthorizeList.Name = "deviceAuthorizeList";
            this.deviceAuthorizeList.RowTemplate.Height = 23;
            this.deviceAuthorizeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deviceAuthorizeList.Size = new System.Drawing.Size(323, 184);
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
            this.passengername.DataPropertyName = "groupname";
            this.passengername.HeaderText = "群组名称";
            this.passengername.Name = "passengername";
            this.passengername.Width = 150;
            // 
            // passengeridcard
            // 
            this.passengeridcard.DataPropertyName = "groupcount";
            this.passengeridcard.HeaderText = "群组人数";
            this.passengeridcard.Name = "passengeridcard";
            this.passengeridcard.Width = 130;
            // 
            // btn_Del
            // 
            this.btn_Del.Location = new System.Drawing.Point(359, 184);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(108, 42);
            this.btn_Del.TabIndex = 5;
            this.btn_Del.Text = "删除群组的权限";
            this.btn_Del.UseVisualStyleBackColor = true;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
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
            // DeviceAuthorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 514);
            this.Controls.Add(this.lab_Position);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lab_DevceType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_DeviceName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Del);
            this.Controls.Add(this.deviceAuthorizeList);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeviceAuthorize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑设备权限";
            this.Load += new System.EventHandler(this.DeviceAuthorize_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectGroupGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deviceAuthorizeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView SelectGroupGrid;
        private System.Windows.Forms.Button btn_SearchGroup;
        private System.Windows.Forms.TextBox txb_SearchUserKey;
        private System.Windows.Forms.DataGridView deviceAuthorizeList;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_DeviceName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_DevceType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lab_Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorizeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengername;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengeridcard;

    }
}