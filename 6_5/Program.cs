using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 5 - Write a program and ask the user to supply a list
             * of comma separated numbers (e.g 5, 1, 9, 2, 10). If the
             * list is empty or includes less than 5 numbers, display
             * "Invalid List" and ask the user to re-try; otherwise,
             * display the 3 smallest numbers in the list. */

            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Please supply a list of comma seperated numbers.");
                var input = Console.ReadLine();
                var splitted = input.Split(',');
                var converted = Array.ConvertAll(splitted, n => Convert.ToInt32(n));

                if (converted.Length < 5)
                {
                    Console.WriteLine("Invalid list. Please re-try.");
                    continue;
                }

                numbers.AddRange(converted);
                break;
            }

            numbers.Sort();
            Console.Write("Smallest numbers are: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
