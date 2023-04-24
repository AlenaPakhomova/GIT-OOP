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
        /// Тарифная ставка
        /// </summary>
        private double _tariffRate;

        /// <summary>
        /// Количество фактически отработанных дней
        /// </summary>
        private double _workingDays;

        /// <summary>
        /// Расчёт тарифной ставки
        /// </summary>
        private double _calculationOfTheTariffRate;

        /// <summary>
        /// Расчёт размера тарифной ставки
        /// </summary>
        public double CalculationOfTariffRate
        {
            get
            {
                return _calculationOfTheTariffRate;
            }
            set
            {
                CheckingNumber(value);
                _calculationOfTheTariffRate = value;
            }
        }

        /// <summary>
        /// Вычисление тарифной ставки
        /// </summary>
        public override double Wages
        {
            get
            {
                return _workingDays * _tariffRate;
            }
        }

    }
}
