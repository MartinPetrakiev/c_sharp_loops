using System;

namespace MyProject
{
    class Program
    {
        static int CalculateGreatestCommonDivisorOfTwo(string input)
        {
            string[] numbersArray = input.Split(' ');
            int a = int.Parse(numbersArray[0].ToString());
            int b = int.Parse(numbersArray[1].ToString());
            int biggestNumber = a - b >= 0 ? a : b;
            int greatestCommonDevisor = 1;

            for (int i = 1; i <= biggestNumber; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    greatestCommonDevisor = i;
                }
            }

            return greatestCommonDevisor;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;


            Console.WriteLine(CalculateGreatestCommonDivisorOfTwo(input));
        }
    }
}



/*
Description
Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.
Use the Euclidean algorithm (find it in Internet).

Input
On the first and only line of the input you will receive the 2 integers A and B, separated by a whitespace.

Output
Output a single number - the GCD of the numbers A and B.

Constraints
The numbers A and B will always be valid integers in the range [2, 500].
Time limit: 0.1s
Memory limit: 16MB
*/