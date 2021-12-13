using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
    class Student
    {
        private string _name;
        private double _grade;

        public Student(string name, double grade)
        {
            _name = name;
            _grade = grade;
        }

        public override string ToString()
        {
            return $"Student: {_name}, Grade: {_grade}";
        }

        public static bool CompareName(object student1, object student2)
        {
            return (student2 as Student)._name.CompareTo((student1 as Student)._name) > 0;
        }

        public static bool CompareGrade(object student1, object student2)
        {
            return (student2 as Student)._grade.CompareTo((student1 as Student)._grade) > 0;
        }

    }
}
