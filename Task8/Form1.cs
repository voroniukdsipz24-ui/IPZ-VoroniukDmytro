using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace FinanceTracker
{
    public partial class Form1 : Form
    {
        private List<Operation> operations = new List<Operation>();
        private const string FileName = "operations.json";

        public Form1()
        {
            InitializeComponent();

            cmbType.Items.Add("Дохід");
            cmbType.Items.Add("Витрата");
            cmbType.SelectedIndex = 0;

            cmbCategory.Items.AddRange(new string[]
            {
                "Зарплата",
                "Стипендія",
                "Підробіток",
                "Продукти",
                "Транспорт",
                "Розваги",
                "Комунальні послуги",
                "Одяг",
                "Навчання",
                "Інше"
            });
            cmbCategory.SelectedIndex = 0;

            cmbCurrency.Items.AddRange(new string[]
            {
                "UAH",
                "USD",
                "EUR",
                "PLN"
            });
            cmbCurrency.SelectedIndex = 0;

            cmbFilter.Items.Add("Усі категорії");

            foreach (string category in cmbCategory.Items)
                cmbFilter.Items.Add(category);

            cmbFilter.SelectedIndex = 0;

            LoadData();
            UpdateTable();
            UpdateBalance();
        }

        public class Operation
        {
            public DateTime Date { get; set; }
            public string Type { get; set; }
            public string Category { get; set; }
            public decimal Amount { get; set; }
            public string Currency { get; set; }
            public string Description { get; set; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) ||
                amount <= 0)
            {
                MessageBox.Show(
                    "Введіть правильну суму.",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Operation operation = new Operation
            {
                Date = DateTime.Now,
                Type = cmbType.Text,
                Category = cmbCategory.Text,
                Amount = amount,
                Currency = cmbCurrency.Text,
                Description = txtDescription.Text
            };

            operations.Add(operation);

            UpdateTable();
            UpdateBalance();

            txtAmount.Clear();
            txtDescription.Clear();
        }

        private void UpdateTable()
        {
            string filter = cmbFilter.Text;

            IEnumerable<Operation> result = operations;

            if (filter != "Усі категорії")
            {
                result = operations.Where(x => x.Category == filter);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result
                .OrderByDescending(x => x.Date)
                .ToList();

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns["Date"].HeaderText = "Дата";
                dataGridView1.Columns["Type"].HeaderText = "Тип";
                dataGridView1.Columns["Category"].HeaderText = "Категорія";
                dataGridView1.Columns["Amount"].HeaderText = "Сума";
                dataGridView1.Columns["Currency"].HeaderText = "Валюта";
                dataGridView1.Columns["Description"].HeaderText = "Опис";

                dataGridView1.Columns["Date"]
                    .DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            }
        }

        private void UpdateBalance()
        {
            decimal uah = GetBalance("UAH");
            decimal usd = GetBalance("USD");
            decimal eur = GetBalance("EUR");
            decimal pln = GetBalance("PLN");

            lblBalance.Text =
                "Поточний баланс:\n\n" +
                $"UAH: {uah:0.00}\n" +
                $"USD: {usd:0.00}\n" +
                $"EUR: {eur:0.00}\n" +
                $"PLN: {pln:0.00}";
        }

        private decimal GetBalance(string currency)
        {
            decimal income = operations
                .Where(x => x.Currency == currency &&
                            x.Type == "Дохід")
                .Sum(x => x.Amount);

            decimal expenses = operations
                .Where(x => x.Currency == currency &&
                            x.Type == "Витрата")
                .Sum(x => x.Amount);

            return income - expenses;
        }

        private void cmbFilter_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Виберіть операцію.");
                return;
            }

            Operation operation =
                dataGridView1.CurrentRow.DataBoundItem as Operation;

            if (operation != null)
            {
                operations.Remove(operation);

                UpdateTable();
                UpdateBalance();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string json = JsonSerializer.Serialize(
                    operations,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

                File.WriteAllText(FileName, json);

                MessageBox.Show(
                    "Дані успішно збережено.",
                    "Збереження",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Помилка: " + ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
            UpdateTable();
            UpdateBalance();

            MessageBox.Show(
                "Дані завантажено.",
                "Завантаження",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void LoadData()
        {
            try
            {
                if (!File.Exists(FileName))
                    return;

                string json = File.ReadAllText(FileName);

                List<Operation> loaded =
                    JsonSerializer.Deserialize<List<Operation>>(json);

                if (loaded != null)
                    operations = loaded;
            }
            catch
            {
                operations = new List<Operation>();
            }
        }
    }
}