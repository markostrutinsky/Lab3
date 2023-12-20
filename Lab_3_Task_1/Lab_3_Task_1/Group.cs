using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_1
{
    internal class Group : ICommand
    {
        public string NameOfGroup { get; set; }
        public List<Room> Rooms { get; set; }
        public Group(string nameOfGroup)
        {
            NameOfGroup = nameOfGroup;
            Rooms = new List<Room>();
        }
        public void AddToGroup(Room room)
        {
            if (Rooms.Count < 11)
                Rooms.Add(room);
            else
                Console.WriteLine($"Group {NameOfGroup} is full.");
        }
        public void ExecuteCommand(Commands command)
        {
            if (command.Equals(Commands.WakeUp))
            {
                Console.WriteLine($" Group {NameOfGroup} received a lift message.");
                foreach (var room in Rooms)
                {
                    Console.WriteLine($"   Counselor wakes up children in {room.RoomNumber} room");
                    foreach (var child in room.Children)
                    {
                        Console.WriteLine($"Child {child.Name} woke up.");
                    }
                }
            }
            else
            {
                Console.WriteLine($" Group {NameOfGroup} received the command to repel.");
                foreach (var room in Rooms)
                {
                    Console.WriteLine($"   Counselor notifies children");
                    foreach (var child in room.Children)
                    {
                        Console.WriteLine($"Child {child.Name} went to bed.");
                    }
                }
            }
        }
    }
}
