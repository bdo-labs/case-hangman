using System;

namespace HangmanAPI
{
    public class Hangman
    {
        public const char HiddenCharacter = '_';

        public char[] Play()
        {
            throw new NotImplementedException();
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
