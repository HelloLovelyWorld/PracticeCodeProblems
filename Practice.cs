using System;

namespace Practice_CodingProblems
{
    class Practice
    {
        // Write a method that prints out a reversed string.
        static void Main(string[] args)
        {
            var word = "technology";
            var wordTochar = word.ToCharArray();
            var length = wordTochar.Length;

            for (int i = length - 1; i >= 0; i--)
            {
                Console.Write(wordTochar[i]);
            }
        }
    }
}
