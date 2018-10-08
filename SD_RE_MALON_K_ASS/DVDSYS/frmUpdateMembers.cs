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
    public partial class frmUpdateMembers : Form
    {
        frmMainMenu parent;
        public frmUpdateMembers()
        {
            InitializeComponent();
        }

        public frmUpdateMembers(frmMainMenu Parent)
        {
            InitializeComponent();

            parent = Parent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            parent.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //Validate Data
            Regex validEmail = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
            Regex validContact = new Regex(@"\(?\d{3}\)?[-\.]? *\d{3}[-\.]? *[-\.]?\d{4}");

            if (txtName.Text.Equals("") || txtEmail.Text.Equals("") || txtStreet.Text.Equals("") || txtTown.Text.Equals("") || txtContact.Text.Equals(""))
            {
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
                MessageBox.Show("Not a valid Email");
                txtEmail.Text = "";
                txtEmail.Focus();
                return;
            }

            else
            {
                //Display Confirmation Message
                MessageBox.Show("Member details has been updated.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

                //instantiate Member Object
                Members myMembers = new Members();

            myMembers.setMember_id(Convert.ToInt32(txtMemId.Text));
            myMembers.setName(txtName.Text);
            myMembers.setEmail(txtEmail.Text);
            myMembers.setStreet(txtStreet.Text);
            myMembers.setTown(txtTown.Text);
            myMembers.setContact(Convert.ToDouble(txtContact.Text));

            //INSERT Member record into table
            myMembers.updMembers();


            //Reset UI
            grpMember.Visible = false;

            cboMembers.SelectedIndex = -1;

        }

        private void frmUpdateMembers_Load(object sender, EventArgs e)
        {
            //load combo with Member ID and other details
            DataSet ds = new DataSet();
            ds = Members.getMembers(ds);

            for (int i = 0; i < ds.Tables["ss"].Rows.Count; i++)
               cboMembers.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " + ds.Tables[0].Rows[i][1].ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if resetting combo, ignore
            if (cboMembers.SelectedIndex == -1)
            {
                return;
            }

            //find Member Details
            Members updMembers = new Members();
            updMembers.getMember(Convert.ToInt32(cboMembers.Text.Substring(0, 3)));

            if (updMembers.getMemId().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemId.Focus();
                return;
            }

            //display Member details
           
            txtMemId.Text = updMembers.getMemId().ToString("000");
            txtName.Text = updMembers.getName();
            txtEmail.Text = updMembers.getEmail();
            txtStreet.Text = updMembers.getStreet();
            txtTown.Text = updMembers.getTown();
            txtContact.Text = updMembers.getContact().ToString();

            //display details
            grpMember.Visible = true;
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            if (txtContact.Text.All(char.IsDigit))
            {

            }
            else
            {
                MessageBox.Show("Numbers Only");
            }
        }

        private void lblTown_Click(object sender, EventArgs e)
        {

        }

        private void lblMemId_Click(object sender, EventArgs e)
        {

        }
    }
}
