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
    public partial class Bookings : Form
    {
        public Bookings()
        {
            InitializeComponent();
        }

        private void Bookings_Load(object sender, EventArgs e)
        { 
            // prevent selecting past dates
            DTP_Check_IN.MinDate = DateTime.Today; 
            DTP_Check_OUT.MinDate = DateTime.Today.AddDays(1);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {   //Updates the check-out when check in is changed 
            DTP_Check_OUT.MinDate = DTP_Check_IN.Value.AddDays(1);
            
            if(DTP_Check_OUT.Value <= DTP_Check_IN.Value)
            {
                DTP_Check_OUT.Value = DTP_Check_IN.Value.AddDays(1);
            }
           
        }

        private void DTP_Check_OUT_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DTP_Check_OUT.Value <= DTP_Check_IN.Value)
            {
                MessageBox.Show("Check-out date must be afther check-in date");
                return;
            }
        }
    }
}
