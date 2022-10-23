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
            int playerMoveX = 0;
            int playerMoveY = 1;
            char symbolPlayer = 'e';
            bool isMoving = true;

            Console.CursorVisible = false;

            DrawMap(map);

            Console.SetCursorPosition(playerPositionY, playerPositionX);
            Console.Write(symbolPlayer);

            while (isMoving)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    ChangeDirection(key, ref playerMoveX, ref playerMoveY);

                    if (map[playerPositionX + playerMoveX, playerPositionY + playerMoveY] != '*')
                    {
                        MovePlayer(ref playerPositionX,ref playerPositionY,ref playerMoveX,ref playerMoveY,ref symbolPlayer);
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

        static void MovePlayer(ref int playerPositionX, ref int playerPositionY,ref int playerMoveX,ref int playerMoveY,ref char symbolPlayer)
        {
            Console.SetCursorPosition(playerPositionY, playerPositionX);
            Console.Write(' ');

            playerPositionX += playerMoveX;
            playerPositionY += playerMoveY;

            Console.SetCursorPosition(playerPositionY, playerPositionX);
            Console.Write(symbolPlayer);
        }

        static void ChangeDirection(ConsoleKeyInfo key, ref int playerMoveX, ref int playerMoveY)
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    playerMoveX = -1;
                    playerMoveY = 0;
                    break;
                case ConsoleKey.DownArrow:
                    playerMoveX = 1;
                    playerMoveY = 0;
                    break;
                case ConsoleKey.LeftArrow:
                    playerMoveX = 0;
                    playerMoveY = -1;
                    break;
                case ConsoleKey.RightArrow:
                    playerMoveX = 0;
                    playerMoveY = 1;
                    break;
            }
        }
    }
}
