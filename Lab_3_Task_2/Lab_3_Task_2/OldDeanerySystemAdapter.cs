using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_2
{
    internal class OldDeanerySystemAdapter : INewDeanerySystem
    {
        private readonly OldDeanerySystem _system;
        public NewDeanerySystem NewSystem { get; } = new NewDeanerySystem();
        public OldDeanerySystemAdapter(OldDeanerySystem system) => _system = system;
        public void Print(string key)
        {
            if (NewSystem.Students.ContainsKey(key))
                _system.Print(NewSystem.Students[key]);
            else
                Console.WriteLine("Group not found.");
        }
    }
}
