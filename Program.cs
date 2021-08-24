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

            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            int parsedGuess = int.Parse(guess);
            int secretNum = 21;

            if (parsedGuess == secretNum)
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
            else
            {
                Console.WriteLine(@"
                        
                      _...._
                    .`      `.
                   / ***      \         
                  : **         :         
                  :            :    Aww, you guessed incorrectly!                             
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
