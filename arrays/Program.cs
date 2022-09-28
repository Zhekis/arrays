using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            //bool up = true;
            //int[] array = {3,3, 2,2,2, 1, 4, 4, 4, 5, 5, 5, 6,6,3,3,3, 8, 8, 9,9,9,0,0,0,1,1};
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Локальные максимумы:");

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] >= array[i - 1])
            //        up = true;
            //    if (array[i] < array[i - 1])
            //        up = false;
            //    Console.Write(array[i-1] + " ");
            //}
            if (array.Length == 1)
                Console.WriteLine(array[0]);

            if (array.Length == 2)
                if (array[0] > array[1])
                    Console.WriteLine(array[0]);
                else
                    Console.WriteLine(array[1]);

            if (array.Length > 2)
            {
                if (array[0] > array[1])
                    Console.Write(array[0] + " ");
                else
                    if (array[1] > array[2])
                        Console.Write(array[1] + " ");


                for (int i = 1; i < (array.Length - 1); i++)
                {
                    if (array[i] > array[i - 1] && array[i] > array[i + 1])
                        Console.Write(array[i] + " ");
                    //else if (array[i] == array[i - 1] && array[i] > array[i + 1])
                    //    Console.Write(array[i] + " ");
                }

                if (array[array.Length - 1] > array[array.Length - 2])
                    Console.WriteLine(array[array.Length - 1]);
            }

            Console.WriteLine();
        }
    }
}
