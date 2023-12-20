using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_1
{
    internal class Room
    {
        public int RoomNumber { get; set; }
        public List<Child> Children { get; set; }
        public Room(int roomNumber) 
        {
            RoomNumber = roomNumber;
            Children = new List<Child>();
        }

        public void AddToRoom(Child child)
        {
            if (Children.Count < 3)
                Children.Add(child);
            else
                Console.WriteLine($"Room {RoomNumber} is full.");
        }
    }
}
