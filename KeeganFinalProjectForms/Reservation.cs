using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KeeganFinalProjectForms
{
    public class Reservation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RoomType { get; set; }
        public int NumberRooms { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string CardType { get; set; }
        public int CardNumber { get; set;}
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        //Constructor for Reservation Class
        public Reservation()
        {
            FirstName = "";
            LastName = "";
            RoomType = "";
            NumberRooms = 0;
            CheckInDate = DateTime.Today;
            CheckOutDate = DateTime.Today;
            CardType = "";
            CardNumber = 0;
            PhoneNumber = "";
            EmailAddress = "";

        }
        
    }
}