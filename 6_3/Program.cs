using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3 - Write a program and ask the user to enter 5 numbers.
             * If a number has been previously entered, display an error
             * message and ask the user to re-try. Once the user
             * successfully enters 5 unique numbers, sort them and display
             * the result on the console. */

            var numbers = new List<int>();
            int temp_number;

            Console.WriteLine("Enter 5 unique numbers");

            do
            {
                do
                {
                    temp_number = Convert.ToInt32(Console.ReadLine());

                    if (numbers.Contains(temp_number))
                    {
                        Console.WriteLine("Number already exists. Please re-try.");
                        continue;
                    }

                    numbers.Add(temp_number);
                    break;

                } while (true);
            } while (numbers.Count < 5);

            numbers.Sort();
            Console.WriteLine("Entered and sorted numbers:");
            var output = string.Join(", ", numbers);
            Console.WriteLine(output);

            //foreach (var number in numbers)
            //{
            //    Console.Write(number + " ");
            //}
        }
    }
}
