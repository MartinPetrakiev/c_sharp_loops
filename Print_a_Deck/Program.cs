using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine()!;
            char card = input == "10" ? '\x000A' : char.Parse(input);
            int loopCounts = 0;

            switch (card)
            {
                case 'A':
                    loopCounts = 14;
                    break;
                case 'J':
                    loopCounts = 11;
                    break;
                case 'Q':
                    loopCounts = 12;
                    break;
                case 'K':
                    loopCounts = 13;
                    break;
                case '\x000A':
                    loopCounts = 10;
                    break;
                default:
                    loopCounts = int.Parse(card.ToString());
                    break;
            }

            for (int i = 2; i <= loopCounts; i++)
            {
                switch (i)
                {
                    case 14:
                        Console.WriteLine("A of spades, A of clubs, A of hearts, A of diamonds");
                        break;
                    case 11:
                        Console.WriteLine("J of spades, J of clubs, J of hearts, J of diamonds");
                        break;
                    case 12:
                        Console.WriteLine("Q of spades, Q of clubs, Q of hearts, Q of diamonds");
                        break;
                    case 13:
                        Console.WriteLine("K of spades, K of clubs, K of hearts, K of diamonds");
                        break;
                    default:
                        Console.WriteLine($"{i} of spades, {i} of clubs, {i} of hearts, {i} of diamonds");
                        break;
                }
            }
        }
    }
}

/*
Description
Write a program that reads a card sign(as a char) from the console and generates and prints all possible cards from a standard deck of 52 cards up to the card with the given sign(without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades.

Input
On the only line, you will receive the sign of the card to which, including, you should print the cards in the deck.

Output
The output should follow the format bellow(assume our input is 5):
2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
...
5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds

Constraints
The input character will always be a valid card sign.
Time limit: 0.1s
Memory limit: 16MB
*/
