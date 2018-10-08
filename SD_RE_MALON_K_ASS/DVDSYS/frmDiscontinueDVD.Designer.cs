namespace DVDSYS
{
    partial class frmDiscontinueDVD
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
            this.btnDiscontinue = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSelectToDiscontinue = new System.Windows.Forms.Label();
            this.lblIdSelected = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtDVDId = new System.Windows.Forms.TextBox();
            this.cbotxtStatus = new System.Windows.Forms.ComboBox();
            this.lblAvail = new System.Windows.Forms.Label();
            this.lblNonAvail = new System.Windows.Forms.Label();
            this.grdDVD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdDVD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDiscontinue
            // 
            this.btnDiscontinue.Location = new System.Drawing.Point(340, 447);
            this.btnDiscontinue.Name = "btnDiscontinue";
            this.btnDiscontinue.Size = new System.Drawing.Size(75, 23);
            this.btnDiscontinue.TabIndex = 0;
            this.btnDiscontinue.Text = "Discontinue";
            this.btnDiscontinue.UseVisualStyleBackColor = true;
            this.btnDiscontinue.Click += new System.EventHandler(this.btnDiscontinue_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(470, 447);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSelectToDiscontinue
            // 
            this.lblSelectToDiscontinue.AutoSize = true;
            this.lblSelectToDiscontinue.Location = new System.Drawing.Point(83, 44);
            this.lblSelectToDiscontinue.Name = "lblSelectToDiscontinue";
            this.lblSelectToDiscontinue.Size = new System.Drawing.Size(129, 13);
            this.lblSelectToDiscontinue.TabIndex = 3;
            this.lblSelectToDiscontinue.Text = "Select DVD to Dicontinue";
            // 
            // lblIdSelected
            // 
            this.lblIdSelected.AutoSize = true;
            this.lblIdSelected.Location = new System.Drawing.Point(300, 330);
            this.lblIdSelected.Name = "lblIdSelected";
            this.lblIdSelected.Size = new System.Drawing.Size(89, 13);
            this.lblIdSelected.TabIndex = 4;
            this.lblIdSelected.Text = "DVD ID Selected";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(300, 367);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // txtDVDId
            // 
            this.txtDVDId.Enabled = false;
            this.txtDVDId.Location = new System.Drawing.Point(413, 327);
            this.txtDVDId.Name = "txtDVDId";
            this.txtDVDId.Size = new System.Drawing.Size(54, 20);
            this.txtDVDId.TabIndex = 7;
            this.txtDVDId.TextChanged += new System.EventHandler(this.txtDVDId_TextChanged);
            // 
            // cbotxtStatus
            // 
            this.cbotxtStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbotxtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotxtStatus.FormattingEnabled = true;
            this.cbotxtStatus.Items.AddRange(new object[] {
            "A",
            "NA"});
            this.cbotxtStatus.Location = new System.Drawing.Point(413, 367);
            this.cbotxtStatus.Name = "cbotxtStatus";
            this.cbotxtStatus.Size = new System.Drawing.Size(54, 21);
            this.cbotxtStatus.TabIndex = 17;
            this.cbotxtStatus.SelectedIndexChanged += new System.EventHandler(this.cbotxtStatus_SelectedIndexChanged);
            // 
            // lblAvail
            // 
            this.lblAvail.AutoSize = true;
            this.lblAvail.Location = new System.Drawing.Point(490, 370);
            this.lblAvail.Name = "lblAvail";
            this.lblAvail.Size = new System.Drawing.Size(66, 13);
            this.lblAvail.TabIndex = 18;
            this.lblAvail.Text = "A - Available";
            // 
            // lblNonAvail
            // 
            this.lblNonAvail.AutoSize = true;
            this.lblNonAvail.Location = new System.Drawing.Point(490, 400);
            this.lblNonAvail.Name = "lblNonAvail";
            this.lblNonAvail.Size = new System.Drawing.Size(94, 13);
            this.lblNonAvail.TabIndex = 19;
            this.lblNonAvail.Text = "NA - Not Available";
            // 
            // grdDVD
            // 
            this.grdDVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDVD.Location = new System.Drawing.Point(72, 78);
            this.grdDVD.Name = "grdDVD";
            this.grdDVD.Size = new System.Drawing.Size(746, 205);
            this.grdDVD.TabIndex = 20;
            this.grdDVD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDVD_CellClick);
            this.grdDVD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDVD_CellContentClick);
            // 
            // frmDiscontinueDVD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 544);
            this.Controls.Add(this.grdDVD);
            this.Controls.Add(this.lblNonAvail);
            this.Controls.Add(this.lblAvail);
            this.Controls.Add(this.cbotxtStatus);
            this.Controls.Add(this.txtDVDId);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblIdSelected);
            this.Controls.Add(this.lblSelectToDiscontinue);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDiscontinue);
            this.Name = "frmDiscontinueDVD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discontinue DVD";
            this.Load += new System.EventHandler(this.frmDiscontinueDVD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDVD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDiscontinue;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSelectToDiscontinue;
        private System.Windows.Forms.Label lblIdSelected;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtDVDId;
        private System.Windows.Forms.ComboBox cbotxtStatus;
        private System.Windows.Forms.Label lblAvail;
        private System.Windows.Forms.Label lblNonAvail;
        private System.Windows.Forms.DataGridView grdDVD;
    }
}