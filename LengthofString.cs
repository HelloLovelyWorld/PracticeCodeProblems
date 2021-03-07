using System;

namespace Practice_CodingProblems
{
    class Practice
    {
        //Write a methed that finds the length of a string.
        static void Main(string[] args)
        {
            string mySentence = "I love technology.";
            var sentenceLength = mySentence.Length;

            Console.WriteLine($"My sentence is: {mySentence}");
            Console.WriteLine($"It has {sentenceLength} characters in it.");
        }
    }
}
