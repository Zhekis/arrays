using System;

class Program
{

    static void Main(string[] args)
    {
        int sumRow = 0;
        int multiplicationColumn = 1;
        int[,] array = { { 1, 3, 5, 6 }, { 2, 4, 6, 2 } };

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }

            Console.WriteLine();
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            multiplicationColumn = multiplicationColumn * array[i, 0];
        }

        for (int i = 1; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                    sumRow += array[i, j];
            }
        }

        Console.WriteLine();
        Console.WriteLine(sumRow);
        Console.WriteLine(multiplicationColumn);
    }
}
