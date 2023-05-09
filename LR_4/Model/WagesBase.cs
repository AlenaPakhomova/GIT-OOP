using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model
{
    /// <summary>
    /// Класс для начисления заработной платы.
    /// </summary>
    public abstract class WagesBase
    {
        /// <summary>
        /// Вычисление заработной платы.
        /// </summary>
        public abstract double Wages();

        /// <summary>
        /// Проверка на отрицательные числа.
        /// </summary>
        /// <param name="number">размер зарплаты</param>
        /// <returns>размер зарплаты</returns>
        /// <exception cref="ArgumentOutOfRangeException">отрицательное
        /// число в зарплате</exception>
        public static double CheckPositiveNumber(double number)
        {
            if (number < 0)
            {
                throw new Exception("Ставка, оклад и количество дней " +
                    "не могут быть отрицательными числами!");
            }
            return number;
        }

    }
}