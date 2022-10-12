using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Удачно ваше число : " + GetNumber());
        }

        static int GetNumber()
        {
            bool isNumber = false;
            int result = 0;

            while (isNumber == false)
            {
                Console.WriteLine("Введите число :");
                string userInput = Console.ReadLine();
                isNumber = int.TryParse(userInput,out int number);

                if (isNumber == true)
                    result = number;
                else
                    Console.WriteLine("Неудачно, попробуй еще!");
            }

            return result;
        }
    }
}
