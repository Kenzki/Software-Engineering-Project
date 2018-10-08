using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DVDSYS
{
    public partial class frmRegMembers : Form
    {
        frmMainMenu parent;
        public frmRegMembers()
        {
            InitializeComponent();
        }

        public frmRegMembers(frmMainMenu Parent)
        {
            InitializeComponent();

            parent = Parent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            parent.Show();
        }

        
        private void btnRegMem_Click(object sender, EventArgs e)
        {
            //Validate Data
            Regex validEmail = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
            Regex validContact = new Regex(@"\(?\d{3}\)?[-\.]? *\d{3}[-\.]? *[-\.]?\d{4}");

            if (txtName.Text.Equals("") || txtEmail.Text.Equals("") || txtStreet.Text.Equals("") || txtTown.Text.Equals("") || txtContact.Text.Equals(""))   {
                MessageBox.Show("All field must be entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();

                return;
            }

            else if (!validContact.IsMatch(txtContact.Text))
            {
                MessageBox.Show("Not a valid Contact");
                txtContact.Text = "";
                txtContact.Focus();
                return;

            }       
            
            else if (!validEmail.IsMatch(txtEmail.Text))
            {
                MessageBox.Show("Now a valid Email");
                txtEmail.Text = "";
                txtEmail.Focus();
                return;
            }

            else
            {
                //Display Confirmation Message
                MessageBox.Show("A new member has been registered.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




            //For Register Date
            string d = DateTime.Now.ToString("d-MMM-yyyy");

            //Save Data to Registerd DVD file
            Members RegMem = new Members();

            RegMem.setMember_id(Convert.ToInt32(txtMemId.Text));
            RegMem.setName(txtName.Text);
            RegMem.setEmail(txtEmail.Text);
            RegMem.setStreet(txtStreet.Text);
            RegMem.setTown(txtTown.Text);
            RegMem.setContact(Convert.ToInt32(txtContact.Text));
            RegMem.setStatus("A");
            RegMem.setRegDate(d);

           

            //Insert Rate record into Rate Table
            RegMem.setRegisterMember();

            
            //Reset UI
            txtMemId.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtStreet.Text = "";
            txtTown.Text = "";
            txtContact.Text = "";
            txtMemId.Text = Members.nextMemId().ToString("0000");


            txtName.Focus();


        }

     

        private void frmRegMembers_Load(object sender, EventArgs e)
        {
            txtMemId.Text = Members.nextMemId().ToString("0000");
        }

        private void txtContact_TextChanged_1(object sender, EventArgs e)
        {
            if (txtContact.Text.All(char.IsDigit))
            {

            }
            else
            {
                MessageBox.Show("Numbers Only");
            }
        }
    }
}
