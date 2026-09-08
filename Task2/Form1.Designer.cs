namespace Task2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitleBMI;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.Label lblBMIResult;

        private System.Windows.Forms.Label lblTitleUtilities;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.Label lblWaterTariff;
        private System.Windows.Forms.TextBox txtWater;
        private System.Windows.Forms.TextBox txtWaterTariff;

        private System.Windows.Forms.Label lblElectricity;
        private System.Windows.Forms.Label lblElectricityTariff;
        private System.Windows.Forms.TextBox txtElectricity;
        private System.Windows.Forms.TextBox txtElectricityTariff;

        private System.Windows.Forms.Label lblGas;
        private System.Windows.Forms.Label lblGasTariff;
        private System.Windows.Forms.TextBox txtGas;
        private System.Windows.Forms.TextBox txtGasTariff;

        private System.Windows.Forms.Button btnUtilities;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotal;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblTitleBMI = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnBMI = new System.Windows.Forms.Button();
            this.lblBMI = new System.Windows.Forms.Label();
            this.lblBMIResult = new System.Windows.Forms.Label();

            this.lblTitleUtilities = new System.Windows.Forms.Label();
            this.lblWater = new System.Windows.Forms.Label();
            this.lblWaterTariff = new System.Windows.Forms.Label();
            this.txtWater = new System.Windows.Forms.TextBox();
            this.txtWaterTariff = new System.Windows.Forms.TextBox();

            this.lblElectricity = new System.Windows.Forms.Label();
            this.lblElectricityTariff = new System.Windows.Forms.Label();
            this.txtElectricity = new System.Windows.Forms.TextBox();
            this.txtElectricityTariff = new System.Windows.Forms.TextBox();

            this.lblGas = new System.Windows.Forms.Label();
            this.lblGasTariff = new System.Windows.Forms.Label();
            this.txtGas = new System.Windows.Forms.TextBox();
            this.txtGasTariff = new System.Windows.Forms.TextBox();

            this.btnUtilities = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // =========================
            // ИМТ
            // =========================

            this.lblTitleBMI.AutoSize = true;
            this.lblTitleBMI.Font = new System.Drawing.Font(
                "Arial", 16F,
                System.Drawing.FontStyle.Bold);

            this.lblTitleBMI.Location =
                new System.Drawing.Point(30, 25);

            this.lblTitleBMI.Text = "РОЗРАХУНОК ІМТ";

            this.lblWeight.AutoSize = true;
            this.lblWeight.Location =
                new System.Drawing.Point(30, 75);

            this.lblWeight.Text = "Вага (кг):";

            this.txtWeight.Location =
                new System.Drawing.Point(130, 72);

            this.txtWeight.Size =
                new System.Drawing.Size(120, 23);

            this.lblHeight.AutoSize = true;
            this.lblHeight.Location =
                new System.Drawing.Point(30, 115);

            this.lblHeight.Text = "Зріст (м):";

            this.txtHeight.Location =
                new System.Drawing.Point(130, 112);

            this.txtHeight.Size =
                new System.Drawing.Size(120, 23);

            this.btnBMI.Location =
                new System.Drawing.Point(30, 155);

            this.btnBMI.Size =
                new System.Drawing.Size(220, 35);

            this.btnBMI.Text =
                "Розрахувати ІМТ";

            this.btnBMI.UseVisualStyleBackColor = true;

            this.btnBMI.Click +=
                new System.EventHandler(this.btnBMI_Click);

            this.lblBMI.AutoSize = true;
            this.lblBMI.Font =
                new System.Drawing.Font(
                    "Arial", 12F,
                    System.Drawing.FontStyle.Bold);

            this.lblBMI.Location =
                new System.Drawing.Point(30, 205);

            this.lblBMI.Text = "ІМТ: -";

            this.lblBMIResult.AutoSize = true;
            this.lblBMIResult.Location =
                new System.Drawing.Point(30, 235);

            this.lblBMIResult.Text =
                "Оцінка: -";


            // =========================
            // КОМУНАЛЬНІ ПЛАТЕЖІ
            // =========================

            this.lblTitleUtilities.AutoSize = true;
            this.lblTitleUtilities.Font =
                new System.Drawing.Font(
                    "Arial", 16F,
                    System.Drawing.FontStyle.Bold);

            this.lblTitleUtilities.Location =
                new System.Drawing.Point(330, 25);

            this.lblTitleUtilities.Text =
                "КОМУНАЛЬНІ ПЛАТЕЖІ";


            // Вода
            this.lblWater.AutoSize = true;
            this.lblWater.Location =
                new System.Drawing.Point(330, 75);

            this.lblWater.Text =
                "Вода (м³):";

            this.txtWater.Location =
                new System.Drawing.Point(430, 72);

            this.txtWater.Size =
                new System.Drawing.Size(100, 23);

            this.lblWaterTariff.AutoSize = true;
            this.lblWaterTariff.Location =
                new System.Drawing.Point(550, 75);

            this.lblWaterTariff.Text =
                "Тариф:";

            this.txtWaterTariff.Location =
                new System.Drawing.Point(610, 72);

            this.txtWaterTariff.Size =
                new System.Drawing.Size(100, 23);


            // Свет
            this.lblElectricity.AutoSize = true;
            this.lblElectricity.Location =
                new System.Drawing.Point(330, 115);

            this.lblElectricity.Text =
                "Світло (кВт):";

            this.txtElectricity.Location =
                new System.Drawing.Point(430, 112);

            this.txtElectricity.Size =
                new System.Drawing.Size(100, 23);

            this.lblElectricityTariff.AutoSize = true;
            this.lblElectricityTariff.Location =
                new System.Drawing.Point(550, 115);

            this.lblElectricityTariff.Text =
                "Тариф:";

            this.txtElectricityTariff.Location =
                new System.Drawing.Point(610, 112);

            this.txtElectricityTariff.Size =
                new System.Drawing.Size(100, 23);


            // Газ
            this.lblGas.AutoSize = true;
            this.lblGas.Location =
                new System.Drawing.Point(330, 155);

            this.lblGas.Text =
                "Газ (м³):";

            this.txtGas.Location =
                new System.Drawing.Point(430, 152);

            this.txtGas.Size =
                new System.Drawing.Size(100, 23);

            this.lblGasTariff.AutoSize = true;
            this.lblGasTariff.Location =
                new System.Drawing.Point(550, 155);

            this.lblGasTariff.Text =
                "Тариф:";

            this.txtGasTariff.Location =
                new System.Drawing.Point(610, 152);

            this.txtGasTariff.Size =
                new System.Drawing.Size(100, 23);


            // Кнопка
            this.btnUtilities.Location =
                new System.Drawing.Point(330, 195);

            this.btnUtilities.Size =
                new System.Drawing.Size(380, 35);

            this.btnUtilities.Text =
                "Розрахувати платежі";

            this.btnUtilities.UseVisualStyleBackColor = true;

            this.btnUtilities.Click +=
                new System.EventHandler(this.btnUtilities_Click);


            // Таблица
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ReadOnly = true;

            this.dataGridView1.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dataGridView1.Location =
                new System.Drawing.Point(330, 245);

            this.dataGridView1.Size =
                new System.Drawing.Size(500, 200);

            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dataGridView1.Columns.Add(
                "Service",
                "Послуга");

            this.dataGridView1.Columns.Add(
                "Amount",
                "Показник");

            this.dataGridView1.Columns.Add(
                "Tariff",
                "Тариф");

            this.dataGridView1.Columns.Add(
                "Cost",
                "Сума");


            // Общая сумма
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font =
                new System.Drawing.Font(
                    "Arial", 14F,
                    System.Drawing.FontStyle.Bold);

            this.lblTotal.Location =
                new System.Drawing.Point(330, 465);

            this.lblTotal.Text =
                "Загальна сума: 0.00 грн";


            // =========================
            // FORM
            // =========================

            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(900, 550);

            this.Controls.Add(this.lblTitleBMI);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.lblBMIResult);

            this.Controls.Add(this.lblTitleUtilities);
            this.Controls.Add(this.lblWater);
            this.Controls.Add(this.txtWater);
            this.Controls.Add(this.lblWaterTariff);
            this.Controls.Add(this.txtWaterTariff);

            this.Controls.Add(this.lblElectricity);
            this.Controls.Add(this.txtElectricity);
            this.Controls.Add(this.lblElectricityTariff);
            this.Controls.Add(this.txtElectricityTariff);

            this.Controls.Add(this.lblGas);
            this.Controls.Add(this.txtGas);
            this.Controls.Add(this.lblGasTariff);
            this.Controls.Add(this.txtGasTariff);

            this.Controls.Add(this.btnUtilities);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTotal);

            this.Name = "Form1";
            this.Text = "Калькулятори";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)
                (this.dataGridView1)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
