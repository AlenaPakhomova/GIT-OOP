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
    /// Добавление тарифной ставки
    /// </summary>
    public partial class WageRateUserControl : UserControl, IAddWages
    {
        /// <summary>
        /// Добавлвение тарифной ставки
        /// </summary>
        public WageRateUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ввод количества рабочих часов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelWorkingHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            Proverki.CheckInput(e);
        }

        /// <summary>
        /// Ввод тарифной ставки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            Proverki.CheckInput(e);
        }

        /// <summary>
        /// Метод добавления зарплаты
        /// </summary>
        /// <returns></returns>
        public WagesBase AddingWages()
        {
            var wagesWageRate = new WageRate();

            wagesWageRate.TariffRate = Proverki.CheckNumber(textBoxRate.Text);
            wagesWageRate.WorkingDays = Proverki.CheckNumber(textBoxWorkingHours.Text);

            return wagesWageRate;

        }


    }
}
