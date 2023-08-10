using System;

namespace MyProject
{
    class Program
    {
        static string DecimalToHex(string str)
        {
            long decimalNumber = long.Parse(str);
            string result = "";
            long quotient = decimalNumber;

            while (quotient > 0)
            {
                long remainder = quotient % 16;

                switch (remainder)
                {
                    case 10:
                        result += "A";
                        break;
                    case 11:
                        result += "B";
                        break;
                    case 12:
                        result += "C";
                        break;
                    case 13:
                        result += "D";
                        break;
                    case 14:
                        result += "E";
                        break;
                    case 15:
                        result += "F";
                        break;
                    default:
                        result += remainder;
                        break;
                }

                quotient = Math.DivRem(quotient, 16, out remainder);
            }

            char[] HexDigitsArray = result.ToCharArray();
            string hexOutput = String.Empty;
            for (int i = HexDigitsArray.Length - 1; i > -1; i--)
            {
                hexOutput += HexDigitsArray[i];
            }

            return hexOutput;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;

            Console.WriteLine(DecimalToHex(input));
        }
    }
}

/*
Description
Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.

Input
On the first and only line you will receive an integer in the decimal numeral system.

Output
On the only output line write the hexadecimal representation of the read number.

Constraints
All numbers will always be valid 64-bit integers.
Time limit: 0.1s
Memory limit: 16MB
*/