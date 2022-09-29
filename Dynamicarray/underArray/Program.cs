using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace underArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter1 = 0;
            int counterMax = 0;
            int maxNumber = 0;
            int[] array = new int[30];
            Random random = new Random();
            Console.WriteLine("Array:");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write(array[i] + " ");
            }

            for (int i = 0; i < (array.Length - 1); i++)
            {
                if (array[i] == array[i + 1])
                {
                    counter1++;
                }

                if (counter1 > counterMax)
                {
                    maxNumber = array[i];
                    counterMax = counter1;
                }

                if (array[i] != array[i + 1])
                {
                    counter1 = 1;
                }    
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Число " + maxNumber + " повторяется большее число раз подряд (количество повторений " + counterMax + ").");
        }
    }
}
