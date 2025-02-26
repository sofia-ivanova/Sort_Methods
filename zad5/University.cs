using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class University
    {
        private List<Student> students;
        public University(List<Student> students)
        {
            this.students = students;
            SelectionSort(this.students); // Сортиране с Selection Sort
        }
        private void SelectionSort(List<Student> students)
        {
            int n = students.Count;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (students[j].Score < students[minIndex].Score)
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    Student temp = students[i];
                    students[i] = students[minIndex];
                    students[minIndex] = temp;
                }
            }
        }

        public string FindStudentByScore(int score)
        {
            int left = 0, right = students.Count - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (students[mid].Score == score)
                    return students[mid].Name;
                else if (students[mid].Score < score)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return "Не е намерен";
        }
    }
}
