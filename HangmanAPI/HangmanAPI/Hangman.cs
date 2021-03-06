using System;
using System.Linq;

namespace HangmanAPI
{
    public class HangmanServer : IHangman
    {
        Hangman _hangman;

        public HangmanServer()
        {
            _hangman = new Hangman("apekatt", 10);
        }

        public char[] Play()
        {
            return _hangman.Play();
        }

        public GuessResult Guess(char guess)
        {
            return _hangman.Guess(guess);
        }
    }

    public interface IHangman
    {
        char[] Play();

        GuessResult Guess(char guess);
    }

    public class Hangman
    {
        private readonly string _solution;
        private readonly int _allowedGuesses;
        private int _guesses;

        public Hangman(string solution, int allowedGuesses)
        {
            _allowedGuesses = allowedGuesses;
            _solution = solution;
        }

        public const char HiddenCharacter = '_';

        public char[] Play()
        {
            return _solution.Select(x => HiddenCharacter).ToArray();
        }

        public GuessResult Guess(char guess)
        {
            _guesses++;

            if (_guesses >_allowedGuesses)
            {
                return new GuessResult
                {
                    Status = Status.Lost,
                    Solution = null
                };
            }

            return new GuessResult
            {
                Status = Status.InProgress,
                Solution = null
            };
        }
    }

    public class GuessResult
    {
        public Status Status { get; internal set; }
        public char[] Solution { get; internal set; }
        public bool SuccessfulGuess { get; internal set; }
    }

    public enum Status
    {
        InProgress,
        Won,
        Lost
    }
}
