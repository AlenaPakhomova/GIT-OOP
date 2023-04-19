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

            for (int i = 1; i < 9; i++)
            {                
                personList.AddPerson(RandomPerson.GreateRandomPerson());
            }

            Console.WriteLine("Список создан.");
            PrintList(personList);
            Console.ReadKey();


            Console.WriteLine("\nВывод информации о четвертом человеке из списка");
            Console.WriteLine();
            Console.ReadKey();

            PersonBase person = personList.FindPersonByIndex(3);

            switch (person)
            {
                case Adult adult:
                    {
                        Console.WriteLine(adult.GetInfo());
                        break;
                    }
                case Child child:
                    {
                        Console.WriteLine(child.GetInfo());
                        break;
                    }
                default:
                    break;
            }

            Console.ReadKey();
            Console.WriteLine("\nНовый человек: ");
            PersonBase newPerson = AddConsolePerson();
            Console.WriteLine(newPerson.GetInfo());

            
        }




        /// <summary>
        /// Печать списка.
        /// </summary>
        /// <param name="list">Список людей</param>
        /// <param name="stroka">Наименование списка</param>
        public static void PrintList(PersonList people)
        {
            int count = people.CountPersonInList();
            for (int i = 1; i < count; i++)
            {
                Console.WriteLine($"\nЧеловек № {i}");
                Console.WriteLine(people.FindPersonByIndex(i).GetInfo());
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
                Console.Write($"Если хотите ввести взрослого напишите 1, " +
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
                       Console.Write("Имя: ");
                       string name = Console.ReadLine();
                       newPerson.Name = PersonBase.CorrectNameAndSurname(name);

                   }), "name"),
                   (new Action(() =>
                   {
                        Console.Write("Фамилия: ");
                        string surname = Console.ReadLine();
                        newPerson.Surname = PersonBase.CorrectNameAndSurname(surname);
                   }), "surname"),
                   (new Action(() =>
                   {
                       Console.Write("Возраст: ");
                       string ageStr = Console.ReadLine();
                       if (!Int32.TryParse(ageStr, out int age))
                       {
                           throw new ArgumentException("Неправильный тип данных!");
                       }
                       newPerson.Age = age;
                   }), "age"),
                   (new Action(() =>
                   {
                       Console.Write("Gender (0 - Male, 1 - Female): ");
                       int genderStr = Int32.Parse(Console.ReadLine());
                       CheckingGender(genderStr);
                       newPerson.Gender = (Gender)Enum.Parse(typeof(Gender),
                                           Convert.ToString(genderStr));
                   }), "gender"),

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
                }), "passport"),
                (new Action(() =>
                {
                    Adult newPersonAdult = (Adult)newPerson;
                    Console.Write("Для выбора места работы введите цифру из списка:" +
                        "\nЮрист - 1" +
                        "\nСтроитель - 2" +
                        "\nИнженер - 3" +
                        "\nЭкономист - 4" +
                        "\nДоктор - 5" +
                        "Ваша цифра: ");
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
                }), "job"),
                (new Action(() =>
                {
                    Adult newPersonAdult = (Adult)newPerson;
                    Console.Write("Для выбора семейного положения введите цифру из списка:" +
                        "\nСостоит в браке - 1" +
                        "\nОдиночество - 2" +
                        "\nОвдовел - 3" +
                        "\nРазведен - 4" +
                        "\nВаша цифра:");
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
                }), "maritalStatus"),
            };

            var actionChild = new List<(Action, string)>
            {
                (new Action(() =>
                {
                    Child newPersonChild = (Child)newPerson;
                    newPersonChild.Mother = CheckingParents(newPersonChild, "есть мама", Gender.Female);
                }), "mother"),
                (new Action(() =>
                {
                    Child newPersonChild = (Child)newPerson;
                    newPersonChild.Father = CheckingParents(newPersonChild, "есть папа", Gender.Male);
                }), "father"),
                (new Action(() =>
                {
                    Child newPersonChild = (Child)newPerson;
                    Console.Write("Для выбора школы введите цифру из списка:" +
                        "\nГимназия - 1" +
                        "\nЛицей - 2" +
                        "\nСОШ - 3" +
                        "Ваша цифра: ");
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
                }), "scholl"),
            };


            SetAction(action, "Взрослый или ребёнок");

            foreach (var actions in actionPersonList)
            {
                SetAction(actions.Item1, actions.Item2);
            }


            switch(newPerson)
            {
                case Adult:
                    {
                        foreach (var actions in actionAdult)
                        {
                            SetAction(actions.Item1, actions.Item2);
                        }
                        break;
                    }
                case Child:
                    {
                        foreach (var actions in actionChild)
                        {
                            SetAction(actions.Item1, actions.Item2);
                        }
                        break;
                    }
                default:
                    break;


            }
            return newPerson;

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


        private static Adult? CheckingParents(Child newPersonChild, string parents, Gender gender)
        {
            Console.WriteLine("Есть ли у ребенка родители (введите нужную цифру):" +
                "\nродители живы и здоровы - 0," +
                "\nнет родителей - 1" +
                "\nВаша цифра: ");
            int haveParents = int.Parse(Console.ReadLine());
            switch (haveParents)
            {
                case 0:
                    {
                        return gender == Gender.Male ? RandomPerson.RandomAdult(MaritalStatus.Married, newPersonChild.Mother, gender)
                        : RandomPerson.RandomAdult(MaritalStatus.Married, newPersonChild.Father, gender);
                    }
                case 1:
                    {
                        return null;
                    }
                default:
                    {
                        throw new Exception("Выберите цифру 0 или 1!");
                    }
            }



        }
        public static void SetAction(Action action, string typeOfPerson)
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
                    if(s.GetType() == typeof(ArgumentException) || s.GetType() == typeof(ArgumentException))
                    {
                        Console.WriteLine($"Ошибка: {s.Message}\n" +
                            $"Некоректный ввод: {typeOfPerson}");
                    }
                    else
                    {
                        throw;
                    }
                    
                }
            }
        }

        


    }
}




        
  
      
    
