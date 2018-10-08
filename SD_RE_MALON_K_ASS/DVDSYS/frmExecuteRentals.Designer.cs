namespace DVDSYS
{
    partial class frmExecuteRentals
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
            this.btnDone = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnSearchDVD = new System.Windows.Forms.Button();
            this.btnSearchName = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.txtRentId = new System.Windows.Forms.TextBox();
            this.lblDVD = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRent = new System.Windows.Forms.Button();
            this.grpDVDRented = new System.Windows.Forms.GroupBox();
            this.txtTransactionId = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstRentDVD = new System.Windows.Forms.ListBox();
            this.lblSlctDVD = new System.Windows.Forms.Label();
            this.grpMemRent = new System.Windows.Forms.GroupBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtMemStatus = new System.Windows.Forms.TextBox();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.txtMemName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMemID = new System.Windows.Forms.Label();
            this.lblMemName = new System.Windows.Forms.Label();
            this.txtSearchDVDTitle = new System.Windows.Forms.TextBox();
            this.lblSlctMem = new System.Windows.Forms.Label();
            this.lblRentalId = new System.Windows.Forms.Label();
            this.grdSelectMembers = new System.Windows.Forms.DataGridView();
            this.grdSelectDVD = new System.Windows.Forms.DataGridView();
            this.lblTransactionId = new System.Windows.Forms.Label();
            this.grpDVDRented.SuspendLayout();
            this.grpMemRent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectDVD)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(177, 161);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 27;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(772, 527);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(109, 138);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 13);
            this.lblPrice.TabIndex = 59;
            this.lblPrice.Text = "Total Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(173, 135);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(79, 20);
            this.txtPrice.TabIndex = 58;
            this.txtPrice.Text = "0.00";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSearchDVD
            // 
            this.btnSearchDVD.Location = new System.Drawing.Point(675, 46);
            this.btnSearchDVD.Name = "btnSearchDVD";
            this.btnSearchDVD.Size = new System.Drawing.Size(75, 23);
            this.btnSearchDVD.TabIndex = 57;
            this.btnSearchDVD.Text = "Search";
            this.btnSearchDVD.UseVisualStyleBackColor = true;
            this.btnSearchDVD.Visible = false;
            this.btnSearchDVD.Click += new System.EventHandler(this.btnSearchDVD_Click);
            // 
            // btnSearchName
            // 
            this.btnSearchName.Location = new System.Drawing.Point(289, 49);
            this.btnSearchName.Name = "btnSearchName";
            this.btnSearchName.Size = new System.Drawing.Size(75, 23);
            this.btnSearchName.TabIndex = 56;
            this.btnSearchName.Text = "Search";
            this.btnSearchName.UseVisualStyleBackColor = true;
            this.btnSearchName.Click += new System.EventHandler(this.btnSearchName_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(172, 51);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchName.TabIndex = 55;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // txtRentId
            // 
            this.txtRentId.Enabled = false;
            this.txtRentId.Location = new System.Drawing.Point(172, 12);
            this.txtRentId.Name = "txtRentId";
            this.txtRentId.Size = new System.Drawing.Size(100, 20);
            this.txtRentId.TabIndex = 54;
            this.txtRentId.TextChanged += new System.EventHandler(this.txtRentId_TextChanged);
            // 
            // lblDVD
            // 
            this.lblDVD.AutoSize = true;
            this.lblDVD.Location = new System.Drawing.Point(469, 51);
            this.lblDVD.Name = "lblDVD";
            this.lblDVD.Size = new System.Drawing.Size(81, 13);
            this.lblDVD.TabIndex = 53;
            this.lblDVD.Text = "Enter DVD Title";
            this.lblDVD.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(83, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 13);
            this.lblName.TabIndex = 52;
            this.lblName.Text = "Enter Name";
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(824, 229);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(75, 23);
            this.btnRent.TabIndex = 49;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Visible = false;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // grpDVDRented
            // 
            this.grpDVDRented.Controls.Add(this.btnRemove);
            this.grpDVDRented.Controls.Add(this.txtPrice);
            this.grpDVDRented.Controls.Add(this.lblPrice);
            this.grpDVDRented.Controls.Add(this.lstRentDVD);
            this.grpDVDRented.Controls.Add(this.btnDone);
            this.grpDVDRented.Location = new System.Drawing.Point(472, 276);
            this.grpDVDRented.Name = "grpDVDRented";
            this.grpDVDRented.Size = new System.Drawing.Size(375, 215);
            this.grpDVDRented.TabIndex = 48;
            this.grpDVDRented.TabStop = false;
            this.grpDVDRented.Text = "DVDs Rented";
            this.grpDVDRented.Visible = false;
            // 
            // txtTransactionId
            // 
            this.txtTransactionId.Enabled = false;
            this.txtTransactionId.Location = new System.Drawing.Point(584, 501);
            this.txtTransactionId.Name = "txtTransactionId";
            this.txtTransactionId.Size = new System.Drawing.Size(75, 20);
            this.txtTransactionId.TabIndex = 62;
            this.txtTransactionId.Visible = false;
            this.txtTransactionId.TextChanged += new System.EventHandler(this.txtTransactionId_TextChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(284, 73);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(59, 23);
            this.btnRemove.TabIndex = 61;
            this.btnRemove.Text = "Rem";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstRentDVD
            // 
            this.lstRentDVD.FormattingEnabled = true;
            this.lstRentDVD.Location = new System.Drawing.Point(17, 34);
            this.lstRentDVD.Name = "lstRentDVD";
            this.lstRentDVD.Size = new System.Drawing.Size(261, 95);
            this.lstRentDVD.TabIndex = 60;
            this.lstRentDVD.SelectedIndexChanged += new System.EventHandler(this.lstRentDVD_SelectedIndexChanged);
            // 
            // lblSlctDVD
            // 
            this.lblSlctDVD.AutoSize = true;
            this.lblSlctDVD.Location = new System.Drawing.Point(469, 86);
            this.lblSlctDVD.Name = "lblSlctDVD";
            this.lblSlctDVD.Size = new System.Drawing.Size(101, 13);
            this.lblSlctDVD.TabIndex = 46;
            this.lblSlctDVD.Text = "Select DVD to Rent";
            this.lblSlctDVD.Visible = false;
            // 
            // grpMemRent
            // 
            this.grpMemRent.Controls.Add(this.txtContact);
            this.grpMemRent.Controls.Add(this.txtTown);
            this.grpMemRent.Controls.Add(this.lblContact);
            this.grpMemRent.Controls.Add(this.lblTown);
            this.grpMemRent.Controls.Add(this.txtMemStatus);
            this.grpMemRent.Controls.Add(this.txtMemId);
            this.grpMemRent.Controls.Add(this.txtMemName);
            this.grpMemRent.Controls.Add(this.lblStatus);
            this.grpMemRent.Controls.Add(this.lblMemID);
            this.grpMemRent.Controls.Add(this.lblMemName);
            this.grpMemRent.Location = new System.Drawing.Point(72, 276);
            this.grpMemRent.Name = "grpMemRent";
            this.grpMemRent.Size = new System.Drawing.Size(375, 215);
            this.grpMemRent.TabIndex = 45;
            this.grpMemRent.TabStop = false;
            this.grpMemRent.Text = "Member Details";
            this.grpMemRent.Visible = false;
            this.grpMemRent.Enter += new System.EventHandler(this.grpMemRent_Enter);
            // 
            // txtContact
            // 
            this.txtContact.Enabled = false;
            this.txtContact.Location = new System.Drawing.Point(80, 128);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(111, 20);
            this.txtContact.TabIndex = 45;
            // 
            // txtTown
            // 
            this.txtTown.Enabled = false;
            this.txtTown.Location = new System.Drawing.Point(80, 94);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(111, 20);
            this.txtTown.TabIndex = 44;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(19, 135);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(44, 13);
            this.lblContact.TabIndex = 43;
            this.lblContact.Text = "Contact";
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(17, 97);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(34, 13);
            this.lblTown.TabIndex = 42;
            this.lblTown.Text = "Town";
            // 
            // txtMemStatus
            // 
            this.txtMemStatus.Enabled = false;
            this.txtMemStatus.Location = new System.Drawing.Point(80, 161);
            this.txtMemStatus.Name = "txtMemStatus";
            this.txtMemStatus.Size = new System.Drawing.Size(111, 20);
            this.txtMemStatus.TabIndex = 41;
            // 
            // txtMemId
            // 
            this.txtMemId.Enabled = false;
            this.txtMemId.Location = new System.Drawing.Point(80, 31);
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.Size = new System.Drawing.Size(111, 20);
            this.txtMemId.TabIndex = 40;
            // 
            // txtMemName
            // 
            this.txtMemName.Enabled = false;
            this.txtMemName.Location = new System.Drawing.Point(80, 60);
            this.txtMemName.Name = "txtMemName";
            this.txtMemName.Size = new System.Drawing.Size(111, 20);
            this.txtMemName.TabIndex = 39;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(19, 166);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            // 
            // lblMemID
            // 
            this.lblMemID.AutoSize = true;
            this.lblMemID.Location = new System.Drawing.Point(17, 34);
            this.lblMemID.Name = "lblMemID";
            this.lblMemID.Size = new System.Drawing.Size(57, 13);
            this.lblMemID.TabIndex = 1;
            this.lblMemID.Text = "Member Id";
            // 
            // lblMemName
            // 
            this.lblMemName.AutoSize = true;
            this.lblMemName.Location = new System.Drawing.Point(17, 63);
            this.lblMemName.Name = "lblMemName";
            this.lblMemName.Size = new System.Drawing.Size(35, 13);
            this.lblMemName.TabIndex = 0;
            this.lblMemName.Text = "Name";
            this.lblMemName.Click += new System.EventHandler(this.lblMemName_Click);
            // 
            // txtSearchDVDTitle
            // 
            this.txtSearchDVDTitle.Location = new System.Drawing.Point(558, 48);
            this.txtSearchDVDTitle.Name = "txtSearchDVDTitle";
            this.txtSearchDVDTitle.Size = new System.Drawing.Size(100, 20);
            this.txtSearchDVDTitle.TabIndex = 41;
            this.txtSearchDVDTitle.Visible = false;
            this.txtSearchDVDTitle.TextChanged += new System.EventHandler(this.txtSearchDVDTitle_TextChanged);
            // 
            // lblSlctMem
            // 
            this.lblSlctMem.AutoSize = true;
            this.lblSlctMem.Location = new System.Drawing.Point(83, 86);
            this.lblSlctMem.Name = "lblSlctMem";
            this.lblSlctMem.Size = new System.Drawing.Size(78, 13);
            this.lblSlctMem.TabIndex = 40;
            this.lblSlctMem.Text = "Select Member";
            this.lblSlctMem.Visible = false;
            // 
            // lblRentalId
            // 
            this.lblRentalId.AutoSize = true;
            this.lblRentalId.Location = new System.Drawing.Point(83, 19);
            this.lblRentalId.Name = "lblRentalId";
            this.lblRentalId.Size = new System.Drawing.Size(52, 13);
            this.lblRentalId.TabIndex = 39;
            this.lblRentalId.Text = "Rental ID";
            // 
            // grdSelectMembers
            // 
            this.grdSelectMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSelectMembers.Location = new System.Drawing.Point(86, 102);
            this.grdSelectMembers.Name = "grdSelectMembers";
            this.grdSelectMembers.Size = new System.Drawing.Size(346, 150);
            this.grdSelectMembers.TabIndex = 58;
            this.grdSelectMembers.Visible = false;
            this.grdSelectMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSelectMember_CellClick);
            this.grdSelectMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSelectMembers_CellContentClick);
            // 
            // grdSelectDVD
            // 
            this.grdSelectDVD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSelectDVD.Location = new System.Drawing.Point(472, 102);
            this.grdSelectDVD.Name = "grdSelectDVD";
            this.grdSelectDVD.Size = new System.Drawing.Size(346, 150);
            this.grdSelectDVD.TabIndex = 59;
            this.grdSelectDVD.Visible = false;
            this.grdSelectDVD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSelectDVD_CellClick);
            this.grdSelectDVD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSelectDVD_CellContentClick);
            // 
            // lblTransactionId
            // 
            this.lblTransactionId.AutoSize = true;
            this.lblTransactionId.Location = new System.Drawing.Point(498, 504);
            this.lblTransactionId.Name = "lblTransactionId";
            this.lblTransactionId.Size = new System.Drawing.Size(75, 13);
            this.lblTransactionId.TabIndex = 63;
            this.lblTransactionId.Text = "Transaction Id";
            this.lblTransactionId.Visible = false;
            // 
            // frmExecuteRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 591);
            this.Controls.Add(this.lblTransactionId);
            this.Controls.Add(this.txtTransactionId);
            this.Controls.Add(this.grdSelectDVD);
            this.Controls.Add(this.grdSelectMembers);
            this.Controls.Add(this.btnSearchDVD);
            this.Controls.Add(this.btnSearchName);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.txtRentId);
            this.Controls.Add(this.lblDVD);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.grpDVDRented);
            this.Controls.Add(this.lblSlctDVD);
            this.Controls.Add(this.grpMemRent);
            this.Controls.Add(this.txtSearchDVDTitle);
            this.Controls.Add(this.lblSlctMem);
            this.Controls.Add(this.lblRentalId);
            this.Controls.Add(this.btnBack);
            this.Name = "frmExecuteRentals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Execute Rentals";
            this.Load += new System.EventHandler(this.frmExecuteRentals_Load);
            this.grpDVDRented.ResumeLayout(false);
            this.grpDVDRented.PerformLayout();
            this.grpMemRent.ResumeLayout(false);
            this.grpMemRent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSelectDVD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnSearchDVD;
        private System.Windows.Forms.Button btnSearchName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.TextBox txtRentId;
        private System.Windows.Forms.Label lblDVD;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.GroupBox grpDVDRented;
        private System.Windows.Forms.Label lblSlctDVD;
        private System.Windows.Forms.GroupBox grpMemRent;
        private System.Windows.Forms.TextBox txtMemStatus;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.TextBox txtMemName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblMemID;
        private System.Windows.Forms.Label lblMemName;
        private System.Windows.Forms.TextBox txtSearchDVDTitle;
        private System.Windows.Forms.Label lblSlctMem;
        private System.Windows.Forms.Label lblRentalId;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox lstRentDVD;
        private System.Windows.Forms.DataGridView grdSelectMembers;
        private System.Windows.Forms.DataGridView grdSelectDVD;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtTransactionId;
        private System.Windows.Forms.Label lblTransactionId;
    }
}