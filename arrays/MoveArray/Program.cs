using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, };
            int countShift = 3;
            int tempNumber = 0;

            for (int i = 0; i < countShift; i++)
            {
                tempNumber = array[0];

                for (int j = 0; j < (array.Length - 1); j++)
                {
                    array[j] = array[j + 1];
                }

                array[array.Length - 1] = tempNumber;
            }

            for (int j = 0; j < array.Length; j++)
            {
                Console.Write(array[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
