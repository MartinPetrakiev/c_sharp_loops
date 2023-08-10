using System;

namespace MyProject
{
    class Program
    {
        static long BinaryToDecimal(string str)
        {
            char[] binaryNumberDigits = str.ToCharArray();
            long decimalOutput = 0;
            int power = binaryNumberDigits.Length - 1;

            for (int i = 0; i < binaryNumberDigits.Length; i++)
            {
                long currentDigit = long.Parse(binaryNumberDigits[i].ToString());

                decimalOutput += currentDigit * (long)Math.Pow(2, power);

                power--;
            }

            return decimalOutput;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;

            Console.WriteLine(BinaryToDecimal(input));
        }
    }
}

/*
Description
Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.

Input
You will receive exactly one line containing an integer number representation in binary

Output
On the only output line write the decimal representation of the number

Constraints
All input numbers will be valid 32-bit integers
Time limit: 0.1s
Memory limit: 16MB
*/