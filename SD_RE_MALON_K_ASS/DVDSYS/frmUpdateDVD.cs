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
    public partial class frmUpdateDVD : Form
    {

        frmMainMenu parent;
        public frmUpdateDVD()
        {
            InitializeComponent();
        }

        public frmUpdateDVD(frmMainMenu Parent)
        {
            InitializeComponent();

            parent = Parent;
        }

        private void frmUpdateDVD_Load(object sender, EventArgs e)
        {
            //load combo with DVD ID and other details
            DataSet ds = new DataSet();
            ds = DVD.getDVD(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
                cboDVD.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][1].ToString());

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            parent.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Validate Data
            if (txtDVDId.Text.Equals("") || txtDVDTitle.Text.Equals("") || txtDVDDescription.Text.Equals("") || txtDVDYearRelease.Text.Equals("") || txtRateCode.Text.Equals(""))
            {
                MessageBox.Show("All field must be entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDVDId.Focus();

                return;
            }

            //instantiate Rate Object
            DVD myDVD = new DVD();

            myDVD.setDVDId(Convert.ToInt32(txtDVDId.Text));
            myDVD.setTitle(txtDVDTitle.Text);
            myDVD.setDescription(txtDVDDescription.Text);
            myDVD.setYear(Convert.ToInt32(txtDVDYearRelease.Text));
            myDVD.setRateCode(txtRateCode.Text);

            //INSERT DVD record into table
            myDVD.updDVD();

            //Display Confirmation Message
            MessageBox.Show("DVD has been Updated.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);



            //Reset UI
            grpDVD.Visible = false;

            cboDVD.SelectedIndex = -1;


        }

        private void cboDVD_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if resetting combo, ignore
            if(cboDVD.SelectedIndex == -1)
            {
                return;
            }

            //find DVD Details
            DVD updDVD = new DVD();
            updDVD.getDVD(Convert.ToInt32(cboDVD.Text.Substring(0, 3)));

            if (updDVD.getDVDId().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDVDId.Focus();
                return;
            }

            //display DVD details

            txtDVDId.Text = updDVD.getDVDId().ToString("000");
            txtDVDTitle.Text = updDVD.getTitle();
            txtDVDDescription.Text = updDVD.getDescription();
            txtDVDYearRelease.Text = updDVD.getYear().ToString();
            txtRateCode.Text = updDVD.getRateCode();

            //display details
            grpDVD.Visible = true;

        }

        private void groupDVD_Enter(object sender, EventArgs e)
        {

        }

        private void txtDVDId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDVDYearRelease_TextChanged(object sender, EventArgs e)
        {
            if (txtDVDYearRelease.Text.All(char.IsDigit))
            {

            }
            else
            {
                MessageBox.Show("Numbers Only");
            }
        }

        private void cboRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
