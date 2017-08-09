namespace SmartAccessPlugin
{
    partial class SmartAccessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartAccessForm));
            this.panel_Video = new System.Windows.Forms.Panel();
            this.Pic_Video = new System.Windows.Forms.PictureBox();
            this.panel_Photo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_PutCardPicture = new System.Windows.Forms.Panel();
            this.Panel_TakePhoto = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_PutCardNotice = new System.Windows.Forms.Panel();
            this.lab_NoticeText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_Notice = new System.Windows.Forms.Label();
            this.lab_rfid = new System.Windows.Forms.Label();
            this.lab_Group = new System.Windows.Forms.Label();
            this.panel_Video.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Video)).BeginInit();
            this.panel_Photo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_PutCardPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_PutCardNotice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Video
            // 
            this.panel_Video.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel_Video.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_Video.Controls.Add(this.Pic_Video);
            this.panel_Video.Location = new System.Drawing.Point(13, 13);
            this.panel_Video.Name = "panel_Video";
            this.panel_Video.Size = new System.Drawing.Size(218, 176);
            this.panel_Video.TabIndex = 0;
            // 
            // Pic_Video
            // 
            this.Pic_Video.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pic_Video.BackgroundImage")));
            this.Pic_Video.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pic_Video.Location = new System.Drawing.Point(-1, 0);
            this.Pic_Video.Name = "Pic_Video";
            this.Pic_Video.Size = new System.Drawing.Size(216, 173);
            this.Pic_Video.TabIndex = 0;
            this.Pic_Video.TabStop = false;
            // 
            // panel_Photo
            // 
            this.panel_Photo.Controls.Add(this.pictureBox1);
            this.panel_Photo.Location = new System.Drawing.Point(13, 209);
            this.panel_Photo.Name = "panel_Photo";
            this.panel_Photo.Size = new System.Drawing.Size(218, 180);
            this.panel_Photo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 178);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_PutCardPicture
            // 
            this.panel_PutCardPicture.BackColor = System.Drawing.Color.Transparent;
            this.panel_PutCardPicture.Controls.Add(this.lab_Notice);
            this.panel_PutCardPicture.Controls.Add(this.Panel_TakePhoto);
            this.panel_PutCardPicture.Controls.Add(this.pictureBox2);
            this.panel_PutCardPicture.Location = new System.Drawing.Point(238, 13);
            this.panel_PutCardPicture.Name = "panel_PutCardPicture";
            this.panel_PutCardPicture.Size = new System.Drawing.Size(572, 176);
            this.panel_PutCardPicture.TabIndex = 2;
            // 
            // Panel_TakePhoto
            // 
            this.Panel_TakePhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_TakePhoto.BackgroundImage")));
            this.Panel_TakePhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Panel_TakePhoto.Location = new System.Drawing.Point(4, 133);
            this.Panel_TakePhoto.Name = "Panel_TakePhoto";
            this.Panel_TakePhoto.Size = new System.Drawing.Size(43, 42);
            this.Panel_TakePhoto.TabIndex = 1;
            this.Panel_TakePhoto.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_TakePhoto_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(201, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 151);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel_PutCardNotice
            // 
            this.panel_PutCardNotice.BackColor = System.Drawing.Color.Transparent;
            this.panel_PutCardNotice.Controls.Add(this.lab_Group);
            this.panel_PutCardNotice.Controls.Add(this.lab_rfid);
            this.panel_PutCardNotice.Controls.Add(this.lab_Name);
            this.panel_PutCardNotice.Controls.Add(this.lab_NoticeText);
            this.panel_PutCardNotice.Location = new System.Drawing.Point(238, 209);
            this.panel_PutCardNotice.Name = "panel_PutCardNotice";
            this.panel_PutCardNotice.Size = new System.Drawing.Size(572, 180);
            this.panel_PutCardNotice.TabIndex = 3;
            // 
            // lab_NoticeText
            // 
            this.lab_NoticeText.AutoSize = true;
            this.lab_NoticeText.Font = new System.Drawing.Font("KaiTi", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_NoticeText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lab_NoticeText.Location = new System.Drawing.Point(82, 77);
            this.lab_NoticeText.Name = "lab_NoticeText";
            this.lab_NoticeText.Size = new System.Drawing.Size(385, 35);
            this.lab_NoticeText.TabIndex = 0;
            this.lab_NoticeText.Text = "请刷身份证或按压手指";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(13, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 20);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(231, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 175);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(230, 209);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(8, 180);
            this.panel3.TabIndex = 1;
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Name.Location = new System.Drawing.Point(87, 80);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(73, 29);
            this.lab_Name.TabIndex = 1;
            this.lab_Name.Text = "甄川";
            this.lab_Name.Visible = false;
            // 
            // lab_Notice
            // 
            this.lab_Notice.AutoSize = true;
            this.lab_Notice.Font = new System.Drawing.Font("SimSun", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Notice.Location = new System.Drawing.Point(189, 78);
            this.lab_Notice.Name = "lab_Notice";
            this.lab_Notice.Size = new System.Drawing.Size(195, 35);
            this.lab_Notice.TabIndex = 2;
            this.lab_Notice.Text = "欢迎您请进";
            this.lab_Notice.Visible = false;
            // 
            // lab_rfid
            // 
            this.lab_rfid.AutoSize = true;
            this.lab_rfid.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_rfid.Location = new System.Drawing.Point(344, 80);
            this.lab_rfid.Name = "lab_rfid";
            this.lab_rfid.Size = new System.Drawing.Size(148, 29);
            this.lab_rfid.TabIndex = 2;
            this.lab_rfid.Text = "785412548";
            this.lab_rfid.Visible = false;
            // 
            // lab_Group
            // 
            this.lab_Group.AutoSize = true;
            this.lab_Group.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Group.Location = new System.Drawing.Point(194, 80);
            this.lab_Group.Name = "lab_Group";
            this.lab_Group.Size = new System.Drawing.Size(133, 29);
            this.lab_Group.TabIndex = 3;
            this.lab_Group.Text = "物业中心";
            this.lab_Group.Visible = false;
            // 
            // SmartAccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(822, 401);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_PutCardNotice);
            this.Controls.Add(this.panel_PutCardPicture);
            this.Controls.Add(this.panel_Photo);
            this.Controls.Add(this.panel_Video);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SmartAccessForm";
            this.Text = "认证合一";
            this.Load += new System.EventHandler(this.SmartAccessForm_Load);
            this.panel_Video.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Video)).EndInit();
            this.panel_Photo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_PutCardPicture.ResumeLayout(false);
            this.panel_PutCardPicture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_PutCardNotice.ResumeLayout(false);
            this.panel_PutCardNotice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Video;
        private System.Windows.Forms.Panel panel_Photo;
        private System.Windows.Forms.Panel panel_PutCardPicture;
        private System.Windows.Forms.Panel panel_PutCardNotice;
        private System.Windows.Forms.PictureBox Pic_Video;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lab_NoticeText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel Panel_TakePhoto;
        private System.Windows.Forms.Label lab_Notice;
        private System.Windows.Forms.Label lab_Group;
        private System.Windows.Forms.Label lab_rfid;
        private System.Windows.Forms.Label lab_Name;
    }
}

