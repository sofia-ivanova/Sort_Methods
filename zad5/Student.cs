using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public Student(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
}
