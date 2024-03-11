using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagotchiPlay
{
    public class HomePet
    {
        static void Main()
        {
            bool playAgain = true;
            while (playAgain)
            {
                Console.WriteLine("                                ¶¶¶¶¶¶¶¶¶\r\n                              ¶¶¶  ¶¶¶¶¶¶\r\n                            ¶¶    ¶¶              ¶¶¶¶¶¶\r\n                            ¶   ¶¶             ¶¶¶¶ ¶¶¶¶¶¶¶¶¶¶\r\n                           ¶¶   ¶¶¶¶¶¶¶¶      ¶¶   ¶¶       ¶¶¶¶¶¶\r\n                           ¶¶ ¶¶¶¶     ¶¶¶¶¶¶¶       ¶         ¶¶_¶¶\r\n                            ¶¶¶            ¶¶       ¶¶         ¶  ¶\r\n                           ¶¶             ¶¶         ¶         ¶¶ ¶¶\r\n                          ¶¶              ¶¶         ¶          ¶ ¶¶\r\n                          ¶                 ¶¶¶¶    ¶¶ ¶¶    ¶¶¶¶  ¶\r\n                          ¶                ¶¶¶¶¶¶¶¶¶  ¶O¶  ¶O¶ ¶ ¶¶\r\n                          ¶                ¶¶¶¶   ¶¶         ¶¶  ¶¶\r\n                          ¶¶                ¶ ¶¶            ¶ ¶¶\r\n                          ¶                 ¶¶ ¶¶¶¶¶¶ ¶     ¶¶¶¶\r\n                         ¶        ¶          ¶¶¶¶¶ ¶¶¶¶     ¶¶¶\r\n                         ¶      ¶¶¶¶¶          ¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n                         ¶     ¶¶ ¶ ¶¶¶             ¶  ¶¶¶   ¶¶\r\n                         ¶     ¶  ¶¶  ¶¶¶      ¶¶¶ ¶   ¶¶¶¶ ¶¶¶¶¶\r\n                         ¶       ¶  ¶¶   ¶       ¶ ¶¶¶    ¶ ¶¶¶¶¶¶¶¶\r\n                         ¶¶  ¶¶¶¶   ¶¶¶¶¶¶     ¶¶ ¶ ¶    ¶¶¶¶¶¶¶¶¶¶\r\n                          ¶¶¶¶¶¶¶       ¶¶¶       ¶¶¶  ¶     ¶¶¶¶¶¶¶¶\r\n                                          ¶     ¶¶  ¶¶¶       ¶  ¶¶\r\n                                          ¶¶     ¶¶¶ ¶¶¶         ¶¶\r\n                                           ¶¶     ¶¶ ¶¶¶¶¶     ¶¶\r\n                                           ¶¶¶¶ ¶¶¶     ¶¶¶¶¶¶¶\r\n                                              ¶¶¶¶¶\n");
                Console.WriteLine("                         Доброго времени суток! Добро пожаловать в игру тамагочи.\n");
                string NamePet;
                do
                {
                    Console.WriteLine("Для старта игры введите ведите имя питомца: ");
                    NamePet = Console.ReadLine();
                    if (NamePet == "")
                    {
                        Console.WriteLine("Вы не ввели имя питомца");
                    }
                } while (NamePet == "");
                Console.WriteLine($"{NamePet} изначальное имеет уровень здоровья: 10 \nуровень голода: 0\nуровень усталости: 0\n");
                Tamagotchi pet = new Tamagotchi(10, 0, 0);
                string userInput;
                while (pet.Health > 0)
                {
                    Console.WriteLine($"\nВыберите действие для {NamePet}:");
                    Console.WriteLine("1.Покормить");
                    Console.WriteLine("2.Поиграть");
                    Console.WriteLine("3.Укачать(сон)");
                    userInput = Console.ReadLine();
                    switch (userInput)
                    {
                        case "1":
                            pet.Feed();
                            break;

                        case "2":
                            pet.Play();
                            break;

                        case "3":
                            pet.Rock();
                            break;
                        default:
                            Console.WriteLine("\nНекорректный ввод, пожалуйста выберите действие из списка");
                            break;
                    }
                    Console.WriteLine($"{NamePet} имеет уровень здоровья " + pet.Health);
                    Console.WriteLine("Уровень голода питомца " + pet.Hunger);
                    Console.WriteLine("Уровень усталости питомца " + pet.Fatigue);
                }
                Console.WriteLine("К сожалению, Ваш питомец погиб.");
                string playAgainInput;
                do
                {
                    Console.WriteLine("Хотите начать новую игру? (да/нет)");
                    playAgainInput = Console.ReadLine().ToLower();
                    if (playAgainInput != "да" && playAgainInput != "нет")
                    {
                        Console.WriteLine("Пожалуйста, введите 'да' или 'нет'");
                    }
                } while (playAgainInput != "да" && playAgainInput != "нет");

                playAgain = (playAgainInput == "да");
            }
        }
    }
}