using System;

namespace Selection
{
    class Program
    {
        public static void Sort(int[] array, int startingIndex)
        {
            // Base case
            if (startingIndex == array.Length)
            {
                return;
            }

            // Find min
            int indexOfMin = startingIndex;
            for (int i = startingIndex; i < array.Length; i++)
            {
                if (array[i] < array[indexOfMin])
                {
                    indexOfMin = i;
                }
            }

            // Swap
            int temp = array[startingIndex];
            array[startingIndex] = array[indexOfMin];
            array[indexOfMin] = temp;

            // Recursion
            Sort(array, startingIndex + 1);
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item},");
            }
            Console.WriteLine();
        }

    static void Main(string[] args)
        {
            int[] array = { 9, 8, 4, 11, 5, 7, 3, 1 };

            PrintArray(array);

            Sort(array, 0);

            PrintArray(array);

        }
    }
}
