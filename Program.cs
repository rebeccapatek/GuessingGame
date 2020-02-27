using System;

namespace GuessingGame {
    class Program {
        static void Main (string[] args) {
            Random rand = new Random ();
            int secretNumber = rand.Next (1, 11);
            for (int i = 0; i < 3; i++) {

                Console.WriteLine ("Guess a number from 1 to 10");
                string userGuess = Console.ReadLine ();
                int userGuessInt = int.Parse (userGuess);
                if (userGuessInt == secretNumber) {
                    Console.WriteLine ($"You guessed it! It was {secretNumber}");
                    return;
                } else if (userGuessInt > secretNumber && i != 2) {
                    Console.WriteLine ("Nope, try sometime lower");
                } else if (userGuessInt < secretNumber && i != 2) {
                    Console.WriteLine ("Try Something higher");
                } else if (userGuessInt != secretNumber && i == 2) {
                    Console.WriteLine ($"Game Over, it was {secretNumber}");
                }
            }
        }
    }
}