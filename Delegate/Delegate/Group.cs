
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Group
    {
        public string Name { get; }

        public List<Student> Students { get; }

        public Group(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public void AddToGroup(Student student)
        {
            Students.Add(student);
        }

        public void ShowStudents()
        {
            foreach (var item in Students)
            {
                Console.WriteLine(item);
            }
        }

        public Student FindById(int id)
        {
            foreach (var item in Students)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            return null;
        }

        public Student FindBy(Predicate<Student> predicate)
        {
            var student = Students.Find(predicate);
            return student;
        }
    }
}
