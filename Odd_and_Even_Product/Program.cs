using System;

namespace MyProject
{
    class Program
    {
        static string checkOddProductEqualEvenProduct(int n, string str)
        {
            int productOdd = 1;
            int productEven = 1;
            string result = "";
            // bool isOdd = true;

            // for (int i = 0; i < str.Length; i++)
            // {
            //     int currentNumber;
            //     if (Char.IsDigit(str[i]))
            //     {
            //         currentNumber = int.Parse(str[i].ToString());
            //     }
            //     else
            //     {
            //         continue;
            //     }

            //     if (isOdd)
            //     {
            //         productOdd *= currentNumber;
            //         isOdd = false;
            //     }
            //     else
            //     {
            //         isOdd = true;
            //         productEven *= currentNumber;
            //     }
            // }

            string[] numbers = str.Split(' ');

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = int.Parse(numbers[i].ToString());

                if (i % 2 == 0)
                {
                    productOdd *= currentNumber;
                }
                else
                {
                    productEven *= currentNumber;
                }
            }

            if (productOdd == productEven)
            {
                result = $"yes {productOdd}";
            }
            else
            {
                result = $"no {productOdd} {productEven}";
            }

            return result;
        }
        static void Main(string[] args)
        {
            int numberOfIntegers = int.Parse(Console.ReadLine()!);
            string elements = Console.ReadLine()!;

            Console.WriteLine(checkOddProductEqualEvenProduct(numberOfIntegers, elements));
        }
    }
}

/*
Description
You are given N integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to N, so the first element is odd, the second is even, etc.

Input
On the first line you will receive the number N
On the second line you will receive N numbers separated by a whitespace

Output
If the two products are equal, output a string in the format "yes PRODUCT_VALUE", otherwise write on the console "no ODD_PRODUCT_VALUE EVEN_PRODUCT_VALUE"

Constraints
N will always be a valid integer number in the range [4, 50]
All input numbers from the second line will also be valid integers
Time limit: 0.1s
Memory limit: 16MB
*/