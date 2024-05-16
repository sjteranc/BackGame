using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackGame
{
    internal class Menu
    {
        public void ShowMenu()
        {
            Console.WriteLine("=== Menú ===");
            Console.WriteLine("1. Jugar");
            Console.WriteLine("2. Ver instrucciones");
            Console.WriteLine("3. Salir");
            Console.WriteLine("============");
            Console.Write("Selecciona una opción: ");
        }

        public int GetMenuChoice()
        {
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Por favor ingresa un número válido (1-3).");
                Console.Write("Selecciona una opción: ");
            }
            return choice;
        }

        public void ShowInstructions()
        {
            Console.WriteLine("Instrucciones:");
            Console.WriteLine("Elige entre par o impar antes de lanzar los dados.");
            Console.WriteLine("El ganador se determina según si la suma de los dados es par o impar y tu elección.");
            Console.WriteLine("Presiona cualquier tecla para volver al menú principal.");
            Console.ReadKey();
        }
    }
}
