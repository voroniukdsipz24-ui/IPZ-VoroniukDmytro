using System;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbGroup.Items.Add("ІПЗ 3/1");
            cmbGroup.Items.Add("ІПЗ 3/2");
            cmbGroup.Items.Add("КН 3/1");
            cmbGroup.Items.Add("КН 3/2");

            dtpBirthDate.MaxDate = DateTime.Today;
            dtpBirthDate.Value = DateTime.Today.AddYears(-18);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show(
                    "Введіть ПІБ!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtFullName.Focus();
                return;
            }

            if (cmbGroup.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Оберіть групу або спеціальність!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbGroup.Focus();
                return;
            }

            if (!rbMale.Checked && !rbFemale.Checked)
            {
                MessageBox.Show(
                    "Оберіть стать!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!chkConsent.Checked)
            {
                MessageBox.Show(
                    "Необхідно погодитися на обробку персональних даних!",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string gender;

            if (rbMale.Checked)
                gender = "Чоловіча";
            else
                gender = "Жіноча";

            string result =
                "РЕЄСТРАЦІЯ УСПІШНА!\n\n" +
                "ПІБ: " + txtFullName.Text + "\n" +
                "Дата народження: " +
                dtpBirthDate.Value.ToString("dd.MM.yyyy") + "\n" +
                "Група/спеціальність: " +
                cmbGroup.SelectedItem.ToString() + "\n" +
                "Стать: " + gender + "\n" +
                "Згода на обробку даних: Так";

            MessageBox.Show(
                result,
                "Результат реєстрації",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}