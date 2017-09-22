using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_48_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2 - Write a program and continuously ask the user to enter
             * a number or "ok" to exit. Calculate the sum of all the
             * previously entered numbers and display it on the console. */

            int temp_number;
            string temp_input;
            var sum = 0;

            do
            {
                Console.WriteLine("Enter a number or 'ok' to exit");
                temp_input = Console.ReadLine();
                var success = int.TryParse(temp_input, out temp_number);

                if (success)
                {
                    sum += temp_number;
                }
            } while (temp_input.ToLower() != "ok");

            Console.WriteLine("Sum of entered numbers: " + sum);
        }
    }
}
