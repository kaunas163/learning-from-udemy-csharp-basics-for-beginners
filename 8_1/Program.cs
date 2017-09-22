using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1 - Write a program and ask the user to enter
             * a few numbers separated by a hyphen. Work out
             * if the numbers are consecutive. For example,
             * if the input is "5-6-7-8-9" or "20-19-18-17-16",
             * display a message: "Consecutive"; otherwise,
             * display "Not Consecutive". */

            Console.WriteLine("Enter a few numbers separated by a hyphen (-).");
            var input = Console.ReadLine();
            var splitted = input.Split('-');
            var numbers = Array.ConvertAll(splitted, s => Convert.ToInt32(s));

            var consecutive = true;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] + 1 != numbers[i + 1] && numbers[i] - 1 != numbers[i + 1])
                {
                    consecutive = false;
                    break;
                }
            }

            if (consecutive)
            {
                Console.WriteLine("Numbers are consecutive.");
            }
            else
            {
                Console.WriteLine("Numbers are not consecutive");
            }
        }
    }
}
