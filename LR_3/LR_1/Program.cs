﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;
using System.Xml.Linq;

// TODO: Описание методов
// TODO: Длинные строки (+)
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

            Console.WriteLine("Приветствуем нового работника " +
                "нашей фирмы! \nДля ознакомлления с размерами " +
                "оплаты труда нажмите любую клавишу...");
            Console.WriteLine();
            Console.ReadKey();

            while (true)
            {
                Console.WriteLine("\nСпособы начисления зарплаты:" +
                "\n1 - Оклад" +
                "\n2 - Часовая тарифная ставка" +
                "\n3 - Тарифная ставка" +
                "\n4 - Завершить выбор");

                Console.Write("\nВведите цифру из представленного " +
                    "списка: ");
                var consoleKey = Console.ReadLine();
                switch (consoleKey)
                {
                    case "1":
                        {
                            Console.WriteLine("\tОплата по окладу");
                            PrintWages(WagesBySalary());
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("\tОплата по часовой " +
                                "тарифной ставке");
                            PrintWages(WagesAtTheHourlyTariffRate());
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("\tОплата по тарифной " +
                                "ставке");
                            PrintWages(WagesAtTheTariffRate());
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

        /// <summary>
        /// Ввод данных для расчёта размера заработной платы 
        /// по тарифной ставке
        /// </summary>
        /// <returns></returns>
        public static WageRate WagesAtTheTariffRate()
        {
            var wageRate = new WageRate();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write("Количество отработанный дней в " +
                        "месяце: ");
                    wageRate.WorkingDays = ParseConsoleString();
                }),
                new Action(() =>
                {
                    Console.Write("Тарифная ставка (рублей в день): ");
                    wageRate.TariffRate = ParseConsoleString();
                })               
            };
            actions.ForEach(SetInformationFromConsole);
            return wageRate;
        }

        /// <summary>
        /// Ввод данных для расчёта размера заработной платы 
        /// по часовой тарифной ставке
        /// </summary>
        /// <returns></returns>
        public static HourlyWageRate WagesAtTheHourlyTariffRate()
        {
            var hourlyWageRate = new HourlyWageRate();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write("Размер часовой тарифной ставки " +
                        "(рублей в час): ");
                    hourlyWageRate.SizeOfTheHourlyTariffRate
                    = ParseConsoleString();
                }),
                new Action(() =>
                {
                    Console.Write("Количество отработанных часов: ");
                    hourlyWageRate.WorkingHours = ParseConsoleString();
                })
            };
            actions.ForEach(SetInformationFromConsole);
            return hourlyWageRate;
        }

        /// <summary>
        /// Ввод данных для расчёта размера заработной платы по окладу
        /// </summary>
        /// <returns></returns>
        public static Salary WagesBySalary()
        {
            var salary = new Salary();
            var actions = new List<Action>()
            {
                new Action(() =>
                {
                    Console.Write("Размер оклада (в рублях): ");
                    salary.SalaryAmount = ParseConsoleString();
                }),
                new Action(() =>
                {
                    Console.Write("Количество рабочих дней " +
                        "в месяце: ");
                    salary.DaysInMonth = ParseConsoleString();
                }),
                new Action(() =>
                {
                    Console.Write("Количество фактически " +
                        "отработанных дней: ");
                    salary.WorkingDays = ParseConsoleString();
                }),
            };
            actions.ForEach(SetInformationFromConsole);
            return salary;
        }

        // TODO: PrintWages (+)
        /// <summary>
        /// Вывод полученной информации на консоль
        /// </summary>
        /// <param name="value"></param>
        public static void PrintWages(WagesBase value)
        {
            Console.WriteLine($"Размер заработной платы: " +
                $"{value.Wages} рублей.");
        }

        // TODO: ParseConsoleString or smth (+)
        /// <summary>
        /// Чтение информации с консоли
        /// </summary>
        /// <returns></returns>
        public static double ParseConsoleString()
        {
            return double.Parse(Console.ReadLine().Replace('.', ','));
        }

        /// <summary>
        /// Получение введенной информации
        /// </summary>
        /// <param name="action"></param>
        public static void SetInformationFromConsole(Action action)
        {
            while (true)
            {
                try
                {
                    action.Invoke();
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\n{e.Message}\n");
                }
            }
        }
    }         
}




        
  
      
    
