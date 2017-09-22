using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_48_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4 - Write a program that picks a random number between
             * 1 and 10. Give the user 4 chances to guess the number.
             * If the user guesses the number, display “You won";
             * otherwise, display “You lost". (To make sure the program
             * is behaving correctly, you can display the secret
             * number on the console first.) */

            var random = new Random();
            var secret = random.Next(1, 11);
            var chances = 4;

            //Console.WriteLine("secret number: " + secret);

            while (chances > 0)
            {
                Console.Write("Guess secret number: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (secret == guess)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong");
                    chances--;
                }
            }

            if (chances == 0)
            {
                Console.WriteLine("You lost!");
            }
        }
    }
}
