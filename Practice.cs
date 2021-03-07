using System;

namespace Practice_CodingProblems
{
    class Practice
    {
        // How to print out a reversed string.
        static void Main(string[] args)
        {
            string myString = "Hello World";
            var characters = myString.ToCharArray();
            var length = characters.Length;

            for (var i = length - 1; i >= 0; i--)
            {
                Console.Write(characters[i]);
            }
        }
    }
}
