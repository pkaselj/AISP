using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
    class Quick
    {
        public delegate bool Comparison(object a, object b);

        public static void Sort(
            object[] array,
            int left,
            int right,
            Comparison cmp)
        {
            if (left >= right) return;
            int last = Partition(array, left, right, cmp);
            Sort(array, left, last - 1, cmp);
            Sort(array, last + 1, right, cmp);
        }

        public static int Partition(
            object[] array,
            int left,
            int right,
            Comparison cmp)
        {
            object pivot = array[left];

            int last = left;

            for (int i = last + 1; i <= right; i++)
            {
                if(cmp(array[i], pivot) == true)
                {
                    Swap(array, ++last, i);
                }
            }

            Swap(array, left, last);
            return last;
        }

        private static void Swap(object[] array, int v, int i)
        {
            object temp = array[v];
            array[v] = array[i];
            array[i] = temp;
        }
    }
}
