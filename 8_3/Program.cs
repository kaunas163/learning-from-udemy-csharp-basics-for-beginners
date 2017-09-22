using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3 - Write a program and ask the user to
             * enter a time value in the 24-hour time
             * format (e.g. 19:00). A valid time should
             * be between 00:00 and 23:59. If the time
             * is valid, display "Ok"; otherwise,
             * display "Invalid Time". If the user
             * doesn't provide any values, consider it
             * as invalid time.  */

            Console.WriteLine("Enter a time value in the 24-hours time format");
            var input = Console.ReadLine();

            var numbers = Array.ConvertAll(input.Split(':'), n => Convert.ToInt32(n));

            if (numbers.Length != 2 || numbers[0] < 0 || numbers[0] > 23
                || numbers[1] < 0 || numbers[1] > 59)
            {
                Console.WriteLine("Invalid time");
            }
            else
            {
                Console.WriteLine("Ok");
            }
        }
    }
}
