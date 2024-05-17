```mermaid
classDiagram
    class Program {
        +Main()
    }

    class Controller {
        -GameModel model
        -ConsoleView view
        +GameController(GameModel model, ConsoleView view)
        +Start()
    }

    class Model {
        -int TargetNumber
        -int Attempts
        +GameModel()
        +IncrementAttempts()
        +IsCorrectGuess(int guess) bool
        +IsGuessTooLow(int guess) bool
    }

    class IView {
        +ShowWelcomeMessage()
        +GetGuess()
        +ShowTooLowMessage()
        +ShowTooHighMessage()
        +ShowSuccessMessage(int attempts)
        +ShowThankYouMessage()
    }

    Program --> Controller
    GameController --> Model
    GameController --> IView
