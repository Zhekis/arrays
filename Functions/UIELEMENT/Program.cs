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
            int maxMana = 20;
            char symbolInput = '#';
            string exit = " ";
            string wordExit = "no";

            while (exit != wordExit)
            {
                Console.Write($"Введите процент маны (число процентов от {minManaPercents} до {maxManaPercents}):");
                manaPercents = Convert.ToInt32(Console.ReadLine());

                if (manaPercents <= maxManaPercents && manaPercents >= minManaPercents)
                {
                    DrawBar(manaPercents, maxMana, symbolInput);
                    Console.WriteLine();
                }    
                else
                {
                    Console.WriteLine("Некорректное число %");
                }

                Console.WriteLine();
                Console.WriteLine("Для выхода введите - " + wordExit);
                exit = Console.ReadLine();
                Console.Clear();
            }
        }
        
        static void DrawBar (float percents, float maxValue, char symbol, ConsoleColor color = default)
        {
            float number = maxValue * (percents / 100);
            int value = (int)Math.Round(number);
            string bar = "";
            ConsoleColor defaultColor = Console.BackgroundColor;

            for (int i = 0; i < value; i++)
            {
                bar += symbol;
            }

            Console.SetCursorPosition (0, 2);
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
