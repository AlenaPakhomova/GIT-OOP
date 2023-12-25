using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIEW
{
    /// <summary>
    /// Класс для тестирования библиотеки классов Model
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения
        /// </summary>
        /// <param name="args">Параметры</param>
        [STAThread]
        public static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
