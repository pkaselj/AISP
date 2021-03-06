using System;

namespace Comparables
{
    public class Student : IComparable
    {
        public string _name;
        public double _grade;

        public Student(string name, double grade)
        {
            _name = name;
            _grade = grade;
        }

        public int CompareTo(object obj)
        {
            Student other = obj as Student;

            return this._grade.CompareTo(other._grade);
        }

        public override string ToString()
        {
            //return $"Student {_name} with GPA: {_grade:F02}";
            return $"{_grade} : {_name}";
        }

    }
}
