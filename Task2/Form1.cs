using System;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // =========================
        // РОЗРАХУНОК ІМТ
        // =========================
        private void btnBMI_Click(object sender, EventArgs e)
        {
            double weight;
            double height;

            if (!double.TryParse(txtWeight.Text, out weight) ||
                !double.TryParse(txtHeight.Text, out height))
            {
                MessageBox.Show("Введіть правильні числові значення!");
                return;
            }

            if (weight <= 0 || height <= 0)
            {
                MessageBox.Show("Вага та зріст повинні бути більшими за 0!");
                return;
            }

            double bmi = weight / (height * height);

            lblBMI.Text = "ІМТ: " + bmi.ToString("F2");

            if (bmi < 18.5)
            {
                lblBMIResult.Text = "Оцінка: недостатня вага";
            }
            else if (bmi < 25)
            {
                lblBMIResult.Text = "Оцінка: норма";
            }
            else if (bmi < 30)
            {
                lblBMIResult.Text = "Оцінка: надлишкова вага";
            }
            else
            {
                lblBMIResult.Text = "Оцінка: ожиріння";
            }
        }

        // =========================
        // КОМУНАЛЬНІ ПЛАТЕЖІ
        // =========================
        private void btnUtilities_Click(object sender, EventArgs e)
        {
            double water;
            double waterTariff;
            double electricity;
            double electricityTariff;
            double gas;
            double gasTariff;

            if (!double.TryParse(txtWater.Text, out water) ||
                !double.TryParse(txtWaterTariff.Text, out waterTariff) ||
                !double.TryParse(txtElectricity.Text, out electricity) ||
                !double.TryParse(txtElectricityTariff.Text, out electricityTariff) ||
                !double.TryParse(txtGas.Text, out gas) ||
                !double.TryParse(txtGasTariff.Text, out gasTariff))
            {
                MessageBox.Show("Введіть правильні числові значення!");
                return;
            }

            if (water < 0 ||
                waterTariff < 0 ||
                electricity < 0 ||
                electricityTariff < 0 ||
                gas < 0 ||
                gasTariff < 0)
            {
                MessageBox.Show("Значення не можуть бути від'ємними!");
                return;
            }

            double waterCost = water * waterTariff;
            double electricityCost = electricity * electricityTariff;
            double gasCost = gas * gasTariff;

            double total = waterCost + electricityCost + gasCost;

            dataGridView1.Rows.Clear();

            dataGridView1.Rows.Add(
                "Вода",
                water,
                waterTariff.ToString("F2"),
                waterCost.ToString("F2")
            );

            dataGridView1.Rows.Add(
                "Світло",
                electricity,
                electricityTariff.ToString("F2"),
                electricityCost.ToString("F2")
            );

            dataGridView1.Rows.Add(
                "Газ",
                gas,
                gasTariff.ToString("F2"),
                gasCost.ToString("F2")
            );

            lblTotal.Text = "Загальна сума: " + total.ToString("F2") + " грн";
        }
    }
}
