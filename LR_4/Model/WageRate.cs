
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
                _tariffRate = CheckPositiveNumber(value);
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
                _workingDays = CheckPositiveNumber(value);
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public WageRate()
        { }
        

        /// <summary>
        /// Тип заработной платы
        /// </summary>
        public override string WageType => "Тарифная ставка";

        /// <summary>
        /// Вычисление зарплаты по тарифной ставке
        /// </summary>
        public override double Wages => Math.Round((TariffRate * WorkingDays),2);

        /// <summary>
        /// Параметры для расчёта заработной платы 
        /// </summary>
        public override string Parameters
        {
            get
            {
                return $"Ставка = {TariffRate}, Рабочие дни = {WorkingDays}";
            }
        }


        /// <summary>
        /// Информация о зарплате 
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            //TODO: округление (+)
            //TODO: RSDN (+)
            return $"Тарифная ставка: Ставка = {TariffRate}, " +
                $"Рабочие дни = {WorkingDays}, ЗП: {Wages}";
        }


    }
}
