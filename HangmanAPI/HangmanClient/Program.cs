using HangmanAPI;
using System;

namespace HangmanClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var hangman = new HangmanServer();
            
            var solution = hangman.Play();

            Print(new string(solution));

            while (true)
            {
                try
                {
                    var toGuess = GetInput();

                    var result = hangman.Guess(toGuess);

                    solution = result.Solution;
                    switch(result.Status)
                    {
                        case Status.InProgress:
                            var message = result.SuccessfulGuess ? "Correct!" : "Wrong :/";
                            Print(new string(solution), message);
                            break;
                        case Status.Lost:
                            PrintLost();
                            break;
                        case Status.Won:
                            PrintWon(new string(solution));
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Print(new string(solution), ex.Message);
                }
            }
        }

        static char GetInput()
        {
            Console.WriteLine();
            Console.Write("Your guess: ");
            var input = Console.ReadLine();

            if (input.Length > 1)
            {
                throw new Exception("Only one character allowed per entry");
            }

            return input[0];
        }

        static void Print(string state, string message = null)
        {
            Console.Clear();
            Console.WriteLine("----- Hangman ----- ");
            Console.WriteLine(state);
            
            if (message != null)
            {
                Console.WriteLine();
                Console.WriteLine(message);
            }
        }

        static void PrintLost()
        {
            Console.Clear();
            Console.WriteLine("----- Hangman ----- ");
            Console.WriteLine("You lost :(");
        }

        static void PrintWon(string state)
        {
            Console.Clear();
            Console.WriteLine("----- Hangman ----- ");
            Console.WriteLine("You won! The word was " + state);
        }
    }
}
