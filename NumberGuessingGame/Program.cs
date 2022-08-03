using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void promptUserForNumber(out string numberGuessString) {
            Console.WriteLine("What's your guess?");
            numberGuessString = Console.ReadLine();
        }

        static void obtainAndValidateNumber(out int numberGuessInt) {
            string numberGuessString;
            promptUserForNumber(out numberGuessString);
            while (!Int32.TryParse(numberGuessString, out numberGuessInt)) {
                Console.WriteLine("Hmmm, that doesn't look like a number. Try again.");
                promptUserForNumber(out numberGuessString);
            }
        }

        static void Main(string[] args)
        {
            // Introduction + initial prompt.
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 ad 20.");
            Console.WriteLine("Enter your guess, Or -1 to give up.");
            
            // Generate target number.
            int targetNumber = new Random().Next(20);

            // Create variable that will hold the integer guess from the user.
            int numberGuessInt;

            // Initialize guessCount.
            int guessCount = 0;

            // Obtain the number from the user and ensure that it is valid. If not, re-prompt.
            obtainAndValidateNumber(out numberGuessInt);

            // Ask user for new guesses until they succeed, or quit.
            while (numberGuessInt != -1) {
                if (numberGuessInt < targetNumber) {
                    // Too high.
                    guessCount++;
                    Console.WriteLine("Nope, higher than that.");
                    obtainAndValidateNumber(out numberGuessInt);
                } else if (numberGuessInt > targetNumber) {
                    // Too low.
                    guessCount++;
                    Console.WriteLine("Nope, lower than that.");
                    obtainAndValidateNumber(out numberGuessInt);
                } else {
                    // BINGO.
                    Console.WriteLine($"You got it in {guessCount} guesses!!");
                    break;
                }
            }



        }
    }
}
