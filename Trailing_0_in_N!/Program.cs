using System;
using System.Numerics;

namespace MyProject
{
    class Program
    {
        static int OutputTrailingZeroes(string input)
        {
            char[] factDigitsArray = input.ToCharArray();
            int countZeroes = 0;

            for (int i = factDigitsArray.Length - 1; i > -1; i--)
            {
                if (factDigitsArray[i].ToString() == "0")
                {
                    countZeroes++;
                }
                else
                {
                    break;
                }
            }
            return countZeroes;
        }

        static string FactorialOfNString(int input)
        {
            BigInteger factNumber = new BigInteger(1);

            for (int i = 1; i <= input; i++)
            {
                factNumber *= (BigInteger)i;
            }

            return factNumber.ToString();
        }
        static void Main(string[] args)
        {
            int inputInteger = int.Parse(Console.ReadLine()!);

            
            Console.WriteLine(OutputTrailingZeroes(FactorialOfNString(inputInteger)));
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