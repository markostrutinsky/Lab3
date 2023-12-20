using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Task_2
{
    internal class NewDeanerySystem : INewDeanerySystem
    {
        public Dictionary<string, List<Student>> Students { get; set; }
        public NewDeanerySystem() => Students = new Dictionary<string, List<Student>>();    

        public void Print(string key)
        {
            if (Students.ContainsKey(key))
            {
                foreach (var student in Students[key])
                    Console.WriteLine(student.ToString());
            }
        }

        public void AddToDictionary(Student student)
        {
            if (Students.ContainsKey(student.Group))
            {
                List<Student> list = Students[student.Group];
                if (!list.Contains(student))
                    list.Add(student);
            }
            else
            {
                List<Student> list = new List<Student>();
                list.Add(student);
                Students.Add(student.Group, list);
            }
        }
    }
}
