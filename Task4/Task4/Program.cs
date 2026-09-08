using CreditDepositCalculator;
using System;
using System.Windows.Forms;
using Task4;
namespace StudentRegistration
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
