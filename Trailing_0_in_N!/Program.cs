using System;

namespace MyProject
{
    class Program
    {
        static int OutputTrailingZeroes(int n)
        {
            int countZeroes = 0;

            for (int i = 5; n / i >= 1; i *= 5)
            {
                countZeroes += n / i;
            }
            return countZeroes;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(OutputTrailingZeroes(n));
        }
    }
}



/*
Description
Write a program that calculates with how many zeroes the factorial of a given number N has at its end.
Your program should work well for very big numbers, e.g. N = 100000.

Input
On the only input line, you will receive a single integer - the number N

Output
Output a single number - the count of trailing zeroes for the N!

Constraints
N will always be a valid positive integer number.
Time limit: 0.1s
Memory limit: 16MB
*/