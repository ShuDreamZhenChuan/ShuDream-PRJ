namespace SmartPlugin.SmartChildForm
{
    partial class GroupAuthorize
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
            this.AuthrizeGroupHave = new System.Windows.Forms.DataGridView();
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
            this.lab_groupname = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_UpdateAuthirizeTime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AuthrizeGroupHave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthrizeCanGive)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthrizeGroupHave
            // 
            this.AuthrizeGroupHave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthrizeGroupHave.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.DeviceName,
            this.DeviceType,
            this.AuthorizeEndTime});
            this.AuthrizeGroupHave.Location = new System.Drawing.Point(6, 23);
            this.AuthrizeGroupHave.Name = "AuthrizeGroupHave";
            this.AuthrizeGroupHave.RowTemplate.Height = 23;
            this.AuthrizeGroupHave.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AuthrizeGroupHave.Size = new System.Drawing.Size(318, 203);
            this.AuthrizeGroupHave.TabIndex = 0;
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
            this.DeviceName.HeaderText = "设备名称";
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
            this.AuthrizeCanGive.Location = new System.Drawing.Point(12, 20);
            this.AuthrizeCanGive.Name = "AuthrizeCanGive";
            this.AuthrizeCanGive.RowTemplate.Height = 23;
            this.AuthrizeCanGive.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AuthrizeCanGive.Size = new System.Drawing.Size(312, 147);
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
            this.dataGridViewTextBoxColumn2.HeaderText = "设备名称";
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
            this.btn_AddAuthrize.Location = new System.Drawing.Point(367, 306);
            this.btn_AddAuthrize.Name = "btn_AddAuthrize";
            this.btn_AddAuthrize.Size = new System.Drawing.Size(75, 23);
            this.btn_AddAuthrize.TabIndex = 2;
            this.btn_AddAuthrize.Text = "添加权限";
            this.btn_AddAuthrize.UseVisualStyleBackColor = true;
            this.btn_AddAuthrize.Click += new System.EventHandler(this.btn_AddAuthrize_Click);
            // 
            // btn_DeleteAuthrize
            // 
            this.btn_DeleteAuthrize.Location = new System.Drawing.Point(367, 254);
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
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "群组名称：";
            // 
            // lab_groupname
            // 
            this.lab_groupname.AutoSize = true;
            this.lab_groupname.Location = new System.Drawing.Point(93, 26);
            this.lab_groupname.Name = "lab_groupname";
            this.lab_groupname.Size = new System.Drawing.Size(41, 12);
            this.lab_groupname.TabIndex = 5;
            this.lab_groupname.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AuthrizeGroupHave);
            this.groupBox1.Location = new System.Drawing.Point(15, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 232);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "已拥有权限的设备";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AuthrizeCanGive);
            this.groupBox2.Location = new System.Drawing.Point(15, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 173);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "可以添加权限的设备";
            // 
            // btn_UpdateAuthirizeTime
            // 
            this.btn_UpdateAuthirizeTime.Location = new System.Drawing.Point(367, 60);
            this.btn_UpdateAuthirizeTime.Name = "btn_UpdateAuthirizeTime";
            this.btn_UpdateAuthirizeTime.Size = new System.Drawing.Size(75, 36);
            this.btn_UpdateAuthirizeTime.TabIndex = 10;
            this.btn_UpdateAuthirizeTime.Text = "更新权限时间";
            this.btn_UpdateAuthirizeTime.UseVisualStyleBackColor = true;
            this.btn_UpdateAuthirizeTime.Click += new System.EventHandler(this.btn_UpdateAuthirizeTime_Click);
            // 
            // GroupAuthorize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 485);
            this.Controls.Add(this.btn_UpdateAuthirizeTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lab_groupname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DeleteAuthrize);
            this.Controls.Add(this.btn_AddAuthrize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GroupAuthorize";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑分组权限";
            this.Load += new System.EventHandler(this.CustomerAuthorize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AuthrizeGroupHave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthrizeCanGive)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AuthrizeGroupHave;
        private System.Windows.Forms.DataGridView AuthrizeCanGive;
        private System.Windows.Forms.Button btn_AddAuthrize;
        private System.Windows.Forms.Button btn_DeleteAuthrize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_groupname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_UpdateAuthirizeTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthorizeEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}