namespace DVDSYS
{
    partial class frmSetRate
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
            this.lblRateCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.btnSetRate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtRateCode = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSetRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblRateCode
            // 
            this.lblRateCode.AutoSize = true;
            this.lblRateCode.Location = new System.Drawing.Point(12, 26);
            this.lblRateCode.Name = "lblRateCode";
            this.lblRateCode.Size = new System.Drawing.Size(58, 13);
            this.lblRateCode.TabIndex = 0;
            this.lblRateCode.Text = "Rate Code";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 62);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(12, 98);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(30, 13);
            this.lblRate.TabIndex = 2;
            this.lblRate.Text = "Rate";
            // 
            // btnSetRate
            // 
            this.btnSetRate.Location = new System.Drawing.Point(43, 149);
            this.btnSetRate.Name = "btnSetRate";
            this.btnSetRate.Size = new System.Drawing.Size(75, 23);
            this.btnSetRate.TabIndex = 7;
            this.btnSetRate.Text = "Set Rate";
            this.btnSetRate.UseVisualStyleBackColor = true;
            this.btnSetRate.Click += new System.EventHandler(this.btnSetRate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(142, 149);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtRateCode
            // 
            this.txtRateCode.Location = new System.Drawing.Point(96, 23);
            this.txtRateCode.Name = "txtRateCode";
            this.txtRateCode.Size = new System.Drawing.Size(121, 20);
            this.txtRateCode.TabIndex = 12;
            this.txtRateCode.TextChanged += new System.EventHandler(this.txtRateCode_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(96, 59);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(121, 20);
            this.txtDescription.TabIndex = 13;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtSetRate
            // 
            this.txtSetRate.Location = new System.Drawing.Point(96, 95);
            this.txtSetRate.Name = "txtSetRate";
            this.txtSetRate.Size = new System.Drawing.Size(121, 20);
            this.txtSetRate.TabIndex = 14;
            this.txtSetRate.TextChanged += new System.EventHandler(this.txtSetRate_TextChanged);
            // 
            // frmSetRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 202);
            this.Controls.Add(this.txtSetRate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtRateCode);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSetRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblRateCode);
            this.Name = "frmSetRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set DVD Rate";
            this.Load += new System.EventHandler(this.frmSetRate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRateCode;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnSetRate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtRateCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSetRate;
    }
}