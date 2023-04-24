using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс для оплаиы по часовой тарифной ставке
    /// </summary>
    public class HourlyWageRate : WagesBase
    {
        /// <summary>
        /// Рачёт часовой тарифной ставки
        /// </summary>
        private double _calculationOfTheHourlyTariffRate;

        /// <summary>
        /// Размер часовой тарифной ставки
        /// </summary>
        private double _sizeOfTheHourlyTariffRate;

        /// <summary>
        /// Количество фактически отработанных часов
        /// </summary>
        private int _workingHours;

        /// <summary>
        /// Расчёт размера часовой тарифной ставки
        /// </summary>
        public double CalculationOfTheHourlyTariffRate
        {
            get
            {
                return _calculationOfTheHourlyTariffRate;
            }
            set
            {
                CheckingNumber(value);
                _calculationOfTheHourlyTariffRate = value;
            }

        }

        /// <summary>
        /// Вычисление размера часовой тарифной ставки
        /// </summary>
        public override double Wages
        {
            get
            {
                return _sizeOfTheHourlyTariffRate * _workingHours;
            }
        }

    }
}
