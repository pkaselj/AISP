using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create an Employee object and assign it to a reference e of type Employee.
            // ERROR:
            // Employee e = new Employee("Ante");

           //2.Create a Manager object of type Worker and assign it to a reference ceo of
           //type Manager.

           //3.Declare a list of Employee-s.
           List<Employee> employees = new List<Employee>
            {
                new Worker("Ante",     12m,    150),
                new Worker("Ivo",      15m,    124),
                new Worker("Mate",     14.2m,  156),
                new Worker("Ana",      15.4m,  170),
                new Worker("Josipa",   12.6m,  180),
                new Manager("John",    2500m)
            };
            //5.Declare a variable total of type decimal and initialize it to 0.0m.
            decimal total = 0.0m;

            //6.Display all employees in stuff in the console window.
            //7.Calculate the overall pay of all employees in the stuff list and display it to the
            //console window. 
            foreach (var _employee in employees)
            {
                total += _employee.CalculatePay();
                Console.WriteLine(_employee);
            }
        }
    }
}
