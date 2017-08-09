namespace SmartPlugin.SmartChildForm
{
    partial class EditUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txb_UserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_UserType = new System.Windows.Forms.ComboBox();
            this.btn_CheckUserName = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lab_error = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_UserStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账户名";
            // 
            // txb_UserName
            // 
            this.txb_UserName.Location = new System.Drawing.Point(96, 26);
            this.txb_UserName.Name = "txb_UserName";
            this.txb_UserName.Size = new System.Drawing.Size(121, 21);
            this.txb_UserName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "用户类型";
            // 
            // cmb_UserType
            // 
            this.cmb_UserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UserType.FormattingEnabled = true;
            this.cmb_UserType.Location = new System.Drawing.Point(95, 74);
            this.cmb_UserType.Name = "cmb_UserType";
            this.cmb_UserType.Size = new System.Drawing.Size(121, 20);
            this.cmb_UserType.TabIndex = 11;
            // 
            // btn_CheckUserName
            // 
            this.btn_CheckUserName.Location = new System.Drawing.Point(236, 24);
            this.btn_CheckUserName.Name = "btn_CheckUserName";
            this.btn_CheckUserName.Size = new System.Drawing.Size(49, 23);
            this.btn_CheckUserName.TabIndex = 12;
            this.btn_CheckUserName.Text = "检查";
            this.btn_CheckUserName.UseVisualStyleBackColor = true;
            this.btn_CheckUserName.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(37, 242);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 13;
            this.btn_OK.Text = "确认修改";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(210, 242);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 14;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // lab_error
            // 
            this.lab_error.AutoSize = true;
            this.lab_error.ForeColor = System.Drawing.Color.Red;
            this.lab_error.Location = new System.Drawing.Point(38, 242);
            this.lab_error.Name = "lab_error";
            this.lab_error.Size = new System.Drawing.Size(0, 12);
            this.lab_error.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "用户状态";
            // 
            // cmb_UserStatus
            // 
            this.cmb_UserStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_UserStatus.FormattingEnabled = true;
            this.cmb_UserStatus.Location = new System.Drawing.Point(94, 120);
            this.cmb_UserStatus.Name = "cmb_UserStatus";
            this.cmb_UserStatus.Size = new System.Drawing.Size(121, 20);
            this.cmb_UserStatus.TabIndex = 17;
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 282);
            this.Controls.Add(this.cmb_UserStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lab_error);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_CheckUserName);
            this.Controls.Add(this.cmb_UserType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_UserName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑用户";
            this.Load += new System.EventHandler(this.NewUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_UserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_UserType;
        private System.Windows.Forms.Button btn_CheckUserName;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lab_error;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_UserStatus;
    }
}