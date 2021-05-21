using HangmanAPI;

namespace HangmanClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var hangman = new HangmanServer();
            
            var solution = hangman.Play();

            // input loop for client
            // loop through characters from console

            var guessResult = hangman.Guess('a');
        }
    }
}
