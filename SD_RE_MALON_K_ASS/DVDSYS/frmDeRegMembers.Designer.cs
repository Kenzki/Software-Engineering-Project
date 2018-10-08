namespace DVDSYS
{
    partial class frmDeRegMembers
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grdMember = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbotxtStatus = new System.Windows.Forms.ComboBox();
            this.txtMemId = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblIdSelected = new System.Windows.Forms.Label();
            this.lblSelectToDiscontinue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdMember)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(282, 423);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(398, 423);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grdMember
            // 
            this.grdMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMember.Location = new System.Drawing.Point(70, 65);
            this.grdMember.Name = "grdMember";
            this.grdMember.Size = new System.Drawing.Size(633, 205);
            this.grdMember.TabIndex = 28;
            this.grdMember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMember_CellClick);
            this.grdMember.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMember_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "D - Deactivate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "A - Available";
            // 
            // cbotxtStatus
            // 
            this.cbotxtStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbotxtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotxtStatus.FormattingEnabled = true;
            this.cbotxtStatus.Items.AddRange(new object[] {
            "A",
            "D"});
            this.cbotxtStatus.Location = new System.Drawing.Point(350, 346);
            this.cbotxtStatus.Name = "cbotxtStatus";
            this.cbotxtStatus.Size = new System.Drawing.Size(54, 21);
            this.cbotxtStatus.TabIndex = 25;
            this.cbotxtStatus.SelectedIndexChanged += new System.EventHandler(this.cbotxtStatus_SelectedIndexChanged);
            // 
            // txtMemId
            // 
            this.txtMemId.Enabled = false;
            this.txtMemId.Location = new System.Drawing.Point(350, 306);
            this.txtMemId.Name = "txtMemId";
            this.txtMemId.Size = new System.Drawing.Size(54, 20);
            this.txtMemId.TabIndex = 24;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(237, 346);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = "Status";
            // 
            // lblIdSelected
            // 
            this.lblIdSelected.AutoSize = true;
            this.lblIdSelected.Location = new System.Drawing.Point(237, 309);
            this.lblIdSelected.Name = "lblIdSelected";
            this.lblIdSelected.Size = new System.Drawing.Size(104, 13);
            this.lblIdSelected.TabIndex = 22;
            this.lblIdSelected.Text = "Member ID Selected";
            // 
            // lblSelectToDiscontinue
            // 
            this.lblSelectToDiscontinue.AutoSize = true;
            this.lblSelectToDiscontinue.Location = new System.Drawing.Point(67, 33);
            this.lblSelectToDiscontinue.Name = "lblSelectToDiscontinue";
            this.lblSelectToDiscontinue.Size = new System.Drawing.Size(144, 13);
            this.lblSelectToDiscontinue.TabIndex = 21;
            this.lblSelectToDiscontinue.Text = "Select Member to Dicontinue";
            // 
            // frmDeRegMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 497);
            this.Controls.Add(this.grdMember);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbotxtStatus);
            this.Controls.Add(this.txtMemId);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblIdSelected);
            this.Controls.Add(this.lblSelectToDiscontinue);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirm);
            this.Name = "frmDeRegMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "De-Register Members";
            this.Load += new System.EventHandler(this.frmDeRegMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView grdMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbotxtStatus;
        private System.Windows.Forms.TextBox txtMemId;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblIdSelected;
        private System.Windows.Forms.Label lblSelectToDiscontinue;
    }
}