using System;
using System.Windows.Forms;

namespace TestQuestionnaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int score = 0;

            // Питання 1
            if (rbQ1_2.Checked)
                score++;

            // Питання 2
            if (rbQ2_1.Checked)
                score++;

            // Питання 3
            if (rbQ3_1.Checked)
                score++;

            // Питання 4
            // Правильні відповіді: int та string
            if (cbQ4_1.Checked &&
                cbQ4_2.Checked &&
                !cbQ4_3.Checked)
            {
                score++;
            }

            string result;

            switch (score)
            {
                case 4:
                    result = "Відмінний результат!";
                    break;

                case 3:
                    result = "Дуже добре!";
                    break;

                case 2:
                    result = "Непогано, але потрібно повторити матеріал.";
                    break;

                case 1:
                    result = "Слабкий результат. Варто повторити основи C#.";
                    break;

                default:
                    result = "Всі відповіді неправильні. Потрібно повторити матеріал.";
                    break;
            }

            MessageBox.Show(
                $"Ваш результат: {score} з 4 балів.\n\n{result}",
                "Результат тесту",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}