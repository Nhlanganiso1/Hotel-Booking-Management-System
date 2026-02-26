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

namespace Hotel_Booking_Management_System.Manager_Pages
{
    public partial class UpdateEmployee : Form
    {
        int hotelID;
        public UpdateEmployee(CurrentUser currentUser)
        {
            InitializeComponent();
            hotelID = currentUser.UserHotelId;
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.the_Luxe_ServerDataSet.Employee,hotelID);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(employeeDGV.CurrentRow != null)
            {
                nameTXB.Text = employeeDGV.CurrentRow.Cells[2].Value.ToString();
                surnameTXB.Text = employeeDGV.CurrentRow.Cells[3].Value.ToString();
                roleDropDown.Text = employeeDGV.CurrentRow.Cells[4].Value.ToString();
                emailTXB.Text = employeeDGV.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void searchTXB_TextChanged(object sender, EventArgs e)
        {
            employeeTableAdapter.FillByName(this.the_Luxe_ServerDataSet.Employee,searchTXB.Text, hotelID );
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            nameTXB.Clear();
            surnameTXB.Clear();
            roleDropDown.SelectedIndex = -1;
            emailTXB.Clear();
            pwdTXB.Clear();
        }

        private void updateEmployeeBTN_Click(object sender, EventArgs e)
        {
            if (employeeDGV.CurrentRow != null)
            {
                int employeeID = Convert.ToInt32(employeeDGV.CurrentRow.Cells[0].Value.ToString());
                if (isValidDetails())
                {

                    employeeTableAdapter.UpdateEmployee(nameTXB.Text, surnameTXB.Text, roleDropDown.Text, emailTXB.Text, pwdTXB.Text, employeeID, hotelID);
                    MessageBox.Show("Employee details updated successfully");
                    employeeTableAdapter.Fill(this.the_Luxe_ServerDataSet.Employee, hotelID);
                }  
            }
            else
            {
                MessageBox.Show("Please select an employee to update, double click on the side");
            }
        }

        private bool isValidDetails()
        {
            if(nameTXB.Text == "" || surnameTXB.Text == "" || roleDropDown.SelectedIndex < 0 || emailTXB.Text == "" || pwdTXB.Text == "")
            {
                MessageBox.Show("Please fill in all the details");
                return false;
            }

            if(emailTXB.Text.EndsWith("@luxe.com") == false)
            {
                MessageBox.Show("Please enter a valid email address");
                return false;
            }
            if(pwdTXB.Text != "")
            {
                if(pwdTXB.Text.Length < 8)
                {
                    MessageBox.Show("Password must be at least 8 characters long");
                    return false;
                }
            }

            return true;
        }

        private void employeeDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            employeeDGV.ClearSelection();
            employeeDGV.CurrentCell = null;
        }
    }
}
