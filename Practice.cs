using System;

namespace Practice_CodingProblems
{
    class Practice
    {
        // Write a method to find the length of a string.
        static void Main(string[] args)
        {
            string myString = "Hello World";
            var length = myString.Length;

            Console.WriteLine($"This phrase is {length} characters long.");
        }
    }
}
