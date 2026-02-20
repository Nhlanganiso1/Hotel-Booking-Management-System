using Hotel_Booking_Management_System.Cleaner_Pages;
using Hotel_Booking_Management_System.Receptionist_Pages;
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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displays the specified form as the sole maximized MDI child of the current parent form.
        /// </summary>
        /// <remarks>This method closes all existing MDI child forms before displaying the new form. The
        /// provided form will be set as a child of the current MDI parent and maximized upon display.</remarks>
        /// <param name="myForm">The form to display as a maximized MDI child. Must not be null and should be initialized before calling this
        /// method.</param>
        public void FormSetup(Form myForm)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

            myForm.MdiParent = this;
            myForm.WindowState = FormWindowState.Maximized;
            myForm.Show();
        }

        // Method to configure menu strip visibility based on user role,called(in login) after user login
        public void ConfigureMenuStripForRole(string role)
        {
            switch (role)
            {
                case "Manager":
                    // login for manager
                    menuStrip1.Items["mAToolStripMenuItem"].Visible = true;
                    menuStrip1.Items["rEPORTSToolStripMenuItem"].Visible = true;
                    menuStrip1.Items["mANAGECLIENTDETAILSToolStripMenuItem"].Visible = true;
                    menuStrip1.Items["BOOKINGSToolStripMenuItem"].Visible = true;
                    menuStrip1.Items["cHECKINCHECKOUTToolStripMenuItem"].Visible = true;
                    menuStrip1.Items["cLEANINGToolStripMenuItem"].Visible = true;
                    menuStrip1.Items["eMPLOYEEDETAILSToolStripMenuItem"].Visible=true;
                    break;
                case "Receptionist":
                    // login for receptionist
                    menuStrip1.Items["mANAGECLIENTDETAILSToolStripMenuItem"].Visible = true;
                    menuStrip1.Items["BOOKINGSToolStripMenuItem"].Visible = true;
                    menuStrip1.Items["cHECKINCHECKOUTToolStripMenuItem"].Visible = true;
                    break;
                case "Cleaner":
                    // login for cleaner
                    menuStrip1.Items["cLEANINGToolStripMenuItem"].Visible = true;
                    break;
                default:
                    // role not recognized, show error message
                    MessageBox.Show("An error occurred, user role not recognized.");
                    return;
            }
        }

        /// <summary>
        /// Handles the click event for the Reports menu item and initializes the ManagerReports form for display.
        /// </summary>
        /// <remarks>This method prepares and displays the ManagerReports form when the Reports menu item
        /// is selected. Use this event handler to provide access to reporting functionality from the application's main
        /// menu.</remarks>
        /// <param name="sender">The source of the event, typically the Reports menu item that was clicked.</param>
        /// <param name="e">The event data associated with the click event.</param>

        private void mAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //link it to the Manage room page
            Manage_Room j = new Manage_Room();
            FormSetup(j);
        }

        private void rEPORTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagerReports reportPage = new ManagerReports();
            FormSetup(reportPage);
        }

        private void eMPLOYEEDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {


            
        }

        private void mANAGECLIENTDETAILSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageClient clientPage = new ManageClient();
            FormSetup (clientPage);
        }

        private void BOOKINGSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bookings bookingPage = new Bookings();
            FormSetup(bookingPage);
        }

        private void cHECKINCHECKOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //@TO DO need to decide whether the checkin/out will be on the same page or different pages
            // if on different pages add the drop down pages and implement using the code on the exercise book
            CheckIn checkinPage = new CheckIn();
            FormSetup(checkinPage);
        }

        private void cLEANINGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CleanerPage cleanerPage = new CleanerPage();
            FormSetup(cleanerPage);
        }

        private void aDDEMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployeePage = new AddEmployee();
            FormSetup(addEmployeePage);
        }

        private void rEMOVEEMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveEmployee removeEmployeePage = new RemoveEmployee();
            FormSetup(removeEmployeePage);
        }

        private void uPDATEEMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmployeePage = new UpdateEmployee();
            FormSetup(updateEmployeePage);
        }
    }
}
