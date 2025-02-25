using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 3, 4, 5, 7, 9, 11 };
            int target = 3;
            (int count, List<int> positions) = BinarySearch(array, target);
            Console.WriteLine($"Found elements count: {count}");
            Console.WriteLine("Positions: " + (positions.Count > 0 ? string.Join(", ", positions) : "No elements found"));
            Console.ReadKey();
        }
        static (int, List<int>) BinarySearch(int[] arr, int target)
        {
            List<int> positions = new List<int>();
            int first = FindFirst(arr, target);
            if (first == -1)
            {
                return (0, positions);
            }
            int last = FindLast(arr, target);
            for (int i = first; i <= last; i++)
            {
                positions.Add(i);
            }
            return (positions.Count, positions);
        }
        static int FindFirst(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1, first = -1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] >= target)
                {
                    if (arr[mid] == target) first = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return first;
        }
        static int FindLast(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1, last = -1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] <= target)
                {
                    if (arr[mid] == target) last = mid;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return last;
        }
    }
}
