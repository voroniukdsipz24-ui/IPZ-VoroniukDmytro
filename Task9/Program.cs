using System;
using System.Windows.Forms;

namespace EcoFootprintCalculator
{
    /// <summary>
    /// Точка входу в застосунок.
    /// </summary>
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}