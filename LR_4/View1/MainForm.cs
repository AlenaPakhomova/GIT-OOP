using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
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
            Size = new Size(830, 410);
        }

        /// <summary>
        /// ������ �������
        /// </summary>
        private BindingList<WagesBase> _wageList = new();

        private BindingList<WagesBase> _filteredWageList = new();


        private void Form1_Load(object sender, EventArgs e)
        {
            // ��������� ������
            _wageList = new BindingList<WagesBase>();
            CreateTable(_wageList, dataGridViewSpace);
        }



        /// <summary>
        /// ���������� ����� ������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var addWageForm = new AddWageForm();

            addWageForm.AddingWages += (sender, wageEventArgs) =>
            {
                _wageList.Add(((WageEventArgs)wageEventArgs).WageValue);
            };
            addWageForm.ShowDialog();
        }


        /// <summary>
        /// �������� ������� DataGrid.
        /// </summary>
        /// <param name="wages"></param>
        /// <param name="dataGridView"></param>
        public static void CreateTable(BindingList<WagesBase> wages,
              DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            var source = new BindingSource(wages, null);
            dataGridView.DataSource = source;
            dataGridView.Columns[0].Width = 190;
            dataGridView.Columns[1].Width = 400;
            dataGridView.Columns[2].Width = 131;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.Columns[0].HeaderText = "��� ��";
            dataGridView.Columns[1].HeaderText = "������ ��";
            dataGridView.Columns[2].HeaderText = "����� � ������";
            //dataGridView.AutoSizeColumnsMode =
            // DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
        }

        /// <summary>
        /// �������� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSpace.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in dataGridViewSpace.SelectedRows)
                {
                    _wageList.Remove(row.DataBoundItem as WagesBase);

                    //_filteredList.Remove(row.DataBoundItem as FigureBase);
                }
            }
        }

       

        /// <summary>
        /// ������� ������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            _wageList.Clear();
        }

        /// <summary>
        /// ������� ��������� ��������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRandom_Click(object sender, EventArgs e)
        {
            _wageList.Add(RandomWages.GetRandomWages());
        }

        
        /// <summary>
        /// ������ ��� �������� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var newFilterWages = new FilterWages(_wageList);
            newFilterWages.Show();
            newFilterWages.WagesFiltered += (sender, wageEventArgs) =>
            {
                dataGridViewSpace.DataSource = ((WageListEventArgs)wageEventArgs).WageListValue;
                _filteredWageList = ((WageListEventArgs)wageEventArgs).WageListValue;
            };
        }

        /// <summary>
        /// ����� �������� �������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCleanFilter_Click(object sender, EventArgs e)
        {
            CreateTable(_wageList, dataGridViewSpace);
        }
    }   
}