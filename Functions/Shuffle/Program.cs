using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 5, 6, 2, 3, 4, 7, 9 };

            Shuffle(myArray);

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write(myArray[i]);
            }

            Console.WriteLine();
        }

        static void Shuffle(int [] array)
        {
            Random random = new Random();

            for (int i = array.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                int temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
}
