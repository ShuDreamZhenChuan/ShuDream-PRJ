namespace CommonFormModel
{
    partial class InfoViewModel
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
            this.InfoListView = new System.Windows.Forms.DataGridView();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txb_SearchKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InfoListView)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoListView
            // 
            this.InfoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InfoListView.Location = new System.Drawing.Point(12, 49);
            this.InfoListView.Name = "InfoListView";
            this.InfoListView.RowTemplate.Height = 23;
            this.InfoListView.Size = new System.Drawing.Size(697, 336);
            this.InfoListView.TabIndex = 0;
            // 
            // btn_ADD
            // 
            this.btn_ADD.Location = new System.Drawing.Point(13, 405);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(100, 35);
            this.btn_ADD.TabIndex = 1;
            this.btn_ADD.Text = "添加";
            this.btn_ADD.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(211, 405);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(100, 35);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "编辑";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(409, 405);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 35);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(607, 405);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(100, 35);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // txb_SearchKey
            // 
            this.txb_SearchKey.Location = new System.Drawing.Point(91, 16);
            this.txb_SearchKey.Name = "txb_SearchKey";
            this.txb_SearchKey.Size = new System.Drawing.Size(136, 21);
            this.txb_SearchKey.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "关键字:";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(243, 8);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(100, 35);
            this.btn_Search.TabIndex = 7;
            this.btn_Search.Text = "查询";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // InfoViewModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_SearchKey);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_ADD);
            this.Controls.Add(this.InfoListView);
            this.Name = "InfoViewModel";
            this.Size = new System.Drawing.Size(730, 452);
            ((System.ComponentModel.ISupportInitialize)(this.InfoListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InfoListView;
        private System.Windows.Forms.Button btn_ADD;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txb_SearchKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Search;
    }
}