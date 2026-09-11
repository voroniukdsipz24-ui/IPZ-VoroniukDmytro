using System;
using System.Text;
using System.Windows.Forms;

namespace PasswordGeneratorApp
{
    public partial class Form1 : Form
    {
        private readonly Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Генерує пароль заданої довжини з обраними наборами символів.
        /// </summary>
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int length = (int)numericUpDownLength.Value;

            const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string digitChars = "0123456789";
            const string specialChars = "!@#$%^&*()_-+=<>?";

            // Мала літера присутня завжди, щоб пароль не був порожнім
            // навіть якщо всі опції знято.
            string charPool = lowerChars;

            if (checkBoxUpper.Checked)
            {
                charPool += upperChars;
            }

            if (checkBoxDigits.Checked)
            {
                charPool += digitChars;
            }

            if (checkBoxSpecial.Checked)
            {
                charPool += specialChars;
            }

            if (length <= 0)
            {
                MessageBox.Show("Вкажіть довжину пароля більше нуля.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringBuilder passwordBuilder = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                int index = random.Next(charPool.Length);
                passwordBuilder.Append(charPool[index]);
            }

            textBoxResult.Text = passwordBuilder.ToString();
        }

        /// <summary>
        /// Копіює згенерований пароль у буфер обміну.
        /// </summary>
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxResult.Text))
            {
                MessageBox.Show("Спочатку згенеруйте пароль.", "Увага",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Clipboard.SetText(textBoxResult.Text);
            MessageBox.Show("Пароль скопійовано в буфер обміну.", "Готово",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
