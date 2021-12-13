using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    class Program
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Console.WriteLine($"Before swap : A = {a}, B = {b}");

            Swap(ref a, ref b);

            Console.WriteLine($"After swap : A = {a}, B = {b}");



            int[] array = new int[]
            {
                2, 3, 4, 1, 8, 6, 5, 7
            };

            Console.WriteLine("Before swap: ");
            foreach (var item in array)
            {
                Console.Write($"{item}, ");
            }
            Console.Write("\n");

            Swap(ref array[2], ref array[3]);

            Console.WriteLine("After swap: ");
            foreach (var item in array)
            {
                Console.Write($"{item}, ");
            }
            Console.Write("\n");

            Console.ReadKey();

        }
    }
}
