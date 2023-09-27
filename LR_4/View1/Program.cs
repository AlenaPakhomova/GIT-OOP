
namespace View
{
    /// <summary>
    /// Класс для тестирования библиотеки классов Model
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args"></param>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.EnableVisualStyles(); //под вопросом
            //Application.SetCompatibleTextRenderingDefault(false); // под вопросом
            Application.Run(new MainForm());
        }
    }
}