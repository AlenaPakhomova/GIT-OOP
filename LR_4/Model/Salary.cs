
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
                _daysInMonth = CheckDaysInMonth(value); 
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
                _workingDays = CheckWorkingDaysInMonth(value);
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
        public override double Wages => 
            Math.Round((SalaryAmount / DaysInMonth * WorkingDays), 2);

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
                return $"Оклад = {SalaryAmount}, " +
                    $"Дни в месяце = {DaysInMonth}, " +
                    $"Рабочие дни = {WorkingDays}";
            }
        }

        /// <summary>
        /// Информация о зарплате
        /// </summary>
        /// <returns></returns>
        public override string GetInfo()
        {
            return $"Зарплата по окладу: Оклад = {SalaryAmount}, " +
                $"Дни в месяце = {DaysInMonth}," +
                $" Рабочие дни = {WorkingDays}, ЗП: {Wages}";
        }

        /// <summary>
        /// Проверка количества дней в месяце
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public double CheckDaysInMonth(double number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Количество дней " +
                    "не может быть отрицательным числом!");
            }
            else if (double.IsNaN(number))
            {
                throw new ArgumentException("Нечисловое значение!");
            }
            else if (number > 31 || number < 28)
            {
                throw new ArgumentException("В месяце " +
                    "может быть от 28 до 31 дня!");
            }
            else
            {
                return number;
            }
        }


        /// <summary>
        /// Проверка количества рабочих дней в месяце
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public double CheckWorkingDaysInMonth(double number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Количество дней " +
                    "не может быть отрицательным числом!");
            }
            else if (double.IsNaN(number))
            {
                throw new ArgumentException("Нечисловое значение!");
            }
            else if (number > 22)
            {
                throw new ArgumentException("В месяце " +
                    "не может быть болше 22 рабочих дней!");
            }
            else
            {
                return number;
            }
        }
    }
}
