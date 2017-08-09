namespace SmartPlugin.SmartUserControl
{
    partial class CarAuthorized
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_Refresh = new System.Windows.Forms.Label();
            this.lab_Add = new System.Windows.Forms.Label();
            this.lab_Edit = new System.Windows.Forms.Label();
            this.lab_StopUse = new System.Windows.Forms.Label();
            this.lab_RecoverUse = new System.Windows.Forms.Label();
            this.lab_Delete = new System.Windows.Forms.Label();
            this.lab_key = new System.Windows.Forms.Label();
            this.txb_CardSearchKey = new System.Windows.Forms.TextBox();
            this.lab_KeySearch = new System.Windows.Forms.Label();
            this.lab_CleanKey = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_SearchWay = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_OtherOption = new System.Windows.Forms.Button();
            this.dataGrid_CarInfo = new System.Windows.Forms.DataGridView();
            this.CardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisableDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_CarInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_Refresh
            // 
            this.lab_Refresh.AutoSize = true;
            this.lab_Refresh.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Refresh.Location = new System.Drawing.Point(15, 15);
            this.lab_Refresh.Name = "lab_Refresh";
            this.lab_Refresh.Size = new System.Drawing.Size(40, 16);
            this.lab_Refresh.TabIndex = 0;
            this.lab_Refresh.Text = "刷新";
            this.lab_Refresh.Click += new System.EventHandler(this.lab_Refresh_Click);
            // 
            // lab_Add
            // 
            this.lab_Add.AutoSize = true;
            this.lab_Add.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Add.Location = new System.Drawing.Point(78, 15);
            this.lab_Add.Name = "lab_Add";
            this.lab_Add.Size = new System.Drawing.Size(40, 16);
            this.lab_Add.TabIndex = 1;
            this.lab_Add.Text = "添加";
            this.lab_Add.Click += new System.EventHandler(this.lab_Add_Click);
            // 
            // lab_Edit
            // 
            this.lab_Edit.AutoSize = true;
            this.lab_Edit.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Edit.Location = new System.Drawing.Point(141, 15);
            this.lab_Edit.Name = "lab_Edit";
            this.lab_Edit.Size = new System.Drawing.Size(40, 16);
            this.lab_Edit.TabIndex = 2;
            this.lab_Edit.Text = "编辑";
            // 
            // lab_StopUse
            // 
            this.lab_StopUse.AutoSize = true;
            this.lab_StopUse.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_StopUse.Location = new System.Drawing.Point(207, 15);
            this.lab_StopUse.Name = "lab_StopUse";
            this.lab_StopUse.Size = new System.Drawing.Size(40, 16);
            this.lab_StopUse.TabIndex = 3;
            this.lab_StopUse.Text = "停用";
            // 
            // lab_RecoverUse
            // 
            this.lab_RecoverUse.AutoSize = true;
            this.lab_RecoverUse.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_RecoverUse.Location = new System.Drawing.Point(268, 15);
            this.lab_RecoverUse.Name = "lab_RecoverUse";
            this.lab_RecoverUse.Size = new System.Drawing.Size(72, 16);
            this.lab_RecoverUse.TabIndex = 4;
            this.lab_RecoverUse.Text = "恢复使用";
            // 
            // lab_Delete
            // 
            this.lab_Delete.AutoSize = true;
            this.lab_Delete.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_Delete.Location = new System.Drawing.Point(357, 15);
            this.lab_Delete.Name = "lab_Delete";
            this.lab_Delete.Size = new System.Drawing.Size(40, 16);
            this.lab_Delete.TabIndex = 5;
            this.lab_Delete.Text = "删除";
            this.lab_Delete.Click += new System.EventHandler(this.lab_Delete_Click);
            // 
            // lab_key
            // 
            this.lab_key.AutoSize = true;
            this.lab_key.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_key.Location = new System.Drawing.Point(463, 19);
            this.lab_key.Name = "lab_key";
            this.lab_key.Size = new System.Drawing.Size(56, 16);
            this.lab_key.TabIndex = 6;
            this.lab_key.Text = "关键字";
            // 
            // txb_CardSearchKey
            // 
            this.txb_CardSearchKey.Location = new System.Drawing.Point(525, 15);
            this.txb_CardSearchKey.Name = "txb_CardSearchKey";
            this.txb_CardSearchKey.Size = new System.Drawing.Size(122, 21);
            this.txb_CardSearchKey.TabIndex = 7;
            // 
            // lab_KeySearch
            // 
            this.lab_KeySearch.AutoSize = true;
            this.lab_KeySearch.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_KeySearch.Location = new System.Drawing.Point(663, 19);
            this.lab_KeySearch.Name = "lab_KeySearch";
            this.lab_KeySearch.Size = new System.Drawing.Size(40, 16);
            this.lab_KeySearch.TabIndex = 8;
            this.lab_KeySearch.Text = "搜索";
            // 
            // lab_CleanKey
            // 
            this.lab_CleanKey.AutoSize = true;
            this.lab_CleanKey.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lab_CleanKey.Location = new System.Drawing.Point(709, 19);
            this.lab_CleanKey.Name = "lab_CleanKey";
            this.lab_CleanKey.Size = new System.Drawing.Size(88, 16);
            this.lab_CleanKey.TabIndex = 9;
            this.lab_CleanKey.Text = "关键字清空";
            this.lab_CleanKey.Click += new System.EventHandler(this.lab_CleanKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "查询条件";
            // 
            // cmb_SearchWay
            // 
            this.cmb_SearchWay.FormattingEnabled = true;
            this.cmb_SearchWay.Items.AddRange(new object[] {
            "卡号",
            "持卡人",
            "车牌号"});
            this.cmb_SearchWay.Location = new System.Drawing.Point(81, 59);
            this.cmb_SearchWay.Name = "cmb_SearchWay";
            this.cmb_SearchWay.Size = new System.Drawing.Size(126, 20);
            this.cmb_SearchWay.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(213, 58);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 21);
            this.textBox2.TabIndex = 12;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(454, 56);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 13;
            this.btn_Search.Text = "查询";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // btn_OtherOption
            // 
            this.btn_OtherOption.Location = new System.Drawing.Point(788, 58);
            this.btn_OtherOption.Name = "btn_OtherOption";
            this.btn_OtherOption.Size = new System.Drawing.Size(75, 23);
            this.btn_OtherOption.TabIndex = 14;
            this.btn_OtherOption.Text = "高级设置";
            this.btn_OtherOption.UseVisualStyleBackColor = true;
            // 
            // dataGrid_CarInfo
            // 
            this.dataGrid_CarInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_CarInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CardID,
            this.CardUser,
            this.CarNum,
            this.CardStatus,
            this.UserType,
            this.Balance,
            this.AvailableDate,
            this.DisableDate});
            this.dataGrid_CarInfo.Location = new System.Drawing.Point(18, 85);
            this.dataGrid_CarInfo.Name = "dataGrid_CarInfo";
            this.dataGrid_CarInfo.RowTemplate.Height = 23;
            this.dataGrid_CarInfo.Size = new System.Drawing.Size(845, 462);
            this.dataGrid_CarInfo.TabIndex = 15;
            // 
            // CardID
            // 
            this.CardID.HeaderText = "卡号";
            this.CardID.Name = "CardID";
            // 
            // CardUser
            // 
            this.CardUser.HeaderText = "持卡人";
            this.CardUser.Name = "CardUser";
            // 
            // CarNum
            // 
            this.CarNum.HeaderText = "车牌号";
            this.CarNum.Name = "CarNum";
            // 
            // CardStatus
            // 
            this.CardStatus.HeaderText = "卡状态";
            this.CardStatus.Name = "CardStatus";
            // 
            // UserType
            // 
            this.UserType.HeaderText = "用户类型";
            this.UserType.Name = "UserType";
            // 
            // Balance
            // 
            this.Balance.HeaderText = "余额";
            this.Balance.Name = "Balance";
            // 
            // AvailableDate
            // 
            this.AvailableDate.HeaderText = "生效时间";
            this.AvailableDate.Name = "AvailableDate";
            // 
            // DisableDate
            // 
            this.DisableDate.HeaderText = "到期时间";
            this.DisableDate.Name = "DisableDate";
            // 
            // CarAuthorized
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGrid_CarInfo);
            this.Controls.Add(this.btn_OtherOption);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cmb_SearchWay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lab_CleanKey);
            this.Controls.Add(this.lab_KeySearch);
            this.Controls.Add(this.txb_CardSearchKey);
            this.Controls.Add(this.lab_key);
            this.Controls.Add(this.lab_Delete);
            this.Controls.Add(this.lab_RecoverUse);
            this.Controls.Add(this.lab_StopUse);
            this.Controls.Add(this.lab_Edit);
            this.Controls.Add(this.lab_Add);
            this.Controls.Add(this.lab_Refresh);
            this.Name = "CarAuthorized";
            this.Size = new System.Drawing.Size(880, 550);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_CarInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Refresh;
        private System.Windows.Forms.Label lab_Add;
        private System.Windows.Forms.Label lab_Edit;
        private System.Windows.Forms.Label lab_StopUse;
        private System.Windows.Forms.Label lab_RecoverUse;
        private System.Windows.Forms.Label lab_Delete;
        private System.Windows.Forms.Label lab_key;
        private System.Windows.Forms.TextBox txb_CardSearchKey;
        private System.Windows.Forms.Label lab_KeySearch;
        private System.Windows.Forms.Label lab_CleanKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_SearchWay;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_OtherOption;
        private System.Windows.Forms.DataGridView dataGrid_CarInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisableDate;
    }
}
