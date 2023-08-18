using System;

namespace MyProject
{
    class Program
    {
        static int CalculateGreatestCommonDivisorOfTwo(int a, int b)
        {
            while (b != 0)
            {
                var swapVar = b;
                b = a % b;
                a = swapVar;
            }

            return a;
        }

        static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine()!.Split(' ');

            int a = int.Parse(inputNumbers[0].ToString());
            int b = int.Parse(inputNumbers[1].ToString());

            Console.WriteLine(CalculateGreatestCommonDivisorOfTwo(a, b));
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