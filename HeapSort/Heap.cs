using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeapSort
{
    class Heap
    {
        public static void Sort(int[] array)
        {
            Heapify(array);
            Arrange(array);
        }
        public static void Heapify(int[] array)
        {
            int last = array.Length - 1;

            //for(int i = 0; i < array.Length; i++)
            //{
            //    BubbleDown(array, i, last);
            //}
            for (int i = last / 2; i >= 0; i--)
            {
                BubbleDown(array, i, last);
            }
        }

        public static void Arrange(int[] array)
        {
            int last = array.Length - 1;
            while(last > 0)
            {
                Swap(array, 0, last--);
                BubbleDown(array, 0, last);
            }
        }

        private static int GetLargerChildIndex(int[] array, int i, int last)
        {
            int childIndex = -1;
            if(2 * i > last)
            {
                return childIndex;
            }
            else if (2 * i <= last && array[i] < array[2 * i])
            {
                childIndex = 2 * i;
            }

            if(2 * i + 1 <= last && array[2 * i + 1] > array[2 * i])
            {
                childIndex = 2 * i + 1;
            }

            return childIndex;
        }

        public static void BubbleDown(
            int[] array,
            int i,
            int last
        )
        {
            if (i > last)
            {
                return;
            }

            int largerChildIndex = GetLargerChildIndex(array, i, last);
            if(largerChildIndex != -1)
            {
                Swap(array, i, largerChildIndex);
                BubbleDown(array, largerChildIndex, last);
            }
        }

        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }


    }
}
