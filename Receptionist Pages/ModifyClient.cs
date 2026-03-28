using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Booking_Management_System.Receptionist_Pages
{
    public partial class ModifyClient : Form
    {
        public ModifyClient()
        {
            InitializeComponent();
        }

        private void ModifyClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'the_Luxe_ServerDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.the_Luxe_ServerDataSet.Client);

        }

        private void clientDGV_DoubleClick(object sender, EventArgs e)
        {

        }

        private void clientDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clientDGV.CurrentRow != null)
            {
                nameTXB.Text = clientDGV.CurrentRow.Cells[1].Value.ToString();
                surnameTXB.Text = clientDGV.CurrentRow.Cells[2].Value.ToString();
                emailTXB.Text = clientDGV.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void searchTXB_TextChanged(object sender, EventArgs e)
        {
            clientTableAdapter.FillByName(the_Luxe_ServerDataSet.Client, searchTXB.Text);
        }

        private void modifyBTN_Click(object sender, EventArgs e)
        {
            if (ValidClientDetails())
            {
                int clientID = Convert.ToInt32(clientDGV.CurrentRow.Cells[0].Value.ToString());

                clientTableAdapter.UpdateClientDetails(nameTXB.Text, surnameTXB.Text, emailTXB.Text, clientID);
                MessageBox.Show("Client details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nameTXB.Clear();
                surnameTXB.Clear();
                emailTXB.Clear();

                clientTableAdapter.Fill(this.the_Luxe_ServerDataSet.Client);
            }
            else
            {
                MessageBox.Show("Please fill in all fields with valid information.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidClientDetails()
        {
            if (string.IsNullOrWhiteSpace(nameTXB.Text) || string.IsNullOrWhiteSpace(surnameTXB.Text) || string.IsNullOrWhiteSpace(emailTXB.Text))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(emailTXB.Text);
                return addr.Address == emailTXB.Text.Trim();
            }
            catch
            {
                return false;
            }
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            nameTXB.Clear();
            surnameTXB.Clear();
            emailTXB.Clear();  
        }
    }
}
