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
    public partial class HourlyWageRateUserControl : UserControl
    {
        public HourlyWageRateUserControl()
        {
            InitializeComponent();
        }

        private void labelHourlyRate_Click(object sender, EventArgs e)
        {

        }

        private void labelTimeHourlyRate_Click(object sender, EventArgs e)
        {

        }

        private void textBoxHourlyRate_TextChanged(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        private void textBoxTimeHourlyRate_TextChanged(object sender, KeyPressEventArgs e)
        {
            CheckInput(e);
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public WagesBase AddingWages()
        {
            var wages = new HourlyWageRate();

           // wages.SizeOfTheHourlyTariffRate = CheckNumber(SizeOfTheHourlyTariffRate.Text);

            return wages;

        }
        
        
        /// <summary>
        /// Метод позволяющий вводить определенные символы.
        /// </summary>
        /// <param name="e"></param>
        public static void CheckInput(KeyPressEventArgs e)
        {
            const int backSpace = 8;

            char number = e.KeyChar;
            if ((e.KeyChar < '0' || e.KeyChar > '9')
                && number != backSpace
                && number != ','
                && number != '.')
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Преобразование числа в double
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static double CheckNumber(string number)
        {
            if (number.Contains('.'))
            {
                number = number.Replace('.', ',');
            }
            return double.Parse(number);
        }
    }
}
