using System.Drawing;
using System.Windows.Forms;

namespace HabitCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label labelTitle;
        private Label labelHabit;
        private Label labelDaily;
        private Label labelThing;
        private Label labelMonth;
        private Label labelYear;
        private Label labelFiveYears;
        private Label labelComparisonTitle;
        private Label labelComparison;

        private TextBox textBoxHabit;
        private TextBox textBoxDaily;

        private ComboBox comboBoxThing;

        private Button buttonCalculate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelHabit = new Label();
            labelDaily = new Label();
            labelThing = new Label();

            textBoxHabit = new TextBox();
            textBoxDaily = new TextBox();

            comboBoxThing = new ComboBox();

            buttonCalculate = new Button();

            labelMonth = new Label();
            labelYear = new Label();
            labelFiveYears = new Label();

            labelComparisonTitle = new Label();
            labelComparison = new Label();

            SuspendLayout();

            // 
            // Form1
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 500);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Калькулятор \"Скільки коштує моя звичка\"";

            // 
            // labelTitle
            //
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.Location = new Point(120, 25);
            labelTitle.Text = "Скільки коштує моя звичка";

            // 
            // labelHabit
            //
            labelHabit.AutoSize = true;
            labelHabit.Font = new Font("Segoe UI", 10F);
            labelHabit.Location = new Point(50, 90);
            labelHabit.Text = "Назва звички:";

            // 
            // textBoxHabit
            //
            textBoxHabit.Location = new Point(220, 87);
            textBoxHabit.Size = new Size(350, 23);

            // 
            // labelDaily
            //
            labelDaily.AutoSize = true;
            labelDaily.Font = new Font("Segoe UI", 10F);
            labelDaily.Location = new Point(50, 135);
            labelDaily.Text = "Витрата за день (грн):";

            // 
            // textBoxDaily
            //
            textBoxDaily.Location = new Point(220, 132);
            textBoxDaily.Size = new Size(350, 23);

            // 
            // labelThing
            //
            labelThing.AutoSize = true;
            labelThing.Font = new Font("Segoe UI", 10F);
            labelThing.Location = new Point(50, 180);
            labelThing.Text = "Порівняти з:";

            // 
            // comboBoxThing
            //
            comboBoxThing.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxThing.Location = new Point(220, 177);
            comboBoxThing.Size = new Size(350, 23);

            // 
            // buttonCalculate
            //
            buttonCalculate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonCalculate.Location = new Point(220, 220);
            buttonCalculate.Size = new Size(180, 40);
            buttonCalculate.Text = "Розрахувати";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;

            // 
            // labelMonth
            //
            labelMonth.AutoSize = true;
            labelMonth.Font = new Font("Segoe UI", 10F);
            labelMonth.Location = new Point(50, 290);
            labelMonth.Text = "За місяць: 0.00 грн";

            // 
            // labelYear
            //
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI", 10F);
            labelYear.Location = new Point(50, 320);
            labelYear.Text = "За рік: 0.00 грн";

            // 
            // labelFiveYears
            //
            labelFiveYears.AutoSize = true;
            labelFiveYears.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelFiveYears.Location = new Point(50, 350);
            labelFiveYears.Text = "За 5 років: 0.00 грн";

            // 
            // labelComparisonTitle
            //
            labelComparisonTitle.AutoSize = true;
            labelComparisonTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelComparisonTitle.Location = new Point(50, 390);
            labelComparisonTitle.Text = "Порівняння:";

            // 
            // labelComparison
            //
            labelComparison.AutoSize = true;
            labelComparison.Font = new Font("Segoe UI", 10F);
            labelComparison.Location = new Point(160, 390);
            labelComparison.MaximumSize = new Size(450, 0);
            labelComparison.Text = "Введіть дані та натисніть «Розрахувати».";

            // 
            // Controls
            //
            Controls.Add(labelTitle);
            Controls.Add(labelHabit);
            Controls.Add(textBoxHabit);
            Controls.Add(labelDaily);
            Controls.Add(textBoxDaily);
            Controls.Add(labelThing);
            Controls.Add(comboBoxThing);
            Controls.Add(buttonCalculate);
            Controls.Add(labelMonth);
            Controls.Add(labelYear);
            Controls.Add(labelFiveYears);
            Controls.Add(labelComparisonTitle);
            Controls.Add(labelComparison);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
