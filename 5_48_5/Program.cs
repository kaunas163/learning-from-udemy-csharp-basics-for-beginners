using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_48_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 5 - Write a program and ask the user to enter a series
             * of numbers separated by comma. Find the maximum of the
             * numbers and display it on the console. For example, if
             * the user enters “5, 3, 8, 1, 4", the program should
             * display 8. */

            Console.WriteLine("Enter a series of numbers seperated by comma");
            var input = Console.ReadLine();

            var input_split = input.Split(',');
            var numbers = Array.ConvertAll(input_split, n => Convert.ToInt32(n));
            
            var biggest = numbers.Max();
            Console.WriteLine("Biggest number: " + biggest);
        }
    }
}
