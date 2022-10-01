using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempNumber;
            int[] array = {2, 4, 5, 6, 7, 1, 1, 1, 8, 9, 9, 10};

            for (int i = 0; i < (array.Length - 1); i++)
            {
                for (int j = 0; j < (array.Length - 1); j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        tempNumber = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tempNumber;
                    }

                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
