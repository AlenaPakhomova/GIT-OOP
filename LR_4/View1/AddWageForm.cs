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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace View
{
    public partial class AddWageForm : Form
    {
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
            DialogResult = DialogResult.OK;

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
