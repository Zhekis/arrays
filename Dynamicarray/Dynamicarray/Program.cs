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
            const string UserChoiceExit = "exit";
            const string UserChoiceSum = "sum";
            int[] array = new int[1];
            int[] tempArray = new int[array.Length + 1];
            int userInputNumber;
            string userChoice = " ";
            int sumArray = 0;

            while (userChoice != "exit")
            {
                Console.WriteLine("Введите число (для вывода суммы чисел - введите sum, для выхода - введите exit");
                userChoice = Console.ReadLine();

                if (userChoice == UserChoiceSum)
                    Console.WriteLine(sumArray);
                else if (userChoice != UserChoiceSum && userChoice != UserChoiceExit)
                {
                    sumArray = 0;
                    userInputNumber = Convert.ToInt32(userChoice);
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
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
