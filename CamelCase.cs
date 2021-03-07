using System;

namespace Practice_CodingProblems
{
    class Practice
    {
        // C#: Create a program that will return a string to a CamelCase.
        static void Main(string[] args)
        {
            string currentString = "I love technology";

            // Split the string into words.
            string[] words = currentString.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);

            // If there are 0 or 1 characters, just return the string.
            if (currentString == null || currentString.Length < 2)
            {
                Console.WriteLine(currentString);
            }

            // Combine the words.
            string result = words[0].ToLower();

            for (int i = 1; i < words.Length; i++)
            {
                result += words[i].Substring(0, 1).ToUpper() + words[i].Substring(1);
            }
            Console.WriteLine(result);
        }
    }
}
