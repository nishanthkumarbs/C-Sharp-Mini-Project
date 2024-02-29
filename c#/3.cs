using System;
using System.Collections.Generic;

namespace Substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            List<string> substrings = GetAllSubstrings(input);

            Console.WriteLine("All substrings:");
            foreach (string substring in substrings)
            {
                Console.WriteLine(substring);
            }
        }

        static List<string> GetAllSubstrings(string input)
        {
            List<string> substrings = new List<string>();

            for (int start = 0; start < input.Length; start++)
            {
                for (int length = 1; length <= input.Length - start; length++)
                {
                    string substring = input.Substring(start, length);
                    substrings.Add(substring);
                }
            }

            return substrings;
        }
    }
}
