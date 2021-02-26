using System;

namespace Practice_CodingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            // “FizzBuzz” is an interview question asked during interviews to check logical skills of developers.
            // For Demonstration, we will print number starting from 1 to 100. When a number is multiple of three,
            // print “Fizz” instead of a number on the console and if multiple of five then print “Buzz” on the console.
            // For numbers which are multiple of three as well five, print “FizzBuzz” on the console.

            for (int i = 1; i <= 100; i++) // using a for-loop to run through numbers 1-100
            {
                if (i % 3 == 0 && i % 5 == 0) //Check to see if numbers are multiples of 3 and 5
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0) //Check to see if numbers are multiples of only 3
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0) //Check to see if numbers are multiples of only 5
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i); //Will print out the numbers that aren't multiples of 3 or 5
                }
            }
        }
    }
}
