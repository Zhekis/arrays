using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] map = { {'*', '*', '*', '*', '*', '*' }, { '*', ' ', ' ', ' ', ' ', '*' }, { '*', ' ', '*', ' ', ' ', '*' } , { '*', ' ', '*', '*', ' ', '*' }, { '*', ' ', ' ', '*', ' ', '*' }, { '*', ' ', '*', '*', ' ', '*' }, { '*', ' ', ' ', ' ', ' ', '*' }, { '*', '*', '*', '*', '*', '*' } };
            int playerX = 1;
            int playerY = 1;
            int playerDX = 0;
            int playerDY = 1;
            bool isMoving = true;

            Console.CursorVisible = false;

            DrawMap(map);

            Console.SetCursorPosition(playerY, playerX);
            Console.Write('e');

            while (isMoving)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            playerDX = -1; playerDY = 0;
                            break;
                        case ConsoleKey.DownArrow:
                            playerDX = 1; playerDY = 0;
                            break;
                        case ConsoleKey.LeftArrow:
                            playerDX = 0; playerDY = -1;
                            break;
                        case ConsoleKey.RightArrow:
                            playerDX = 0; playerDY = 1;
                            break;
                    }

                    if (map[playerX + playerDX, playerY + playerDY] != '*')
                    {
                        Console.SetCursorPosition(playerY, playerX);
                        Console.Write(' ');

                        playerX += playerDX;
                        playerY += playerDY;

                        Console.SetCursorPosition(playerY, playerX);
                        Console.Write('e');
                    }
                }
            }
        }

        static void DrawMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
