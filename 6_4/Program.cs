using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4 - Write a program and ask the user to continuously
             * enter a number or type "Quit" to exit. The list of
             * numbers may include duplicates. Display the unique
             * numbers that the user has entered. */

            var numbers = new List<int>();
            string input;
            int temp_number;
            bool good;

            Console.WriteLine("Continuously enter numbers or type 'Quit' to exit.");

            do
            {
                input = Console.ReadLine();
                good = int.TryParse(input, out temp_number);
                if (good)
                {
                    numbers.Add(temp_number);
                }
            } while (good);

            var unique_numbers = new List<int>();

            foreach (var number in numbers)
            {
                if (!unique_numbers.Contains(number))
                {
                    unique_numbers.Add(number);
                }
            }

            var output = string.Join(", ", unique_numbers);
            Console.WriteLine("All unique numbers: " + output);
        }
    }
}
