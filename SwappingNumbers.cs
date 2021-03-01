using System;

namespace Practice_CodingProblems
{
    class SwappingNumbers
    {
        //Write a C# Sharp program to swap two numbers.
        static void Main(string[] args)
        {
            int num1, num2, temp;

            Console.WriteLine("Enter first number.");
            num1 = Int32.Parse(Console.ReadLine()); // 6
            Console.WriteLine("Enter second number.");
            num2 = Int32.Parse(Console.ReadLine()); // 5

            temp = num1; // 6
            num1 = num2; // 5
            num2 = temp; // 6

            Console.WriteLine("After swapping numbers:");
            Console.WriteLine("First Number: " + num1);
            Console.WriteLine("Second number: " + num2);
            
        }
    }
}
