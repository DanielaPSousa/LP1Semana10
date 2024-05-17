using System;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            Model model = new Model();
            IView view = new IView();
            Controller controller = new Controller(model, view);
            controller.Start();
        }
    }
}