﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Comparables
{
    class Bubble
    {
        public static void Sort(IComparable[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[i]) > 0)
                    {
                        IComparable temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
    }
}
