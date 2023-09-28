using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Добавление часовой тарифной ставки
    /// </summary>
    public partial class HourlyWageRateUserControl : UserControl, IAddWages
    {
        /// <summary>
        /// Добавление часовой тарифной ставки
        /// </summary>
        public HourlyWageRateUserControl()
        {
            InitializeComponent();
        }

        //TODO: duplication
        /// <summary>
        /// Вввод часовой тарифной ставки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelHourlyWageRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            Proverki.CheckInput(e);
        }

        //TODO: duplication
        /// <summary>
        /// Ввод часов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelTimeHourlyRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            Proverki.CheckInput(e);
        }

        
        /// <summary>
        /// Метод добавления зарплаты
        /// </summary>
        /// <returns></returns>
        public WagesBase AddingWages()
        {
            var wagesHourlyWageRate = new HourlyWageRate();

            wagesHourlyWageRate.SizeOfTheHourlyTariffRate = Proverki.CheckNumber(textBoxHourlyWageRate.Text);
            wagesHourlyWageRate.WorkingHours = Proverki.CheckNumber(textBoxTimeHourlyRate.Text);

            return wagesHourlyWageRate;

        }
    }
}
