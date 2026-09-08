using System;
using System.Windows.Forms;

namespace HabitCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxThing.Items.Add("Смартфон — 30000 грн");
            comboBoxThing.Items.Add("Ноутбук — 50000 грн");
            comboBoxThing.Items.Add("Відпустка — 40000 грн");
            comboBoxThing.Items.Add("Ігрова приставка — 25000 грн");

            comboBoxThing.SelectedIndex = 0;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxHabit.Text))
            {
                MessageBox.Show(
                    "Введіть назву звички!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!double.TryParse(textBoxDaily.Text, out double dailyCost) ||
                dailyCost < 0)
            {
                MessageBox.Show(
                    "Введіть правильну суму витрати за день!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            double monthCost = dailyCost * 30;
            double yearCost = dailyCost * 365;
            double fiveYearsCost = dailyCost * 365 * 5;

            labelMonth.Text = $"За місяць: {monthCost:F2} грн";
            labelYear.Text = $"За рік: {yearCost:F2} грн";
            labelFiveYears.Text = $"За 5 років: {fiveYearsCost:F2} грн";

            double thingPrice = 0;
            string thingName = "";

            switch (comboBoxThing.SelectedIndex)
            {
                case 0:
                    thingPrice = 30000;
                    thingName = "смартфон";
                    break;

                case 1:
                    thingPrice = 50000;
                    thingName = "ноутбук";
                    break;

                case 2:
                    thingPrice = 40000;
                    thingName = "відпустку";
                    break;

                case 3:
                    thingPrice = 25000;
                    thingName = "ігрову приставку";
                    break;
            }

            int quantity = (int)(fiveYearsCost / thingPrice);

            if (quantity > 0)
            {
                labelComparison.Text =
                    $"За 5 років на звичку буде витрачено {fiveYearsCost:F2} грн.\n\n" +
                    $"За ці гроші можна купити {quantity} × {thingName}.\n\n" +
                    $"Вартість одного: {thingPrice:F2} грн.";
            }
            else
            {
                double remaining = thingPrice - fiveYearsCost;

                labelComparison.Text =
                    $"За 5 років на звичку буде витрачено {fiveYearsCost:F2} грн.\n\n" +
                    $"Цього недостатньо для покупки: {thingName}.\n\n" +
                    $"Не вистачає: {remaining:F2} грн.";
            }
        }
    }
}
