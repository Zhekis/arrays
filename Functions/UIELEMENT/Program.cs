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
            int mana;
            int maxMana = 100;

            while (true)
            {
                Console.Write("Введите количесто маны (число процентов от 0 до 100):");
                mana = Convert.ToInt32(Console.ReadLine());

                Drawbar(mana, maxMana, '#');
                Console.ReadKey();
                Console.Clear();
            }
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
