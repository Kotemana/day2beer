using System;
using System.Collections.Generic;

namespace day2beer
{
    class Program
    {
        static void Main(string[] args)
        {
            //string beer = AskBeerType();
            //GoToCources(beer);
            //Console.WriteLine("Всем пока");
            //boolOperations();
            //SomeMath();
            ChoosePerson();
            GoToBarInCovidTimes();
        }

        static void GoToBarInCovidTimes()
        {
            Console.WriteLine("what is your temp.?");
            string temp = Console.ReadLine();
            double Temp = double.Parse(temp);
            if (Temp <= 35)
            {
                Console.WriteLine("go to the graveyard");
            }
            else if (Temp < 36.8)
            {
                Console.WriteLine("Enter the Bar");
                           }
            else if (Temp < 37.2)
            {
                Console.WriteLine("Go get some rest");
            }
            else {
                Console.WriteLine("Go to the NAHUY!!!");
            }

        }

        static void ChoosePerson()
        {
            List<string> list = new List<string>() { "Леший", "Вера", "Шакира", "Конь"};
            var random = new Random();
            Console.WriteLine(list[random.Next(list.Count)]);
        }

        static string AskBeerType()
        {
            Console.WriteLine("Напишу в телегу спрошу чё взять");
            Console.WriteLine("Мне ответили:");
            string chosenBeer = Console.ReadLine();

            return chosenBeer;
        }

        static void GoToCources(string beerType)
        {
            bool isWeissBier = beerType == "пшеничка";
            if (isWeissBier)
            {
                Console.WriteLine("так себе выбор - иди пей ее дома");
                return;
            }

            Console.WriteLine("Вышел из метро");
            Console.WriteLine("Хмм, кристалл. Свет горит вроде, работает ли? (да/нет)");
            string reply = Console.ReadLine();

            if (reply == "да")
            {
                Console.WriteLine("Выбираю пивасик - " + beerType + ", главное пшеничку не взять");
                Console.WriteLine("Покупаю пивасик");
            }
            else if (reply == "нет")
            {
                Console.WriteLine($"Иду в арбат за оверпрайснутым пивком с названием {beerType}");
            }
            else
            {
                Console.WriteLine("ты даже да или нет вбить не можешь, иди домой");
                return;
            }

            Console.WriteLine("Иду на курсики");
        }

        static void boolOperations()
        {
            Console.WriteLine("10 > 7");
            Console.WriteLine(10 > 7);
            Console.WriteLine("10 < 10");
            Console.WriteLine(10 < 10);
            Console.WriteLine("10 <= 10");
            Console.WriteLine(10 <= 10);
            Console.WriteLine("10 >= 10");
            Console.WriteLine(10 >= 10);
            Console.WriteLine("10 == 10");
            Console.WriteLine(10 == 10);
            Console.WriteLine("10 == 9 or 4 > 7 or 2 < 8");
            Console.WriteLine(10 == 9 || 4 > 7 || 2 < 8);
            Console.WriteLine("10 == 10 and 4 > 7");
            Console.WriteLine(10 == 10 && 4 > 7);
            Console.WriteLine("10 == 10 and 4 < 7");
            Console.WriteLine(10 == 10 && 4 < 7);
            Console.WriteLine("not 10 == 10");
            Console.WriteLine(!(10 == 10));
        }

        static void SomeMath()
        {
            int x = 10;
            x++;
            x--;
            x += 8; // analogue x = x + 8;
            x -= 5;
            
            Console.WriteLine(x++);
        }

    }
}
