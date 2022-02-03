using System;

namespace Comparables
{
    class Program
    {
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
            foreach (var _student in students)
            {
                Console.WriteLine(_student);
            }

            Bubble.Sort(students);

            Console.WriteLine("After sort: ");
            foreach (var _student in students)
            {
                Console.WriteLine(_student);
            }

            Console.ReadKey();

        }
    }
}
