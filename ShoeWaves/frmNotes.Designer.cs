namespace Doann
{
    partial class frmNotes
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
            this.picRules = new System.Windows.Forms.PictureBox();
            this.imbExit = new System.Windows.Forms.PictureBox();
            this.picRulesList = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRulesList)).BeginInit();
            this.SuspendLayout();
            // 
            // picRules
            // 
            this.picRules.Image = global::Doann.Properties.Resources.logo_26_;
            this.picRules.Location = new System.Drawing.Point(98, 12);
            this.picRules.Name = "picRules";
            this.picRules.Size = new System.Drawing.Size(301, 115);
            this.picRules.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picRules.TabIndex = 9;
            this.picRules.TabStop = false;
            // 
            // imbExit
            // 
            this.imbExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imbExit.Image = global::Doann.Properties.Resources.logo_12_5;
            this.imbExit.Location = new System.Drawing.Point(482, -1);
            this.imbExit.Name = "imbExit";
            this.imbExit.Size = new System.Drawing.Size(28, 27);
            this.imbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imbExit.TabIndex = 0;
            this.imbExit.TabStop = false;
            this.imbExit.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // picRulesList
            // 
            this.picRulesList.Image = global::Doann.Properties.Resources.logo_21_;
            this.picRulesList.Location = new System.Drawing.Point(119, 133);
            this.picRulesList.Name = "picRulesList";
            this.picRulesList.Size = new System.Drawing.Size(256, 255);
            this.picRulesList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRulesList.TabIndex = 0;
            this.picRulesList.TabStop = false;
            // 
            // frmNotes
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(510, 418);
            this.ControlBox = false;
            this.Controls.Add(this.picRules);
            this.Controls.Add(this.imbExit);
            this.Controls.Add(this.picRulesList);
            this.Name = "frmNotes";
            ((System.ComponentModel.ISupportInitialize)(this.picRules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRulesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picRulesList;
        private System.Windows.Forms.PictureBox imbExit;
        private System.Windows.Forms.PictureBox picRules;
    }
}