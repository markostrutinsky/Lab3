using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_2
{
    internal class OldDeanerySystem
    {
        public List<Student> Students { get; set; }
        public OldDeanerySystem() => Students = new List<Student>();
        public void Print(List<Student> students) 
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }
        public void AddToList(Student student) => Students.Add(student); 
    }
}
