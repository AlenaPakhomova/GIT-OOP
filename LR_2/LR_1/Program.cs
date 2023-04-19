using Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace LabRab_1
{
    /// <summary>
    /// Класс для выполнения программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args"> Списки </param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Нажмите любую клавишу.");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Создаём семь человек...");
            Console.WriteLine();
            Console.ReadKey();

            PersonList personList = new PersonList();

            for (int i = 0; i < 7; i++)
            {
                personList.AddPerson(RandomPerson.GreateRandomPerson());
            }

            Console.WriteLine("Список создан.");
            PrintList(personList);
            Console.ReadKey();



        }




        /// <summary>
        /// Печать списка.
        /// </summary>
        /// <param name="list">Список людей</param>
        /// <param name="stroka">Наименование списка</param>
        public static void PrintList(PersonList people)
        {
            int count = people.CountPersonInList();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(people.FindPersonByIndex(i).GetInfo);
            }
        }


        /// <summary>
        /// Добавление людей через консоль
        /// </summary>
        /// <returns> Новых людей </returns>
        /// <exception cref="ArgumentException"> Неправильный тип 
        /// данных </exception>
        public static PersonBase AddConsolePerson()
        {
            PersonBase newPerson = new Adult();

            Action action = new Action(() =>
            {
                Console.Write($"Если хотите ввести взрослого напишите - 1, " +
                                  $"если ребёнка - 2: ");

                int candidate = int.Parse(Console.ReadLine());
                switch (candidate)
                {
                    case 1:
                        {
                            newPerson = new Adult();
                            break;
                        }

                    case 2:
                        {
                            newPerson = new Child();
                            break;
                        }
                    default:
                        {
                            throw new ArgumentException("Введите для взрослого - 1, для ребёнка - 2: ");
                        }
                }
            });


            var actionPersonList = new List<(Action, string)>
            {
                   (new Action(() =>
                   {
                       Console.Write("Name: ");
                       string name = Console.ReadLine();
                       newPerson.Name = PersonBase.CorrectNameAndSurname(name);

                   }),
                   (new Action(() =>
                    {
                        Console.Write("Surname: ");
                        string surname = Console.ReadLine();
                        newPerson.Surname = PersonBase.CorrectNameAndSurname(surname);
                   }),
                   (new Action(() =>
                   {
                       Console.Write("Age: ");
                       string ageStr = Console.ReadLine();
                       if (!Int32.TryParse(ageStr, out int age))
                       {
                           throw new ArgumentException("Неправильный тип данных!");
                       }
                       newPerson.Age = age;
                   }),
                   (new Action(() =>
                   {
                       Console.Write("Sex (0 - Male, 1 - Female): ");
                       int genderStr = Int32.Parse(Console.ReadLine());
                       CheckingGender(genderStr);
                       newPerson.Gender = (Gender)Enum.Parse(typeof(Gender),
                                           Convert.ToString(genderStr));
                   }),

            };

            var actionAdult = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Console.Write("Введите номер паспорта (номер состоит из 9 цифр): ");
                    bool number = uint.TryParse(Console.ReadLine(), out uint passport);
                    Adult newPersonAdult = (Adult)newPerson;
                    if(number != true)
                    {
                        throw new Exception($"Введен некоректный номер паспорта!");
                    }
                     newPersonAdult.Passport = passport;
                }),
                (new Action(() =>
                {
                    Adult newPersonAdult = (Adult)newPerson;
                    Console.Write("Для выбора места работы введите цифру из списка:" +
                        "Юрист - 1" +
                        "Строитель - 2" +
                        "Инженер - 3" +
                        "Экономист - 4" +
                        "Доктор - 5");
                    int job = int.Parse(Console.ReadLine());
                    switch(job)
                    {
                        case 1:
                            {
                                newPersonAdult.Job = Job.Юрист;
                                Console.WriteLine("Профессия: Юрист");
                                break;
                            }
                        case 2:
                            {
                                newPersonAdult.Job = Job.Строитель;
                                Console.WriteLine("Профессия: Строитель");
                                break;
                            }
                        case 3:
                            {
                                newPersonAdult.Job = Job.Инженер;
                                Console.WriteLine("Профессия: Инженер");
                                break;
                            }
                         case 4:
                            {
                                newPersonAdult.Job = Job.Экономист;
                                Console.WriteLine("Профессия: Экономист");
                                break;
                            }
                         case 5:
                            {
                                newPersonAdult.Job = Job.Доктор;
                                Console.WriteLine("Профессия: Доктор");
                                break;
                            }
                        default:
                            {
                                newPersonAdult.Job = Job.Безработный;
                                Console.WriteLine("Безработный");
                                break;
                            }
                    }
                }),
                (new Action(() =>
                {
                    Adult newPersonAdult = (Adult)newPerson;
                    Console.Write("Для выбора семейного положения введите цифру из списка:" +
                        "Состоит в браке - 1" +
                        "Одиночество - 2" +
                        "Овдовел - 3" +
                        "Разведен - 4");
                    int maritalStatus = int.Parse(Console.ReadLine());
                    switch(maritalStatus)
                    {
                        case 1:
                            {
                                newPersonAdult.MaritalStatus = MaritalStatus.Married;
                                Console.WriteLine("Состоит в браке! Нажмите любую клавишу, чтобы вывести информацию о партнере.");
                                Console.ReadKey();
                                var randomGender = newPersonAdult.Gender == Gender.Male ? Gender.Female : Gender.Male;
                                newPersonAdult.Partner = RandomPerson.RandomAdult(MaritalStatus.Married, newPersonAdult);
                                break;
                            }
                        case 2:
                            {
                                newPersonAdult.MaritalStatus = MaritalStatus.Single;
                                Console.WriteLine("Я пока одинок.");
                                break;
                            }
                        case 3:
                            {
                                newPersonAdult.MaritalStatus = MaritalStatus.Widowed;
                                Console.WriteLine("К сожалению мой партнер погиб.");
                                break;
                            }
                         case 4:
                            {
                                newPersonAdult.MaritalStatus = MaritalStatus.Divorced;
                                Console.WriteLine("Наши жизненные пути разошлись! Теперь я одинок.");
                                break;
                            }
                        default:
                            {
                                throw new Exception("Выберите цифру от 1 до 4!");
                            }
                    }
                }),
            };

            var actionChild = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Console.Write("Введите номер паспорта (номер состоит из 9 цифр): ");
                    
                }),
                (new Action(() =>
                {
                    Child newPersonChild = (Child)newPerson;
                    Console.Write("Для выбора школы введите цифру из списка:" +
                        "Гимназия - 1" +
                        "Лицей - 2" +
                        "СОШ - 3");
                    int school = int.Parse(Console.ReadLine());
                    switch(school)
                    {
                        case 1:
                            {
                                newPersonChild.School = School.Гимназия;
                                Console.WriteLine("Место учёбы: Гимназия");
                                break;
                            }
                        case 2:
                            {
                                newPersonChild.School = School.Лицей;
                                Console.WriteLine("Место учёбы: Лицей");
                                break;
                            }
                        case 3:
                            {
                                newPersonChild.School = School.СОШ;
                                Console.WriteLine("Место учёбы: СОШ");
                                break;
                            }
                        default:
                            {
                                newPersonChild.School = School.Бездельник;
                                Console.WriteLine("Сидит дома и ничего не делает");
                                break;
                            }
                    }
                }),
            };









        }









        public static int CheckingGender(int number)
        {
            if (number < 0 || number > 1)
            {
                throw new Exception("Введите 0 или 1, где 0 - Male," +
                    "1 - Female!");
            }
            else
            {
                return number;
            }
        }


    }
}


/*
/// <summary>
/// Вывод делегата 
/// </summary>
/// <param name="action"> делегат </param>
public static void SetAction(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception s)
                {
                    Console.WriteLine($"\n{s.Message}\n");
                }
            }
        }

  */
      
    
