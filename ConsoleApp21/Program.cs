using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = {
                new Worker("Ivan", 3000),
                new Worker("Pavel", 2500),
                new Worker("Aleksandar", 1800),
                new Worker("Elena", 2000),
                new Worker("Maria", 2800)
            };
            Program sorter = new Program();
            sorter.Sort(workers);
            Console.WriteLine("Sorted by salary:");
            foreach (var worker in workers)
                Console.WriteLine(worker);
            Console.ReadKey();
        }
        public void Sort(Worker[] workers)
        {
            MergeSortRecursive(workers, 0, workers.Length - 1);
        }

        private void MergeSortRecursive(Worker[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSortRecursive(array, left, mid);
                MergeSortRecursive(array, mid + 1, right);
                Merge(array, left, mid, right);
            }
        }
        private void Merge(Worker[] array, int left, int mid, int right)
        {
            int leftSize = mid - left + 1, rightSize = right - mid;
            Worker[] leftArr = new Worker[leftSize];
            Worker[] rightArr = new Worker[rightSize];

            Array.Copy(array, left, leftArr, 0, leftSize);
            Array.Copy(array, mid + 1, rightArr, 0, rightSize);

            int i = 0, j = 0, k = left;
            while (i < leftSize && j < rightSize)
            {
                array[k++] = leftArr[i].Salary <= rightArr[j].Salary ? leftArr[i++] : rightArr[j++];
            }

            while (i < leftSize) array[k++] = leftArr[i++];
            while (j < rightSize) array[k++] = rightArr[j++];
        }

    }
}
