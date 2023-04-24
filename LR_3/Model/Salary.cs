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
        /// Расчёт размера оклада
        /// </summary>
        private double _salaryCalculation;

        /// <summary>
        /// Размер оклада
        /// </summary>
        private double _salaryAmount;

        /// <summary>
        /// Количество рабочих дней в месяце
        /// </summary>
        private int _daysInMonth;

        /// <summary>
        /// Количество фактически отработанных дней
        /// </summary>
        private int _workingDays;

        /// <summary>
        /// Расчёт размера оклада
        /// </summary>
        public double SalaryCalculation
        {
            get
            {
                return _salaryCalculation;
            }
            set
            {
                CheckingNumber(value);
                _salaryCalculation = value;
            }
        }

        /// <summary>
        /// Вычисление размера оклада
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
