using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 4 - Write a program and ask the user
             * to enter a few words separated by a
             * space. Use the words to create a
             * variable name with PascalCase. For
             * example, if the user types: "number
             * of students", display "NumberOfStudents".
             * Make sure that the program is not
             * dependent on the input. So, if the user
             * types "NUMBER OF STUDENTS", the
             * program should still display
             * "NumberOfStudents".  */

            Console.WriteLine("Write some words separated by a space");
            var input = Console.ReadLine().ToLower();
            
            var splitted_words = input.Split(' ');
            string result = "";

            foreach (var word in splitted_words)
            {
                result += char.ToUpper(word[0]) + word.Substring(1);
            }

            Console.WriteLine("PascalCase: " + result);
        }
    }
}
