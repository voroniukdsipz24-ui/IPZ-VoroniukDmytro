using System;
using System.Windows.Forms;
using Task12;

namespace PasswordGeneratorApp
{
    static class Program
    {
        /// <summary>
        /// Головна точка входу для застосунку.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

