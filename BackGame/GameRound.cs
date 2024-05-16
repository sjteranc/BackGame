using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGame
{
    internal class GameRound
    {
        public void PlayRound()
        {
            RollDice();
            Console.WriteLine("Resultado de los dados: ");
            RollDice();
        }

        private void RollDice()
        {
            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            Console.WriteLine($"Dado 1: {dice1}, Dado 2: {dice2}");
        }
    }
}
