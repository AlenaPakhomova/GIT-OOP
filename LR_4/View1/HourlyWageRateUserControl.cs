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

        //TODO: duplication (+)
        /// <summary>
        /// Вввод чисел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelHourlyWageRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            Checks.CheckInput(e);
        }

        
        /// <summary>
        /// Метод добавления зарплаты
        /// </summary>
        /// <returns></returns>
        public WagesBase AddingWages()
        {
            var wagesHourlyWageRate = new HourlyWageRate();

            wagesHourlyWageRate.SizeOfTheHourlyTariffRate = Checks.CheckNumber(textBoxHourlyWageRate.Text);
            wagesHourlyWageRate.WorkingHours = Checks.CheckNumber(textBoxTimeHourlyRate.Text);

            return wagesHourlyWageRate;

        }
    }
}
