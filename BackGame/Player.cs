using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGame
{
    internal class Player
    {
        public int MakeGuess(char guess)
        {
            Console.WriteLine($"Has elegido: {(guess == 'p' ? "par" : "impar")}");
            return guess == 'p' ? 0 : 1;
        }
    }
}
