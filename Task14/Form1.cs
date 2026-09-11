using System;
using System.Drawing;
using System.Windows.Forms;

namespace HealthyEatingAnalyzer
{
    public partial class Form1 : Form
    {
        // Сумарна кількість спожитих калорій за день
        private int totalCalories = 0;

        public Form1()
        {
            InitializeComponent();
            UpdateSummary();
        }

        /// <summary>
        /// Додає новий прийом їжі до списку.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string product = txtProduct.Text.Trim();

            if (string.IsNullOrEmpty(product))
            {
                MessageBox.Show("Введіть назву продукту!", "Помилка введення",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProduct.Focus();
                return;
            }

            if (!int.TryParse(txtCalories.Text.Trim(), out int calories) || calories <= 0)
            {
                MessageBox.Show("Введіть коректну калорійність — додатне ціле число!", "Помилка введення",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCalories.Focus();
                return;
            }

            lstMeals.Items.Add($"{product} — {calories} ккал");
            totalCalories += calories;

            UpdateSummary();

            txtProduct.Clear();
            txtCalories.Clear();
            txtProduct.Focus();
        }

        /// <summary>
        /// Видаляє обраний у списку прийом їжі та перераховує суму.
        /// </summary>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstMeals.SelectedIndex == -1)
            {
                MessageBox.Show("Оберіть у списку прийом їжі, який потрібно видалити.",
                    "Нічого не обрано", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedItem = lstMeals.SelectedItem.ToString();
            int caloriesToRemove = ExtractCalories(selectedItem);
            totalCalories -= caloriesToRemove;

            lstMeals.Items.RemoveAt(lstMeals.SelectedIndex);

            UpdateSummary();
        }

        /// <summary>
        /// Повністю очищає список прийомів їжі.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (lstMeals.Items.Count == 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Очистити весь список прийомів їжі за день?",
                "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lstMeals.Items.Clear();
                totalCalories = 0;
                UpdateSummary();
            }
        }

        /// <summary>
        /// Викликається при зміні денної норми калорій користувачем.
        /// </summary>
        private void numDailyNorm_ValueChanged(object sender, EventArgs e)
        {
            UpdateSummary();
        }

        /// <summary>
        /// Витягує кількість калорій з рядка формату "Продукт — 123 ккал".
        /// </summary>
        private int ExtractCalories(string item)
        {
            int dashIndex = item.LastIndexOf('—');
            int kcalIndex = item.LastIndexOf("ккал", StringComparison.Ordinal);

            if (dashIndex == -1 || kcalIndex == -1 || kcalIndex <= dashIndex)
            {
                return 0;
            }

            string numberPart = item.Substring(dashIndex + 1, kcalIndex - dashIndex - 1).Trim();
            int.TryParse(numberPart, out int result);
            return result;
        }

        /// <summary>
        /// Оновлює всі показники підсумку: суму калорій, норму,
        /// ProgressBar та текстовий статус.
        /// </summary>
        private void UpdateSummary()
        {
            int dailyNorm = (int)numDailyNorm.Value;

            lblTotalCalories.Text = $"Сумарна калорійність: {totalCalories} ккал";
            lblDailyNormInfo.Text = $"Денна норма: {dailyNorm} ккал";

            if (dailyNorm <= 0)
            {
                progressBarCalories.Value = 0;
                lblPercentage.Text = "0%";
                lblStatus.Text = "Вкажіть денну норму калорій.";
                lblStatus.ForeColor = SystemColors.ControlText;
                return;
            }

            int percentage = (int)Math.Round((double)totalCalories / dailyNorm * 100);
            int progressValue = Math.Min(Math.Max(percentage, 0), 100);

            progressBarCalories.Value = progressValue;
            lblPercentage.Text = $"{percentage}%";

            if (percentage < 90)
            {
                lblStatus.Text = "У межах денної норми";
                lblStatus.ForeColor = Color.SeaGreen;
            }
            else if (percentage <= 110)
            {
                lblStatus.Text = "Близько до денної норми";
                lblStatus.ForeColor = Color.DarkOrange;
            }
            else
            {
                lblStatus.Text = "Денну норму перевищено!";
                lblStatus.ForeColor = Color.Firebrick;
            }
        }
    }
}