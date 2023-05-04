using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс для оплаты по тарифной ставке
    /// </summary>
    public class WageRate : WagesBase
    {
        /// <summary>
        /// Размер тарифной ставки
        /// </summary>
        private double _tariffRate;

        /// <summary>
        /// Количество фактически отработанных дней
        /// </summary>
        private double _workingDays;


        /// <summary>
        /// Размер тарифной ставки
        /// </summary>
        public double TariffRate
        {
            get
            {
                return _tariffRate;
            }
            set
            {
                CheckPositiveNumber(value);
                _tariffRate = value;
            }
        }

        /// <summary>
        /// Количество рабочих дней
        /// </summary>
        public double WorkingDays
        {
            get
            {
                return _workingDays;
            }
            set
            {
                CheckPositiveNumber(value);
                _workingDays = value;
            }
        }


        /// <summary>
        /// Вычисление зарплаты по тарифной ставке
        /// </summary>
        public override double Wages() => 
            _workingDays * _tariffRate;

    }
}
