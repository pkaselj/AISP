using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create four object of type Student.
            Student student1 = new Student("Anto", 4.54f);
            Student student2 = new Student("Ivo", 3.44f);
            Student student3 = new Student("Ana", 2.56f);
            Student student4 = new Student("Maja", 4.86f);

            //2.Display the objects to the console window.
            Console.WriteLine(student1);
            Console.WriteLine(student2);
            Console.WriteLine(student3);
            Console.WriteLine(student4);

            //3.Create an array students of six students.
            //4.Add all students into the array.
            Student[] students = new Student[]
            {
                student1,
                student2,
                student3,
                student4
            };

            //5.Find the average grade of all students in students and display in in the console
            //window.

            double sum = 0.0d;
            foreach (var _student in students)
            {
                sum += _student.GetGrade();
            }
            double avgGrade = sum / students.Count();
            Console.WriteLine($"The average grade is: {avgGrade:G03}");


            //6.Using method Array.Sort sort the students.
            Array.Sort(students);

            //7.Display sorted students in the console window
            foreach (var _student in students)
            {
                Console.WriteLine(_student);
            }
        }
    }
}
