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
            int manaPercents;
            int minManaPercents = 0;
            int maxManaPercents = 100;
            char symbolInput = '#';
            string exit = " ";

            while (exit != "no")
            {
                Console.Write($"Введите процент маны (число процентов от {minManaPercents} до {maxManaPercents}):");
                manaPercents = Convert.ToInt32(Console.ReadLine());

                if (manaPercents <= 100 && manaPercents >= 0)
                {
                    Drawbar(manaPercents, maxManaPercents, symbolInput);
                    Console.WriteLine();
                }    
                else
                {
                    Console.WriteLine("Некорректное число %");
                }

                Console.WriteLine();
                Console.WriteLine("Для выхода введите - no");
                exit = Console.ReadLine();
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
