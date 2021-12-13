using System;

namespace QuickSort
{
    class Program
    {
        static void Print(object[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item.ToString());
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
             new Student ("Joe", 4.7),
             new Student ("Tom", 4.4),
             new Student ("Iko", 4.6)
             };

            Print(students);

            Quick.Sort(
                students,
                0,
                students.Length - 1,
                Student.CompareName);

            Print(students);

            Quick.Sort(
                students,
                0,
                students.Length - 1,
                Student.CompareGrade);

            Print(students);

        }
    }
}
