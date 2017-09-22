using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 5 - Write a program and ask the user
             * to enter an English word. Count the
             * number of vowels (a, e, o, u, i) in
             * the word. So, if the user enters
             * "inadequate", the program should display
             * 6 on the console. */

            Console.WriteLine("Enter an English word");
            var input = Console.ReadLine().ToLower();

            var sum = 0;

            foreach (var letter in input)
            {
                if (letter == 'a' || letter == 'e' || letter == 'o'
                    || letter == 'u' || letter == 'i')
                {
                    sum++;
                }
            }

            Console.WriteLine("Number of vowels: " + sum);
        }
    }
}
