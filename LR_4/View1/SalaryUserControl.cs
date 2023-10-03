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

        //TODO: duplication (+)
        /// <summary>
        /// Ввод чисел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            Checks.CheckInput(e);
        }

        /// <summary>
        /// Метод добавления зарплаты
        /// </summary>
        /// <returns></returns>
        public WagesBase AddingWages()
        {
            var wagesSalary = new Salary();

            wagesSalary.SalaryAmount = 
                Checks.CheckNumber(textBoxSalary.Text);
            wagesSalary.DaysInMonth = 
                Checks.CheckNumber(textBoxDaysInMonth.Text);
            wagesSalary.WorkingDays = 
                Checks.CheckNumber(textBoxWorkingDays.Text);

            return wagesSalary;

        }
    }
}
