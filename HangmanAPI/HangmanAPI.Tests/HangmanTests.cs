using NUnit.Framework;

namespace HangmanAPI.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Play_returns_solution_length()
        {
            var hangman = new Hangman("heisann");
            var solution = hangman.Play();

            Assert.That(solution.Length, Is.Not.EqualTo(0));
        }
    }
}