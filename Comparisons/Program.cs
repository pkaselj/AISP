using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparisons
{

    class Program
    {
        static void Display(Student[] students)
        {
            foreach (var _student in students)
            {
                Console.WriteLine(_student);
            }
            Console.WriteLine("=================================");
        }
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student("Ivo", 4.1),
                new Student("Ana", 4.9),
                new Student("Iva", 4.3),
                new Student("Bob", 4.5),
                new Student("Joe", 4.7)
            };

            Console.WriteLine("Before sort: ");
            Display(students);

            Bubble.Sort(students, Student.CompareName);
            Display(students);

            Bubble.Sort(students, Student.CompareGrade);
            Display(students);
        }
    }
}
