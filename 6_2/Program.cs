using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2 - Write a program and ask the user to enter their
             * name. Use an array to reverse the name and then store
             * the result in a new string. Display the reversed
             * name on the console. */

            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();
            var name_letters = name.ToCharArray();
            Array.Reverse(name_letters);
            var reversed = new string(name_letters);
            Console.WriteLine("Reversed name: " + reversed);
        }
    }
}
