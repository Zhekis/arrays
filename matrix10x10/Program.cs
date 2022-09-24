using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix10x10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxFigure = 0;
            int putFigure = 0;
            int[,] array = new int[10,10];
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 10);

                    if (array[i, j] > maxFigure)
                        maxFigure = array[i, j];

                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine(maxFigure);
            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (array[i, j] == maxFigure)
                        array[i, j] = putFigure;

                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
