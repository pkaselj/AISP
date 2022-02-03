using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //1. Add class Student that inherits an interface IComparable.
    class Student : IComparable
    {


        //2. Declare a private field name of type string.
        private string _name;

        //3. Declare a private field grade of type float.
        private float _grade;

        //4. Create a constructor that initializes private fields.
        public Student(
            string name,
            float grade
        )
        {
            _name = name;
            _grade = grade;
        }

        //5. Implement public method Learn that displays a string into the console
        //window.
        public void Learn()
        {
            Console.WriteLine($"Student {_name} is learning...");
        }

        //6. Implement public method GetGrade that returns grade.
        public float GetGrade() => _grade;

        //7. Override method ToString that converts a Student to a string.
        public override string ToString()
        {
            return $"Student: {_name} with grade: {_grade:G03}";
        }

        //8. Implement method CompareTo which compares the current Student with the
        //one passes as a parameter.
        public int CompareTo(object obj)
        {
            Student other = obj as Student;
            return this._grade.CompareTo(other.GetGrade());
        }
    }
}
