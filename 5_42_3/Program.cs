using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_42_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 3 - Write a program and ask the user to enter the width
             * and height of an image. Then tell if the image is
             * landscape or portrait. */

            Console.Write("Enter image width: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("Image is landscape");
            }
            else if (width < height)
            {
                Console.WriteLine("Image is portrait");
            }
            else
            {
                Console.WriteLine("Image is square");
            }
        }
    }
}
