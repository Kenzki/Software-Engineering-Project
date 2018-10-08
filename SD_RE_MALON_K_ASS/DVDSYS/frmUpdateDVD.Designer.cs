namespace DVDSYS
{
    partial class frmUpdateDVD
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cboDVD = new System.Windows.Forms.ComboBox();
            this.grpDVD = new System.Windows.Forms.GroupBox();
            this.txtRateCode = new System.Windows.Forms.TextBox();
            this.txtDVDDescription = new System.Windows.Forms.TextBox();
            this.txtDVDTitle = new System.Windows.Forms.TextBox();
            this.txtDVDId = new System.Windows.Forms.TextBox();
            this.txtDVDYearRelease = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblYearRelease = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDVDId = new System.Windows.Forms.Label();
            this.grpDVD.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select DVD";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(119, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(266, 401);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cboDVD
            // 
            this.cboDVD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDVD.FormattingEnabled = true;
            this.cboDVD.Location = new System.Drawing.Point(91, 53);
            this.cboDVD.Name = "cboDVD";
            this.cboDVD.Size = new System.Drawing.Size(300, 21);
            this.cboDVD.TabIndex = 18;
            this.cboDVD.SelectedIndexChanged += new System.EventHandler(this.cboDVD_SelectedIndexChanged);
            // 
            // grpDVD
            // 
            this.grpDVD.Controls.Add(this.txtRateCode);
            this.grpDVD.Controls.Add(this.txtDVDDescription);
            this.grpDVD.Controls.Add(this.txtDVDTitle);
            this.grpDVD.Controls.Add(this.txtDVDId);
            this.grpDVD.Controls.Add(this.txtDVDYearRelease);
            this.grpDVD.Controls.Add(this.lblRate);
            this.grpDVD.Controls.Add(this.lblYearRelease);
            this.grpDVD.Controls.Add(this.lblDescription);
            this.grpDVD.Controls.Add(this.lblTitle);
            this.grpDVD.Controls.Add(this.lblDVDId);
            this.grpDVD.Location = new System.Drawing.Point(12, 134);
            this.grpDVD.Name = "grpDVD";
            this.grpDVD.Size = new System.Drawing.Size(434, 247);
            this.grpDVD.TabIndex = 19;
            this.grpDVD.TabStop = false;
            this.grpDVD.Text = "Edit DVD Details";
            this.grpDVD.Enter += new System.EventHandler(this.groupDVD_Enter);
            // 
            // txtRateCode
            // 
            this.txtRateCode.Location = new System.Drawing.Point(114, 176);
            this.txtRateCode.Name = "txtRateCode";
            this.txtRateCode.Size = new System.Drawing.Size(73, 20);
            this.txtRateCode.TabIndex = 16;
            this.txtRateCode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDVDDescription
            // 
            this.txtDVDDescription.Location = new System.Drawing.Point(114, 102);
            this.txtDVDDescription.Name = "txtDVDDescription";
            this.txtDVDDescription.Size = new System.Drawing.Size(252, 20);
            this.txtDVDDescription.TabIndex = 15;
            // 
            // txtDVDTitle
            // 
            this.txtDVDTitle.Location = new System.Drawing.Point(114, 69);
            this.txtDVDTitle.Name = "txtDVDTitle";
            this.txtDVDTitle.Size = new System.Drawing.Size(252, 20);
            this.txtDVDTitle.TabIndex = 14;
            // 
            // txtDVDId
            // 
            this.txtDVDId.Enabled = false;
            this.txtDVDId.Location = new System.Drawing.Point(114, 35);
            this.txtDVDId.Name = "txtDVDId";
            this.txtDVDId.Size = new System.Drawing.Size(58, 20);
            this.txtDVDId.TabIndex = 13;
            this.txtDVDId.TextChanged += new System.EventHandler(this.txtDVDId_TextChanged);
            // 
            // txtDVDYearRelease
            // 
            this.txtDVDYearRelease.Location = new System.Drawing.Point(114, 141);
            this.txtDVDYearRelease.Name = "txtDVDYearRelease";
            this.txtDVDYearRelease.Size = new System.Drawing.Size(73, 20);
            this.txtDVDYearRelease.TabIndex = 11;
            this.txtDVDYearRelease.TextChanged += new System.EventHandler(this.txtDVDYearRelease_TextChanged);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(17, 179);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(30, 13);
            this.lblRate.TabIndex = 8;
            this.lblRate.Text = "Rate";
            // 
            // lblYearRelease
            // 
            this.lblYearRelease.AutoSize = true;
            this.lblYearRelease.Location = new System.Drawing.Point(17, 144);
            this.lblYearRelease.Name = "lblYearRelease";
            this.lblYearRelease.Size = new System.Drawing.Size(71, 13);
            this.lblYearRelease.TabIndex = 7;
            this.lblYearRelease.Text = "Year Release";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(17, 105);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(17, 69);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Title:";
            // 
            // lblDVDId
            // 
            this.lblDVDId.AutoSize = true;
            this.lblDVDId.Enabled = false;
            this.lblDVDId.Location = new System.Drawing.Point(17, 38);
            this.lblDVDId.Name = "lblDVDId";
            this.lblDVDId.Size = new System.Drawing.Size(47, 13);
            this.lblDVDId.TabIndex = 0;
            this.lblDVDId.Text = "DVD ID:";
            // 
            // frmUpdateDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 475);
            this.Controls.Add(this.grpDVD);
            this.Controls.Add(this.cboDVD);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Name = "frmUpdateDVD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update DVD";
            this.Load += new System.EventHandler(this.frmUpdateDVD_Load);
            this.grpDVD.ResumeLayout(false);
            this.grpDVD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboDVD;
        private System.Windows.Forms.GroupBox grpDVD;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDVDId;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblYearRelease;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtDVDDescription;
        private System.Windows.Forms.TextBox txtDVDTitle;
        private System.Windows.Forms.TextBox txtDVDId;
        private System.Windows.Forms.TextBox txtDVDYearRelease;
        private System.Windows.Forms.TextBox txtRateCode;
    }
}