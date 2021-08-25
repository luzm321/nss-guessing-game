using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
            Let's Play a Guessing Game! Can you guess the secret number between 1 and 100?
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


            Console.WriteLine(@"
                Please choose a difficulty level:
                ~Easy (8 Chances to Guess)
                ~Medium (6 Chances to Guess)
                ~Hard (4 Chances to Guess)
                ~Cheater (Unlimited Chances to Guess! :O)
            ");

            Console.Write("Enter your choice: "); // prompting user to choose difficulty level
            string difficultyLevel = Console.ReadLine().ToLower(); // storing user's choice of difficulty level

            Console.Write($"Enter your guess: ");
            string guess = Console.ReadLine(); // storing user's guess
            int parsedGuess = int.Parse(guess); // converting guess from a string to int
            Random randomNum = new Random(); // instantiating new Random number object from static method
            int secretNum = randomNum.Next(1, 100); // storing random number between 1 and 100 into secretNum variable
            int guessCount = 0; // initial guess count
            int guessLimit; // guess limit of 4 chances to guess secret number since initial count is 0
            bool outOfGuesses = false; // boolean indicating if user is out of guesses

            // Determines number of chances user has to guess number depending on difficulty level chosen:
            if (difficultyLevel == "easy")
            {
                guessLimit = 7;
            }
            else if (difficultyLevel == "medium")
            {
                guessLimit = 5;
            }
            else if (difficultyLevel == "hard")
            {
                guessLimit = 3;
            }
            else
            {
                guessLimit = int.MaxValue; // a property of the integer data type that represents the largest possible value of an int 
            }

            // while user's guess does not match secret number and user is not out of guesses, keep looping/asking user to guess
            while (parsedGuess != secretNum && !outOfGuesses)
            {
                if (guessCount < guessLimit) // if user has not reach guess limit, execute code below:
                {
                    if (parsedGuess > secretNum)
                    {
                        Console.WriteLine(@" 
                            _...._
                          .`      `.
                         / ***      \         
                        : **         :   Aww, you guessed incorrectly!      
                        :            :   Your guess was too high!                             
                         \          /    Please try again! 
                          `-.,,,,.-'             
                           _(    )_
                          )        (
                         (          )
                          `-......-`  
                        ");

                        int guessesLeft = guessLimit - guessCount; // variable will store number of guesses user has left and displays count:
                        Console.Write($"Enter your guess, you have {guessesLeft} guesses left: "); // prompt user to guess number again
                        parsedGuess = int.Parse(Console.ReadLine()); // converting string to int and storing user's guess to variable
                        guessCount++; // increment the guess count for each guess
                    }
                    else
                    {
                        Console.WriteLine(@" 
                            _...._
                          .`      `.
                         / ***      \         
                        : **         :   Aww, you guessed incorrectly!      
                        :            :   Your guess was too low!                             
                         \          /    Please try again! 
                          `-.,,,,.-'             
                           _(    )_
                          )        (
                         (          )
                          `-......-`  
                        ");

                        int guessesLeft = guessLimit - guessCount; // variable will store number of guesses user has left and displays count:
                        Console.Write($"Enter your guess, you have {guessesLeft} guesses left: "); // prompt user to guess number again
                        parsedGuess = int.Parse(Console.ReadLine()); // converting string to int and storing user's guess to variable
                        guessCount++; // increment the guess count for each guess
                    }
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
