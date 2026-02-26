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
    public partial class Manage_Room : Form
    {
        int hotel_ID;
        public Manage_Room(CurrentUser currentUser)
        {
            hotel_ID = currentUser.UserHotelId;
            InitializeComponent();
        }

        private void Manage_Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'the_Luxe_ServerDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.the_Luxe_ServerDataSet.Room,hotel_ID);

        }

        /// <summary>
        /// Handles the cell mouse double-click event for the DataGridView, updating room detail fields and UI controls
        /// based on the selected room's status.
        /// </summary>
        /// <remarks>If a room is selected, the method populates the room number, type, cost, and status
        /// fields, and adjusts the background color and button states according to the room's availability. If no room
        /// is selected, a prompt is displayed to the user.</remarks>
        /// <param name="sender">The source of the event, typically the DataGridView control that was double-clicked.</param>
        /// <param name="e">Provides information about the cell mouse event, including the row and column indexes of the double-clicked
        /// cell.</param>
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (roomDGV.CurrentRow != null)
            {
                roomNoTXB.Text = roomDGV.CurrentRow.Cells[0].Value.ToString();
                roomTypeTXB.Text = roomDGV.CurrentRow.Cells[2].Value.ToString();
                roomCostTXB.Text = roomDGV.CurrentRow.Cells[4].Value.ToString();
                roomStatusTXB.Text = roomDGV.CurrentRow.Cells[3].Value.ToString();

                if(roomStatusTXB.Text == "Booked")
                {
                    roomStatusTXB.BackColor = Color.AliceBlue;
                    unavailableBTN.Enabled = false;
                    availableBTN.Enabled = false;
                }
                else if(roomStatusTXB.Text == "Available")
                {
                    roomStatusTXB.BackColor = Color.LightGreen;
                    unavailableBTN.Enabled = true;
                    availableBTN.Enabled = true;
                }
                else if(roomStatusTXB.Text == "Unavailable")
                {
                    roomStatusTXB.BackColor = Color.Red;
                    unavailableBTN.Enabled = true;
                    availableBTN.Enabled = true;
                }

            }
            else
            {
                MessageBox.Show("Please select a room to edit.");
            }
        }

        private void searchTXB_TextChanged(object sender, EventArgs e)
        {
            roomTableAdapter.FillByRoomNo(this.the_Luxe_ServerDataSet.Room, hotel_ID, searchTXB.Text);
        }


        /// <summary>
        /// Handles the click event for the 'Unavailable' button, marking the selected room as unavailable.
        /// </summary>
        /// <remarks>If no room is selected, a message box prompts the user to select a room before
        /// proceeding. The method updates the room status in the database and refreshes the room data grid
        /// view.</remarks>
        /// <param name="sender">The source of the event, typically the button that was clicked.</param>
        /// <param name="e">The event data associated with the click event.</param>
        private void unavailableBTN_Click(object sender, EventArgs e)
        {
            if(roomDGV.CurrentRow != null)
            {
                int roomNo = Convert.ToInt32(roomDGV.CurrentRow.Cells[0].Value);
                roomTableAdapter.UpdateRoomStatus("Unavailable", roomNo,hotel_ID);
                this.roomTableAdapter.Fill(this.the_Luxe_ServerDataSet.Room, hotel_ID);

                roomNoTXB.Clear();
                roomTypeTXB.Clear();
                roomDGV.Rows.Clear();
                roomStatusTXB.Clear();
                roomCostTXB.Clear();
            }
            else
            {
                MessageBox.Show("Please select a room to mark as unavailable.");
            }
        }


        /// <summary>
        /// Handles the click event for the Available button, marking the selected room as available and updating its
        /// status in the database.
        /// </summary>
        /// <remarks>If no room is selected, a message prompts the user to select a room before
        /// proceeding. After updating the room status, the method refreshes the room data grid and clears related input
        /// fields.</remarks>
        /// <param name="sender">The source of the event, typically the Available button that was clicked.</param>
        /// <param name="e">The event data associated with the button click.</param>
        private void availableBTN_Click(object sender, EventArgs e)
        {
            if (roomDGV.CurrentRow != null)
            {
                int roomNo = Convert.ToInt32(roomDGV.CurrentRow.Cells[0].Value);
                roomTableAdapter.UpdateRoomStatus("Available", roomNo, hotel_ID);
                this.roomTableAdapter.Fill(this.the_Luxe_ServerDataSet.Room, hotel_ID);

                roomNoTXB.Clear();
                roomTypeTXB.Clear();
                roomDGV.Rows.Clear();
                roomStatusTXB.Clear();
                roomCostTXB.Clear();
            }
            else
            {
                MessageBox.Show("Please select a room to mark as available.");
            }
        }
    }
}
