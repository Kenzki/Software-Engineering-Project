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
    public partial class frmExecuteRentals : Form
    {
        frmMainMenu parent;
        public frmExecuteRentals()
        {
            InitializeComponent();
        }

        public frmExecuteRentals(frmMainMenu Parent)
        {
            InitializeComponent();

            parent = Parent;
        }

   

      
    
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            parent.Show();
        }

        private void frmExecuteRentals_Load(object sender, EventArgs e)
        {
            txtRentId.Text = Rentals.nextRentalId().ToString("0000");

            txtTransactionId.Text = Rentals.nextTransactionId().ToString("0000");

        }



        private void btnRent_Click(object sender, EventArgs e)
        {
            //find DVD details
            DVD selectDVD = new DVD();
           

            selectDVD.getDVD(Convert.ToInt32(grdSelectDVD.Rows[grdSelectDVD.CurrentCell.RowIndex].Cells[0].Value));


            if (selectDVD.getDVDId().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            for (int i = 0; i < grdSelectDVD.SelectedRows.Count; i++)
            {
                //display DVD Details

                //Font f = new Font("monospace",10);
                //listBoxRentDVD.Font = f;

            

                lstRentDVD.Items.Add(grdSelectDVD.CurrentRow.Cells[0].Value.ToString() + " " + String.Format("{0:00.00}", grdSelectDVD.CurrentRow.Cells[4].Value) + " " + grdSelectDVD.CurrentRow.Cells[1].Value.ToString().PadRight(50));

                txtPrice.Text = (Convert.ToDecimal(txtPrice.Text) + (Convert.ToDecimal(String.Format("{0:00.00}", grdSelectDVD.CurrentRow.Cells[4].Value)))).ToString();
               
                //+ (Convert.ToDecimal(String.Format("{0:00.00}", grdSelectDVD.CurrentRow.Cells[3].Value)))).ToString();

            }


            grpDVDRented.Visible = true;
            txtSearchDVDTitle.Text = "";
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            Members members = new Members();
            DataSet ds = new DataSet();
            grdSelectMembers.DataSource = Members.getSearchName(ds, txtSearchName.Text.ToString().ToUpper()).Tables["ss"];


            grdSelectMembers.AllowUserToAddRows = false;
            grdSelectMembers.Visible = true;
            lblSlctMem.Visible = true;

        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchDVDTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchDVD_Click(object sender, EventArgs e)
        {
            DVD title = new DVD();
            DataSet ds = new DataSet();
            grdSelectDVD.DataSource = DVD.getSearchDVD(ds, txtSearchDVDTitle.Text.ToString().ToUpper()).Tables["ss"];


            grdSelectDVD.AllowUserToAddRows = false;
            lblSlctDVD.Visible = true;
            grdSelectDVD.Visible = true;
            btnRent.Visible = true;
        }

        private void grdSelectMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //find Member details
            Members selectMem = new Members();

            selectMem.getMember(Convert.ToInt32(grdSelectMembers.Rows[grdSelectMembers.CurrentCell.RowIndex].Cells[0].Value));

            if (selectMem.getMemId().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //display Member Details
            txtMemId.Text = (Convert.ToInt32(grdSelectMembers.Rows[grdSelectMembers.CurrentCell.RowIndex].Cells[0].Value)).ToString();
            txtMemName.Text = grdSelectMembers.Rows[grdSelectMembers.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtTown.Text = grdSelectMembers.Rows[grdSelectMembers.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtContact.Text = grdSelectMembers.Rows[grdSelectMembers.CurrentCell.RowIndex].Cells[5].Value.ToString();
            txtMemStatus.Text = grdSelectMembers.Rows[grdSelectMembers.CurrentCell.RowIndex].Cells[6].Value.ToString();

            grpMemRent.Visible = true;
            lblDVD.Visible = true;
            txtSearchDVDTitle.Visible = true;
            btnSearchDVD.Visible = true;
            txtSearchName.Text = "";

        }

        private void grdSelectMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblMemName_Click(object sender, EventArgs e)
        {

        }

        private void grdSelectDVD_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void btnRemove_Click(object sender, EventArgs e)

        {

            double total = 0;

            for (int i = lstRentDVD.SelectedIndices.Count - 1; i >= 0; i--)
            {
                lstRentDVD.Items.RemoveAt(lstRentDVD.SelectedIndices[i]);


            }
                      
            txtPrice.Text = (Convert.ToDecimal(txtPrice.Text) - (Convert.ToDecimal(String.Format("{0:00.00}", grdSelectDVD.CurrentRow.Cells[4].Value)))).ToString();
            total -= (Convert.ToDouble(txtPrice.Text));
        }

        private void grdSelectDVD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lstRentDVD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grpMemRent_Enter(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //Validate Data
            if (txtRentId.Text.Equals("") || txtMemId.Equals(""))
            {
                MessageBox.Show("All field must be entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSearchName.Focus();

                return;
            }

            string sd = DateTime.Now.ToString("d-MMM-yyyy");

            string dd = DateTime.Now.AddDays(7).ToString("d-MMM-yyyy");

            //Save Data to Rental file
            Rentals regExecute = new Rentals();

            //Change Rent Status into DVD Table
            DVD rentDVDStatus = new DVD();
            //Save Data to Transaction File
            Rentals regTransaction = new Rentals();

            regExecute.setRentalId(Convert.ToInt32(txtRentId.Text));
            regExecute.setName(txtMemName.Text);
            regExecute.setMemberId(Convert.ToInt32(txtMemId.Text));
            regExecute.setRentDate(sd);
            regExecute.setDueDate(dd);

    
      
            regTransaction.setTransactionId(Convert.ToInt32(txtTransactionId.Text));
            regTransaction.setMemberId(Convert.ToInt32(txtMemId.Text));
            regTransaction.setRentalId(Convert.ToInt32(txtRentId.Text));
            regTransaction.setTransactionType("Payment");
            regTransaction.setTransactionDate(sd);
            regTransaction.setTransactionAmount(Convert.ToDecimal(txtPrice.Text));


            //Insert Rental record into Rentals Table
            regExecute.setRentals();

            //Insert Transaction record into Transaction Table
            regTransaction.setTransaction();

            DVD dvdStatus = new DVD();

            dvdStatus.setDVDId(Convert.ToInt32(grdSelectDVD.Rows[grdSelectDVD.CurrentCell.RowIndex].Cells[0].Value));
            
            dvdStatus.setRentStatus(grdSelectDVD.Rows[grdSelectDVD.CurrentCell.RowIndex].Cells[2].Value.ToString());
 
            dvdStatus.setRentStatus("R");

            dvdStatus.ChangeRentDVD();

            {
                //Display Confirmation Message
                MessageBox.Show("Rental is Executed.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            txtSearchName.Text = "";
            txtSearchDVDTitle.Text = "";
            txtRentId.Text = "";

            

            txtTransactionId.Text = Rentals.nextTransactionId().ToString("0000");

            txtRentId.Text = Rentals.nextRentalId().ToString("0000");


        }

        private void txtTransactionId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRentId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
