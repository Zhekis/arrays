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
            const string AddForm = "1";
            const string WriteForm = "2";
            const string DeleteForm = "3";
            const string searchLastName = "4";
            const string Exit = "5";
            string[] fullUsersNames = new string[0];
            string[] usersPositions = new string[0];
            bool isOpen = true;
            string userInput;

            while (isOpen)
            {
                Console.Clear();
                Console.WriteLine(AddForm + " - Добавить досье\n" + WriteForm + " - Вывести досье\n" + DeleteForm + " - Удалить досье\n" + searchLastName + " - Поиск по фамилии\n" + Exit + " - Выход");
                Console.Write("Введите команду: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case AddForm:
                        AddProfile(ref fullUsersNames, ref usersPositions);
                        break;
                    case WriteForm:
                        WriteProfile(fullUsersNames, usersPositions);
                        Console.ReadKey();
                        break;
                    case DeleteForm:
                        DeleteProfile(ref fullUsersNames, ref usersPositions);
                        Console.ReadKey();
                        break;
                    case searchLastName:
                        SearchForLastName(fullUsersNames, usersPositions);
                        Console.ReadKey();
                        break;
                    case Exit:
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
            {
                tempArray[i] = array[i];
            }

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
            if (fullUsersNames.Length > 0)
            {
                Console.WriteLine("Какой номер досье удалить?");
                int numberUser = Convert.ToInt32(Console.ReadLine()) - 1;

                if (numberUser < fullUsersNames.Length)
                {
                    DeleteProfile(ref fullUsersNames, numberUser);
                    DeleteProfile(ref usersPositions, numberUser);
                }
                else
                {
                    Console.WriteLine("Нет такого");
                }
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }
        static void DeleteProfile(ref string[] array, int numberDel)
        {
            string[] tempArray = new string[array.Length - 1];

            for (int i = 0; i < array.Length; i++)
            {
                if (i < numberDel)
                {
                    tempArray[i] = array[i];
                }
                else if (i > numberDel)
                {
                    tempArray[i - 1] = array[i];
                }
            }

            array = tempArray;
        }

        static void SearchForLastName (string[] fullUsersNames, string[] usersPositions)
        {
            Console.WriteLine("Введите фамилию");
            string userInput = Console.ReadLine();
            string[] words;
            bool IsIncludedString = false;

            for (int i = 0; i < fullUsersNames.Length; i++)
            {
                words = fullUsersNames[i].Split(' ');
                IsIncludedString = words[0].ToLower().Contains(userInput.ToLower());

                if (IsIncludedString == true)
                {
                    Console.WriteLine((i + 1) + ". " + fullUsersNames[i] + " - " + usersPositions[i]);
                }
                else
                {
                    Console.WriteLine("Не найдено!");
                }
            }
        }
    }
}