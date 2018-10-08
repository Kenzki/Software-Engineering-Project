using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DVDSYS
{
    public partial class frmMemberAnalysis : Form
    {

        frmMainMenu parent;

        public frmMemberAnalysis()
        {
            InitializeComponent();
        }

        public frmMemberAnalysis(frmMainMenu Parent)
        {
            InitializeComponent();

            parent = Parent;
        }


        private void frmDVDAnalysis_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            parent.Show();
        }

        public String getMonthName(int MonthNo)
        {
            string monthName = "";
            switch (MonthNo)
            {
                case 1:
                    monthName = "JAN";
                    break;
                case 2:
                    monthName = "FEB";
                    break;
                case 3:
                    monthName = "MAR";
                    break;
                case 4:
                    monthName = "APR";
                    break;
                case 5:
                    monthName = "MAY";
                    break;
                case 6:
                    monthName = "JUN";
                    break;
                case 7:
                    monthName = "JUL";
                    break;
                case 8:
                    monthName = "AUG";
                    break;
                case 9:
                    monthName = "SEP";
                    break;
                case 10:
                    monthName = "OCT";
                    break;
                case 11:
                    monthName = "NOV";
                    break;
                case 12:
                    monthName = "DEC";
                    break;
            }
            return monthName;
        }

     

        private void defineChart()
        {
            //define chart
            chtMemberAnalysis.Size = new Size(600, 400);
            chtMemberAnalysis.ChartAreas[0].Name = "mainArea";
            chtMemberAnalysis.ChartAreas["mainArea"].AxisX.LabelStyle.Font = new Font("Consolas", 8);
            chtMemberAnalysis.ChartAreas["mainArea"].AxisY.LabelStyle.Font = new Font("Consolas", 8);

            chtMemberAnalysis.ChartAreas["mainArea"].AxisY.Minimum = 0;
            chtMemberAnalysis.ChartAreas["mainArea"].AxisY.Interval = 5;
            chtMemberAnalysis.ChartAreas["mainArea"].AxisY.Title = "Number of Customers";

            chtMemberAnalysis.ChartAreas["mainArea"].AxisX.Interval = 1;
            chtMemberAnalysis.ChartAreas["mainArea"].AxisX.Title = "Month";

            chtMemberAnalysis.ChartAreas["mainArea"].AxisX.MajorGrid.Enabled = false;
            //chtData.ChartAreas["mainArea"].AxisY.MajorGrid.Enabled = false;



        }
        private void defineSeries()
        {
            chtMemberAnalysis.Series.Clear();
            chtMemberAnalysis.Series.Add("No. Customer");

            chtMemberAnalysis.Series["No. Customer"].ChartType = SeriesChartType.Column;
            chtMemberAnalysis.Series["No. Customer"].XValueType = ChartValueType.String;
        }

        private void fillChart(string year)
        {
            //fill chart
            chtMemberAnalysis.Series["No. Customer"].Points.Clear();

            //load values returned from query into 12 element array
            //decimal[] monthlyRev = { 0, 1200, 800, 1000, 1500, 1700, 2500, 2200, 1500, 1000, 500, 0 };

            //add values in array to chart series
            //for (int i = 0; i < 12; i++)
            //chtData.Series["Revenue"].Points.AddXY(monthName(i + 1), monthlyRev[i]);

            //get data from database
            DataSet ds = new DataSet();
            ds = Analysis.getMonthlyMember(ds, year);

            //add values in array to chart series
            int j = 0;
            for (int i = 1; i <= 12; i++)
            {
                if ((j == ds.Tables["ss"].Rows.Count) || (i < Convert.ToDecimal(ds.Tables[0].Rows[j][0])))
                    chtMemberAnalysis.Series["No. Customer"].Points.AddXY(getMonthName(i), 0);
                else
                {

                    chtMemberAnalysis.Series["No. Customer"].Points.AddXY(getMonthName(i), Convert.ToDecimal(ds.Tables[0].Rows[j][1]));
                    j++;
                }
            }

        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {
            //Chart Title
            lblYearRevenue.Text = "";
            lblYearRevenue.Text = cboYear.Text;
            lblYearRevenue.Visible = true;
            lblTitleMonthlyRevenue.Visible = true;



            //define chart
            defineChart();

            //Define the chart series
            defineSeries();

            //fill Chart
            fillChart(cboYear.Text);

            chtMemberAnalysis.Visible = true;
        }
    }
}
