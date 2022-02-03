using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //1. Declare class Manager that inherits class Employee.
    class Manager : Employee
    {

        //2. Declare a private filed salary of type decimal.
        private decimal _salary;

        //3. Create a constructor that initializes private fields.
        public Manager(
            string name,
            decimal salary
        ) : base(name)
        {
            _salary = salary;
        }

        //4. Implement public virtual method CalculatePay which calculates the pay for a
        //Manager as a fixed value salary.

        public override decimal CalculatePay()
        {
            return _salary;
        }
    }
}
