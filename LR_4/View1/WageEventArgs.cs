using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    /// <summary>
    /// Класс аргумента для передачи данных о зарплате
    /// </summary>
    public class WageEventArgs : EventArgs
    {
        /// <summary>
        /// Отправка значения
        /// </summary>
        public WagesBase WageValue { get; private set; }

        /// <summary>
        /// Конструктор для передачи значения
        /// </summary>
        /// <param name="sendingValue">Передача</param>
        public WageEventArgs(WagesBase wageValue)
        {
            WageValue = wageValue;
        }
    }
}
