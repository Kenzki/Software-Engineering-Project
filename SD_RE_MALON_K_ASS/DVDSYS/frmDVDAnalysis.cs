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
    public partial class frmDVDAnalysis : Form
    {

        frmMainMenu parent;

        public frmDVDAnalysis()
        {
            InitializeComponent();
        }

        public frmDVDAnalysis(frmMainMenu Parent)
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
    }
}
