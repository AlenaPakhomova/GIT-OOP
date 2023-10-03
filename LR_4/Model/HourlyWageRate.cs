namespace Model
{

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
                _sizeOfTheHourlyTariffRate = CheckPositiveNumber(value);
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
                _workingHours = CheckPositiveNumber(value);
            }

        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        public HourlyWageRate()
        { }

        /// <summary>
        /// Вычисление зарплаты по часовой тарифной ставке
        /// </summary>
        public override double Wages => 
            Math.Round((SizeOfTheHourlyTariffRate * WorkingHours),2);
           
     
        /// <summary>
        /// Тип заработной платы
        /// </summary>
        public override string WageType => "Часовая тарифная ставка";

        /// <summary>
        /// Параметры для расчёта заработной платы
        /// </summary>
        public override string Parameters
        {
            get
            {
                return $"Ставка = {SizeOfTheHourlyTariffRate}, " +
                    $"Часы = {WorkingHours}";
            }
        }

        /// <summary>
        /// Информация о зарплате
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            return $"Часовая тарифная ставка: Ставка = " +
                $"{SizeOfTheHourlyTariffRate}, Часы = {WorkingHours}," +
                //TODO: округление (+)
                $" ЗП: {Wages}";
        }


    }
}
