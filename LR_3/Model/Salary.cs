using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс для оплаты по окладу
    /// </summary>
    public class Salary : WagesBase
    {
        /// <summary>
        /// Размер оклада
        /// </summary>
        private double _salaryAmount;

        /// <summary>
        /// Количество рабочих дней в месяце
        /// </summary>
        private double _daysInMonth;

        /// <summary>
        /// Количество фактически отработанных дней
        /// </summary>
        private double _workingDays;

        /// <summary>
        /// Размер оклада
        /// </summary>
        public double SalaryAmount
        {
            get
            {
                return _salaryAmount;
            }
            set
            {
                CheckingNumber(value);
                _salaryAmount = value;
            }
        }

        /// <summary>
        /// Количество рабочих дней в месяце
        /// </summary>
        public double DaysInMonth
        {
            get
            {
                return _daysInMonth;
            }
            set
            {
                CheckingNumber(value);
                _daysInMonth = value;
            }
        }


        /// <summary>
        /// Количество фактически отработанных дней
        /// </summary>
        public double WorkingDays
        {
            get
            {
                return _workingDays;
            }
            set
            {
                CheckingNumber(value);
                _workingDays = value;
            }
        }

        /// <summary>
        /// Вычисление зарплаты по окладу
        /// </summary>
        public override double Wages
        {
            get
            {
                return _salaryAmount / _daysInMonth * _workingDays;
            }
        }

    }
}
