using System;

namespace Practice_CodingProblems
{
    class Average
    {
        //Write a C# Sharp program that takes four numbers as input to calculate and print the average.
        //Test Data:
        //Enter the First number: 10
        //Enter the Second number: 15
        //Enter the third number: 20
        //Enter the four number: 30

        //Expected Output:
        //The average of 10 , 15 , 20 , 30 is: 18
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the third number: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the fourth number: ");
            int num4 = int.Parse(Console.ReadLine());

            int average = (num1 + num2 + num3 + num4) / 4;

            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4}", num1, num2, num3,num4, average);
        }
    }
}
