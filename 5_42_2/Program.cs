using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_42_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2 - Write a program which takes two numbers from the
             * console and displays the maximum of the two. */

            Console.WriteLine("Enter two numbers:");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Bigger number is: ");

            if (firstNumber > secondNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (secondNumber > firstNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else
            {
                Console.WriteLine("Numbers are equal.");
            }
        }
    }
}
