using System;

namespace MyProject
{
    class Program
    {
        static long HexToDecimal(string str)
        {
            char[] hexNumberDigits = str.ToCharArray();
            long decimalOutput = 0;
            int power = hexNumberDigits.Length - 1;

            for (int i = 0; i < hexNumberDigits.Length; i++)
            {
                int currentDigit = 0;

                switch (hexNumberDigits[i])
                {
                    case 'A':
                        currentDigit = 10;
                        break;
                    case 'B':
                        currentDigit = 11;
                        break;
                    case 'C':
                        currentDigit = 12;
                        break;
                    case 'D':
                        currentDigit = 13;
                        break;
                    case 'E':
                        currentDigit = 14;
                        break;
                    case 'F':
                        currentDigit = 15;
                        break;
                    default:
                        currentDigit = int.Parse(hexNumberDigits[i].ToString());
                        break;
                }

                decimalOutput += currentDigit * (long)Math.Pow(16, power);

                power--;
            }

            return decimalOutput;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;

            Console.WriteLine(HexToDecimal(input));
        }
    }
}

/*
Description
Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.

Input
The input will consists of a single line containing a single hexadecimal number as string.

Output
The output should consist of a single line - the decimal representation of the number as string.

Constraints
All numbers will be valid 64-bit integers.
Time limit: 0.1s
Memory limit: 16MB
*/