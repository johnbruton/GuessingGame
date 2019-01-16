using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please guess a number between 1 and 10, or enter 0 for HELP.");
            string userGuess = Console.ReadLine();

            if (userGuess.Equals("0"))
            {
                Console.WriteLine("===  ISTRUCTIONS  ===");
                Console.WriteLine("Guess a number between 1 and 10");
                Console.WriteLine("Hit enter to submit your guess.");

                userGuess = Console.ReadLine();
            }

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

                // if the user guess 0
               
            }
        }
    }
}