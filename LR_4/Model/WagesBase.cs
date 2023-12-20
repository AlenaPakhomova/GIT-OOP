using System.ComponentModel;
using System.Xml.Serialization;

namespace Model
{
    [XmlInclude(typeof(HourlyWageRate))]
    [XmlInclude(typeof(Salary))]
    [XmlInclude(typeof(WageRate))]

    /// <summary>
    /// Класс для начисления заработной платы.
    /// </summary>
    public abstract class WagesBase
    {

        /// <summary>
        /// Тип заработной платы
        /// </summary>
        [DisplayName ("Тип заработной платы")]
        public virtual string WageType { get; }

        /// <summary>
        /// Параметры для расчёта заработной платы
        /// </summary>
        [DisplayName ("Параметры")]
        public virtual string Parameters { get; }

        /// <summary>
        /// Вычисление заработной платы.
        /// </summary>
        [DisplayName("Заработная плата, руб")]
        public abstract double Wages { get; }

        /// <summary>
        /// Проверка на отрицательные числа.
        /// </summary>
        /// <param name="number">размер зарплаты</param>
        /// <returns>размер зарплаты</returns>
        /// <exception cref="ArgumentOutOfRangeException">отрицательное
        /// число в зарплате</exception>
        public static double CheckPositiveNumber(double number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Ставка и оклад " +
                    "не могут быть отрицательными числами!");
            }
            else if (double.IsNaN(number))
            {
                throw new ArgumentException("Нечисловое значение!");
            }
            else
            {
                return number;
            }          
        }

        /// <summary>
        /// Проверка количества дней в месяце
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static double CheckDaysInMonth(double number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Количество дней " +
                    "не может быть отрицательным числом!");
            }
            else if (double.IsNaN(number))
            {
                throw new ArgumentException("Нечисловое значение!");
            }
            else if (number > 31 || number < 28)
            {
                throw new ArgumentException("В месяце " +
                    "может быть от 28 до 31 дня!");
            }
            else
            {
                return number;
            }
        }

        /// <summary>
        /// Проверка количества рабочих дней в месяце
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static double CheckWorkingDaysInMonth(double number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Количество дней " +
                    "не может быть отрицательным числом!");
            }
            else if (double.IsNaN(number))
            {
                throw new ArgumentException("Нечисловое значение!");
            }
            else if (number > 22)
            {
                throw new ArgumentException("В месяце " +
                    "не может быть болше 22 рабочих дней!");
            }
            else
            {
                return number;
            }
        }

        /// <summary>
        /// Вывод информации о зарплате
        /// </summary>
        public abstract string GetInfo();

        //TODO: XML (+)
        /// <summary>
        /// Округление величины зарплаты до 2 знака
        /// </summary>
        /// <param name="wage">зарплата</param>
        /// <returns></returns>
        protected double GetRoundedWage(double wage)
        {
            return Math.Round(wage, 2);
        }
    }
}