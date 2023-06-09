﻿using Model;
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
            PersonList list1 = new PersonList();
            PersonList list2 = new PersonList();

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();

            Console.WriteLine("Шаг 1. Создание двух списков персон, " +
                "в каждом из которых есть три человека");
            Console.ReadKey();

            Console.WriteLine("\nШаг 2. Вывод содержимого списков на экран");
            Console.ReadKey();

            list1.AddPerson(new Person() { Name = "Иван", Surname = "Петров",
                Age = 15, Gender = Gender.Male });
            list1.AddPerson(new Person() { Name = "Вася", 
                Surname = "Николенко", Age = 20, Gender = Gender.Male });
            list1.AddPerson(new Person() { Name = "Вероника", 
                Surname = "Иванова", Age = 30, Gender = Gender.Female });
            list2.AddPerson(new Person() { Name = "Кристина", 
                Surname = "Измайлова", Age = 25, Gender = Gender.Female });
            list2.AddPerson(new Person() { Name = "Владимир", 
                Surname = "Касьянов", Age = 18, Gender = Gender.Male });
            list2.AddPerson(new Person() { Name = "Кирилл", 
                Surname = "Абрамов", Age = 28, Gender = Gender.Male });

            PrintList(list1, "\nList № 1");
            PrintList(list2, "\nList № 2");
            
            Console.ReadKey();
            Console.WriteLine("\nШаг 3. Добавление нового человека в " +
                "первый список");
            Console.ReadKey();
            list1.AddPerson(new Person("Никита", "Семенов", 23, Gender.Male));

            PrintList(list1, "\nList № 1");
            
            Console.ReadKey();
            Console.WriteLine("\nШаг 4. Копирование второго человека из " +
                "первого списка в конец второго списка");
            Console.ReadKey();
            Console.WriteLine("\nСкопированный человек находится в " +
                "двух списках");
            list2.AddPerson(list1.FindPersonByIndex(1));

            PrintList(list1, "\nList № 1");
            PrintList(list2, "\nList № 2");

            Console.ReadKey();
            Console.WriteLine("\nШаг 5. Удаление второго человека " +
                "из первого списка");
            Console.ReadKey();
            list1.RemovePersonByIndex(1);
            PrintList(list1, "\nList № 1");
            PrintList(list2, "\nList № 2");
            Console.WriteLine("\nУдаление человека из первого списка не " +
                "привело к уничтожению этого человека во втором списке");
            Console.ReadKey();

            Console.WriteLine("\nШаг 6. Очистка второго списка");
            Console.ReadKey();
            list2.ClearPerson();
            PrintList(list2, "\nList № 2");

            Console.ReadKey();
            Console.WriteLine("\nШаг 7. Добавление персоны с клавиатуры " +
                "во второй список");
            Console.ReadKey();
            list2.AddPerson(AddConsolePerson());
            PrintList(list2, "\nList № 2");

            Console.ReadKey();
            Console.WriteLine("\nШаг 8. Добавление рандомного человека " +
                "во второй список");
            Console.ReadKey();
            Person randPerson = RandomPerson.GetRandomPerson();
            list2.AddPerson(randPerson);
            PrintList(list2, "\nList № 2");
        }

        /// <summary>
        /// Печать списка.
        /// </summary>
        /// <param name="list">Список людей</param>
        /// <param name="stroka">Наименование списка</param>
        public static void PrintList(PersonList list, string stroka)
        {
            Console.WriteLine(stroka);
            int count = list.CountPersonInList();
            for (int i = 0; i < count; i++)
            {
                Person person = list.FindPersonByIndex(i);
                Console.WriteLine(person.GetInfo());
            }
        }       

        /// <summary>
        /// Добавление людей через консоль
        /// </summary>
        /// <returns> Новых людей </returns>
        /// <exception cref="ArgumentException"> Неправильный тип 
        /// данных </exception>
        public static Person AddConsolePerson()
        {
            Person newPerson = new Person();

            List<Action> actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write("Name: ");
                    newPerson.Name = Console.ReadLine();

                }),
                new Action(() =>
                {
                    Console.Write("Surname: ");
                    newPerson.Surname = Console.ReadLine();
                }),
                new Action(() =>
                {
                    Console.Write("Age: ");
                    string ageStr = Console.ReadLine();
                    if(!Int32.TryParse(ageStr, out int age))
                    {
                        throw new ArgumentException("Неправильный тип данных!");
                    }
                    newPerson.Age = age;
                }),
                new Action(() =>
                {
                    Console.Write("Sex (0 - Male, 1 - Female): ");
                    int genderStr = Int32.Parse(Console.ReadLine());
                    CheckingGender(genderStr);
                    newPerson.Gender = (Gender)Enum.Parse(typeof(Gender),
                                       Convert.ToString(genderStr));
                }),

            };
            actions.ForEach(SetAction);
            return newPerson;
        }

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

        /// <summary>
        /// Проверка пола человека
        /// </summary>
        /// <param name="number"> пол </param>
        /// <returns> Возвращает пол </returns>
        /// <exception cref="Exception">Несуществующий пол</exception>
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