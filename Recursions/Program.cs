using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Recursions
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }

        static int Fibonacci(int n)
        {
            if (n < 2) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static int FibonacciIter(int n)
        {
            if (n < 2) return n;
            int n_1 = 0;
            int n_2 = 1;
            int k = 0;
            for(int i = 2; i <= n + 1; i++)
            {
                k = n_1 + n_2;
                n_2 = n_1;
                n_1 = k;
            }
            return k;
        }

        private delegate int Fn(int a);
        static void CallAndPrintExecutionTime(Fn callback, int param)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int result = callback.Invoke(param);
            sw.Stop();
            Console.WriteLine($"Execution time: {sw.Elapsed} s");
        }

        static void Main(string[] args)
        {
            int n = 6;
            int result = Factorial(n);
            Console.WriteLine($"Factorial of {n} is {result}");
            result = Fibonacci(n);
            Console.WriteLine($"Fibonacci of {n} is {result}");
            result = FibonacciIter(n);
            Console.WriteLine($"FibonacciIter of {n} is {result}");

            n = 40;
            Console.WriteLine($"Recursive fibonacci for n = {n}:");
            CallAndPrintExecutionTime(Fibonacci, n);
            Console.WriteLine($"Iterative fibonacci for n = {n}:");
            CallAndPrintExecutionTime(FibonacciIter, n);
        }
    }
}
