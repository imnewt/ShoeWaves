namespace Doann
{
    partial class frmBillManageMent
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
            this.grbFindAndDelete = new System.Windows.Forms.GroupBox();
            this.imbDelete = new System.Windows.Forms.PictureBox();
            this.imbFind = new System.Windows.Forms.PictureBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.lblFBmhd = new System.Windows.Forms.Label();
            this.dgvBillManageMent = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imbExit = new System.Windows.Forms.PictureBox();
            this.picBillManagement = new System.Windows.Forms.PictureBox();
            this.grbFindAndDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imbDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillManageMent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBillManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // grbFindAndDelete
            // 
            this.grbFindAndDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.grbFindAndDelete.Controls.Add(this.imbDelete);
            this.grbFindAndDelete.Controls.Add(this.imbFind);
            this.grbFindAndDelete.Controls.Add(this.txtMaHoaDon);
            this.grbFindAndDelete.Controls.Add(this.lblFBmhd);
            this.grbFindAndDelete.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFindAndDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.grbFindAndDelete.Location = new System.Drawing.Point(22, 251);
            this.grbFindAndDelete.Margin = new System.Windows.Forms.Padding(4);
            this.grbFindAndDelete.Name = "grbFindAndDelete";
            this.grbFindAndDelete.Padding = new System.Windows.Forms.Padding(4);
            this.grbFindAndDelete.Size = new System.Drawing.Size(365, 202);
            this.grbFindAndDelete.TabIndex = 9;
            this.grbFindAndDelete.TabStop = false;
            this.grbFindAndDelete.Text = "Tìm Thông Tin";
            // 
            // imbDelete
            // 
            this.imbDelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbDelete.Image = global::Doann.Properties.Resources.logo_34_;
            this.imbDelete.Location = new System.Drawing.Point(217, 135);
            this.imbDelete.Margin = new System.Windows.Forms.Padding(4);
            this.imbDelete.Name = "imbDelete";
            this.imbDelete.Size = new System.Drawing.Size(102, 34);
            this.imbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imbDelete.TabIndex = 7;
            this.imbDelete.TabStop = false;
            this.imbDelete.Click += new System.EventHandler(this.ImbDelete_Click);
            // 
            // imbFind
            // 
            this.imbFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbFind.Image = global::Doann.Properties.Resources._72852402_555806741889499_108080717405093888_n;
            this.imbFind.Location = new System.Drawing.Point(39, 135);
            this.imbFind.Margin = new System.Windows.Forms.Padding(4);
            this.imbFind.Name = "imbFind";
            this.imbFind.Size = new System.Drawing.Size(102, 34);
            this.imbFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imbFind.TabIndex = 6;
            this.imbFind.TabStop = false;
            this.imbFind.Click += new System.EventHandler(this.ImbFind_Click);
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(198, 59);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(159, 35);
            this.txtMaHoaDon.TabIndex = 5;
            this.txtMaHoaDon.TextChanged += new System.EventHandler(this.TxtMaHoaDon_TextChanged);
            // 
            // lblFBmhd
            // 
            this.lblFBmhd.AutoSize = true;
            this.lblFBmhd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFBmhd.Location = new System.Drawing.Point(8, 71);
            this.lblFBmhd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFBmhd.Name = "lblFBmhd";
            this.lblFBmhd.Size = new System.Drawing.Size(160, 17);
            this.lblFBmhd.TabIndex = 4;
            this.lblFBmhd.Text = "Lọc Theo Mã Hóa Đơn";
            // 
            // dgvBillManageMent
            // 
            this.dgvBillManageMent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.dgvBillManageMent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillManageMent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column8});
            this.dgvBillManageMent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.dgvBillManageMent.Location = new System.Drawing.Point(428, 32);
            this.dgvBillManageMent.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBillManageMent.Name = "dgvBillManageMent";
            this.dgvBillManageMent.RowHeadersWidth = 51;
            this.dgvBillManageMent.Size = new System.Drawing.Size(1086, 436);
            this.dgvBillManageMent.TabIndex = 12;
            this.dgvBillManageMent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBillManageMent_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã HĐ";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên Khách Hàng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số Điện Thoại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 130;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Giày";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giá";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ngày Xuất";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Ghi Chú";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // imbExit
            // 
            this.imbExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbExit.Image = global::Doann.Properties.Resources.logo_12_4;
            this.imbExit.Location = new System.Drawing.Point(2, 0);
            this.imbExit.Margin = new System.Windows.Forms.Padding(4);
            this.imbExit.Name = "imbExit";
            this.imbExit.Size = new System.Drawing.Size(41, 33);
            this.imbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imbExit.TabIndex = 10;
            this.imbExit.TabStop = false;
            this.imbExit.Click += new System.EventHandler(this.ImbExit_Click);
            // 
            // picBillManagement
            // 
            this.picBillManagement.Image = global::Doann.Properties.Resources.logo_20_;
            this.picBillManagement.Location = new System.Drawing.Point(2, 74);
            this.picBillManagement.Margin = new System.Windows.Forms.Padding(4);
            this.picBillManagement.Name = "picBillManagement";
            this.picBillManagement.Size = new System.Drawing.Size(404, 107);
            this.picBillManagement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBillManagement.TabIndex = 10;
            this.picBillManagement.TabStop = false;
            // 
            // frmBillManageMent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1531, 510);
            this.ControlBox = false;
            this.Controls.Add(this.dgvBillManageMent);
            this.Controls.Add(this.imbExit);
            this.Controls.Add(this.picBillManagement);
            this.Controls.Add(this.grbFindAndDelete);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBillManageMent";
            this.Load += new System.EventHandler(this.FrmBillManageMent_Load);
            this.grbFindAndDelete.ResumeLayout(false);
            this.grbFindAndDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imbDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillManageMent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBillManagement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFindAndDelete;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label lblFBmhd;
        private System.Windows.Forms.PictureBox picBillManagement;
        private System.Windows.Forms.PictureBox imbExit;
        private System.Windows.Forms.DataGridView dgvBillManageMent;
        private System.Windows.Forms.PictureBox imbDelete;
        private System.Windows.Forms.PictureBox imbFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}