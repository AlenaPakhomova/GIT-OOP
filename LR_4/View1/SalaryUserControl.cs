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
    /// Добавление оклада
    /// </summary>
    public partial class SalaryUserControl : UserControl, IAddWages
    {
        /// <summary>
        /// Добавление оклада
        /// </summary>
        public SalaryUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ввод размера оклада
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            Proverki.CheckInput(e);
        }

        /// <summary>
        /// Ввод количества дней в месяце
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDaysInMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            Proverki.CheckInput(e);
        }

        /// <summary>
        /// Ввод количества рабочих дней 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelWorkingDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            Proverki.CheckInput(e);
        }

        /// <summary>
        /// Метод добавления зарплаты
        /// </summary>
        /// <returns></returns>
        public WagesBase AddingWages()
        {
            var wagesSalary = new Salary();

            wagesSalary.SalaryAmount = Proverki.CheckNumber(textBoxSalary.Text);
            wagesSalary.DaysInMonth = Proverki.CheckNumber(textBoxDaysInMonth.Text);
            wagesSalary.WorkingDays = Proverki.CheckNumber(textBoxWorkingDays.Text);

            return wagesSalary;

        }
    }
}
