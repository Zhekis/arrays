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
            while (true)
            {
               ConvertToInt();
               //Console.WriteLine(number);
            }
        }

        static void ConvertToInt()
        {
            Console.WriteLine("Введите число : ");
            string userInput = Console.ReadLine();
            bool result = int.TryParse(userInput, out int number);

            if (result == true)
            {
                Console.WriteLine($"Успешно. Число: {number}");
                //return;
            }
            else
                Console.WriteLine("Неудачно");
            //return number;
        }
    }
}
