using System;
using System.Windows.Forms;

namespace DBMIDProject_2022_CS_138
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Start_Form());
        }
    }
}
