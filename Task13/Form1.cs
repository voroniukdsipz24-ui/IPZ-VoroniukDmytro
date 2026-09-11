using System;
using System.Windows.Forms;

namespace SleepTrackerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обчислює тривалість сну та формує рекомендацію відповідно
        /// до обраної вікової категорії.
        /// </summary>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (comboBoxAge.SelectedIndex < 0)
            {
                MessageBox.Show("Оберіть вікову категорію.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime sleepTime = dateTimePickerSleep.Value;
            DateTime wakeTime = dateTimePickerWake.Value;

            TimeSpan duration = wakeTime.TimeOfDay - sleepTime.TimeOfDay;

            // Якщо пробудження "раніше" за засинання за часом доби,
            // значить сон тривав через північ — додаємо добу.
            if (duration <= TimeSpan.Zero)
            {
                duration = duration.Add(TimeSpan.FromHours(24));
            }

            double hours = duration.TotalHours;

            double minNorm;
            double maxNorm;
            GetNormForCategory(comboBoxAge.SelectedIndex, out minNorm, out maxNorm);

            string status;
            if (hours < minNorm)
            {
                status = "Недосип";
            }
            else if (hours > maxNorm)
            {
                status = "Пересип";
            }
            else
            {
                status = "Норма сну";
            }

            labelDurationResult.Text = string.Format(
                "Тривалість сну: {0} год {1} хв",
                (int)duration.TotalHours,
                duration.Minutes);

            labelRecommendationResult.Text = string.Format(
                "Результат: {0}.\nРекомендована норма для обраної категорії: {1}-{2} год на добу.",
                status, minNorm, maxNorm);
        }

        /// <summary>
        /// Повертає рекомендований діапазон годин сну (хв./макс.)
        /// для заданої вікової категорії (за рекомендаціями National Sleep Foundation).
        /// </summary>
        private void GetNormForCategory(int categoryIndex, out double minHours, out double maxHours)
        {
            switch (categoryIndex)
            {
                case 0: // Немовля (0-1 рік)
                    minHours = 14;
                    maxHours = 17;
                    break;
                case 1: // Дитина (1-5 років)
                    minHours = 10;
                    maxHours = 13;
                    break;
                case 2: // Школяр (6-13 років)
                    minHours = 9;
                    maxHours = 11;
                    break;
                case 3: // Підліток (14-17 років)
                    minHours = 8;
                    maxHours = 10;
                    break;
                case 4: // Дорослий (18-64 роки)
                    minHours = 7;
                    maxHours = 9;
                    break;
                case 5: // Похилий вік (65+ років)
                    minHours = 7;
                    maxHours = 8;
                    break;
                default:
                    minHours = 7;
                    maxHours = 9;
                    break;
            }
        }
    }
}