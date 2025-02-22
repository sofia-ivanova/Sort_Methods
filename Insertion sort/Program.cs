using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = {
                new Student("Ivan", 4.5),
                new Student("Petar", 5.0),
                new Student("Georgi", 4.5),
                new Student("Maria", 6.0),
                new Student("Aleksandra", 5.0)
            };
            Program sorter = new Program();
            sorter.SortByGPA(students);
            Console.WriteLine("Sort by GPA:");
            foreach (var student in students) 
                Console.WriteLine(student);

            Console.WriteLine();

            sorter.SortByName(students);
            Console.WriteLine("Sort by name:");
            foreach (var student in students) 
                Console.WriteLine(student);
            Console.ReadKey();
        }
        public void SortByGPA(Student[] students)
        {
            int n = students.Length;
            for (int i = 1; i < n; i++)
            {
                Student key = students[i];
                int j = i - 1;
                while (j >= 0 && students[j].GPA > key.GPA)
                {
                    students[j + 1] = students[j];
                    j--;
                }
                students[j + 1] = key;
            }
        }
        public void SortByName(Student[] students)
        {
            int n = students.Length;
            for (int i = 1; i < n; i++)
            {
                Student key = students[i];
                int j = i - 1;
                while (j >= 0 && students[j].Name.CompareTo(key.Name) > 0)
                {
                    students[j + 1] = students[j];
                    j--;
                }
                students[j + 1] = key;
            }
        }
    }
}
