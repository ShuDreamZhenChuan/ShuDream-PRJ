﻿namespace SmartPlugin
{
    partial class EditDeviceForm
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
            this.lab3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_DeviceName = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.cmb_DevicePosition = new System.Windows.Forms.ComboBox();
            this.txb_DeviceCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_addr_part1 = new System.Windows.Forms.TextBox();
            this.txb_addr_part2 = new System.Windows.Forms.TextBox();
            this.txb_addr_part3 = new System.Windows.Forms.TextBox();
            this.txb_addr_part4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Location = new System.Drawing.Point(21, 41);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(35, 12);
            this.lab3.TabIndex = 3;
            this.lab3.Text = "名称:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "位置:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "通信地址(IP):";
            // 
            // txb_DeviceName
            // 
            this.txb_DeviceName.Location = new System.Drawing.Point(60, 38);
            this.txb_DeviceName.Name = "txb_DeviceName";
            this.txb_DeviceName.Size = new System.Drawing.Size(100, 21);
            this.txb_DeviceName.TabIndex = 8;
            // 
            // btn_OK
            // 
            this.btn_OK.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_OK.Location = new System.Drawing.Point(60, 188);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(82, 27);
            this.btn_OK.TabIndex = 11;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Cancel.Location = new System.Drawing.Point(260, 188);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(82, 27);
            this.btn_Cancel.TabIndex = 12;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // cmb_DevicePosition
            // 
            this.cmb_DevicePosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_DevicePosition.FormattingEnabled = true;
            this.cmb_DevicePosition.Location = new System.Drawing.Point(60, 78);
            this.cmb_DevicePosition.Name = "cmb_DevicePosition";
            this.cmb_DevicePosition.Size = new System.Drawing.Size(100, 20);
            this.cmb_DevicePosition.TabIndex = 14;
            // 
            // txb_DeviceCode
            // 
            this.txb_DeviceCode.Location = new System.Drawing.Point(242, 38);
            this.txb_DeviceCode.Name = "txb_DeviceCode";
            this.txb_DeviceCode.Size = new System.Drawing.Size(122, 21);
            this.txb_DeviceCode.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "序列号";
            // 
            // txb_addr_part1
            // 
            this.txb_addr_part1.Location = new System.Drawing.Point(97, 121);
            this.txb_addr_part1.MaxLength = 3;
            this.txb_addr_part1.Name = "txb_addr_part1";
            this.txb_addr_part1.Size = new System.Drawing.Size(50, 21);
            this.txb_addr_part1.TabIndex = 17;
            // 
            // txb_addr_part2
            // 
            this.txb_addr_part2.Location = new System.Drawing.Point(162, 121);
            this.txb_addr_part2.MaxLength = 3;
            this.txb_addr_part2.Name = "txb_addr_part2";
            this.txb_addr_part2.Size = new System.Drawing.Size(50, 21);
            this.txb_addr_part2.TabIndex = 18;
            // 
            // txb_addr_part3
            // 
            this.txb_addr_part3.Location = new System.Drawing.Point(227, 121);
            this.txb_addr_part3.MaxLength = 3;
            this.txb_addr_part3.Name = "txb_addr_part3";
            this.txb_addr_part3.Size = new System.Drawing.Size(50, 21);
            this.txb_addr_part3.TabIndex = 19;
            // 
            // txb_addr_part4
            // 
            this.txb_addr_part4.Location = new System.Drawing.Point(292, 121);
            this.txb_addr_part4.MaxLength = 3;
            this.txb_addr_part4.Name = "txb_addr_part4";
            this.txb_addr_part4.Size = new System.Drawing.Size(50, 21);
            this.txb_addr_part4.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 22;
            this.label4.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = ".";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(166, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 12);
            this.label16.TabIndex = 36;
            this.label16.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(367, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 37;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(166, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 38;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(348, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 39;
            this.label10.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(381, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 12);
            this.label17.TabIndex = 41;
            this.label17.Text = "必填项";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(370, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 40;
            this.label11.Text = "*";
            // 
            // EditDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 238);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_addr_part4);
            this.Controls.Add(this.txb_addr_part3);
            this.Controls.Add(this.txb_addr_part2);
            this.Controls.Add(this.txb_addr_part1);
            this.Controls.Add(this.txb_DeviceCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_DevicePosition);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.txb_DeviceName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lab3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDeviceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑设备";
            this.Load += new System.EventHandler(this.EditDeviceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_DeviceName;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ComboBox cmb_DevicePosition;
        private System.Windows.Forms.TextBox txb_DeviceCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_addr_part1;
        private System.Windows.Forms.TextBox txb_addr_part2;
        private System.Windows.Forms.TextBox txb_addr_part3;
        private System.Windows.Forms.TextBox txb_addr_part4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
    }
}