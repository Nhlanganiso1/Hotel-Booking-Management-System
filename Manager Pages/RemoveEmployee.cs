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
    public partial class RemoveEmployee : Form
    {
        int HotelID;
        public RemoveEmployee(CurrentUser currentUser)
        {
            InitializeComponent();
            HotelID  = currentUser.UserHotelId;
        }

        private void RemoveEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'the_Luxe_ServerDataSet.Employee' table. You can move, or remove it, as needed.
            // it loads the employee data for the current hotel into the employee table, allowing the user to see all employees associated with their hotel and select the one they want to remove
            this.employeeTableAdapter.Fill(this.the_Luxe_ServerDataSet.Employee,HotelID);

        }


        /// <summary>
        /// search by the partial name of the employee, as the user types in the search box, the employee table will be filtered to show only employees with a matching name, this allows the user to quickly find the employee they want to remove without having to scroll through the entire list
        /// the search is case insensitive and will match any part of the employee's name, so the user can enter a first name, last name or any part of the name to find the employee they want to remove
        /// takes in the hotel id to ensure that only employees from the same hotel are shown in the search results, this prevents the user from accidentally removing an employee from a different hotel and ensures that the search results are relevant to the user's hotel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            employeeTableAdapter.FillByName(the_Luxe_ServerDataSet.Employee, textBox1.Text,HotelID);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(employeeDGV.CurrentRow != null)
            {
                nameTXB.Text = employeeDGV.CurrentRow.Cells["Employee_name"].Value.ToString();
                surnameTXB.Text = employeeDGV.CurrentRow.Cells["Employee_surname"].Value.ToString();
                idTXB.Text = employeeDGV.CurrentRow.Cells["Employee_ID"].Value.ToString();
                roleTXB.Text = employeeDGV.CurrentRow.Cells["Role"].Value.ToString();
            }
            

        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            nameTXB.Clear();
            surnameTXB.Clear();
            idTXB.Clear();
            roleTXB.Clear();
        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
            if(employeeDGV.CurrentRow != null)
            {
                employeeTableAdapter.RemoveEmployee(int.Parse(employeeDGV.CurrentRow.Cells["Employee_ID"].Value.ToString()));
            }
            else
            {
                MessageBox.Show("Please select an employee to remove.");
            }
        }
    }
}
