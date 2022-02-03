using Comparables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparers
{
    class Program
    {
        static void Display(IEnumerable<object> array)
        {
            foreach (var obj in array)
            {
                Console.Write($"{obj}\n");
            }

            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Student[] students = {
             new Student ("Ivo", 4.1),
             new Student ("Ana", 4.9),
             new Student ("Iva", 4.3),
             new Student ("Bob", 4.5),
             new Student ("Joe", 4.7)
             };

            Display(students);

            StudentComparer comparer_name = new StudentComparer(StudentComparerType.Name);

            Bubble.Sort(students, comparer_name);

            Display(students);

            StudentComparer comparer_grade = new StudentComparer(StudentComparerType.Grade);

            Bubble.Sort(students, comparer_grade);

            Display(students);


        }
    }
}
