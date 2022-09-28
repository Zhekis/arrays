using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamicarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[1];
            int[] tempArray = new int[array.Length + 1];
            int userInputNumber;
            string userChoice = " ";
            int sumArray = 0;

            while (userChoice != "exit")
            {
                sumArray = 0;
                userInputNumber = Convert.ToInt32(Console.ReadLine());
                tempArray = new int[array.Length + 1];

                for (int i = 0; i < array.Length; i++)
                {
                    tempArray[i] = array[i];
                }

                tempArray[tempArray.Length - 1] = userInputNumber;
                array = tempArray;

                for (int i = 0; i < array.Length; i++)
                {
                    sumArray += array[i];
                    Console.Write(array[i] + " ");
                }

                Console.WriteLine();
                Console.WriteLine(sumArray);

            }






        }
    }
}
