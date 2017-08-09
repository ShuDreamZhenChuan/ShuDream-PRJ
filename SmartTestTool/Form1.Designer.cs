namespace SmartTestTool
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txb_passcardnum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_passpastposition = new System.Windows.Forms.ComboBox();
            this.btn_passengerPast = new System.Windows.Forms.Button();
            this.btn_vehiclepast = new System.Windows.Forms.Button();
            this.cmb_vehiclepastposition = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_vehiclenum = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(292, 247);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_passengerPast);
            this.tabPage1.Controls.Add(this.cmb_passpastposition);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txb_passcardnum);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(284, 221);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "人员出入";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_vehiclepast);
            this.tabPage2.Controls.Add(this.cmb_vehiclepastposition);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txb_vehiclenum);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(284, 221);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "车辆出入";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txb_passcardnum
            // 
            this.txb_passcardnum.Location = new System.Drawing.Point(78, 28);
            this.txb_passcardnum.Name = "txb_passcardnum";
            this.txb_passcardnum.Size = new System.Drawing.Size(184, 21);
            this.txb_passcardnum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "证件号码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "出入位置";
            // 
            // cmb_passpastposition
            // 
            this.cmb_passpastposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_passpastposition.FormattingEnabled = true;
            this.cmb_passpastposition.Location = new System.Drawing.Point(79, 68);
            this.cmb_passpastposition.Name = "cmb_passpastposition";
            this.cmb_passpastposition.Size = new System.Drawing.Size(128, 20);
            this.cmb_passpastposition.TabIndex = 3;
            // 
            // btn_passengerPast
            // 
            this.btn_passengerPast.Location = new System.Drawing.Point(23, 133);
            this.btn_passengerPast.Name = "btn_passengerPast";
            this.btn_passengerPast.Size = new System.Drawing.Size(75, 23);
            this.btn_passengerPast.TabIndex = 4;
            this.btn_passengerPast.Text = "执行动作";
            this.btn_passengerPast.UseVisualStyleBackColor = true;
            this.btn_passengerPast.Click += new System.EventHandler(this.btn_passengerPast_Click);
            // 
            // btn_vehiclepast
            // 
            this.btn_vehiclepast.Location = new System.Drawing.Point(24, 151);
            this.btn_vehiclepast.Name = "btn_vehiclepast";
            this.btn_vehiclepast.Size = new System.Drawing.Size(75, 23);
            this.btn_vehiclepast.TabIndex = 9;
            this.btn_vehiclepast.Text = "执行动作";
            this.btn_vehiclepast.UseVisualStyleBackColor = true;
            this.btn_vehiclepast.Click += new System.EventHandler(this.btn_vehiclepast_Click);
            // 
            // cmb_vehiclepastposition
            // 
            this.cmb_vehiclepastposition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_vehiclepastposition.FormattingEnabled = true;
            this.cmb_vehiclepastposition.Location = new System.Drawing.Point(80, 86);
            this.cmb_vehiclepastposition.Name = "cmb_vehiclepastposition";
            this.cmb_vehiclepastposition.Size = new System.Drawing.Size(128, 20);
            this.cmb_vehiclepastposition.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "出入位置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "车牌号";
            // 
            // txb_vehiclenum
            // 
            this.txb_vehiclenum.Location = new System.Drawing.Point(79, 46);
            this.txb_vehiclenum.Name = "txb_vehiclenum";
            this.txb_vehiclenum.Size = new System.Drawing.Size(184, 21);
            this.txb_vehiclenum.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 271);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "出入管理模拟测试工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_passengerPast;
        private System.Windows.Forms.ComboBox cmb_passpastposition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_passcardnum;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_vehiclepast;
        private System.Windows.Forms.ComboBox cmb_vehiclepastposition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_vehiclenum;
    }
}

