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
            GetNumber();
        }

        static void GetNumber()
        {
            bool result = false;

            while (result == false)
            {
                Console.WriteLine("Введите число :");
                string userInput = Console.ReadLine();
                result = int.TryParse(userInput,out int number);

                if (result == false)
                    Console.WriteLine("Неудачно, попробуй еще!");
            }

            Console.WriteLine("Удачно");
            return;
        }
    }
}
