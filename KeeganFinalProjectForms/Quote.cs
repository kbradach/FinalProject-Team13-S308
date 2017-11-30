using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KeeganFinalProjectForms
{
    public class Quote : Reservation
    {
        public string RoomType { get; set; }
        public int NumberRooms { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        //create constructors
        public Quote()
        {
            RoomType = "";
            NumberRooms = 0;
            CheckInDate = DateTime.Today;
            CheckOutDate = DateTime.Today;
        }
        public Quote(string roomType, int numberRooms, DateTime checkInDate, DateTime checkOutDate)
        {
            RoomType = roomType;
            NumberRooms = numberRooms;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
        }
    }
}
