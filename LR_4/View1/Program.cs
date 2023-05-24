using Model;
using System;
using System.Windows.Forms;

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
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}