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

        /// <summary>
        /// Handles the Click event of the Clear button by clearing the text fields for name, surname, ID, and role.
        /// </summary>
        /// <param name="sender">The source of the event, typically the Clear button.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
        private void clearBTN_Click(object sender, EventArgs e)
        {
            nameTXB.Clear();
            surnameTXB.Clear();
            idTXB.Clear();
            roleTXB.Clear();
        }

        /// <summary>
        /// Handles the Click event of the Remove button to delete the selected employee from the data source.
        /// </summary>
        /// <remarks>Displays a confirmation message upon successful removal or prompts the user to select
        /// an employee if none is selected.</remarks>
        /// <param name="sender">The source of the event, typically the Remove button.</param>
        /// <param name="e">An EventArgs object that contains the event data.</param>
        private void removeBTN_Click(object sender, EventArgs e)
        {
            if(employeeDGV.CurrentRow != null)
            {
                employeeTableAdapter.RemoveEmployee(int.Parse(employeeDGV.CurrentRow.Cells[3].Value.ToString()));
                this.employeeTableAdapter.Fill(this.the_Luxe_ServerDataSet.Employee, HotelID);
                MessageBox.Show("Employee removed successfully.");
            }
            else
            {
                MessageBox.Show("Please select an employee to remove.");
            }
        }

        /// <summary>
        /// Handles the event that occurs when a cell in the employee data grid view is double-clicked, populating the
        /// corresponding text boxes with the selected employee's details.
        /// </summary>
        /// <remarks>This method is typically used to allow users to quickly load and edit employee
        /// information by double-clicking a row in the data grid view. If no row is currently selected, the text boxes
        /// are not updated.</remarks>
        /// <param name="sender">The source of the event, typically the employee data grid view.</param>
        /// <param name="e">A DataGridViewCellEventArgs that contains the event data, including the row and column indexes of the
        /// double-clicked cell.</param>
        private void employeeDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (employeeDGV.CurrentRow != null)
            {
                nameTXB.Text = employeeDGV.CurrentRow.Cells[0].Value.ToString();
                surnameTXB.Text = employeeDGV.CurrentRow.Cells[1].Value.ToString();
                idTXB.Text = employeeDGV.CurrentRow.Cells[3].Value.ToString();
                roleTXB.Text = employeeDGV.CurrentRow.Cells[2].Value.ToString();
            }
        }
    }
}
