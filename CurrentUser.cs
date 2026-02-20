using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Booking_Management_System
{
    /// <summary>
    /// This class represents the current user of the hotel booking management system, 
    /// it contains properties such as UserId, UserName, UserRole and UserHotelId which are used to identify the user and their role in the system, 
    /// as well as the hotel they are associated with. 
    /// This class is used to store the current user's information and can be passed around different forms and classes in the application to ensure that the user's information is accessible throughout the application.
    /// </summary>
    public class CurrentUser
    {
        public int UserId { get; set; }
        public String UserName { get; set; }
        public String UserRole { get; set; }
        public int UserHotelId { get; set; }
    }
}
