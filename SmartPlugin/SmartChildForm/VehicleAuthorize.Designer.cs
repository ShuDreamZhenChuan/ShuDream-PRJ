namespace SmartPlugin.SmartChildForm
{
    partial class VehicleAuthorize
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
            this.AuthrizeUserHave = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthorizeEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthrizeCanGive = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AddAuthrize = new System.Windows.Forms.Button();
            this.btn_DeleteAuthrize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_vehiclenum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lab_vehicleowner = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_UpdateAuthirizeTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AuthrizeUserHave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthrizeCanGive)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthrizeUserHave
            // 
            this.AuthrizeUserHave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthrizeUserHave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.DeviceName,
            this.DeviceType,
            this.AuthorizeEndTime});
            this.AuthrizeUserHave.Location = new System.Drawing.Point(8, 20);
            this.AuthrizeUserHave.Name = "AuthrizeUserHave";
            this.AuthrizeUserHave.RowTemplate.Height = 23;
            this.AuthrizeUserHave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AuthrizeUserHave.Size = new System.Drawing.Size(334, 169);
            this.AuthrizeUserHave.TabIndex = 0;
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
            this.DeviceName.DataPropertyName = "devicename";
            this.DeviceName.HeaderText = "权限设备";
            this.DeviceName.Name = "DeviceName";
            this.DeviceName.Width = 80;
            // 
            // DeviceType
            // 
            this.DeviceType.DataPropertyName = "devicetype";
            this.DeviceType.HeaderText = "设备类型";
            this.DeviceType.Name = "DeviceType";
            this.DeviceType.Width = 80;
            // 
            // AuthorizeEndTime
            // 
            this.AuthorizeEndTime.DataPropertyName = "authorizeendtime";
            this.AuthorizeEndTime.HeaderText = "权限截止时间";
            this.AuthorizeEndTime.Name = "AuthorizeEndTime";
            this.AuthorizeEndTime.Width = 150;
            // 
            // AuthrizeCanGive
            // 
            this.AuthrizeCanGive.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthrizeCanGive.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.AuthrizeCanGive.Location = new System.Drawing.Point(12, 18);
            this.AuthrizeCanGive.Name = "AuthrizeCanGive";
            this.AuthrizeCanGive.RowTemplate.Height = 23;
            this.AuthrizeCanGive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AuthrizeCanGive.Size = new System.Drawing.Size(322, 161);
            this.AuthrizeCanGive.TabIndex = 1;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "devicename";
            this.dataGridViewTextBoxColumn2.HeaderText = "权限设备";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "devicetype";
            this.dataGridViewTextBoxColumn3.HeaderText = "设备类型";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // btn_AddAuthrize
            // 
            this.btn_AddAuthrize.Location = new System.Drawing.Point(383, 283);
            this.btn_AddAuthrize.Name = "btn_AddAuthrize";
            this.btn_AddAuthrize.Size = new System.Drawing.Size(75, 23);
            this.btn_AddAuthrize.TabIndex = 2;
            this.btn_AddAuthrize.Text = "添加权限";
            this.btn_AddAuthrize.UseVisualStyleBackColor = true;
            this.btn_AddAuthrize.Click += new System.EventHandler(this.btn_AddAuthrize_Click);
            // 
            // btn_DeleteAuthrize
            // 
            this.btn_DeleteAuthrize.Location = new System.Drawing.Point(382, 220);
            this.btn_DeleteAuthrize.Name = "btn_DeleteAuthrize";
            this.btn_DeleteAuthrize.Size = new System.Drawing.Size(75, 23);
            this.btn_DeleteAuthrize.TabIndex = 3;
            this.btn_DeleteAuthrize.Text = "删除权限";
            this.btn_DeleteAuthrize.UseVisualStyleBackColor = true;
            this.btn_DeleteAuthrize.Click += new System.EventHandler(this.btn_DeleteAuthrize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "车牌号：";
            // 
            // lab_vehiclenum
            // 
            this.lab_vehiclenum.AutoSize = true;
            this.lab_vehiclenum.Location = new System.Drawing.Point(73, 25);
            this.lab_vehiclenum.Name = "lab_vehiclenum";
            this.lab_vehiclenum.Size = new System.Drawing.Size(41, 12);
            this.lab_vehiclenum.TabIndex = 5;
            this.lab_vehiclenum.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "车主:";
            // 
            // lab_vehicleowner
            // 
            this.lab_vehicleowner.AutoSize = true;
            this.lab_vehicleowner.Location = new System.Drawing.Point(381, 25);
            this.lab_vehicleowner.Name = "lab_vehicleowner";
            this.lab_vehicleowner.Size = new System.Drawing.Size(41, 12);
            this.lab_vehicleowner.TabIndex = 7;
            this.lab_vehicleowner.Text = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AuthrizeUserHave);
            this.groupBox1.Location = new System.Drawing.Point(13, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 195);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "已拥有权限";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AuthrizeCanGive);
            this.groupBox2.Location = new System.Drawing.Point(13, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 187);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "可以添加的权限";
            // 
            // btn_UpdateAuthirizeTime
            // 
            this.btn_UpdateAuthirizeTime.Location = new System.Drawing.Point(383, 62);
            this.btn_UpdateAuthirizeTime.Name = "btn_UpdateAuthirizeTime";
            this.btn_UpdateAuthirizeTime.Size = new System.Drawing.Size(75, 36);
            this.btn_UpdateAuthirizeTime.TabIndex = 11;
            this.btn_UpdateAuthirizeTime.Text = "更新权限时间";
            this.btn_UpdateAuthirizeTime.UseVisualStyleBackColor = true;
            this.btn_UpdateAuthirizeTime.Click += new System.EventHandler(this.btn_UpdateAuthirizeTime_Click);
            // 
            // VehicleAuthorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 471);
            this.Controls.Add(this.btn_UpdateAuthirizeTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lab_vehicleowner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_vehiclenum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DeleteAuthrize);
            this.Controls.Add(this.btn_AddAuthrize);
            this.Name = "VehicleAuthorize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.CustomerAuthorize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AuthrizeUserHave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthrizeCanGive)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AuthrizeUserHave;
        private System.Windows.Forms.DataGridView AuthrizeCanGive;
        private System.Windows.Forms.Button btn_AddAuthrize;
        private System.Windows.Forms.Button btn_DeleteAuthrize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_vehiclenum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_vehicleowner;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_UpdateAuthirizeTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorizeEndTime;
    }
}