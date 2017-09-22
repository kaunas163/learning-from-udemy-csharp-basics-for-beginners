using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2 - Write a program and ask the user to enter
             * a few numbers separated by a hyphen. If the
             * user simply presses Enter, without supplying
             * an input, exit immediately; otherwise, check
             * to see if there are duplicates. If so, display
             * "Duplicate" on the console.  */

            Console.WriteLine("Enter a few numbers separated by a hyphen (-)");
            var input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                var numbers = new List<int>(Array.ConvertAll(input.Split('-'), s => Convert.ToInt32(s)));
                numbers.Sort();
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] == numbers[i+1])
                    {
                        Console.WriteLine("Dublicate");
                        break;
                    }
                }
            }
        }
    }
}
