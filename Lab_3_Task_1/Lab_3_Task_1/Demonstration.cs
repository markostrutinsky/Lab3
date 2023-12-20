using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_1
{
    internal class Demonstration
    {
        public static void Demonstrate()
        {
            Child Marko = new Child("Marko", 12);
            Child Sofia = new Child("Sofia", 11);
            Child Andriy = new Child("Andriy", 11);
            Child Elizabeth = new Child("Elizabeth", 11);

            Room firstRoom = new Room(1);
            firstRoom.AddToRoom(Marko);
            firstRoom.AddToRoom(Sofia);

            Room secondRoom = new Room(2);
            secondRoom .AddToRoom(Andriy);
            secondRoom.AddToRoom(Elizabeth);

            Group group = new Group("The suns");
            group.AddToGroup(firstRoom);
            group.AddToGroup(secondRoom);
            Console.WriteLine("\t\t\tMorning");
            group.ExecuteCommand(Commands.WakeUp);
            Console.WriteLine("\t\t\tNight");
            group.ExecuteCommand(Commands.LightsOut);
        }
    }
}
