using System;

namespace GuessTheNumber
{
    public class IView
    {
        public void ShowWelcomeMessage()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }

        public int GetGuess()
        {
            Console.Write("Take a guess: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void ShowTooLowMessage()
        {
            Console.WriteLine("Too low! Try again.");
        }

        public void ShowTooHighMessage()
        {
            Console.WriteLine("Too high! Try again.");
        }

        public void ShowSuccessMessage(int attempts)
        {
            Console.WriteLine("Congratulations! You guessed the number correctly!");
            Console.WriteLine("Number of attempts: " + attempts);
        }

        public void ShowThankYouMessage()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }
    }
}