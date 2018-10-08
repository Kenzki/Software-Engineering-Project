namespace DVDSYS
{
    partial class frmRegDVD
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
            this.lblDVDId = new System.Windows.Forms.Label();
            this.txtDVDId = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblYearRelease = new System.Windows.Forms.Label();
            this.txtDVDTitle = new System.Windows.Forms.TextBox();
            this.txtDVDDescription = new System.Windows.Forms.TextBox();
            this.txtDVDYearRelease = new System.Windows.Forms.TextBox();
            this.btnRegDVD = new System.Windows.Forms.Button();
            this.btnMnuBack = new System.Windows.Forms.Button();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDVDId
            // 
            this.lblDVDId.AutoSize = true;
            this.lblDVDId.Location = new System.Drawing.Point(37, 37);
            this.lblDVDId.Name = "lblDVDId";
            this.lblDVDId.Size = new System.Drawing.Size(44, 13);
            this.lblDVDId.TabIndex = 0;
            this.lblDVDId.Text = "DVD ID";
            this.lblDVDId.Click += new System.EventHandler(this.lblDVDId_Click);
            // 
            // txtDVDId
            // 
            this.txtDVDId.Enabled = false;
            this.txtDVDId.Location = new System.Drawing.Point(125, 34);
            this.txtDVDId.Name = "txtDVDId";
            this.txtDVDId.Size = new System.Drawing.Size(54, 20);
            this.txtDVDId.TabIndex = 1;
            this.txtDVDId.TextChanged += new System.EventHandler(this.txtDVDId_TextChanged);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(37, 173);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(30, 13);
            this.lblRate.TabIndex = 2;
            this.lblRate.Text = "Rate";
            this.lblRate.Click += new System.EventHandler(this.lblRate_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(37, 72);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Title";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(37, 105);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // lblYearRelease
            // 
            this.lblYearRelease.AutoSize = true;
            this.lblYearRelease.Location = new System.Drawing.Point(37, 139);
            this.lblYearRelease.Name = "lblYearRelease";
            this.lblYearRelease.Size = new System.Drawing.Size(71, 13);
            this.lblYearRelease.TabIndex = 6;
            this.lblYearRelease.Text = "Year Release";
            this.lblYearRelease.Click += new System.EventHandler(this.lblYearRelease_Click);
            // 
            // txtDVDTitle
            // 
            this.txtDVDTitle.Location = new System.Drawing.Point(125, 69);
            this.txtDVDTitle.Name = "txtDVDTitle";
            this.txtDVDTitle.Size = new System.Drawing.Size(138, 20);
            this.txtDVDTitle.TabIndex = 7;
            this.txtDVDTitle.TextChanged += new System.EventHandler(this.txtDVDTitle_TextChanged);
            // 
            // txtDVDDescription
            // 
            this.txtDVDDescription.Location = new System.Drawing.Point(125, 98);
            this.txtDVDDescription.Name = "txtDVDDescription";
            this.txtDVDDescription.Size = new System.Drawing.Size(138, 20);
            this.txtDVDDescription.TabIndex = 8;
            this.txtDVDDescription.TextChanged += new System.EventHandler(this.txtDVDDescription_TextChanged);
            // 
            // txtDVDYearRelease
            // 
            this.txtDVDYearRelease.Location = new System.Drawing.Point(125, 136);
            this.txtDVDYearRelease.Name = "txtDVDYearRelease";
            this.txtDVDYearRelease.Size = new System.Drawing.Size(138, 20);
            this.txtDVDYearRelease.TabIndex = 9;
            this.txtDVDYearRelease.TextChanged += new System.EventHandler(this.txtDVDYearRelease_TextChanged);
            // 
            // btnRegDVD
            // 
            this.btnRegDVD.Location = new System.Drawing.Point(52, 228);
            this.btnRegDVD.Name = "btnRegDVD";
            this.btnRegDVD.Size = new System.Drawing.Size(75, 23);
            this.btnRegDVD.TabIndex = 12;
            this.btnRegDVD.Text = "Register";
            this.btnRegDVD.UseVisualStyleBackColor = true;
            this.btnRegDVD.Click += new System.EventHandler(this.btnRegDVD_Click);
            // 
            // btnMnuBack
            // 
            this.btnMnuBack.Location = new System.Drawing.Point(173, 228);
            this.btnMnuBack.Name = "btnMnuBack";
            this.btnMnuBack.Size = new System.Drawing.Size(75, 23);
            this.btnMnuBack.TabIndex = 13;
            this.btnMnuBack.Text = "Back";
            this.btnMnuBack.UseVisualStyleBackColor = true;
            this.btnMnuBack.Click += new System.EventHandler(this.btnMnuBack_Click);
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(125, 170);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(54, 20);
            this.txtRate.TabIndex = 18;
            // 
            // frmRegDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 291);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.btnMnuBack);
            this.Controls.Add(this.btnRegDVD);
            this.Controls.Add(this.txtDVDYearRelease);
            this.Controls.Add(this.txtDVDDescription);
            this.Controls.Add(this.txtDVDTitle);
            this.Controls.Add(this.lblYearRelease);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.txtDVDId);
            this.Controls.Add(this.lblDVDId);
            this.Name = "frmRegDVD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register DVD";
            this.Load += new System.EventHandler(this.frmReg_DVD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDVDId;
        private System.Windows.Forms.TextBox txtDVDId;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblYearRelease;
        private System.Windows.Forms.TextBox txtDVDTitle;
        private System.Windows.Forms.TextBox txtDVDDescription;
        private System.Windows.Forms.TextBox txtDVDYearRelease;
        private System.Windows.Forms.Button btnRegDVD;
        private System.Windows.Forms.Button btnMnuBack;
        private System.Windows.Forms.TextBox txtRate;
    }
}