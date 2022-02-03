using Comparables;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparers
{

    enum StudentComparerType { Name, Grade }
    class StudentComparer : IComparer
    {
        private StudentComparerType _criterion;
        private fnComparison _comparerFunction = null;

        public StudentComparer(StudentComparerType criterion)
        {
            _criterion = criterion;

            switch (_criterion)
            {
                case StudentComparerType.Name:
                    _comparerFunction = (x, y) => (x as Student)._name.CompareTo((y as Student)._name);
                break;

                case StudentComparerType.Grade:
                    _comparerFunction = (x, y) => (x as Student)._grade.CompareTo((y as Student)._grade);
                break;
            }
        }

        private delegate int fnComparison(object x, object y);
        public int Compare(object x, object y)
        {
            return _comparerFunction(x, y);
        }
    }
}
