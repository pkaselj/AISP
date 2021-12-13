using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparisons
{
    delegate bool Comparison(object a, object b);
    class Bubble
    {
        public static void Sort(object[] array, Comparison comparison)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(comparison(array[i], array[j]))
                    {
                        object temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }

}
