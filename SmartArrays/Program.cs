using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartArrays
{
    class Program
    {
        static void Display(SmartArray array)
        {
            IEnumerator enumerator = array.GetEnumerator();
            while (enumerator.MoveNext())
            {
                int i = (int)enumerator.Current;
                Console.Write($"{i}, ");
            }
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            SmartArray smarty = new SmartArray(6);

            for (int i = 0; i < 8; i++)
            {
                smarty.Add(i);
            }

            Display(smarty);

            while(smarty.Length > 0)
            {
                Console.WriteLine($"Removing {smarty[0]}...");
                smarty.Remove(smarty[0]);
            }


        }
    }
}
