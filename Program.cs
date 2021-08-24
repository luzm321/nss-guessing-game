using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Let's Play A Guessing Game! Can you guess the secret number?");
            // Console.Write("What is your guess? ");
            // string guess = Console.ReadLine();
            // Console.WriteLine($"Your guess is: {guess}");
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
            Console.WriteLine($"Your guess is: {guess}");
        }
    }
}
