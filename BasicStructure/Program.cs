using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 12;
            char c = 'A';
            float f = 2.5f;
            decimal d = 13.25m;
            string s = "This is a string.";

            Console.WriteLine($"i = {i:D3}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"f = {f:G}");
            Console.WriteLine($"d = {d:C6}");
            Console.WriteLine($"s = {s}");

            Console.Write("radius = ");

            double radius = Double.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);

            Console.WriteLine(circle);

        }
    }
}
