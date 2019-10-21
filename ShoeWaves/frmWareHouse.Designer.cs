namespace Doann
{
    partial class frmWareHouse
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
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.imbDel = new System.Windows.Forms.PictureBox();
            this.imbAdd = new System.Windows.Forms.PictureBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.dgvWareHouse = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picWareHouse = new System.Windows.Forms.PictureBox();
            this.imbExit = new System.Windows.Forms.PictureBox();
            this.grbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWareHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWareHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInfo
            // 
            this.grbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.grbInfo.Controls.Add(this.imbDel);
            this.grbInfo.Controls.Add(this.imbAdd);
            this.grbInfo.Controls.Add(this.txtNote);
            this.grbInfo.Controls.Add(this.txtBrand);
            this.grbInfo.Controls.Add(this.txtSize);
            this.grbInfo.Controls.Add(this.txtPrice);
            this.grbInfo.Controls.Add(this.txtCode);
            this.grbInfo.Controls.Add(this.lblPrice);
            this.grbInfo.Controls.Add(this.lblCode);
            this.grbInfo.Controls.Add(this.lblNote);
            this.grbInfo.Controls.Add(this.lblBrand);
            this.grbInfo.Controls.Add(this.lblSize);
            this.grbInfo.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.grbInfo.Location = new System.Drawing.Point(16, 202);
            this.grbInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbInfo.Size = new System.Drawing.Size(404, 341);
            this.grbInfo.TabIndex = 8;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Nhập thông tin";
            // 
            // imbDel
            // 
            this.imbDel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbDel.Image = global::Doann.Properties.Resources.logo_34_1;
            this.imbDel.Location = new System.Drawing.Point(228, 274);
            this.imbDel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imbDel.Name = "imbDel";
            this.imbDel.Size = new System.Drawing.Size(102, 34);
            this.imbDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imbDel.TabIndex = 6;
            this.imbDel.TabStop = false;
            this.imbDel.Click += new System.EventHandler(this.ImbDel_Click);
            // 
            // imbAdd
            // 
            this.imbAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbAdd.Image = global::Doann.Properties.Resources.logo_35_;
            this.imbAdd.Location = new System.Drawing.Point(48, 274);
            this.imbAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imbAdd.Name = "imbAdd";
            this.imbAdd.Size = new System.Drawing.Size(102, 34);
            this.imbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imbAdd.TabIndex = 6;
            this.imbAdd.TabStop = false;
            this.imbAdd.Click += new System.EventHandler(this.ImbAdd_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(208, 220);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(187, 35);
            this.txtNote.TabIndex = 5;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(208, 91);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(187, 35);
            this.txtBrand.TabIndex = 5;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(208, 134);
            this.txtSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(187, 35);
            this.txtSize.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(208, 177);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(187, 35);
            this.txtPrice.TabIndex = 5;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(208, 48);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(187, 35);
            this.txtCode.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(29, 188);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 17);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Giá";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(29, 59);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(28, 17);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Mã";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(29, 231);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(62, 17);
            this.lblNote.TabIndex = 4;
            this.lblNote.Text = "Ghi Chú";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(29, 102);
            this.lblBrand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(45, 17);
            this.lblBrand.TabIndex = 4;
            this.lblBrand.Text = "Hãng";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(29, 145);
            this.lblSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(35, 17);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "Size";
            // 
            // dgvWareHouse
            // 
            this.dgvWareHouse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.dgvWareHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWareHouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvWareHouse.Location = new System.Drawing.Point(456, 48);
            this.dgvWareHouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvWareHouse.Name = "dgvWareHouse";
            this.dgvWareHouse.RowHeadersWidth = 51;
            this.dgvWareHouse.Size = new System.Drawing.Size(859, 495);
            this.dgvWareHouse.TabIndex = 10;
            this.dgvWareHouse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvWareHouse_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hãng";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Size";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày Nhập";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Ghi Chú";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // picWareHouse
            // 
            this.picWareHouse.Image = global::Doann.Properties.Resources.logo_19_;
            this.picWareHouse.Location = new System.Drawing.Point(16, 48);
            this.picWareHouse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picWareHouse.Name = "picWareHouse";
            this.picWareHouse.Size = new System.Drawing.Size(404, 116);
            this.picWareHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWareHouse.TabIndex = 2;
            this.picWareHouse.TabStop = false;
            // 
            // imbExit
            // 
            this.imbExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbExit.Image = global::Doann.Properties.Resources.logo_12_3;
            this.imbExit.Location = new System.Drawing.Point(1329, 1);
            this.imbExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imbExit.Name = "imbExit";
            this.imbExit.Size = new System.Drawing.Size(35, 35);
            this.imbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imbExit.TabIndex = 1;
            this.imbExit.TabStop = false;
            this.imbExit.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // frmWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1367, 599);
            this.ControlBox = false;
            this.Controls.Add(this.dgvWareHouse);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.picWareHouse);
            this.Controls.Add(this.imbExit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmWareHouse";
            this.Load += new System.EventHandler(this.FrmWareHouse_Load);
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWareHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWareHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox imbExit;
        private System.Windows.Forms.PictureBox picWareHouse;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.PictureBox imbDel;
        private System.Windows.Forms.PictureBox imbAdd;
        private System.Windows.Forms.DataGridView dgvWareHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}