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
    public partial class frmRegDVD : Form
    {
        frmMainMenu parent;

        public frmRegDVD()
        {
            InitializeComponent();
        }

        public frmRegDVD(frmMainMenu Parent)
        {
            InitializeComponent();

            parent = Parent;
        }

        private void frmReg_DVD_Load(object sender, EventArgs e)
        {

            txtDVDId.Text = DVD.nextDVDId().ToString("0000");

        }

        private void lblDVDId_Click(object sender, EventArgs e)
        {

        }

        private void lblRate_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDVDTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblYearRelease_Click(object sender, EventArgs e)
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

        
        private void btnRegDVD_Click(object sender, EventArgs e)
        {
            //Validate Data
            if (txtDVDTitle.Text.Equals("") || txtDVDDescription.Text.Equals("") || txtDVDYearRelease.Text.Equals("") || txtRate.Text.Equals(""))
            {
                MessageBox.Show("All field must be entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDVDTitle.Focus();
               
                return;
            }

            //Validates Rate Code
            if (Rate.DVDRateCodeExists(txtRate.Text))
            {
                MessageBox.Show("Rate Code doesnt exist");
                return;
            }

            //Save Data to Registerd DVD file

            DVD myRegDVD = new DVD();

            myRegDVD.setDVDId(Convert.ToInt32(txtDVDId.Text));
            myRegDVD.setTitle(txtDVDTitle.Text);
            myRegDVD.setDescription(txtDVDDescription.Text);
            myRegDVD.setYear(Convert.ToInt32(txtDVDYearRelease.Text));
            myRegDVD.setRateCode(txtRate.Text);
            myRegDVD.setStatus("A");
            myRegDVD.setRentStatus("NR");

            //Insert DVD record into DVD Table
            myRegDVD.setRegisterDVD();


            {
                //Display Confirmation Message
                MessageBox.Show("DVD is Registered.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Reset UI
            txtDVDId.Text = "";      
            txtDVDTitle.Text = "";
            txtDVDDescription.Text = "";
            txtDVDYearRelease.Text = "";
            txtRate.Text = "";
            txtDVDId.Text = DVD.nextDVDId().ToString("0000");
            

            txtDVDTitle.Focus();

  
           
           
      


        }

        private void btnMnuBack_Click(object sender, EventArgs e)
        {
            this.Close();

            parent.Show();

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtDVDId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDVDDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbStatus_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
