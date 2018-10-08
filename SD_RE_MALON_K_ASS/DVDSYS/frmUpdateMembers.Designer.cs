namespace DVDSYS
{
    partial class frmUpdateMembers
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
            this.lblSelectMem = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cboMembers = new System.Windows.Forms.ComboBox();
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.lblMemId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grpMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelectMem
            // 
            this.lblSelectMem.AutoSize = true;
            this.lblSelectMem.Location = new System.Drawing.Point(51, 37);
            this.lblSelectMem.Name = "lblSelectMem";
            this.lblSelectMem.Size = new System.Drawing.Size(78, 13);
            this.lblSelectMem.TabIndex = 1;
            this.lblSelectMem.Text = "Select Member";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(144, 373);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(278, 373);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cboMembers
            // 
            this.cboMembers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMembers.FormattingEnabled = true;
            this.cboMembers.Location = new System.Drawing.Point(161, 34);
            this.cboMembers.Name = "cboMembers";
            this.cboMembers.Size = new System.Drawing.Size(192, 21);
            this.cboMembers.TabIndex = 9;
            this.cboMembers.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // grpMember
            // 
            this.grpMember.Controls.Add(this.txtMemId);
            this.grpMember.Controls.Add(this.lblMemId);
            this.grpMember.Controls.Add(this.txtName);
            this.grpMember.Controls.Add(this.txtContact);
            this.grpMember.Controls.Add(this.txtTown);
            this.grpMember.Controls.Add(this.txtStreet);
            this.grpMember.Controls.Add(this.txtEmail);
            this.grpMember.Controls.Add(this.lblTown);
            this.grpMember.Controls.Add(this.lblEmail);
            this.grpMember.Controls.Add(this.lblStreet);
            this.grpMember.Controls.Add(this.lblContact);
            this.grpMember.Controls.Add(this.lblName);
            this.grpMember.Location = new System.Drawing.Point(39, 92);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(411, 251);
            this.grpMember.TabIndex = 10;
            this.grpMember.TabStop = false;
            this.grpMember.Text = "Edit Member Details";
            // 
            // txtMemId
            // 
            this.txtMemId.Enabled = false;
            this.txtMemId.Location = new System.Drawing.Point(102, 39);
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.Size = new System.Drawing.Size(64, 20);
            this.txtMemId.TabIndex = 35;
            // 
            // lblMemId
            // 
            this.lblMemId.AutoSize = true;
            this.lblMemId.Location = new System.Drawing.Point(27, 42);
            this.lblMemId.Name = "lblMemId";
            this.lblMemId.Size = new System.Drawing.Size(59, 13);
            this.lblMemId.TabIndex = 34;
            this.lblMemId.Text = "Member ID";
            this.lblMemId.Click += new System.EventHandler(this.lblMemId_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 20);
            this.txtName.TabIndex = 33;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(102, 208);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(130, 20);
            this.txtContact.TabIndex = 32;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged);
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(102, 176);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(130, 20);
            this.txtTown.TabIndex = 31;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(102, 143);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(130, 20);
            this.txtStreet.TabIndex = 30;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(102, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(130, 20);
            this.txtEmail.TabIndex = 29;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(27, 176);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(34, 13);
            this.lblTown.TabIndex = 28;
            this.lblTown.Text = "Town";
            this.lblTown.Click += new System.EventHandler(this.lblTown_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(27, 108);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 27;
            this.lblEmail.Text = "Email";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(27, 143);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 26;
            this.lblStreet.Text = "Street";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(27, 211);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(64, 13);
            this.lblContact.TabIndex = 25;
            this.lblContact.Text = "Contact No.";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 24;
            this.lblName.Text = "Name";
            // 
            // frmUpdateMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 457);
            this.Controls.Add(this.grpMember);
            this.Controls.Add(this.cboMembers);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblSelectMem);
            this.Name = "frmUpdateMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Members";
            this.Load += new System.EventHandler(this.frmUpdateMembers_Load);
            this.grpMember.ResumeLayout(false);
            this.grpMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSelectMem;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cboMembers;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.Label lblMemId;
    }
}