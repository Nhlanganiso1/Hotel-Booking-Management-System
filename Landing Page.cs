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

        private void mAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //link it to the Manage room page
            Manage_Room j = new Manage_Room();
            j.Show();
            this.Hide();
        }
    }
}
