using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIELEMENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mana = 9, maxMana = 10;
            Drawbar(mana, maxMana, '#');
            Console.WriteLine();
        }
        
        static void Drawbar (int value, int maxValue, char symbol, ConsoleColor color = default)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";

            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }

            Console.SetCursorPosition (0, 0);
            Console.Write('[');
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
            bar = "";

            for (int i = value; i < maxValue; i++)
            {
                bar += '_';
            }

            Console.Write(bar + ']');
        }
    }
}
