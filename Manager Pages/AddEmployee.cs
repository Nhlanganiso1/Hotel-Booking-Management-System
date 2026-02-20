using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Booking_Management_System.Manager_Pages
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'the_Luxe_ServerDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.the_Luxe_ServerDataSet.Employee);

        }

        
        /// <summary>
        /// Adds new employee to the database after all checks are done
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addEmployeeButton_Click(object sender, EventArgs e)
        {

            if(checkHotelID() && checkNameAndSurname() && checkRole() && checkEmail() && passwordTXB.Text.Length > 4)
            {
                employeeTableAdapter1.AddNewEmployee(int.Parse(HotelIDTXB.Text), nameTXB.Text, surnameTXB.Text, roleDropDown.Text, emailTXB.Text, passwordTXB.Text);
                HotelIDTXB.Clear();
                nameTXB.Clear();
                surnameTXB.Clear();
                emailTXB.Clear();
                passwordTXB.Clear();
                roleDropDown.SelectedIndex = -1;
            }   
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            HotelIDTXB.Clear();
            nameTXB.Clear();
            surnameTXB.Clear();
            emailTXB.Clear();
            passwordTXB.Clear();
            roleDropDown.SelectedIndex = -1;

        }

        /// <summary>
        ///returns a bool value if the email address is correct return true otherwise false
        /// </summary>
        /// <returns>bool value</returns>
        private bool checkEmail()
        {
            if (!emailTXB.Text.EndsWith("@luxe.com"))
            {
                MessageBox.Show("Please enter a valid comany Email address", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameTXB.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Return true if the role is selected false otherwise
        /// </summary>
        /// <returns>bool value</returns>
        private bool checkRole()
        {
            if (roleDropDown.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the Role of the employee", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                roleDropDown.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// 
        /// Checks that the name and surname are not null, if null return false 
        /// </summary>
        /// <returns>bool value</returns>
        private bool checkNameAndSurname()
        {
            if (nameTXB.Text.Length <= 0)
            {
                MessageBox.Show("Please enter a valid name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameTXB.Focus();
                return false;
            }
            if (surnameTXB.Text.Length <= 0)
            {
                MessageBox.Show("Please enter a valid surname", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                surnameTXB.Focus();
                return false;
            }
            return true;
        }


        /// <summary>
        /// Check that the entered hotel ID is exists in the database
        /// </summary>
        /// <returns>bool value</returns>
        private bool checkHotelID()
        {
            int hotelID;
            if (!int.TryParse(HotelIDTXB.Text, out hotelID))
            {
                MessageBox.Show("Please enter a valid numeric Hotel ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HotelIDTXB.Clear();
                HotelIDTXB.Focus();
                return false;
            }
            // you can also check if the hotel ID exists in the database here and show a message if it doesn't.
            if (hotelTableAdapter1.CheckHotelID(hotelID) <= 0)
            {
                MessageBox.Show("Please enter a valid  Hotel ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                HotelIDTXB.Clear();
                HotelIDTXB.Focus();
                return false;
            }

            return true;
        }

        //private void backButton_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}
    }
}
