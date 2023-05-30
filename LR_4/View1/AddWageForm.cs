using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace View
{
    public partial class AddWageForm : Form
    {
        /// <summary>
        /// Делегат для добавления заработной платы.
        /// </summary>
        public EventHandler<EventArgs> AddingWages;

        /// <summary>
        /// Переменная для словаря UserControl
        /// </summary>
        private readonly Dictionary<string, UserControl> _comboBoxToUserControl;

        public AddWageForm()
        {
            InitializeComponent();
            BackColor = Color.SeaGreen;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            Size = new Size(400, 500);

            buttonOk.Enabled = false;

            comboSalarySelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboSalarySelection.Items.AddRange(new string[] {
            "Почасовая оплата",
            "Оплата по окладу",
            "Оплата по ставке"});

            _comboBoxToUserControl = new Dictionary<string, UserControl>()
            {
                {"Почасовая оплата", hourlyWageRate },
                {"Оплата по окладу", salary },
                {"Оплата по ставке", wageRate },
            };
        }

        /// <summary>
        /// Действие при выборе слова из выпадающего списка
        /// Задает выбранный элемент в поле со списко ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxSalarySelection(object sender, EventArgs e)
        {
            string wageType = comboSalarySelection.SelectedItem.ToString();
            foreach (var (wage, userControl) in _comboBoxToUserControl)
            {
                userControl.Visible = false;
                if (wageType == wage)
                {
                    userControl.Visible = true;
                    buttonOk.Enabled = true;
                    userControl.Visible = true;
                }
            }
        }
        
        /// <summary>
        /// Кнопка ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOk(object sender, EventArgs e)
        {
            try
            {
                var wagesControlName = comboSalarySelection.SelectedItem.ToString();
                var wagesControl = _comboBoxToUserControl[wagesControlName];
                var wageEventArgs = new WageEventArgs(((IAddWages)wagesControl).AddingWages());
                AddingWages?.Invoke(this, wageEventArgs);
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Введено некорректное значение!\n" +
                    "Введите одно положительное целое или десятичное число" +
                    " в каждое текстовое поле.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Кнопка закрыть.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClose(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalaryLoad(object sender, EventArgs e)
        {
            salary.Visible = false;
            wageRate.Visible = false;
            hourlyWageRate.Visible = false;
        }
    }
}
