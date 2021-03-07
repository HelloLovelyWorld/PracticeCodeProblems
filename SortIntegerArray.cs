using System;

namespace Practice_CodingProblems
{
    class Practice
    {
        //C#: Create a program that will sort an integer array. 
        static void Main(string[] args)
        {
            int[] nums = { 8, 4, 9, 2, 6 };
            Array.Sort(nums);

            foreach (int number in nums)
            {
                Console.Write(number + " ");
            }
        }
    }
}
