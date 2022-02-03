using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //1. Declare class Worker that inherits class Employee.
    class Worker : Employee
    {
        //2. Declare a private filed wage of type decimal.
        private decimal _wage;

        //3. Declare a private filed hours of type int.
        private int _hours;

        //4. Create a constructor that initializes private fields.
        public Worker(
            string name,
            decimal wage,
            int hours
        ) : base(name)
        {
            _wage = wage;
            _hours = hours;
        }

        //5. Implement public virtual method CalculatePay which calculates the pay for a
        //Worker by multiplying wage with hours.
        public override decimal CalculatePay()
        {
            return _wage * _hours;
        }

    }
}
