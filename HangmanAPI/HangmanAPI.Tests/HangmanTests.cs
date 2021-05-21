using NUnit.Framework;

namespace HangmanAPI.Tests
{
    public class Tests
    {
        private string _solution;

        [SetUp]
        public void Setup()
        {
            _solution = "heisann";
        }

        [Test]
        public void Play_returns_solution_length()
        {
            var hangman = new Hangman(_solution, 1);
            var serverSolution = hangman.Play();

            Assert.That(serverSolution.Length, Is.EqualTo(_solution.Length));
        }

        [Test]
        public void Play_replaces_solution_with_hidden_chars()
        {
            var hangman = new Hangman(_solution, 1);
            var serverSolution = hangman.Play();

            Assert.That(serverSolution, Is.EqualTo("_______"));
        }

        [Test]
        public void Game_is_in_progress_when_number_of_guesses_is_not_passed()
        {
            int allowedGuesses = 1;

            var hangman = new Hangman(_solution, allowedGuesses);
            var serverSolution = hangman.Play();

            var guess1 = hangman.Guess('a');
            Assert.That(guess1.Status, Is.EqualTo(Status.InProgress));

            var guess2 = hangman.Guess('b');
            Assert.That(guess2.Status, Is.EqualTo(Status.Lost));
        }
    }
}