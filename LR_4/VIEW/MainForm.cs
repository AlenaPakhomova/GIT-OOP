using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VIEW
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Text = "Калькулятор заработной платы";
            this.BackColor = Color.SeaGreen;
            this.Size = new Size(400, 400);
            StartPosition = FormStartPosition.CenterScreen;

        }

        private BindingList<WagesBase> _wageList = new BindingList<WagesBase>();

        /*
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        */
    }
}
