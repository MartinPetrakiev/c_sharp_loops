using System;

namespace MyProject
{
    class Program
    {
        static string DecimalToBinary(string str)
        {
            long decimalNumber = long.Parse(str);
            string result = "";
            long quotient = decimalNumber;

            while (quotient > 0)
            {
                long remainder = quotient % 2;
                result += remainder;
                quotient = Math.DivRem(quotient, 2, out remainder);
            }

            char[] binaryDigitsArray = result.ToCharArray();
            string binaryOutput = String.Empty;
            for (int i = binaryDigitsArray.Length - 1; i > -1; i--)
            {
                binaryOutput += binaryDigitsArray[i];
            }

            return binaryOutput;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;

            Console.WriteLine(DecimalToBinary(input));
        }
    }
}

/*
Description
Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.

Input
On the only input line you will receive the decimal integer number.

Output
Output a single string - the representation of the input decimal number in it's binary representation.

Constraints
All numbers will always be valid 32-bit integers.
Time limit: 0.1s
Memory limit: 16MB
*/