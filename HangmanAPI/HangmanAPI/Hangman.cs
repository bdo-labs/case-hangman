using System;

namespace HangmanAPI
{
    public class HangmanServer : IHangman
    {
        public char[] Play()
        {
            throw new NotImplementedException();
        }

        public GuessResult Guess(char guess)
        {
            throw new NotImplementedException();
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

        public Hangman(string solution)
        {
            _solution = solution;
        }

        public const char HiddenCharacter = '_';

        public char[] Play()
        {
            return new[] {'a'};
        }

        public GuessResult Guess(char guess)
        {
            throw new NotImplementedException();
        }
    }

    public class GuessResult
    {
        public Status Status { get; private set; }
        public char[] Solution { get; private set; }
    }

    public enum Status
    {
        InProgress,
        Won,
        Lost
    }
}
