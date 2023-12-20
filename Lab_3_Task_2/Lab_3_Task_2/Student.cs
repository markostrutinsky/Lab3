using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_2
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        public int Id { get; set; }

        public Student(string name, string surname, int age, string group, int id)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Group = group;
            Id = id;
        }
        public override string ToString()
        {
            return $"Name: {Name}   Surname: {Surname}  Age: {Age}  Group: {Group}  Id: {Id}";
        }
    }
}
