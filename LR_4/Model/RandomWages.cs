using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс для создания случайной заработной платы
    /// </summary>
    public static class RandomWages
    {
        /// <summary>
        /// Рандомайзер
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Генерация случайного числа double через int
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public static double GetRandomDouble(int minValue, int maxValue)
        {
            var randomValue = Convert.ToDouble(_random.Next(minValue, 
                maxValue));
            return randomValue;
        }

        /// <summary>
        /// Генерация случайной зарплаты
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static WagesBase GetRandomWages()
        {
            var figureType = _random.Next(0, 3);

            switch (figureType)
            {
                case 0:
                    {
                        return RandomHourlyWageRate();
                    }
                case 1:
                    {
                        return RandomSalary();
                    }
                case 2:
                    {
                        return RandomWageRate();
                    }
                default:
                    {
                        throw new ArgumentException("Тип фигуры " +
                            "отсутствует.");
                    }
            }
        }

        /// <summary>
        /// Генерация случайной часовой тарифной ставки
        /// </summary>
        /// <returns></returns>
        public static WagesBase RandomHourlyWageRate()
        {
            var hourlyWageRate = new HourlyWageRate
            {
                SizeOfTheHourlyTariffRate = GetRandomDouble(100, 1000),
                WorkingHours = GetRandomDouble(1, 24),             
            };
            return hourlyWageRate;
        }

        /// <summary>
        /// Генерация случайного оклада
        /// </summary>
        /// <returns></returns>
        public static WagesBase RandomSalary()
        {
            var salary = new Salary
            {
                SalaryAmount = GetRandomDouble(10000, 100000),
                DaysInMonth = GetRandomDouble(28, 31),
                WorkingDays = GetRandomDouble(1, 22),
            };
            return salary;
        }

        /// <summary>
        /// Генерация случайной тарифной ставки
        /// </summary>
        /// <returns></returns>
        public static WagesBase RandomWageRate()
        {
            var wageRate = new WageRate
            {
                TariffRate = GetRandomDouble(100, 1000),
                WorkingDays = GetRandomDouble(1, 22),               
            };
            return wageRate;
        }



    }
}
