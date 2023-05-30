using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    /// <summary>
    /// Интерфейс для добавления фигуры.
    /// </summary>
    internal interface IAddWages
    {
        /// <summary>
        /// Метод для добавления заработной платы.
        /// </summary>
        /// <returns></returns>
        public abstract WagesBase AddingWages();
    }
}


