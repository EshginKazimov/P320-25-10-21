using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Student
    {
        public int Id { get; }

        public string Fullname { get; set; }

        private static int _counter;

        public Student(string fullName)
        {
            Fullname = fullName;
            _counter++;
            Id = _counter;
        }

        public override string ToString()
        {
            return $"{Id} - {Fullname}";
        }
    }
}
