using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    /// <summary>
    /// Класс для создания таблиц.
    /// </summary>
    public class CreatingTable
    {
        /// <summary>
        /// Метод для создания таюлиц
        /// </summary>
        /// <param name="wages">Список зарплат</param>
        /// <param name="dataGridView">Талица с запрлатами</param>
        public static void CreateTable(BindingList<WagesBase> wages, DataGridView dataGridView)
        {
            dataGridView.DataSource = wages;
            dataGridView.Columns[0].HeaderText = "Вид ЗП";
            dataGridView.Columns[1].HeaderText = "Рубли";
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //выравнивание
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }
    }
}
