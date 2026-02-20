using Hotel_Booking_Management_System.Manager_Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Booking_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        //checks that login details are valid, if the user id is not a valid integer, return -1 to indicate an error
        private int validateLogin()
        {
            int userID;
            try { 
                userID = Int32.Parse(UserNameTxb.Text);
            }
            catch (Exception ex)
            {
       
                return -1; // Return -1 to indicate an error
            }

            return userID;
        }

        // event handler for the login button, validates the login details and checks the database for a matching user, if a match is found, opens the landing page for the user and shows the appropriate menu items based on their role
        private void button1_Click(object sender, EventArgs e)
        {
            // validate the login details
            int userID = validateLogin();
            if (userID > 0) {
                employeeTableAdapter.CheckLogin(the_Luxe_ServerDataSet.Employee,userID,PasswordTxb.Text);
            }
            else {
                // user id is not a valid integer, stop the login process
                MessageBox.Show("An error occurred please enter correct login details.");
                return;
            }

            if (the_Luxe_ServerDataSet.Employee.Rows.Count == 0) {
                // no matching user found, show error message
                MessageBox.Show("Incorrect login details, please try again.");
                return;
            }

            //Add details to the Current User class to be used throughout the application
            CurrentUser currentUser = new CurrentUser();
            currentUser.UserId = int.Parse(the_Luxe_ServerDataSet.Employee.Rows[0]["Employee_ID"].ToString());
            currentUser.UserRole = the_Luxe_ServerDataSet.Employee.Rows[0]["Role"].ToString();
            currentUser.UserName = the_Luxe_ServerDataSet.Employee.Rows[0]["Employee_name"].ToString() + " " + the_Luxe_ServerDataSet.Employee.Rows[0]["Employee_surname"].ToString();
            currentUser.UserHotelId = int.Parse(the_Luxe_ServerDataSet.Employee.Rows[0]["Hotel_ID"].ToString());

            //Login successful, check the role of the user and pass it to the landing page to show the appropriate menu items based on the user and open the landing page
            // the role of the user is stored in the first row of the employee table, as the login query should only return one row if the login details are correct
            // first configure the menu strip for the role of the user, then show the landing page and hide the login form
            
            LandingPage f1 = new LandingPage();
            f1.ConfigureMenuStripForRole(currentUser.UserRole);
            f1.currentUserDetails(currentUser);                   // pass the current user details to the landing page to be used throughout the application
            f1.Show();
            this.Hide();
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'the_Luxe_ServerDataSet.Employee' table. You can move, or remove it, as needed.
            // this is a special fill method that is used to check the login details, it should not be removed as it is used in the login process, it is not used to fill the employee table for display purposes, so it does not need to be called in the landing page or any other page that displays employee details
            this.employeeTableAdapter.FillForLogin(this.the_Luxe_ServerDataSet.Employee);

        }
      
    }
}
