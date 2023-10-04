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
        private readonly Dictionary<string, UserControl>
            _comboBoxToUserControl;

        /// <summary>
        /// Метка UserControl
        /// </summary>
        private UserControl userControl;

        public AddWageForm()
        {
            InitializeComponent();
            BackColor = Color.SeaGreen;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            Size = new Size(400, 400);
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            buttonOk.Enabled = false;
            comboSalarySelection.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            //TODO: duplication (+)
            string[] typeWages = { "Почасовая оплата", "Оплата по окладу", 
                "Оплата по ставке" };
            
            comboSalarySelection.Items.AddRange(new string[] {
            typeWages[0], typeWages[1], typeWages[2]});

            _comboBoxToUserControl = new Dictionary<string, UserControl>()
            {
                {typeWages[0], hourlyWageRateUserControl1 },
                {typeWages[1], salaryUserControl1 },
                {typeWages[2], wageRateUserControl1 },
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
            foreach (var (wageValue, userControl) in _comboBoxToUserControl)
            {
                userControl.Visible = false;
                if (wageType == wageValue)
                {
                    userControl.Visible = true;
                    buttonOk.Enabled = true;
                    this.userControl = userControl;
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
                var wagesControlName = 
                    comboSalarySelection.SelectedItem.ToString();
                var wagesControl = _comboBoxToUserControl[wagesControlName];
                var wageEventArgs =
                    new WageEventArgs(((IAddWages)wagesControl).AddingWages());
                AddingWages?.Invoke(this, wageEventArgs);
                DialogResult = DialogResult.OK;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);             
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
            salaryUserControl1.Visible = false;
            wageRateUserControl1.Visible = false;
            hourlyWageRateUserControl1.Visible = false;
        }
    }
}
