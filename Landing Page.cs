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

        private void mAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //link it to the Manage room page
            Manage_Room j = new Manage_Room();
            FormSetup(j);
        }

        public void ConfigureMenuStripForRole(string role)
        {
            ////rest all menu items to be invisible by default
            //foreach (ToolStripItem item in menuStrip1.Items) item.Visible = false;

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
    }
}
