namespace SmartPlugin.SmartChildForm
{
    partial class EditPassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_oldpwd = new System.Windows.Forms.TextBox();
            this.txb_newpwd = new System.Windows.Forms.TextBox();
            this.txb_confirmpwd = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lab_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "旧密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Tag = "";
            this.label3.Text = "新密码确认";
            // 
            // txb_oldpwd
            // 
            this.txb_oldpwd.Location = new System.Drawing.Point(111, 32);
            this.txb_oldpwd.Name = "txb_oldpwd";
            this.txb_oldpwd.PasswordChar = '*';
            this.txb_oldpwd.Size = new System.Drawing.Size(187, 21);
            this.txb_oldpwd.TabIndex = 3;
            // 
            // txb_newpwd
            // 
            this.txb_newpwd.Location = new System.Drawing.Point(111, 76);
            this.txb_newpwd.Name = "txb_newpwd";
            this.txb_newpwd.PasswordChar = '*';
            this.txb_newpwd.Size = new System.Drawing.Size(187, 21);
            this.txb_newpwd.TabIndex = 4;
            this.txb_newpwd.TextChanged += new System.EventHandler(this.txb_newpwd_TextChanged);
            // 
            // txb_confirmpwd
            // 
            this.txb_confirmpwd.Location = new System.Drawing.Point(111, 120);
            this.txb_confirmpwd.Name = "txb_confirmpwd";
            this.txb_confirmpwd.PasswordChar = '*';
            this.txb_confirmpwd.Size = new System.Drawing.Size(187, 21);
            this.txb_confirmpwd.TabIndex = 5;
            this.txb_confirmpwd.TextChanged += new System.EventHandler(this.txb_confirmpwd_TextChanged);
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(30, 217);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(90, 30);
            this.btn_enter.TabIndex = 6;
            this.btn_enter.Text = "确认";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(208, 217);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(90, 30);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lab_error
            // 
            this.lab_error.AutoSize = true;
            this.lab_error.ForeColor = System.Drawing.Color.Red;
            this.lab_error.Location = new System.Drawing.Point(28, 172);
            this.lab_error.Name = "lab_error";
            this.lab_error.Size = new System.Drawing.Size(0, 12);
            this.lab_error.TabIndex = 8;
            // 
            // EditPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 275);
            this.Controls.Add(this.lab_error);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.txb_confirmpwd);
            this.Controls.Add(this.txb_newpwd);
            this.Controls.Add(this.txb_oldpwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPassword";
            this.Text = "密码修改";
            this.Load += new System.EventHandler(this.EditPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_oldpwd;
        private System.Windows.Forms.TextBox txb_newpwd;
        private System.Windows.Forms.TextBox txb_confirmpwd;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lab_error;
    }
}