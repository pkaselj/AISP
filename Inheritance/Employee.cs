using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //1. Declare abstract class Employee.
    abstract class Employee
    {

        //2. Declare a private filed name of type string.
        private string _name;

        //3. Create a constructor that initializes private fields.
        public Employee(string name)
        {
            _name = name;
        }

        //4. Implement public virtual method CalculatePay that returns a decimal 0.0m.
        public virtual decimal CalculatePay()
        {
            return 0.0m;
        }

        //5. Override virtual method ToString that converts an Employee to a string. 
        public override string ToString()
        {
            return $"Employee: {_name} with pay: {CalculatePay():C2}";
        }


    }
}
