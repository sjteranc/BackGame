using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BackGame
{
        internal enum GameResult
        {
            PlayerWin,
            ComputerWin
        }

        internal class GameLogic
        {
            public char GeneratePlayerGuess()
            {
                Console.WriteLine("Elige entre par (p) o impar (i): ");
                char guess = Char.ToLower(Console.ReadKey().KeyChar);
                while (guess != 'p' && guess != 'i')
                {
                    Console.WriteLine("\nPor favor ingresa 'p' para par o 'i' para impar.");
                    guess = Char.ToLower(Console.ReadKey().KeyChar);
                }
                Console.WriteLine();
                return guess;
            }

            public char GenerateComputerGuess(char playerGuess)
            {
                return playerGuess == 'p' ? 'i' : 'p';
            }

            public int RollDice()
            {
                Random random = new Random();
                return random.Next(1, 7);
            }

            public GameResult CompareResults(int playerGuess, int computerGuess)
            {
                int sum = playerGuess + computerGuess;
                bool isSumEven = sum % 2 == 0;
                bool isPlayerGuessEven = playerGuess % 2 == 0;

                if ((isSumEven && isPlayerGuessEven) || (!isSumEven && !isPlayerGuessEven))
                {
                    return GameResult.PlayerWin;
                }
                else
                {
                    return GameResult.ComputerWin;
                }
            }

            public bool PlayAgain()
            {
                Console.WriteLine("¿Quieres jugar otra ronda? (s/n)");
                string? response = Console.ReadLine();
                return response?.ToLower() == "s";
            }
        }
    }