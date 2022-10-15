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

            DrawMap(map);
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
