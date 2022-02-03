using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        //1.Implement method ReadInt that reads an int from the keyboard and returns it.
        static int ReadInt()
        {
            Console.Write("Enter an integer: ");
            return Int32.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {

            try
            {
                //2.In method Main read two integers from the keyboard. Take care about the
                //possible exceptions.
                int a = ReadInt();
                int b = ReadInt();

                //3.Divide integers and display the result in the console window.Take care about
                //possible exceptions.
                Console.WriteLine(a/b);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine($"Arithmetic error: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Input format error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }


            //4.Run the program provoking exceptions
        }
    }
}
