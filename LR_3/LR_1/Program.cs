using Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace LR_3 
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
            Console.WriteLine("Нажмите любую клавишу...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Приветствуем нового работника нашей фирмы!" +
                "\nДля ознакомлления с размерами оплаты труда нажмите " +
                "любую клавишу...");
            Console.WriteLine();
            Console.ReadKey();

            Console.WriteLine("Способы начисления зарплаты:" +
                "\n1 - Оклад" +
                "\n2 - Часовая тарифная ставка" +
                "\n3 - Тарифная ставка" +
                "\n4 - Завершить выбор");          

            while (true)
            {
                Console.Write("\nВаш выбор: ");
                var consoleKey = Console.ReadLine();
                switch (consoleKey)
                {
                    case "1":
                        {
                            Console.WriteLine("Оплата по окладу:");
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Оплата по часовой тарифной ставке:");
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Оплата по тарифной ставке:");
                            break;
                        }
                    case "4":
                        {
                            Environment.Exit(4);
                            break;
                        }
                    default:
                        {
                            
                            Console.WriteLine("Попробуйте еще раз");
                        }
                        break;
                }                    
            }           
        }
            


            /*
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
        } */
    }
            
}




        
  
      
    
