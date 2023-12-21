using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    /// <summary>
    /// Класс, описывающий форму для фильтрации
    /// </summary>
    public partial class FilterWages : Form
    {
        /// <summary>
        /// Лист фигур
        /// </summary>
        private readonly BindingList<WagesBase> _listWages;

        /// <summary>
        /// Лист отфильтрованных фигур
        /// </summary>
        private BindingList<WagesBase> _listWagesFilter;

        /// <summary>
        /// Обработчик события
        /// </summary>
        public EventHandler<EventArgs> WagesFiltered;

        //TODO: RSDN (+)
        /// <summary>
        /// Зарплата
        /// </summary>
        private double _wage;

        /// <summary>
        /// Форма для фильтрации
        /// </summary>
        /// <param name="wages">заработная плата</param>
        public FilterWages(BindingList<WagesBase> wages)
        {
            InitializeComponent();
            BackColor = Color.SeaGreen;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            _listWages = wages;
            textBoxWage.Enabled = false;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        /// <summary>
        /// Ввод необходимой суммы зарплаты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxWage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(textBoxWage.Text != "")
                {
                    _wage = Checks.CheckNumber(textBoxWage.Text);
                }
            }
            catch
            {
                MessageBox.Show("Введено некорректное число", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Контроль ввода значений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       private void TextBoxWage_KeyPress(object sender, KeyPressEventArgs e)
        {
            Checks.CheckInput(e);
        }

        /// <summary>
        /// Активация поля ввода зарплаты для поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBoxInput_CheckedChanged(object sender, EventArgs e)
        {
            
            if(checkBoxInput.Checked)
            {
                textBoxWage.Enabled = true;
            }
        }

        /// <summary>
        /// Кнопка поиска по созданному фильтру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            _listWagesFilter = new BindingList<WagesBase>();

            int count = 0;
            if (!checkBoxHourlyWageRate.Checked
                && !checkBoxWageRate.Checked
                && !checkBoxSalary.Checked
                && !checkBoxInput.Checked)
            {
                MessageBox.Show("Критерии для поиска не введены!",
                    "Внимание", MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }

            foreach (WagesBase figure in _listWages)
            {

                switch (figure)
                {
                    case HourlyWageRate when checkBoxHourlyWageRate.Checked:
                    case WageRate when checkBoxWageRate.Checked:
                    case Salary when checkBoxSalary.Checked:
                        {
                            if (checkBoxInput.Checked)
                            {
                                if (figure.Wages == _wage)
                                {
                                    count++;
                                    _listWagesFilter.Add(figure);
                                    break;
                                }
                                break;
                            }
                            else
                            {
                                count++;
                                _listWagesFilter.Add(figure);
                                break;
                            }
                        }
                }

                if (!checkBoxHourlyWageRate.Checked
                    && !checkBoxWageRate.Checked
                    && !checkBoxSalary.Checked)
                {
                    if (checkBoxInput.Checked && figure.Wages == _wage)
                    {
                        count++;
                        _listWagesFilter.Add(figure);
                    }
                }
            }

            WageListEventArgs eventArgs;

            if (count > 0)
            {
                eventArgs = new WageListEventArgs(_listWagesFilter);
            }
            else
            {
                MessageBox.Show("Зарплат с такими параметрами не " +
                    "существует", "Введите другие параметры", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                eventArgs = new WageListEventArgs(_listWagesFilter);
                return;
            }

            WagesFiltered?.Invoke(this, eventArgs);
            Close();
        }
    }
}
