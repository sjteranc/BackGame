using BackGame;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Menu menu = new Menu();
        GameSetup gameSetup = new GameSetup();
        GameRound gameRound = new GameRound();
        GameLogic gameLogic = new GameLogic();
        Player player = new Player();
        Computer computer = new Computer();

        bool playAgain = true;

        while (playAgain)
        {
            playAgain = true; // Restablecer playAgain a true al comienzo de cada iteración

            menu.ShowMenu();
            int choice = menu.GetMenuChoice();

            switch (choice)
            {
                case 1:
                    gameSetup.StartGame();
                    char playerGuess = gameLogic.GeneratePlayerGuess();
                    int playerRoll = gameLogic.RollDice();
                    int computerRoll = gameLogic.RollDice();
                    char computerGuess = gameLogic.GenerateComputerGuess(playerGuess);

                    int playerResult = player.MakeGuess(playerGuess);
                    int computerResult = computer.MakeGuess(computerGuess);

                    Console.WriteLine($"Tu resultado del dado: {playerRoll}");
                    Console.WriteLine($"Resultado del dado de la computadora: {computerRoll}");

                    GameResult result = gameLogic.CompareResults(playerRoll, computerRoll);
                    if (result == GameResult.PlayerWin)
                    {
                        Console.WriteLine("¡Felicidades! ¡Has ganado!");
                    }
                    else
                    {
                        Console.WriteLine("¡La computadora gana!");
                    }

                    playAgain = gameLogic.PlayAgain();
                    break;
                case 2:
                    menu.ShowInstructions();
                    break;
                case 3:
                    playAgain = false;
                    break;
            }
        }
    }
}
