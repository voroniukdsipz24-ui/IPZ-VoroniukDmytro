using System;
using System.Windows.Forms;
using Task14;

namespace HealthyEatingAnalyzer
{
    /// <summary>
    /// Головна точка входу в застосунок.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Головний метод застосунку.
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
