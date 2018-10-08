namespace DVDSYS
{
    partial class frmRentalAnalysis
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.chtRentalRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblYearRevenue = new System.Windows.Forms.Label();
            this.lblTitleMonthlyRevenue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtRentalRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(844, 582);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(295, 53);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // chtRentalRevenue
            // 
            chartArea1.Name = "ChartArea1";
            this.chtRentalRevenue.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtRentalRevenue.Legends.Add(legend1);
            this.chtRentalRevenue.Location = new System.Drawing.Point(214, 158);
            this.chtRentalRevenue.Name = "chtRentalRevenue";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtRentalRevenue.Series.Add(series1);
            this.chtRentalRevenue.Size = new System.Drawing.Size(705, 300);
            this.chtRentalRevenue.TabIndex = 4;
            this.chtRentalRevenue.Text = "chart1";
            this.chtRentalRevenue.Visible = false;
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Items.AddRange(new object[] {
            "17",
            "18",
            "19",
            "20"});
            this.cboYear.Location = new System.Drawing.Point(156, 55);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(121, 21);
            this.cboYear.TabIndex = 5;
            this.cboYear.SelectedIndexChanged += new System.EventHandler(this.cboYear_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(59, 58);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(68, 13);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Choose Year";
            // 
            // lblYearRevenue
            // 
            this.lblYearRevenue.AutoSize = true;
            this.lblYearRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblYearRevenue.Location = new System.Drawing.Point(557, 121);
            this.lblYearRevenue.Name = "lblYearRevenue";
            this.lblYearRevenue.Size = new System.Drawing.Size(89, 20);
            this.lblYearRevenue.TabIndex = 7;
            this.lblYearRevenue.Text = "Label Year";
            this.lblYearRevenue.Visible = false;
            this.lblYearRevenue.Click += new System.EventHandler(this.lblYearRevenue_Click);
            // 
            // lblTitleMonthlyRevenue
            // 
            this.lblTitleMonthlyRevenue.AutoSize = true;
            this.lblTitleMonthlyRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTitleMonthlyRevenue.Location = new System.Drawing.Point(426, 121);
            this.lblTitleMonthlyRevenue.Name = "lblTitleMonthlyRevenue";
            this.lblTitleMonthlyRevenue.Size = new System.Drawing.Size(137, 20);
            this.lblTitleMonthlyRevenue.TabIndex = 8;
            this.lblTitleMonthlyRevenue.Text = "Monthly Revenue";
            this.lblTitleMonthlyRevenue.Visible = false;
            // 
            // frmRentalAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 667);
            this.Controls.Add(this.lblTitleMonthlyRevenue);
            this.Controls.Add(this.lblYearRevenue);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.chtRentalRevenue);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Name = "frmRentalAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rental Analysis";
            this.Load += new System.EventHandler(this.frmRentalAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtRentalRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtRentalRevenue;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Label lblTitleMonthlyRevenue;
        private System.Windows.Forms.Label lblYearRevenue;
    }
}