using System;
using System.Windows.Forms;

namespace CreditDepositCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            rbCredit.Checked = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtAmount.Text, out double amount) ||
                !double.TryParse(txtRate.Text, out double rate) ||
                !int.TryParse(txtMonths.Text, out int months))
            {
                MessageBox.Show(
                    "Введіть правильні числові значення!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show(
                    "Сума повинна бути більшою за 0!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (rate < 0)
            {
                MessageBox.Show(
                    "Відсоткова ставка не може бути від'ємною!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (months <= 0)
            {
                MessageBox.Show(
                    "Термін повинен бути більшим за 0!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            dataGridView1.Rows.Clear();

            if (rbCredit.Checked)
            {
                CalculateCredit(amount, rate, months);
            }
            else
            {
                CalculateDeposit(amount, rate, months);
            }
        }

        private void CalculateCredit(double amount, double rate, int months)
        {
            double monthlyPrincipal = amount / months;
            double remaining = amount;
            double totalPayment = 0;

            for (int i = 1; i <= months; i++)
            {
                double interest = remaining * (rate / 100) / 12;

                double principal = monthlyPrincipal;

                if (i == months)
                {
                    principal = remaining;
                }

                double payment = principal + interest;

                double startAmount = remaining;

                remaining -= principal;

                if (remaining < 0)
                    remaining = 0;

                totalPayment += payment;

                dataGridView1.Rows.Add(
                    i,
                    startAmount.ToString("F2"),
                    principal.ToString("F2"),
                    interest.ToString("F2"),
                    payment.ToString("F2"),
                    remaining.ToString("F2")
                );
            }

            double overpayment = totalPayment - amount;

            lblResult.Text =
                $"Щомісячний платіж: {totalPayment / months:F2} грн | " +
                $"Загальна сума: {totalPayment:F2} грн | " +
                $"Переплата: {overpayment:F2} грн";
        }

        private void CalculateDeposit(double amount, double rate, int months)
        {
            double currentAmount = amount;
            double totalInterest = 0;

            for (int i = 1; i <= months; i++)
            {
                double startAmount = currentAmount;

                double interest =
                    currentAmount * (rate / 100) / 12;

                currentAmount += interest;
                totalInterest += interest;

                dataGridView1.Rows.Add(
                    i,
                    startAmount.ToString("F2"),
                    "-",
                    interest.ToString("F2"),
                    interest.ToString("F2"),
                    currentAmount.ToString("F2")
                );
            }

            lblResult.Text =
                $"Початкова сума: {amount:F2} грн | " +
                $"Нараховано відсотків: {totalInterest:F2} грн | " +
                $"Підсумкова сума: {currentAmount:F2} грн";
        }
    }
}
