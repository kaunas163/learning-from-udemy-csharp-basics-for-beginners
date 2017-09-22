using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 2 - Write a program that reads a text
             * file and displays the longest word in
             * the file. */

            var text = File.ReadAllLines("Text.txt");
            var longest = "";

            foreach (var line in text)
            {
                var words = line.Split(' ', ',', '.');
                foreach (var word in words)
                {
                    if (word.Length > longest.Length)
                    {
                        longest = word;
                    }
                }
            }

            Console.WriteLine("Longest word: " + longest);
        }
    }
}
