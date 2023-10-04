using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    /// <summary>
    /// Класс событий
    /// </summary>
    internal class WageListEventArgs : EventArgs
    {
        /// <summary>
        /// Список зарплат
        /// </summary>
        public BindingList<WagesBase> WageListValue { get; private set; }

        /// <summary>
        /// Конструктор союытия добавления в список зарплат.
        /// </summary>
        /// <param name="wages"></param>
        public WageListEventArgs(BindingList<WagesBase> wages)
        {
            WageListValue = wages;
        }
    }
}