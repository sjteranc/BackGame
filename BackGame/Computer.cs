using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGame
{
    internal class Computer
    {
        public int MakeGuess(char guess)
        {
            Console.WriteLine($"La computadora elige: {(guess == 'p' ? "impar" : "par")}");
            return guess == 'p' ? 1 : 0;
        }
    }
}
