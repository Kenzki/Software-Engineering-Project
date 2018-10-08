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
    public partial class frmSetRate : Form

    {

        frmMainMenu parent;

        public frmSetRate()
        {
            InitializeComponent();
        }

        public frmSetRate(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmSetRate_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            parent.Show();
        }

        private void btnSetRate_Click(object sender, EventArgs e)
        {
            //Validate Data
            if (txtRateCode.Text.Equals("") || txtDescription.Text.Equals("") || txtSetRate.Text.Equals(""))
            {
                MessageBox.Show("All field must be entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRateCode.Focus();

                return;
            }

            //Validates Rate Code
            if (Rate.RateCodeExists(txtRateCode.Text))
            {
                MessageBox.Show("Rate Code has already been used");
                return;

            }
            

            //Save Data to Registerd DVD file
            //instantiate Rate Object
            Rate myRate = new Rate();
            myRate.setRateCode(txtRateCode.Text);
            myRate.setDescription(txtDescription.Text);
            myRate.setRate(Convert.ToDecimal(txtSetRate.Text));

            //Insert Rate record into Rate Table
            myRate.setRate();

            {
                //Display Confirmation Message
                MessageBox.Show("DVD set Rate.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Reset UI
            txtRateCode.Text = "";
            txtDescription.Text = "";
            txtSetRate.Text = "";
        }

        private void txtRateCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSetRate_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
