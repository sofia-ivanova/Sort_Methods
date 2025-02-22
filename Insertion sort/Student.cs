using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_sort
{
    internal class Student
    {
        public string Name { get; set; }
        public double GPA { get; set; }
        public Student(string name, double gpa)
        {
            Name = name;
            GPA = gpa;
        }
        public override string ToString()
        {
            return $"{Name}: {GPA:F2}";
        }
    }
}
