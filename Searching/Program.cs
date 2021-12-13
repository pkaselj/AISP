using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class Program
    {
        static int SequentialSearch(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target) return i;
            }
            return -1;
        }

        static int BinarySearch(int[] array, int target, int low, int high)
        {
            int pivot = (high + low) / 2;
            if(low == pivot)
            {
                return (array[pivot] == target) ? low : -1;
            }

            int current = array[pivot];
            if(current == target)
            {
                return pivot;
            }
            else if(target > current)
            {
                return BinarySearch(array, target, pivot + 1, high);
            }
            return BinarySearch(array, target, low, pivot);
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            int target = 6;
            int index = SequentialSearch(array, target);
            Console.WriteLine($"Sequential search for {target}; index = {index}");

            index = BinarySearch(array, target, 0, array.Length);
            Console.WriteLine($"Binary search for {target}; index = {index}");
        }
    }
}
