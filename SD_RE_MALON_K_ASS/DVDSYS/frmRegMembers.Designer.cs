namespace DVDSYS
{
    partial class frmRegMembers
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.btnRegMem = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(28, 217);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(64, 13);
            this.lblContactNo.TabIndex = 1;
            this.lblContactNo.Text = "Contact No.";
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Location = new System.Drawing.Point(28, 41);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(59, 13);
            this.lblMemberId.TabIndex = 2;
            this.lblMemberId.Text = "Member ID";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(28, 153);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(35, 13);
            this.lblStreet.TabIndex = 3;
            this.lblStreet.Text = "Street";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(28, 118);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // txtMemId
            // 
            this.txtMemId.Enabled = false;
            this.txtMemId.Location = new System.Drawing.Point(103, 38);
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.Size = new System.Drawing.Size(37, 20);
            this.txtMemId.TabIndex = 6;
            this.txtMemId.Text = "011";
            // 
            // btnRegMem
            // 
            this.btnRegMem.Location = new System.Drawing.Point(79, 280);
            this.btnRegMem.Name = "btnRegMem";
            this.btnRegMem.Size = new System.Drawing.Size(75, 23);
            this.btnRegMem.TabIndex = 13;
            this.btnRegMem.Text = "Register";
            this.btnRegMem.UseVisualStyleBackColor = true;
            this.btnRegMem.Click += new System.EventHandler(this.btnRegMem_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(169, 280);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.Location = new System.Drawing.Point(28, 186);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(34, 13);
            this.lblTown.TabIndex = 15;
            this.lblTown.Text = "Town";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(103, 115);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(130, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(103, 153);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(130, 20);
            this.txtStreet.TabIndex = 20;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(103, 186);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(130, 20);
            this.txtTown.TabIndex = 21;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(103, 214);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(130, 20);
            this.txtContact.TabIndex = 22;
            this.txtContact.TextChanged += new System.EventHandler(this.txtContact_TextChanged_1);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(103, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 20);
            this.txtName.TabIndex = 23;
            // 
            // frmRegMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 374);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtTown);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTown);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegMem);
            this.Controls.Add(this.txtMemId);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblMemberId);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.lblName);
            this.Name = "frmRegMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Members";
            this.Load += new System.EventHandler(this.frmRegMembers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.Button btnRegMem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtName;
    }
}