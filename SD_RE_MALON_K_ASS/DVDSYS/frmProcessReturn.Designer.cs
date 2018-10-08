namespace DVDSYS
{
    partial class frmProcessReturn
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpRentalDetails = new System.Windows.Forms.GroupBox();
            this.txtMemName = new System.Windows.Forms.TextBox();
            this.txtRentId = new System.Windows.Forms.TextBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.txtOverDueFee = new System.Windows.Forms.TextBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblRentalId = new System.Windows.Forms.Label();
            this.lblMemId = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblOverDuePay = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTransactionId = new System.Windows.Forms.Label();
            this.txtTransactionId = new System.Windows.Forms.TextBox();
            this.grdSelectRental = new System.Windows.Forms.DataGridView();
            this.btnSearchRental = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.lblSelectMem = new System.Windows.Forms.Label();
            this.lblSlctRental = new System.Windows.Forms.Label();
            this.grpRentalDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectRental)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRentalDetails
            // 
            this.grpRentalDetails.Controls.Add(this.txtMemName);
            this.grpRentalDetails.Controls.Add(this.txtRentId);
            this.grpRentalDetails.Controls.Add(this.txtMemberId);
            this.grpRentalDetails.Controls.Add(this.txtOverDueFee);
            this.grpRentalDetails.Controls.Add(this.lblMemberName);
            this.grpRentalDetails.Controls.Add(this.lblRentalId);
            this.grpRentalDetails.Controls.Add(this.lblMemId);
            this.grpRentalDetails.Controls.Add(this.btnConfirm);
            this.grpRentalDetails.Controls.Add(this.lblOverDuePay);
            this.grpRentalDetails.Location = new System.Drawing.Point(117, 329);
            this.grpRentalDetails.Name = "grpRentalDetails";
            this.grpRentalDetails.Size = new System.Drawing.Size(356, 190);
            this.grpRentalDetails.TabIndex = 23;
            this.grpRentalDetails.TabStop = false;
            this.grpRentalDetails.Text = "Rental Details";
            // 
            // txtMemName
            // 
            this.txtMemName.Enabled = false;
            this.txtMemName.Location = new System.Drawing.Point(121, 30);
            this.txtMemName.Name = "txtMemName";
            this.txtMemName.Size = new System.Drawing.Size(100, 20);
            this.txtMemName.TabIndex = 65;
            // 
            // txtRentId
            // 
            this.txtRentId.Enabled = false;
            this.txtRentId.Location = new System.Drawing.Point(121, 96);
            this.txtRentId.Name = "txtRentId";
            this.txtRentId.Size = new System.Drawing.Size(100, 20);
            this.txtRentId.TabIndex = 66;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Enabled = false;
            this.txtMemberId.Location = new System.Drawing.Point(121, 60);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(100, 20);
            this.txtMemberId.TabIndex = 68;
            // 
            // txtOverDueFee
            // 
            this.txtOverDueFee.Enabled = false;
            this.txtOverDueFee.Location = new System.Drawing.Point(121, 129);
            this.txtOverDueFee.Name = "txtOverDueFee";
            this.txtOverDueFee.Size = new System.Drawing.Size(100, 20);
            this.txtOverDueFee.TabIndex = 69;
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Location = new System.Drawing.Point(25, 32);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(76, 13);
            this.lblMemberName.TabIndex = 64;
            this.lblMemberName.Text = "Member Name";
            // 
            // lblRentalId
            // 
            this.lblRentalId.AutoSize = true;
            this.lblRentalId.Location = new System.Drawing.Point(25, 99);
            this.lblRentalId.Name = "lblRentalId";
            this.lblRentalId.Size = new System.Drawing.Size(50, 13);
            this.lblRentalId.TabIndex = 65;
            this.lblRentalId.Text = "Rental Id";
            // 
            // lblMemId
            // 
            this.lblMemId.AutoSize = true;
            this.lblMemId.Location = new System.Drawing.Point(25, 63);
            this.lblMemId.Name = "lblMemId";
            this.lblMemId.Size = new System.Drawing.Size(57, 13);
            this.lblMemId.TabIndex = 67;
            this.lblMemId.Text = "Member Id";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(243, 127);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 28;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblOverDuePay
            // 
            this.lblOverDuePay.AutoSize = true;
            this.lblOverDuePay.Location = new System.Drawing.Point(25, 132);
            this.lblOverDuePay.Name = "lblOverDuePay";
            this.lblOverDuePay.Size = new System.Drawing.Size(71, 13);
            this.lblOverDuePay.TabIndex = 68;
            this.lblOverDuePay.Text = "OverDue Fee";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(448, 550);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // lblTransactionId
            // 
            this.lblTransactionId.AutoSize = true;
            this.lblTransactionId.Location = new System.Drawing.Point(114, 48);
            this.lblTransactionId.Name = "lblTransactionId";
            this.lblTransactionId.Size = new System.Drawing.Size(75, 13);
            this.lblTransactionId.TabIndex = 30;
            this.lblTransactionId.Text = "Transaction Id";
            // 
            // txtTransactionId
            // 
            this.txtTransactionId.Enabled = false;
            this.txtTransactionId.Location = new System.Drawing.Point(203, 45);
            this.txtTransactionId.Name = "txtTransactionId";
            this.txtTransactionId.Size = new System.Drawing.Size(100, 20);
            this.txtTransactionId.TabIndex = 31;
            // 
            // grdSelectRental
            // 
            this.grdSelectRental.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSelectRental.Location = new System.Drawing.Point(117, 142);
            this.grdSelectRental.Name = "grdSelectRental";
            this.grdSelectRental.Size = new System.Drawing.Size(346, 150);
            this.grdSelectRental.TabIndex = 63;
            this.grdSelectRental.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSelectRental_CellClick);
            // 
            // btnSearchRental
            // 
            this.btnSearchRental.Location = new System.Drawing.Point(320, 89);
            this.btnSearchRental.Name = "btnSearchRental";
            this.btnSearchRental.Size = new System.Drawing.Size(75, 23);
            this.btnSearchRental.TabIndex = 62;
            this.btnSearchRental.Text = "Search";
            this.btnSearchRental.UseVisualStyleBackColor = true;
            this.btnSearchRental.Click += new System.EventHandler(this.btnSearchRental_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(203, 91);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchName.TabIndex = 61;
            // 
            // lblSelectMem
            // 
            this.lblSelectMem.AutoSize = true;
            this.lblSelectMem.Location = new System.Drawing.Point(114, 94);
            this.lblSelectMem.Name = "lblSelectMem";
            this.lblSelectMem.Size = new System.Drawing.Size(63, 13);
            this.lblSelectMem.TabIndex = 60;
            this.lblSelectMem.Text = "Enter Name";
            // 
            // lblSlctRental
            // 
            this.lblSlctRental.AutoSize = true;
            this.lblSlctRental.Location = new System.Drawing.Point(114, 126);
            this.lblSlctRental.Name = "lblSlctRental";
            this.lblSlctRental.Size = new System.Drawing.Size(71, 13);
            this.lblSlctRental.TabIndex = 59;
            this.lblSlctRental.Text = "Select Rental";
            this.lblSlctRental.Visible = false;
            // 
            // frmProcessReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 621);
            this.Controls.Add(this.grdSelectRental);
            this.Controls.Add(this.btnSearchRental);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.lblSelectMem);
            this.Controls.Add(this.lblSlctRental);
            this.Controls.Add(this.txtTransactionId);
            this.Controls.Add(this.lblTransactionId);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.grpRentalDetails);
            this.Name = "frmProcessReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process Return";
            this.Load += new System.EventHandler(this.frmProcessReturn_Load);
            this.grpRentalDetails.ResumeLayout(false);
            this.grpRentalDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectRental)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpRentalDetails;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTransactionId;
        private System.Windows.Forms.TextBox txtTransactionId;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblRentalId;
        private System.Windows.Forms.Label lblMemId;
        private System.Windows.Forms.Label lblOverDuePay;
        private System.Windows.Forms.TextBox txtMemName;
        private System.Windows.Forms.TextBox txtRentId;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.TextBox txtOverDueFee;
        private System.Windows.Forms.DataGridView grdSelectRental;
        private System.Windows.Forms.Button btnSearchRental;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lblSelectMem;
        private System.Windows.Forms.Label lblSlctRental;
    }
}