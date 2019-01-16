using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a number between 1 and 10.");
            string userGuess = Console.ReadLine();
            Console.WriteLine("You guessed: " + userGuess);

            // if the user guess 7
            if (userGuess.Equals("7"))
            {
                // then they win
                Console.WriteLine("YOU WIN!");
            }
            else
            {
                // otherwise the lose
                Console.WriteLine("You lose.");
            }
        }
    }
}
