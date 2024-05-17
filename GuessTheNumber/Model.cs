using System;

namespace GuessTheNumber
{
    public class Model
    {
        public int TargetNumber { get; private set; }
        public int Attempts { get; private set; }

        public Model()
        {
            Random random = new Random();
            TargetNumber = random.Next(1, 101);
            Attempts = 0;
        }

        public void IncrementAttempts()
        {
            Attempts++;
        }

        public bool IsCorrectGuess(int guess)
        {
            return guess == TargetNumber;
        }

        public bool IsGuessTooLow(int guess)
        {
            return guess < TargetNumber;
        }
    }
}