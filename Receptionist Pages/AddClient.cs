using Hotel_Booking_Management_System.The_Luxe_ServerDataSetTableAdapters;
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
    public partial class AddClient : Form
    {
        
        public AddClient()
        {
            InitializeComponent();
            
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'the_Luxe_ServerDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter2.Fill(this.the_Luxe_ServerDataSet1.Client);

        }

        private void addResidentBTN_Click(object sender, EventArgs e)
        {
            if(validateResidentDetails())
            {
                int existingResidentEmails = clientTableAdapter2.CheckEmailAddress(this.the_Luxe_ServerDataSet1.Client, emailTXB.Text);

                if (existingResidentEmails > 0)
                {
                    MessageBox.Show("A resident with this email already exists.");
                }
                else
                {
                    clientTableAdapter2.InsertNewClient(nameTXB.Text, surnameTXB.Text, emailTXB.Text);
                    MessageBox.Show("Resident added successfully.");
                    nameTXB.Clear();
                    surnameTXB.Clear();
                    emailTXB.Clear();
                }
            }
        }

        private bool validateResidentDetails()
        {
            if(String.IsNullOrWhiteSpace(nameTXB.Text) || String.IsNullOrWhiteSpace(surnameTXB.Text))
            {
                MessageBox.Show("Name and Surname cannot be empty");
                return false;
            }
            if(emailTXB.Text.Contains("@") == false || emailTXB.Text.Contains(".") == false)
            {
                MessageBox.Show("Email is not valid");
                return false;
            }
            return true;

        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            nameTXB.Clear();
            surnameTXB.Clear();
            emailTXB.Clear();
        }
    }
}
