using System;

namespace Practice_CodingProblems
{
    class LongestWord
    {
        // Write a method that displays the longest word in a sentence.
        static void Main(string[] args)
        {
            string mySentence = "I love technology.";
            var largestWord = " ";
            string[] array = mySentence.Split(' ');


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length >largestWord.Length)
                {
                    largestWord = array[i];
                }
            }
            Console.WriteLine($"The sentence is: \"{mySentence}\"");
            Console.WriteLine($"The largest word in this sentence is: {largestWord}");
        }
    }
}
