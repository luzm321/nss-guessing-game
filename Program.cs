using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
            Let's Play a Guessing Game! Can you guess the secret number?
                _...._
              .`      `.
             / ***      \         
            : **         :         
            :            :                                        
             \          /       
              `-.,,,,.-'              
               _(    )_
              )        (
             (          )
              `-......-`
            ");

            Console.Write("Enter your guess: ");
            string guess = Console.ReadLine();
            int parsedGuess = int.Parse(guess); // converting string to int
            int secretNum = 21;
            int guessCount = 0; // initial guess count
            int guessLimit = 3; // guess limit of 4 chances to guess secret number since initial count is 0
            bool outOfGuesses = false; // boolean indicating if user is out of guesses

            // while user's guess does not match secret number and user is not out of guesses, keep looping/asking user to guess
            while (parsedGuess != secretNum && !outOfGuesses)
            {
                if (guessCount < guessLimit) // if user has not reach guess limit, execute code below:
                {
                    Console.WriteLine(@" 
                      _...._
                    .`      `.
                   / ***      \         
                  : **         :         
                  :            :   Aww, you guessed incorrectly!                             
                   \          /    Please try again! 
                    `-.,,,,.-'             
                     _(    )_
                    )        (
                   (          )
                    `-......-`  
                    ");

                    int guessesLeft = guessLimit - guessCount; // variable will store number of guesses left and display count:
                    Console.Write($"Enter your guess, you have {guessesLeft} guesses left: "); // prompt user to guess number again
                    parsedGuess = int.Parse(Console.ReadLine()); // converting string to int and storing user's guess to variable
                    guessCount++; // increment the guess count for each guess
                }
                else
                {
                    outOfGuesses = true;
                }
            }

            if (outOfGuesses)
            {
                Console.WriteLine(@"
                    _...._
                  .`      `.
                 / ***      \         
                : **         :    You guessed incorrectly!     
                :            :    Sorry, you are out of guesses!                             
                 \          /       
                  `-.,,,,.-'              
                   _(    )_
                  )        (
                 (          )
                  `-......-`  
                ");
            }
            else
            {
                Console.WriteLine(@"
                    _...._
                  .`      `.
                 / ***      \         
                : **         :         
                :            :    Yay, you got it right!                             
                 \          /       
                  `-.,,,,.-'              
                   _(    )_
                  )        (
                 (          )
                  `-......-`  
                ");
            }
        }
    }
}
