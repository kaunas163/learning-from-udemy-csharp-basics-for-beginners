using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1 - Write a program that reads a text
             * file and displays the number of words. */

            var word_count = 0;
            var text = File.ReadAllLines("Text.txt");
            foreach (var line in text)
            {
                var words = line.Split(' ');
                word_count += words.Length;
            }
            Console.WriteLine("Words in text file: " + word_count);
        }
    }
}
