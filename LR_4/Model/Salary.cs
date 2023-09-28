
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
                _salaryAmount = CheckPositiveNumber(value);
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
                _daysInMonth = CheckDays(value); 
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
                _workingDays = CheckDays(value);
            }
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        public Salary()
        { }


        /// <summary>
        /// Вычисление зарплаты по окладу
        /// </summary>
        public override double Wages => SalaryAmount / DaysInMonth * WorkingDays;

        /// <summary>
        /// Тип заработной платы
        /// </summary>
        public override string WageType => "Зарплата по окладу";

        /// <summary>
        /// Параметры для расчёта заработной платы
        /// </summary>
        public override string Parameters
        {
            get
            {
                return $"Оклад = {SalaryAmount}, Дни в месяце = {DaysInMonth}, Рабочие дни = {WorkingDays}";
            }
        }

        /// <summary>
        /// Информация о зарплате
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            return $"Зарплата по окладу: Оклад = {SalaryAmount}, Дни в месяце = {DaysInMonth}," +
                //TODO: округление
                $" Рабочие дни = {WorkingDays}, ЗП: {Math.Round(Wages, 1)} ";
        }

        

    }
}
