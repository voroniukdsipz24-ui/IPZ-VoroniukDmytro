using System;
using System.Windows.Forms;

namespace SubscriptionBudget
{
    public partial class Form1 : Form
    {
        private decimal totalExpenses = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Перевірка зарплати
            if (!decimal.TryParse(txtSalary.Text, out decimal salary) || salary < 0)
            {
                MessageBox.Show(
                    "Введіть правильну суму зарплати!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // Перевірка назви підписки
            string subscriptionName = txtSubscription.Text.Trim();

            if (string.IsNullOrEmpty(subscriptionName))
            {
                MessageBox.Show(
                    "Введіть назву підписки!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // Перевірка ціни
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show(
                    "Введіть правильну ціну підписки!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // Додаємо ціну підписки до загальних витрат
            totalExpenses += price;

            // Додаємо підписку до списку
            lstSubscriptions.Items.Add(
                subscriptionName + " - " + price.ToString("F2") + " грн"
            );

            // Розрахунок залишку
            decimal remaining = salary - totalExpenses;

            // Виведення результатів
            lblTotal.Text = "Всього витрат: " +
                            totalExpenses.ToString("F2") + " грн";

            lblRemaining.Text = "Залишок зарплати: " +
                                remaining.ToString("F2") + " грн";

            // Якщо витрати перевищили зарплату
            if (remaining < 0)
            {
                lblRemaining.Text += " (перевищення витрат)";
            }

            // Очищення полів
            txtSubscription.Clear();
            txtPrice.Clear();
            txtSubscription.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            totalExpenses = 0;

            lstSubscriptions.Items.Clear();

            lblTotal.Text = "Всього витрат: 0.00 грн";
            lblRemaining.Text = "Залишок зарплати: 0.00 грн";

            txtSubscription.Clear();
            txtPrice.Clear();
        }
    }
}