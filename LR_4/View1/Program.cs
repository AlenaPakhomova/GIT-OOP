
namespace View
{
    /// <summary>
    /// ����� ��� ������������ ���������� ������� Model
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// ����� ����� � ���������.
        /// </summary>
        /// <param name="args"></param>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.EnableVisualStyles(); //��� ��������
            //Application.SetCompatibleTextRenderingDefault(false); // ��� ��������
            Application.Run(new MainForm());
        }
    }
}