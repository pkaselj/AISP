using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Program
    {
        static void Display(IEnumerable<int> array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] array = { 5, 6, 8, 3, 4, 2, 1, 7, 3, 5, 4, 5, 4, 8 };

            Display(array);

            Heap.Sort(array);

            Display(array);

            Console.ReadKey();

        }
    }
}
