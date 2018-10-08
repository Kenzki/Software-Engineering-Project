namespace DVDSYS
{
    partial class frmMemberAnalysis
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitleMonthlyRevenue = new System.Windows.Forms.Label();
            this.lblYearRevenue = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.chtMemberAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtMemberAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(695, 576);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitleMonthlyRevenue
            // 
            this.lblTitleMonthlyRevenue.AutoSize = true;
            this.lblTitleMonthlyRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTitleMonthlyRevenue.Location = new System.Drawing.Point(426, 112);
            this.lblTitleMonthlyRevenue.Name = "lblTitleMonthlyRevenue";
            this.lblTitleMonthlyRevenue.Size = new System.Drawing.Size(142, 20);
            this.lblTitleMonthlyRevenue.TabIndex = 14;
            this.lblTitleMonthlyRevenue.Text = "Monthly Members";
            this.lblTitleMonthlyRevenue.Visible = false;
            // 
            // lblYearRevenue
            // 
            this.lblYearRevenue.AutoSize = true;
            this.lblYearRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblYearRevenue.Location = new System.Drawing.Point(565, 112);
            this.lblYearRevenue.Name = "lblYearRevenue";
            this.lblYearRevenue.Size = new System.Drawing.Size(89, 20);
            this.lblYearRevenue.TabIndex = 13;
            this.lblYearRevenue.Text = "Label Year";
            this.lblYearRevenue.Visible = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(59, 49);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(68, 13);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "Choose Year";
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "17",
            "18",
            "19",
            "20"});
            this.cboYear.Location = new System.Drawing.Point(156, 46);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(121, 21);
            this.cboYear.TabIndex = 11;
            // 
            // chtMemberAnalysis
            // 
            chartArea1.Name = "ChartArea1";
            this.chtMemberAnalysis.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtMemberAnalysis.Legends.Add(legend1);
            this.chtMemberAnalysis.Location = new System.Drawing.Point(214, 149);
            this.chtMemberAnalysis.Name = "chtMemberAnalysis";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtMemberAnalysis.Series.Add(series1);
            this.chtMemberAnalysis.Size = new System.Drawing.Size(705, 300);
            this.chtMemberAnalysis.TabIndex = 10;
            this.chtMemberAnalysis.Text = "chart1";
            this.chtMemberAnalysis.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(295, 44);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click_1);
            // 
            // frmMemberAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 682);
            this.Controls.Add(this.lblTitleMonthlyRevenue);
            this.Controls.Add(this.lblYearRevenue);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.chtMemberAnalysis);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Name = "frmMemberAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDVDAnalysis";
            this.Load += new System.EventHandler(this.frmDVDAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtMemberAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitleMonthlyRevenue;
        private System.Windows.Forms.Label lblYearRevenue;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtMemberAnalysis;
        private System.Windows.Forms.Button btnConfirm;
    }
}