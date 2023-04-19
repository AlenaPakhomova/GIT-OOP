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
        /// <param name="args">параметры</param>
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

            Console.WriteLine("\nВывод информации о четвертом человеке " +
                "из списка");
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
                Console.WriteLine($"\nЧеловек № {i}");
                Console.WriteLine(people.FindPersonByIndex(i).GetInfo());
            }
        }
    }
}




        
  
      
    
