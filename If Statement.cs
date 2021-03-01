using System;

namespace Practice_CodingProblems
{
    class Practice
    {
        //Write a C# Sharp program to accept two integers and check whether they are equal or not.
        //Test Data :
        //Input 1st number: 5
        //Input 2nd number: 5
        //Expected Output :
        //5 and 5 are equal
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine($"{num1} and {num2} are equal.");
            }
            else
            {
                Console.WriteLine($"{num1} and {num2} are not equal.");
            }
        }
    }
}
