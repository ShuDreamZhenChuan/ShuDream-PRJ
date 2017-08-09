namespace SmartPlugin.SmartChildForm
{
    partial class CustomerGroupInfo
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
            this.GroupCustomerIn = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupCanJoin = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_JoinGroup = new System.Windows.Forms.Button();
            this.btn_ExitGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_username = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_rfid = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.GroupCustomerIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupCanJoin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupCustomerIn
            // 
            this.GroupCustomerIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupCustomerIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.DeviceName,
            this.DeviceType});
            this.GroupCustomerIn.Location = new System.Drawing.Point(6, 23);
            this.GroupCustomerIn.Name = "GroupCustomerIn";
            this.GroupCustomerIn.RowTemplate.Height = 23;
            this.GroupCustomerIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GroupCustomerIn.Size = new System.Drawing.Size(318, 170);
            this.GroupCustomerIn.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 70;
            // 
            // DeviceName
            // 
            this.DeviceName.DataPropertyName = "groupname";
            this.DeviceName.HeaderText = "群组名称";
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Width = 80;
            // 
            // DeviceType
            // 
            this.DeviceType.DataPropertyName = "devicename";
            this.DeviceType.HeaderText = "群组权限";
            this.DeviceType.Name = "DeviceType";
            this.DeviceType.Width = 80;
            // 
            // GroupCanJoin
            // 
            this.GroupCanJoin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupCanJoin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.GroupCanJoin.Location = new System.Drawing.Point(12, 20);
            this.GroupCanJoin.Name = "GroupCanJoin";
            this.GroupCanJoin.RowTemplate.Height = 23;
            this.GroupCanJoin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GroupCanJoin.Size = new System.Drawing.Size(312, 183);
            this.GroupCanJoin.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "groupname";
            this.dataGridViewTextBoxColumn2.HeaderText = "群组名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "devicename";
            this.dataGridViewTextBoxColumn3.HeaderText = "群组权限";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // btn_JoinGroup
            // 
            this.btn_JoinGroup.Location = new System.Drawing.Point(367, 284);
            this.btn_JoinGroup.Name = "btn_JoinGroup";
            this.btn_JoinGroup.Size = new System.Drawing.Size(75, 23);
            this.btn_JoinGroup.TabIndex = 2;
            this.btn_JoinGroup.Text = "加入群组";
            this.btn_JoinGroup.UseVisualStyleBackColor = true;
            this.btn_JoinGroup.Click += new System.EventHandler(this.btn_AddAuthrize_Click);
            // 
            // btn_ExitGroup
            // 
            this.btn_ExitGroup.Location = new System.Drawing.Point(367, 62);
            this.btn_ExitGroup.Name = "btn_ExitGroup";
            this.btn_ExitGroup.Size = new System.Drawing.Size(75, 23);
            this.btn_ExitGroup.TabIndex = 3;
            this.btn_ExitGroup.Text = "退出群组";
            this.btn_ExitGroup.UseVisualStyleBackColor = true;
            this.btn_ExitGroup.Click += new System.EventHandler(this.btn_DeleteAuthrize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "群组名称：";
            // 
            // lab_username
            // 
            this.lab_username.AutoSize = true;
            this.lab_username.Location = new System.Drawing.Point(73, 25);
            this.lab_username.Name = "lab_username";
            this.lab_username.Size = new System.Drawing.Size(41, 12);
            this.lab_username.TabIndex = 5;
            this.lab_username.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "门禁卡号";
            // 
            // lab_rfid
            // 
            this.lab_rfid.AutoSize = true;
            this.lab_rfid.Location = new System.Drawing.Point(194, 25);
            this.lab_rfid.Name = "lab_rfid";
            this.lab_rfid.Size = new System.Drawing.Size(41, 12);
            this.lab_rfid.TabIndex = 7;
            this.lab_rfid.Text = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GroupCustomerIn);
            this.groupBox1.Location = new System.Drawing.Point(15, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 207);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "当前所在群组";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GroupCanJoin);
            this.groupBox2.Location = new System.Drawing.Point(15, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 209);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "可以加入的群组";
            // 
            // CustomerGroupInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 485);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lab_rfid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ExitGroup);
            this.Controls.Add(this.btn_JoinGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerGroupInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑用户群组";
            this.Load += new System.EventHandler(this.CustomerAuthorize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupCustomerIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupCanJoin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GroupCustomerIn;
        private System.Windows.Forms.DataGridView GroupCanJoin;
        private System.Windows.Forms.Button btn_JoinGroup;
        private System.Windows.Forms.Button btn_ExitGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_rfid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}