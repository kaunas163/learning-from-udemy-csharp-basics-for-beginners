using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_42_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4 - Your job is to write a program for a speed camera.
             * For simplicity, ignore the details such as camera, sensors,
             * etc and focus purely on the logic. Write a program that
             * asks the user to enter the speed limit. Once set, the program 
             * asks for the speed of a car. If the user enters a value less
             * than the speed limit, program should display Ok on the console.
             * If the value is above the speed limit, the program should
             * calculate the number of demerit points. For every 5km/hr above
             * the speed limit, 1 demerit points should be incurred and
             * displayed on the console. If the number of demerit points is
             * above 12, the program should display License Suspended. */

            Console.WriteLine("What is the speed limit?");
            var limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How fast is the car going?");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed <= limit)
            {
                Console.WriteLine("OK");
            }
            else
            {
                var demerit = (carSpeed - limit) / 5 + 1;

                if (demerit > 12)
                {
                    Console.WriteLine("License suspended.");
                }
                else
                {
                    Console.WriteLine(demerit + " demerit points");
                }
            }
        }
    }
}
