using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KeeganFinalProjectForms
{
    public class Room
    {
        public string RoomType { get; set; }
        public int RoomQuantity { get; set; }
        public double RoomPrice { get; set; }

        //constructor
        public Room()
        {
            RoomType = "";
            RoomQuantity = 0;
            RoomPrice = 0;
        }

        public Room(string roomType, int roomQuantity, double roomPrice)
        {
            RoomType = roomType;
            RoomQuantity = roomQuantity;
            RoomPrice = roomPrice;
        }
    }
}
