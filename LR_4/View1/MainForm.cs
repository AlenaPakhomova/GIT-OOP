using System;
using System.ComponentModel;
using Model;
namespace View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            BackColor = Color.SeaGreen;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            Size = new Size(400, 500);
        }

        /// <summary>
        /// Ñïèñîê çàðïëàò
        /// </summary>
        private BindingList<WagesBase> _wageList = new BindingList<WagesBase>();






        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var wage = new AddWageForm();

            if (wage.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxÑalculator_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewSpace_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}