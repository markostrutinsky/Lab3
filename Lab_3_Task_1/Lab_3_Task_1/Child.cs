using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_1
{
    internal class Child
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Child(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
