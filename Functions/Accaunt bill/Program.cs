using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accaunt_bill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fullUsersNames = new string[0];
            string[] usersPositions = new string[0];
            bool isOpen = true;
            string userInput;

            while (isOpen)
            {
                Console.Clear();
                Console.WriteLine("1 - Добавить досье\n2 - Вывести досье\n3 - Удалить досье\n4 - Поиск по фамилии\n5 - Выход");
                Console.Write("Введите команду: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddProfile(ref fullUsersNames, ref usersPositions);
                        break;
                    case "2":
                        WriteProfile(fullUsersNames, usersPositions);
                        Console.ReadKey();
                        break;
                    case "3":
                        if (fullUsersNames.Length > 0)
                            DeleteProfile(ref fullUsersNames, ref usersPositions);
                        else
                            Console.WriteLine("Empty");
                        Console.ReadKey();
                        break;
                    case "4":
                        SearchForLastName(fullUsersNames, usersPositions);
                        Console.ReadKey();
                        break;
                    case "5":
                        isOpen = false;
                        break;
                }
            }
        }

        static void AddProfile (ref string[] fullUsersNames, ref string[] usersPositions)
        {
            AddProfile(ref fullUsersNames);
            AddProfile(ref usersPositions);
            Console.WriteLine("Введите ФИО.");
            fullUsersNames[fullUsersNames.Length - 1] = Console.ReadLine();
            Console.WriteLine("Введите должность.");
            usersPositions[usersPositions.Length - 1] = Console.ReadLine();
        }
        static void AddProfile (ref string[] array)
        {
            string[] tempArray = new string[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
                tempArray[i] = array[i];

            array = tempArray;
        }

        static void WriteProfile (string[] fullUsersNames, string[] usersPositions)
        {
            for (int i = 0; i < fullUsersNames.Length;i++)
            {
                Console.Write((i+1) + ". " + fullUsersNames[i] + " - " + usersPositions[i] + " ");
            }
        }

        static void DeleteProfile (ref string[] fullUsersNames, ref string[] usersPositions)
        {
            Console.WriteLine("Какой номер досье удалить?");
            int numberUser = Convert.ToInt32(Console.ReadLine()) - 1;

            if (numberUser < fullUsersNames.Length)
            {
                DeleteProfile(ref fullUsersNames, ref numberUser);
                DeleteProfile(ref usersPositions, ref numberUser);
            }
            else
                Console.WriteLine("Нет такого");
        }
        static void DeleteProfile(ref string[] array, ref int numberDel)
        {
            string[] tempArray = new string[array.Length - 1];

            for (int i = 0; i < array.Length; i++)
            {
                if (i < numberDel)
                    tempArray[i] = array[i];
                else if (i > numberDel)
                    tempArray[i - 1] = array[i];
            }

            array = tempArray;
        }

        static void SearchForLastName (string[] fullUsersNames, string[] usersPositions)
        {
            Console.WriteLine("Введите фамилию");
            string userInput = Console.ReadLine();
            bool IsIncludedString = false;

            for (int i = 0; i < fullUsersNames.Length; i++)
            {
                IsIncludedString = fullUsersNames[i].ToLower().Contains(userInput.ToLower());

                if (IsIncludedString == true)
                    Console.WriteLine((i + 1) + ". " + fullUsersNames[i] + " - " + usersPositions[i]);
                else
                    Console.WriteLine("Не найдено!");
            }
        }
    }
}
