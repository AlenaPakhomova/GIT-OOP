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
        /// Список зарплат
        /// </summary>
        private BindingList<WagesBase> _wageList = new BindingList<WagesBase>();



        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wage = new AddWageForm();
            
            if (wage.ShowDialog() == DialogResult.OK)
            {
              
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}