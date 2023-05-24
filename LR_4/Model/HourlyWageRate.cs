using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]

    /// <summary>
    /// Класс для оплаты по часовой тарифной ставке
    /// </summary>
    public class HourlyWageRate : WagesBase
    {
        /// <summary>
        /// Размер часовой тарифной ставки
        /// </summary>
        private double _sizeOfTheHourlyTariffRate;

        /// <summary>
        /// Количество фактически отработанных часов
        /// </summary>
        private double _workingHours;

        /// <summary>
        /// Тип заработной платы
        /// </summary>
        public override string TypeWage => "Часовая тарифная ставка";

        /// <summary>
        /// Размер часовой тарифной ставки
        /// </summary>
        public double SizeOfTheHourlyTariffRate
        {
            get
            {
                return _sizeOfTheHourlyTariffRate;
            }
            set
            {
                CheckPositiveNumber(value);
                _sizeOfTheHourlyTariffRate = value;
            }

        }

        /// <summary>
        /// Количество фактически отработанных часов
        /// </summary>
        public double WorkingHours
        {
            get
            {
                return _workingHours;
            }
            set
            {
                CheckPositiveNumber(value);
                _workingHours = value;
            }

        }

        /// <summary>
        /// Вычисление зарплаты по часовой тарифной ставке
        /// </summary>
        public override double Wages() => 
            _sizeOfTheHourlyTariffRate * _workingHours;
    }
}
