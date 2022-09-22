using System;

class Program
{

    static void Main(string[] args)
    {
        int numberRow = 1;
        int numberColumn = 0;
        int sumRow = 0;
        int multiplicationColumn = 1;
        int[,] array = { { 1, 3, 5, 6 }, { 2, 4, 6, 2 } };

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == numberColumn)
                    multiplicationColumn = multiplicationColumn * array[i, j];
                if (i == numberRow)
                    sumRow += array[i, j];

                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine(sumRow);
        Console.WriteLine(multiplicationColumn);
    }
}