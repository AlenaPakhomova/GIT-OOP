using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //TODO: XML
    public static class RandomWages
    {
        private static Random _random = new Random();

        public static double GetRandomDouble(int minValue, int maxValue)
        {
            var randomValue = Convert.ToDouble(_random.Next(minValue, maxValue));
            return randomValue;
        }


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
                        throw new ArgumentException("Тип фигуры отсутствует.");
                    }
            }
        }

        public static WagesBase RandomHourlyWageRate()
        {
            var hourlyWageRate = new HourlyWageRate
            {
                SizeOfTheHourlyTariffRate = GetRandomDouble(50, 500),
                WorkingHours = GetRandomDouble(1, 24),             
            };
            return hourlyWageRate;
        }

        public static WagesBase RandomSalary()
        {
            var salary = new Salary
            {
                SalaryAmount = GetRandomDouble(10000, 100000),
                DaysInMonth = GetRandomDouble(28, 31),
                WorkingDays = GetRandomDouble(1, 21),
            };
            return salary;
        }

        public static WagesBase RandomWageRate()
        {
            var wageRate = new WageRate
            {
                TariffRate = GetRandomDouble(50, 500),
                WorkingDays = GetRandomDouble(1, 21),               
            };
            return wageRate;
        }

    }
}
