using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_48_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3 - Write a program and ask the user to enter a number.
             * Compute the factorial of the number and print it on the
             * console. For example, if the user enters 5, the program
             * should calculate 5 x 4 x 3 x 2 x 1 and display it
             * as 5! = 120. */

            Console.Write("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            var sum = 1;

            for (int i = number; i > 0; i--)
            {
                sum *= i;
            }

            Console.WriteLine("{0}! = {1}", number, sum);
        }
    }
}
