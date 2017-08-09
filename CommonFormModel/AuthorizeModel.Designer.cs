namespace CommonFormModel
{
    partial class AuthorizeModel
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
            this.AuthorizeInfoGrid = new System.Windows.Forms.DataGridView();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.cmb_SearchWay = new System.Windows.Forms.ComboBox();
            this.txb_Key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Select = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AuthorizeInfoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AuthorizeInfoGrid
            // 
            this.AuthorizeInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuthorizeInfoGrid.Location = new System.Drawing.Point(12, 66);
            this.AuthorizeInfoGrid.Name = "AuthorizeInfoGrid";
            this.AuthorizeInfoGrid.RowTemplate.Height = 23;
            this.AuthorizeInfoGrid.Size = new System.Drawing.Size(548, 271);
            this.AuthorizeInfoGrid.TabIndex = 0;
            // 
            // btn_ADD
            // 
            this.btn_ADD.Location = new System.Drawing.Point(584, 66);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(100, 35);
            this.btn_ADD.TabIndex = 1;
            this.btn_ADD.Text = "添加授权";
            this.btn_ADD.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(584, 144);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(100, 35);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "删除授权";
            this.btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(584, 222);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(100, 35);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "编辑授权";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(584, 300);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(100, 35);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // cmb_SearchWay
            // 
            this.cmb_SearchWay.FormattingEnabled = true;
            this.cmb_SearchWay.Location = new System.Drawing.Point(99, 29);
            this.cmb_SearchWay.Name = "cmb_SearchWay";
            this.cmb_SearchWay.Size = new System.Drawing.Size(121, 20);
            this.cmb_SearchWay.TabIndex = 5;
            // 
            // txb_Key
            // 
            this.txb_Key.Location = new System.Drawing.Point(308, 28);
            this.txb_Key.Name = "txb_Key";
            this.txb_Key.Size = new System.Drawing.Size(100, 21);
            this.txb_Key.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "查询方式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "关键字";
            // 
            // btn_Select
            // 
            this.btn_Select.Location = new System.Drawing.Point(455, 23);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(100, 35);
            this.btn_Select.TabIndex = 9;
            this.btn_Select.Text = "查询授权";
            this.btn_Select.UseVisualStyleBackColor = true;
            // 
            // AuthorizeModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 349);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Key);
            this.Controls.Add(this.cmb_SearchWay);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_ADD);
            this.Controls.Add(this.AuthorizeInfoGrid);
            this.Name = "AuthorizeModel";
            this.Text = "授权管理";
            ((System.ComponentModel.ISupportInitialize)(this.AuthorizeInfoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AuthorizeInfoGrid;
        private System.Windows.Forms.Button btn_ADD;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ComboBox cmb_SearchWay;
        private System.Windows.Forms.TextBox txb_Key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Select;
    }
}

