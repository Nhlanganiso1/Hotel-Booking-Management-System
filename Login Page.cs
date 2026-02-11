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
            MainMenuStrip.Items[1].Visible = false;
            MainMenuStrip.Items[2].Visible = false;
            MainMenuStrip.Items[3].Visible = false;
            MainMenuStrip.Items[4].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // check if the login is for the manager
            if (UserNameTxb.Text == "123" && PasswordTxb.Text == "123") {
                //MainMenuStrip.Items[0].Visible = false;
                //MainMenuStrip.Items[1].Visible = true;
                //MainMenuStrip.Items[2].Visible = true;
                //MainMenuStrip.Items[3].Visible = true;
                //MainMenuStrip.Items[4].Visible = true;

                //Manager_Pages.ManagerLandingPage f1 = new Manager_Pages.ManagerLandingPage();
                //f1.MdiParent = MainForm.ActiveForm;
                //f1.Show();
                //this.Hide();

                LandingPage f1  = new LandingPage();
                f1.Show();
                this.Hide();
            }
            // if the login is for the receptionist
            // if the login id for the cleaner 
            //error incorrect login details
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
