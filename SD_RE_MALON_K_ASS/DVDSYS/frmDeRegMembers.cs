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
    public partial class frmDeRegMembers : Form
    {
        frmMainMenu parent;
        public frmDeRegMembers()
        {
            InitializeComponent();
        }

        public frmDeRegMembers(frmMainMenu Parent)
        {
            InitializeComponent();

            parent = Parent;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

            parent.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtMemId.Text.Equals(""))
            {
                MessageBox.Show("Field Must Not Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemId.Focus();
                return;
            }


            Members members = new Members();

            members.setMember_id(Convert.ToInt32(grdMember.Rows[grdMember.CurrentCell.RowIndex].Cells[0].Value));
            members.setStatus(cbotxtStatus.Text);
            members.DeRegMem();

            if (cbotxtStatus.Text == "A")
            {
                members.setStatus("A");
            }
            else
            {
                members.setStatus("D");
            }

            //Display Confirmation Message
            MessageBox.Show(grdMember.Rows[grdMember.CurrentCell.RowIndex].Cells[1].Value + " status has been changed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtMemId.Text = "";
            cbotxtStatus.Text = "";
            DataSet ds = new DataSet();
            grdMember.DataSource = Members.getMembers(ds).Tables["ss"];

        }

        private void frmDeRegMembers_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            grdMember.DataSource = Members.getMembers(ds).Tables["ss"];

            grdMember.AllowUserToAddRows = false;
        }

        private void grdMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //find Member details
            Members deRegMem = new Members();

            deRegMem.getMember(Convert.ToInt32(grdMember.Rows[grdMember.CurrentCell.RowIndex].Cells[0].Value));

            if (deRegMem.getMemId().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            //display Member Details
            txtMemId.Text = (Convert.ToInt32(grdMember.Rows[grdMember.CurrentCell.RowIndex].Cells[0].Value)).ToString();
            cbotxtStatus.Text = grdMember.Rows[grdMember.CurrentCell.RowIndex].Cells[5].Value.ToString();
        }

        private void grdMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbotxtStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
