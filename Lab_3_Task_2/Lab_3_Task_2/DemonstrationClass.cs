using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_2
{
    internal class DemonstrationClass
    {
        public static void Demonstrate()
        {
            Student Marko = new Student("Marko", "Strutinsky", 19, "KP-21", 1);
            Student Sofia = new Student("Sofia", "Strutinska", 19, "KP-21", 2);
            Student Andriy = new Student("Andriy", "Konavich", 18, "KP-23", 3);
            Student Liza = new Student("Liza", "Konavich", 18, "KP-23", 4);

            Console.WriteLine("\t\t\t\tOld system");

            var oldSys = new OldDeanerySystem();

            oldSys.AddToList(Marko);
            oldSys.AddToList(Sofia);
            oldSys.AddToList(Andriy);
            oldSys.AddToList(Liza);

            oldSys.Print(oldSys.Students);

            Console.WriteLine("\t\t\t\tNew system");

            OldDeanerySystemAdapter adapter = new OldDeanerySystemAdapter(oldSys);

            adapter.NewSystem.AddToDictionary(Marko);
            adapter.NewSystem.AddToDictionary(Sofia);
            adapter.NewSystem.AddToDictionary(Andriy);
            adapter.NewSystem.AddToDictionary(Liza);

            Console.WriteLine("\t\t\t\t   KP-21");
            adapter.Print("KP-21");

            Console.WriteLine("\t\t\t\t   KP-23");
            adapter.Print("KP-23");

        }
    }
}
