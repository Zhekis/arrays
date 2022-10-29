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
            int playerPositionX = 1;
            int playerPositionY = 1;
            int playerDirectionX = 0;
            int playerDirectionY = 1;
            char symbolPlayer = 'e';
            bool isMoving = true;

            Console.CursorVisible = false;

            DrawMap(map);

            Console.SetCursorPosition(playerPositionY, playerPositionX);
            Console.Write(symbolPlayer);

            while (isMoving)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);

                ChangeDirection(key, ref playerDirectionX, ref playerDirectionY);

                if (map[playerPositionX + playerDirectionX, playerPositionY + playerDirectionY] != '*')
                {
                    MovePlayer(ref playerPositionX, ref playerPositionY, playerDirectionX, playerDirectionY, symbolPlayer);
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

        static void MovePlayer(ref int playerPositionX, ref int playerPositionY, int playerDirectionX, int playerDirectionY, char symbolPlayer)
        {
            Console.SetCursorPosition(playerPositionY, playerPositionX);
            Console.Write(' ');

            playerPositionX += playerDirectionX;
            playerPositionY += playerDirectionY;

            DrawSymbol(ref playerPositionX, ref playerPositionY, symbolPlayer);
        }

        static void DrawSymbol(ref int playerPositionX, ref int playerPositionY, char symbolPlayer)
        {
            Console.SetCursorPosition(playerPositionY, playerPositionX);
            Console.Write(symbolPlayer);
        }

        static void ChangeDirection(ConsoleKeyInfo key, ref int playerDirectionX, ref int playerDirectionY)
        {
            const ConsoleKey keyUp = ConsoleKey.UpArrow;
            const ConsoleKey keyDown = ConsoleKey.DownArrow;
            const ConsoleKey keyLeft = ConsoleKey.LeftArrow;
            const ConsoleKey keyRight = ConsoleKey.RightArrow;

            switch (key.Key)
            {
                case keyUp:
                    playerDirectionX = -1;
                    playerDirectionY = 0;
                    break;
                case keyDown:
                    playerDirectionX = 1;
                    playerDirectionY = 0;
                    break;
                case keyLeft:
                    playerDirectionX = 0;
                    playerDirectionY = -1;
                    break;
                case keyRight:
                    playerDirectionX = 0;
                    playerDirectionY = 1;
                    break;
            }
        }
    }
}
