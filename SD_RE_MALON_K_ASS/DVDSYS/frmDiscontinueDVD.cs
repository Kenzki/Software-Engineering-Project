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
    public partial class frmDiscontinueDVD : Form

    {
        frmMainMenu parent;
        public frmDiscontinueDVD()
        {
            InitializeComponent();
        }

        public frmDiscontinueDVD(frmMainMenu Parent)
        {
            InitializeComponent();

            parent = Parent;
        }

        private void btnDiscontinue_Click(object sender, EventArgs e)
        {
            if (txtDVDId.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDVDId.Focus();
                return;
            }


            DVD dvd = new DVD();

            dvd.setDVDId(Convert.ToInt32(grdDVD.Rows[grdDVD.CurrentCell.RowIndex].Cells[0].Value));
            dvd.setStatus(cbotxtStatus.Text);
            dvd.DiscontinueDVD();

            if (cbotxtStatus.Text == "A")
            {
                dvd.setStatus("A");
            }
            else
            {
                dvd.setStatus("NA");
            }

            //Display Confirmation Message
            MessageBox.Show(grdDVD.Rows[grdDVD.CurrentCell.RowIndex].Cells[1].Value + " status has been changed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtDVDId.Text = "";
            cbotxtStatus.Text = "";
            DataSet ds = new DataSet();
            grdDVD.DataSource = DVD.getDVD(ds).Tables["ss"];

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            parent.Show();
        }


        private void cbotxtStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmDiscontinueDVD_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            grdDVD.DataSource = DVD.getDVD(ds).Tables["ss"];

            grdDVD.AllowUserToAddRows = false;
        }

        private void grdDVD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //find DVD details
            DVD dicontinueDVD = new DVD();

            dicontinueDVD.getDVD(Convert.ToInt32(grdDVD.Rows[grdDVD.CurrentCell.RowIndex].Cells[0].Value));

            if (dicontinueDVD.getDVDId().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //display DVD Details
            txtDVDId.Text = (Convert.ToInt32(grdDVD.Rows[grdDVD.CurrentCell.RowIndex].Cells[0].Value)).ToString();
            cbotxtStatus.Text = grdDVD.Rows[grdDVD.CurrentCell.RowIndex].Cells[5].Value.ToString();
        }

        private void txtDVDId_TextChanged(object sender, EventArgs e)
        {

        }

        private void grdDVD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
