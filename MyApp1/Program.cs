using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

class Program
{

    static void Main(string[] args)
    // Не использовать асинхронно.
    /*
     Слова.
     */
    {
        //Task 4
        ////Console.WriteLine("Как вас зовут?");
        ////string name = Console.ReadLine();

        ////Console.WriteLine("Сколько вам лет?");
        ////int age = Convert.ToInt32(Console.ReadLine());

        ////Console.WriteLine("Ваш знак зодиака?");
        ////string zodiacSign = Console.ReadLine().ToLower();

        ////Console.WriteLine("Кто вы по специальности?");
        ////string specialization = Console.ReadLine().ToLower();

        ////string resault = $"Вас зовут {name}, вам {age} лет, знак зодиака - {zodiacSign}, и ваша специальность {specialization}";

        ////Console.WriteLine(resault);


        /// Task 5
        //string Given_name = "Zh";
        //string First_name = "Akh";
        //string Full_name = Given_name + First_name;
        //string Given_name1 = Given_name;
        //Given_name = First_name;
        ////First_name = Given_name1;
        ////string Full_name1 = Given_name + First_name;
        ////Console.WriteLine(Full_name);
        ////Console.WriteLine(Full_name1);

        ////Task 6
        ////int All_pic = 52;
        //int num_in_row = 3;
        //int count_row = All_pic / num_in_row;
        //int count_over = All_pic % num_in_row;
        //Console.WriteLine(count_row);
        //Console.WriteLine(count_over);

        //Task 7
        //Console.WriteLine("What gold coins do you have?");
        //int goldCoins = Convert.ToInt32(Console.ReadLine());
        //int crystalPrice = 3;
        //Console.WriteLine("How much do you want to buy crystals (price {0})", crystalPrice);
        //int countCrystal = Convert.ToInt32(Console.ReadLine());
        //goldCoins -= countCrystal * crystalPrice;
        //string resault = $"You have {countCrystal} crystals and {goldCoins} gold_coins";
        //Console.WriteLine(resault);

        // Task 8
        //Console.WriteLine("How many persons in a range?");
        //int peopleRange = Convert.ToInt32(Console.ReadLine());
        //int minutesWaitPerson = 10;
        //int minutesInHour = 60;
        //int allMinutesWait = peopleRange * minutesWaitPerson;
        //int hoursWait = allMinutesWait / minutesInHour;
        //int minutesWait = allMinutesWait % minutesInHour;
        //string result = $"You need to wait {hoursWait} hours and {minutesWait} minutes";
        //Console.WriteLine(result);
        //task while, for
        //Console.WriteLine("What do you want to say?");
        //string phrase = Console.ReadLine();
        //Console.WriteLine("What many times?");
        //int countTimes = Convert.ToInt32(Console.ReadLine());
        //for (int i = 0; i < countTimes; i++)
        //{
        //    Console.WriteLine(phrase);
        //}


        // while

        //string phrase = "start";
        //string exit = "exit";

        //while (phrase != exit)
        //{
        //    Console.WriteLine("Введите команду! Для выхода используйте - " + exit);
        //    phrase = Console.ReadLine();
        //    Console.WriteLine("Ваша команда: " + phrase);

        //    if (phrase == exit)
        //        Console.WriteLine("Программа завершена!");

        //последовательность

        //int startNumber = 5;
        //int endNumber = 96;

        //for (int i = startNumber; i <= endNumber; i += 7)
        //{
        //    Console.Write(" " + i);
        //}
        //Console.WriteLine();


        //random
        //int endNumber = 101;
        //Random random = new Random();
        //int randomNumber = random.Next(endNumber);
        //int sum = 0;
        //int number1 = 3;
        //int number2 = 5;

        //for (int i = 0; i <= randomNumber; i++)
        //{
        //    if (i % number1 == 0 || i % number2 == 0)
        //    {
        //        sum += i;
        //    }      
        //}

        //Console.WriteLine(sum);


        // converter coins
        //float rub = 100000;
        //float usd = 1000;
        //float btc = 10;
        //float usdToRub = 61;
        //float rubToUsd = 1 / usdToRub;
        //float btcToRub = 6000;
        //float rubToBtc = 1 / btcToRub;
        //float btcToUsd = 101;
        //float usdToBtc = 1 / btcToUsd;

        //string userChoice = "start";
        //float countCoinsForChange;
        //string exit = "7";

        //Console.WriteLine("Добро пожаловать в обменник валют. Можете обменять рубли, доллары, биткоин!");

        //while(userChoice != exit)
        //{
        //    Console.WriteLine("Ваш баланс : " + rub + " рублей, " + usd + " долларов, " + btc + " биткоин.");
        //    Console.WriteLine();
        //    Console.WriteLine("Выбирете необходимую операцию:");
        //    Console.WriteLine("1 - обменять рубли на доллары.");
        //    Console.WriteLine("2 - обменять рубли на биткоин.");
        //    Console.WriteLine("3 - обменять доллары на рубли.");
        //    Console.WriteLine("4 - обменять доллары на биткоин.");
        //    Console.WriteLine("5 - обменять биткоин на рубли.");
        //    Console.WriteLine("6 - обменять биткоин на доллары.");
        //    Console.WriteLine("7 - выход.");
        //    userChoice = Console.ReadLine();

        //    switch (userChoice)
        //    {
        //        case "1":
        //            Console.WriteLine("Сколько хотите обменять?");
        //            countCoinsForChange = Convert.ToSingle(Console.ReadLine());

        //            if (countCoinsForChange <= rub)
        //            {
        //                rub -= countCoinsForChange;
        //                usd += countCoinsForChange * rubToUsd;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Недостаточно средств!");
        //            }

        //            break;
        //        case "2":
        //            Console.WriteLine("Сколько хотите обменять?");
        //            countCoinsForChange = Convert.ToSingle(Console.ReadLine());

        //            if (countCoinsForChange <= rub)
        //            {
        //                rub -= countCoinsForChange;
        //                btc += countCoinsForChange * rubToBtc;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Недостаточно средств!");
        //            }

        //            break;
        //        case "3":
        //            Console.WriteLine("Сколько хотите обменять?");
        //            countCoinsForChange = Convert.ToSingle(Console.ReadLine());

        //            if (countCoinsForChange <= usd)
        //            {
        //                usd -= countCoinsForChange;
        //                rub += countCoinsForChange * usdToRub;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Недостаточно средств!");
        //            }

        //            break;
        //        case "4":
        //            Console.WriteLine("Сколько хотите обменять?");
        //            countCoinsForChange = Convert.ToSingle(Console.ReadLine());

        //            if (countCoinsForChange <= usd)
        //            {
        //                usd -= countCoinsForChange;
        //                btc += countCoinsForChange * usdToBtc;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Недостаточно средств!");
        //            }

        //            break;
        //        case "5":
        //            Console.WriteLine("Сколько хотите обменять?");
        //            countCoinsForChange = Convert.ToSingle(Console.ReadLine());

        //            if (countCoinsForChange <= btc)
        //            {
        //                btc -= countCoinsForChange;
        //                rub += countCoinsForChange * btcToRub;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Недостаточно средств!");
        //            }

        //            break;
        //        case "6":
        //            Console.WriteLine("Сколько хотите обменять?");
        //            countCoinsForChange = Convert.ToSingle(Console.ReadLine());

        //            if (countCoinsForChange <= btc)
        //            {
        //                btc -= countCoinsForChange;
        //                usd += countCoinsForChange * btcToUsd;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Недостаточно средств!");
        //            }

        //            break;
        //    }

        //}

        //Console.WriteLine("Спасибо! До свидания!");


        //menu
        //const string SetName = "SetName";
        //const string SetPassword = "SetPassword";
        //const string SetDamage = "SetDamage";
        //const string ChangeColor = "ChangeColor";
        //const string ChangeWaipon = "ChangeWaipon";
        //string namePlayer = "unnamed";
        //string password = "***";
        //int damageMin = 1;
        //int damageMax = 100;
        //float damage = 50;
        //string colorPlayer = "white";
        //string waipon = "knife";
        //string userChoice = "start";
        //string exit = "Esc";
        //Console.WriteLine("Settings player:");

        //while (userChoice != exit)
        //{
        //    Console.WriteLine("Name player : " + namePlayer + ", Password: " + password + ", Damage: " + damage + ", Color player: " + colorPlayer + ", Waipon: " + waipon + ".");
        //    Console.WriteLine();
        //    Console.WriteLine(SetName + " - задать имя игрока.");
        //    Console.WriteLine(SetPassword + " - установить пароль.");
        //    Console.WriteLine(SetDamage + " - установить урон.");
        //    Console.WriteLine(ChangeColor + " - выбрать цвет игрока.");
        //    Console.WriteLine(ChangeWaipon + " - изменить оружие.");
        //    Console.WriteLine(exit + " - выход.");
        //    userChoice = Console.ReadLine();

        //    switch (userChoice)
        //    {
        //        case SetName:
        //            Console.WriteLine("Введите имя:");
        //            namePlayer = Console.ReadLine();
        //            break;
        //        case SetPassword:
        //            Console.WriteLine("Введите пароль:");
        //            password = Console.ReadLine();
        //            break;
        //        case SetDamage:
        //            Console.WriteLine("Введите урон от " + damageMin + " до " + damageMax + " :");
        //            damage = Convert.ToSingle(Console.ReadLine());
        //            break;
        //        case ChangeColor:
        //            Console.WriteLine("Введите цвет игрока:");
        //            colorPlayer = Console.ReadLine();
        //            break;
        //        case ChangeWaipon:
        //            Console.WriteLine("Укажите оружие игрока:");
        //            waipon = Console.ReadLine();
        //            break;
        //    }

        //}


        //console

        //int indexWidthFrame = 1;
        //Console.WriteLine("What's your name?");
        //string name = Console.ReadLine();
        //Console.WriteLine("Write your symbol!");
        //string symbol = Console.ReadLine();
        //string frame = symbol;
        //int lenghtName = name.Length;
        //int lenghtFrame = lenghtName + indexWidthFrame;

        //for (int i = 0; i < lenghtFrame; i++)
        //{
        //    frame += symbol;
        //}

        //Console.WriteLine(frame);
        //Console.WriteLine(symbol + name + symbol);
        //Console.WriteLine(frame);


        //Password

        //string hiddenMessage = "Great! You join to us";
        //string password = "123";
        //string inputPassword = " ";
        //int countAttempts = 3;
        //int countAttemptsEnd = 0;

        //while ((inputPassword != password) && (countAttempts != countAttemptsEnd))
        //{
        //    Console.WriteLine("Введите пароль для просмотра сообщения!");
        //    inputPassword = Console.ReadLine();

        //    if (inputPassword == password)
        //        Console.WriteLine(hiddenMessage);

        //    countAttempts -= 1;
        //}


        // Figure

        //int startRange = 100;
        //int endRange = 1000;
        //int startNumber = 1;
        //int endNumber = 28;
        //Random random = new Random();
        //int randomNumber = random.Next(startNumber, endNumber);
        //int counter = 0;
        ////int i = 0;
        //Console.WriteLine("N = " + randomNumber);

        //for (int i = 0; i < endRange; i += randomNumber)
        //{
        //    if (i >= startRange)
        //        counter++;

        //}

        //while (i < endRange)
        //{
        //    i += randomNumber;

        //    if (i > startRange)
        //        counter++;

        //}

        //Console.WriteLine("Число кратных трехзначных чисел = " + counter);


        //extend 2

        //int number = 2;
        //int extentNumber = 1;
        //int extent = 1;
        //int endNumber = 10001;
        //Random random = new Random();
        //int randomNumber = random.Next(endNumber);

        //while (randomNumber > extentNumber)
        //{
        //    for (int i = 0; i < extent; i++)
        //    {
        //        extentNumber *= number;
        //    }

        //    extent++;
        //}

        //Console.WriteLine("Минимальная степень двойки, превосходящая число " + randomNumber + " равна числу " + extent);


        // скобки
        
        //var lineBrakets = Console.ReadLine();
        //var length = lineBrakets.Length;
        //var balanceBrakets = 0;
        //var maxDeepBrakets = 0;
        //var check = 0;

        //for (var i = 0; i < length; i++)
        //{
        //    if (lineBrakets[i] == '(')
        //    {
        //        balanceBrakets++;

        //        if (balanceBrakets > maxDeepBrakets)
        //            maxDeepBrakets = balanceBrakets;

        //    }
                
        //    else if (lineBrakets[i] == ')')
        //        balanceBrakets--;

        //    if (balanceBrakets < 0)
        //        check++;

        //}

        //if (balanceBrakets == 0 && check == 0)
        //    Console.WriteLine("Строка корректная, максимальная глубина вложенности " + maxDeepBrakets);
        //else Console.WriteLine("Некорректная строка!");


        // fight gladiators

        Random random = new Random();
        const string UserChoiceHit = "1";
        const string UserChoiceReflection = "2";
        const string UserChoiceRegeneration = "3";
        const string UserChoiceFreeze = "4";
        const string Hit = UserChoiceHit + " - разящий удар.";
        const string Reflection = UserChoiceReflection + " - отражение и возврат атаки боссу.";
        const string Regeneration = UserChoiceRegeneration + " - восстановление здоровья.";
        const string Freeze = UserChoiceFreeze + " - заморозка Босса на 1 ход";
        float healthBoss = 500;
        int minDamageBoss = 10;
        int maxDamageBoss = 50;
        int damageBoss = random.Next(minDamageBoss, maxDamageBoss);
        float healthHero = 300;
        float halfHealthHero = 150;
        int minDamageHero = 20;
        int maxDamageHero = 40;
        int damageHero = random.Next(minDamageHero, maxDamageHero);
        string userChoice = " ";
        int countDamageHero = 0;
        int countRegeneration = 1;
        bool isEvailabledFreeze  = false;
        bool isEvailabledRegeneration = false;
        bool isEvailabledReflection = false;
        bool isEnabledFreezeBoss = false;
        int indexPower = 2;
        int countMinHits = 2;
        Console.WriteLine("Бой начался! Hero vs Boss!");

        while (healthBoss > 0 && healthHero > 0)
        {
            float damageBossCurrent = Convert.ToSingle(random.Next(minDamageBoss, damageBoss));
            float damageHeroCurrent = Convert.ToSingle(random.Next(minDamageHero, damageHero));

            if (isEnabledFreezeBoss == false)
            {
                healthHero -= damageBossCurrent;
                Console.WriteLine("Hero получил удар = " + damageBossCurrent + ", осталость HP Hero = " + healthHero);
            }
            else
            {
                Console.WriteLine("Босс пропускает ход.");
                isEnabledFreezeBoss = false;
            }

            if (countDamageHero > countMinHits)
                isEvailabledFreeze = true;

            if (healthHero < halfHealthHero)
                isEvailabledRegeneration = true;

            if (healthHero > 0)
            {
                Console.WriteLine("Выбирете заклинание:");
                Console.WriteLine(Hit);

                if (isEvailabledReflection == true)
                    Console.WriteLine(Reflection);

                if (isEvailabledRegeneration == true && countRegeneration > 0)
                    Console.WriteLine(Regeneration);

                if (isEvailabledFreeze == true)
                    Console.WriteLine(Freeze);

                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case UserChoiceHit:
                        healthBoss -= damageHeroCurrent;
                        Console.WriteLine("Boss получил удар = " + damageHeroCurrent + ", осталость HP = " + healthBoss);
                        countDamageHero++;
                        break;
                    case UserChoiceReflection:

                        if (isEvailabledReflection == true)
                        {
                            healthBoss -= damageBossCurrent * indexPower;
                            isEvailabledReflection = false;
                            Console.WriteLine("Boss получил удар = " + damageHeroCurrent + ", осталость HP = " + healthBoss);
                        }

                        break;
                    case UserChoiceRegeneration:

                        if (isEvailabledRegeneration == true && countRegeneration > 0)
                        {
                            healthHero += damageBossCurrent * indexPower;
                            countRegeneration--;
                        }

                        break;
                    case UserChoiceFreeze:

                        if (isEvailabledFreeze == true)
                        {
                            isEvailabledFreeze = false;
                            isEnabledFreezeBoss = true;
                            countDamageHero = 0;
                            isEvailabledReflection = true;
                        }

                        break;
                }
            }

            if (healthBoss <= 0 && healthHero <= 0)
                Console.WriteLine("Ничья");
            else if (healthHero < 0)
                Console.WriteLine("Hero losed");
            else if (healthBoss < 0)
                Console.WriteLine("Boss losed");

        }
    }
}
