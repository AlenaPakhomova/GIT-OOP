using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace LR_2
{
    /// <summary>
    /// Класс для выполнения программы
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <param name="args">параметры</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Press any key...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Creating seven people...");
            Console.WriteLine();
            Console.ReadKey();


            PersonList personList = new PersonList();
            
            for (int i = 1; i < 9; i++)
            {
                personList.AddPerson(RandomPerson.GreateRandomPerson());
            }
            

            Console.WriteLine("The list has been created.");
            PrintList(personList);
            Console.ReadKey();

            Console.WriteLine("\nInformation about the fourth person from" +
                " the created list:");
            Console.ReadKey();

            Console.WriteLine("\nLet's find out about his taste " +
                "preferences");
            Console.ReadKey();

            PersonBase person = personList.FindPersonByIndex(4);
            switch (person)
            {
                case Adult adult:
                    {
                        Console.WriteLine(adult.FavoriteFood());
                        break;
                    }
                case Child child:
                    {
                        Console.WriteLine(child.FavoriteSweet());
                        break;
                    }
                default:
                    break;
            }
        }

        /// <summary>
        /// Печать списка
        /// </summary>
        /// <param name="people">человек</param>
        public static void PrintList(PersonList people)
        {
            int count = people.CountPersonInList();
            for (int i = 1; i < count; i++)
            {
                Console.WriteLine($"\nPerson № {i}");
                Console.WriteLine(people.FindPersonByIndex(i).GetInfo());
            }
        }
    }   
}





    












