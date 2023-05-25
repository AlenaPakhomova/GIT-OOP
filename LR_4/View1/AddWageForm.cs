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

        /// <summary>
        /// Переменная для использования UserControl
        /// </summary>
        private UserControl userControl;

        public AddWageForm()
        {
            InitializeComponent();
            BackColor = Color.SeaGreen;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            Size = new Size(400, 500);

            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new string[] {
            "Почасовая оплата",
            "Оплата по окладу",
            "Оплата по ставке"});

            _comboBoxToUserControl = new Dictionary<string, UserControl>()
            {
                {"Почасовая оплата", hourlyWageRate1 },
                {"Оплата по окладу", salary1 },
                {"Оплата по ставке", wageRate1 },
            };
        }

        /// <summary>
        /// Действие при выборе слова из выпадающего списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string figureType = comboBox1.SelectedItem.ToString();
            foreach (var (wage, userControl) in _comboBoxToUserControl)
            {
                userControl.Visible = false;
                if (figureType == wage)
                {
                    userControl.Visible = true;
                    this.userControl = userControl;
                }
            }
        }

        /// <summary>
        /// Кнопка ОК
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var wageControlName = comboBox1.SelectedItem.ToString();
                var wageControl = _comboBoxToUserControl[wageControlName];
               // var wageEventArgs = new WageEventArgs(((IAddF)))
                DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Введено некорректное значение!\n",
                   "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Кнопка закрыть.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void salary1_Load(object sender, EventArgs e)
        {
            salary1.Visible = false;
            wageRate1.Visible = false;
            hourlyWageRate1.Visible = false;
        }
    }
}
