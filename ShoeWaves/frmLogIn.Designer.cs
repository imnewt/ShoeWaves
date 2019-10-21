namespace Doann
{
    partial class frmLogIn
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.imbConfirm = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.imbExit = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imbConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(224, 97);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(40, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Tên";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(224, 129);
            this.lblPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(85, 20);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "Mật khẩu";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(331, 96);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(205, 22);
            this.txtUserName.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(331, 128);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(205, 22);
            this.txtPass.TabIndex = 3;
            // 
            // imbConfirm
            // 
            this.imbConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbConfirm.Image = global::Doann.Properties.Resources.logo_36_1;
            this.imbConfirm.Location = new System.Drawing.Point(404, 160);
            this.imbConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.imbConfirm.Name = "imbConfirm";
            this.imbConfirm.Size = new System.Drawing.Size(102, 34);
            this.imbConfirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imbConfirm.TabIndex = 6;
            this.imbConfirm.TabStop = false;
            this.imbConfirm.Click += new System.EventHandler(this.ImbConfirm_Click);
            // 
            // picLogin
            // 
            this.picLogin.Image = global::Doann.Properties.Resources.logo_31_1;
            this.picLogin.Location = new System.Drawing.Point(273, -10);
            this.picLogin.Margin = new System.Windows.Forms.Padding(4);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(208, 84);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogin.TabIndex = 5;
            this.picLogin.TabStop = false;
            // 
            // imbExit
            // 
            this.imbExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbExit.Image = global::Doann.Properties.Resources.logo_12_7;
            this.imbExit.Location = new System.Drawing.Point(589, 0);
            this.imbExit.Margin = new System.Windows.Forms.Padding(4);
            this.imbExit.Name = "imbExit";
            this.imbExit.Size = new System.Drawing.Size(38, 34);
            this.imbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imbExit.TabIndex = 4;
            this.imbExit.TabStop = false;
            this.imbExit.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Doann.Properties.Resources.imageedit_1_77781085782;
            this.picLogo.Location = new System.Drawing.Point(3, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(183, 164);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(629, 211);
            this.ControlBox = false;
            this.Controls.Add(this.imbConfirm);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.imbExit);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUserName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogIn";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.imbConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox imbExit;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.PictureBox imbConfirm;
    }
}