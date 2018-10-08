using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDSYS
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void manageDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void setRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmSetRate setRate = new frmSetRate(this);
            setRate.Show();
          
        }
        private void registerDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmRegDVD regDVD = new frmRegDVD(this);
            regDVD.Show();
        }

        private void updateDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmUpdateDVD updateDVD = new frmUpdateDVD(this);
            updateDVD.Show();
        }

        private void discontinueDVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmDiscontinueDVD discontinueDVD = new frmDiscontinueDVD(this);
            discontinueDVD.Show();
        }

        private void registerMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmRegMembers regMembers = new frmRegMembers(this);
            regMembers.Show();
        }

        private void updateMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmUpdateMembers updateMembers = new frmUpdateMembers(this);
            updateMembers.Show();
        }

        private void deregistersMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmDeRegMembers deRegMembers = new frmDeRegMembers(this);
            deRegMembers.Show();
        }

        private void rentalProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmExecuteRentals executeRentals = new frmExecuteRentals(this);
            executeRentals.Show();
        }

        private void returnProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmProcessReturn processReturn = new frmProcessReturn(this);
            processReturn.Show();
        }

        private void rentalAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmRentalAnalysis rentalAnalysis = new frmRentalAnalysis(this);
            rentalAnalysis.Show();
        }

        private void dVDAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMemberAnalysis DVDAnalysis = new frmMemberAnalysis(this);
            DVDAnalysis.Show();

        }
    }
}
