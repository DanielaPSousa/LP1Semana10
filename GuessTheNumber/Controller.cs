using System;

namespace GuessTheNumber
{
    public class Controller
    {
        private readonly Model model;
        private readonly IView view;

        public Controller(Model model, IView view)
        {
            this.model = model;
            this.view = view;
        }

        public void Start()
        {
            view.ShowWelcomeMessage();
            bool guessedCorrectly = false;

            while (!guessedCorrectly)
            {
                int guess = view.GetGuess();
                model.IncrementAttempts();

                if (model.IsCorrectGuess(guess))
                {
                    view.ShowSuccessMessage(model.Attempts);
                    guessedCorrectly = true;
                }
                else if (model.IsGuessTooLow(guess))
                {
                    view.ShowTooLowMessage();
                }
                else
                {
                    view.ShowTooHighMessage();
                }
            }

            view.ShowThankYouMessage();
        }
    }
}