using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparisons
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
            return $"{_name} : {_grade}";
        }

        public static bool CompareName(object a, object b)
        {
            Student _this = a as Student;
            Student _other = b as Student;
            return _this._name.CompareTo(_other._name) > 0;
        }

        public static bool CompareGrade(object a, object b)
        {
            Student _this = a as Student;
            Student _other = b as Student;
            return _this._grade.CompareTo(_other._grade) > 0;
        }


    }
}
