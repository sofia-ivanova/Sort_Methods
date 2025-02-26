using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
        {
            new Student("Иван", 83),
            new Student("Мария", 90),
            new Student("София", 95),
            new Student("Александър", 76),
            new Student("Йордан", 87)
        };
            University university = new University(students);
            Console.WriteLine("Въведете бал за търсене: ");
            int score = int.Parse(Console.ReadLine());
            string result = university.FindStudentByScore(score);
            Console.WriteLine("Резултат: " + result);
            Console.ReadKey();
        }
    }
}
