using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Xml.Serialization;
using Model;
namespace View
{
    //TODO: XML (+)
    /// <summary>
    /// Класс для создания главной формы калькулятора 
    /// </summary>
    public partial class MainForm : Form
    {
        //TODO: XML (+)
        /// <summary>
        /// Инициализация формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            BackColor = Color.SeaGreen;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            Size = new Size(830, 410);
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }

        /// <summary>
        /// Список зарплат
        /// </summary>
        private BindingList<WagesBase> _wageList = new();


        /// <summary>
        /// Для файлов 
        /// </summary>
        private readonly XmlSerializer _serializer =
            new XmlSerializer(typeof(BindingList<WagesBase>));

        //TODO: rename (+)
        /// <summary>
        /// Загрузка формы 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Выделение памяти
            _wageList = new BindingList<WagesBase>();
            CreateTable(_wageList, dataGridViewSpace);
        }

        //TODO: RSDN (+)
        /// <summary>
        /// Добавление новой фигуры.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            var addWageForm = new AddWageForm();

            addWageForm.AddingWages += (sender, wageEventArgs) =>
            {
                _wageList.Add(((WageEventArgs)wageEventArgs).WageValue);
            };
            addWageForm.ShowDialog();
        }


        /// <summary>
        /// Создание таблицы DataGrid.
        /// </summary>
        /// <param name="wages"></param>
        /// <param name="dataGridView"></param>
        public static void CreateTable(BindingList<WagesBase> wages,
              DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            var source = new BindingSource(wages, null);
            dataGridView.DataSource = source;
            //TODO: поправить (+)
            dataGridView.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AutoSizeRowsMode = 
                DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.AutoSizeColumnsMode = 
                DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.WrapMode =
                DataGridViewTriState.True;
        }

        /// <summary>
        /// Удаление позиций
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewSpace.SelectedCells.Count != 0)
            {
                foreach (DataGridViewRow row in 
                    dataGridViewSpace.SelectedRows)
                {
                    _wageList.Remove(row.DataBoundItem as WagesBase);
                }
            }
        }

       

        /// <summary>
        /// Очистка списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            _wageList.Clear();
        }

        /// <summary>
        /// Функция случайной зарплаты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            _wageList.Add(RandomWages.GetRandomWages());
        }

        
        /// <summary>
        /// Кнопка для открытия фильтра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            var newFilterWages = new FilterWages(_wageList);
            newFilterWages.Show();
            newFilterWages.WagesFiltered += (sender, wageEventArgs) =>
            {
                dataGridViewSpace.DataSource =
                ((WageListEventArgs)wageEventArgs).WageListValue;
               
            };
        }

        /// <summary>
        /// Сброс найтроек фильтра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCleanFilter_Click(object sender, EventArgs e)
        {
            CreateTable(_wageList, dataGridViewSpace);
        }

         
        /// <summary>
        /// Сохранение списка в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_wageList.Count == 0)
            {
                MessageBox.Show("Отсутствуют данные для сохранения.",
                    "Данные не сохранены",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Файлы (*.zp)|*.zp|Все файлы (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName.ToString();
                using (FileStream file = File.Create(path))
                {
                    _serializer.Serialize(file, _wageList);
                }
                MessageBox.Show("Файл успешно сохранён.",
                    "Сохранение завершено",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// Открытие файла со списком
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Файлы (*.zp)|*.zp|Все файлы (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var path = openFileDialog.FileName.ToString();
            try
            {
                using (var file = new StreamReader(path))
                {
                    _wageList = (BindingList<WagesBase>)
                        _serializer.Deserialize(file);
                }

                dataGridViewSpace.DataSource = _wageList;
                dataGridViewSpace.CurrentCell = null;
                MessageBox.Show("Файл успешно загружен.",
                    "Загрузка завершена",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Не удалось загрузить файл.\n" +
                    "Файл повреждён или не соответствует формату.",
                    "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }   
}