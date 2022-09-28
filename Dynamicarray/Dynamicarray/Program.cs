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
            int[] array = new int[0];
            int userInputNumber;
            string userChoice = " ";
            int sumArray = 0;

            while (userChoice != UserChoiceExit)
            {
                Console.WriteLine("Введите число (для вывода суммы чисел - введите " + UserChoiceSum +", для выхода - введите " + UserChoiceExit);
                userChoice = Console.ReadLine();

                if (userChoice == UserChoiceSum)
                {
                    Console.WriteLine(sumArray);
                }             
                else if (userChoice != UserChoiceSum && userChoice != UserChoiceExit)
                {
                    userInputNumber = Convert.ToInt32(userChoice);
                    int[] tempArray = new int[array.Length + 1];

                    for (int i = 0; i < array.Length; i++)
                    {
                        tempArray[i] = array[i];
                    }

                    tempArray[tempArray.Length - 1] = userInputNumber;
                    array = tempArray;
                    sumArray += userInputNumber;
                    Console.WriteLine();
                }
            }
        }
    }
}
