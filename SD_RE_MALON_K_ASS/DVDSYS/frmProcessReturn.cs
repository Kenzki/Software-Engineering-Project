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
    public partial class frmProcessReturn : Form
    {
        frmMainMenu parent;
        public frmProcessReturn()
        {
            InitializeComponent();
        }

        public frmProcessReturn(frmMainMenu Parent)
        {
            InitializeComponent();

            parent = Parent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void button1_Click(object sender, EventArgs e)
        {
         
            //Save Data to Registerd DVD file

            {
                //Display Confirmation Message
                MessageBox.Show("DVD is Returned.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Reset UI
          
        }

       

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();

            parent.Show();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
          /*  Finish Off
           *  
           *  //For Register Date
            string d = DateTime.Now.ToString("d-MMM-yyyy");

            //Save Data to Registerd DVD file
            Rentals returnRentals = new Rentals();

            RegMem.setMember_id(Convert.ToInt32(txtMemId.Text));
            RegMem.setName(txtName.Text);
            RegMem.setEmail(txtEmail.Text);
            RegMem.setStreet(txtStreet.Text);
            RegMem.setTown(txtTown.Text);
            RegMem.setContact(Convert.ToInt32(txtContact.Text));
            RegMem.setStatus("A");
            RegMem.setRegDate(d);





            //Insert Rate record into Rate Table
            RegMem.setRegisterMember();*/
        }

        private void lblSlctMem_Click(object sender, EventArgs e)
        {

        }

        private void frmProcessReturn_Load(object sender, EventArgs e)
        {
            txtTransactionId.Text = Rentals.nextTransactionId().ToString("0000");

            
        }

        private void cboMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnSearchRental_Click(object sender, EventArgs e)
        {
            Rentals rentals = new Rentals();
            DataSet ds = new DataSet();
            grdSelectRental.DataSource =Rentals.getSearchRentIdbyName(ds, txtSearchName.Text.ToString().ToUpper()).Tables["ss"];
        }

        private void grdSelectRental_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //find Rental details
            Rentals selectRentals = new Rentals();

            selectRentals.getRentals(Convert.ToInt32(grdSelectRental.Rows[grdSelectRental.CurrentCell.RowIndex].Cells[0].Value));

            if (selectRentals.getRentalId().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //display Rentals Details
           

            txtRentId.Text = (Convert.ToInt32(grdSelectRental.Rows[grdSelectRental.CurrentCell.RowIndex].Cells[0].Value)).ToString();
            txtMemName.Text = grdSelectRental.Rows[grdSelectRental.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtMemberId.Text = (Convert.ToInt32(grdSelectRental.Rows[grdSelectRental.CurrentCell.RowIndex].Cells[2].Value)).ToString();


            

            txtSearchName.Text = "";
        }
    }
}
