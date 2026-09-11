using System.Drawing;
using System.Windows.Forms;

namespace EcoFootprintCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Обов'язкова змінна конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очищення ресурсів, що використовуються.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, згенерований конструктором Windows Forms

        private void InitializeComponent()
        {
            this.grpCar = new System.Windows.Forms.GroupBox();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.cmbFuelType = new System.Windows.Forms.ComboBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.nudDistance = new System.Windows.Forms.NumericUpDown();
            this.lblTripsPerWeek = new System.Windows.Forms.Label();
            this.nudTripsPerWeek = new System.Windows.Forms.NumericUpDown();

            this.grpAppliances = new System.Windows.Forms.GroupBox();
            this.lblAppliancePower = new System.Windows.Forms.Label();
            this.nudAppliancePower = new System.Windows.Forms.NumericUpDown();
            this.lblApplianceHours = new System.Windows.Forms.Label();
            this.nudApplianceHours = new System.Windows.Forms.NumericUpDown();

            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();

            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblCarResult = new System.Windows.Forms.Label();
            this.lblApplianceResult = new System.Windows.Forms.Label();
            this.lblTotalMonth = new System.Windows.Forms.Label();
            this.lblTotalYear = new System.Windows.Forms.Label();
            this.pnlIndicator = new System.Windows.Forms.Panel();
            this.lblAssessment = new System.Windows.Forms.Label();

            this.grpCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTripsPerWeek)).BeginInit();
            this.grpAppliances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAppliancePower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudApplianceHours)).BeginInit();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();

            // 
            // grpCar
            // 
            this.grpCar.Controls.Add(this.cmbFuelType);
            this.grpCar.Controls.Add(this.lblFuelType);
            this.grpCar.Controls.Add(this.nudDistance);
            this.grpCar.Controls.Add(this.lblDistance);
            this.grpCar.Controls.Add(this.nudTripsPerWeek);
            this.grpCar.Controls.Add(this.lblTripsPerWeek);
            this.grpCar.Location = new Point(12, 12);
            this.grpCar.Name = "grpCar";
            this.grpCar.Size = new Size(480, 140);
            this.grpCar.TabIndex = 0;
            this.grpCar.TabStop = false;
            this.grpCar.Text = "Автомобіль";

            // 
            // lblTripsPerWeek
            // 
            this.lblTripsPerWeek.AutoSize = true;
            this.lblTripsPerWeek.Location = new Point(15, 28);
            this.lblTripsPerWeek.Name = "lblTripsPerWeek";
            this.lblTripsPerWeek.Size = new Size(220, 15);
            this.lblTripsPerWeek.TabIndex = 0;
            this.lblTripsPerWeek.Text = "Кількість поїздок на тиждень:";

            // 
            // nudTripsPerWeek
            // 
            this.nudTripsPerWeek.Location = new Point(320, 25);
            this.nudTripsPerWeek.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.nudTripsPerWeek.Name = "nudTripsPerWeek";
            this.nudTripsPerWeek.Size = new Size(90, 23);
            this.nudTripsPerWeek.TabIndex = 1;
            this.nudTripsPerWeek.Value = new decimal(new int[] { 5, 0, 0, 0 });

            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new Point(15, 60);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new Size(220, 15);
            this.lblDistance.TabIndex = 2;
            this.lblDistance.Text = "Середня відстань поїздки, км:";

            // 
            // nudDistance
            // 
            this.nudDistance.DecimalPlaces = 1;
            this.nudDistance.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            this.nudDistance.Location = new Point(320, 57);
            this.nudDistance.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            this.nudDistance.Name = "nudDistance";
            this.nudDistance.Size = new Size(90, 23);
            this.nudDistance.TabIndex = 3;
            this.nudDistance.Value = new decimal(new int[] { 10, 0, 0, 0 });

            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Location = new Point(15, 93);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new Size(220, 15);
            this.lblFuelType.TabIndex = 4;
            this.lblFuelType.Text = "Тип палива:";

            // 
            // cmbFuelType
            // 
            this.cmbFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuelType.FormattingEnabled = true;
            this.cmbFuelType.Items.AddRange(new object[] {
                "Бензин",
                "Дизель",
                "Газ (LPG)",
                "Електромобіль"});
            this.cmbFuelType.Location = new Point(320, 90);
            this.cmbFuelType.Name = "cmbFuelType";
            this.cmbFuelType.Size = new Size(140, 23);
            this.cmbFuelType.TabIndex = 5;

            // 
            // grpAppliances
            // 
            this.grpAppliances.Controls.Add(this.nudAppliancePower);
            this.grpAppliances.Controls.Add(this.lblAppliancePower);
            this.grpAppliances.Controls.Add(this.nudApplianceHours);
            this.grpAppliances.Controls.Add(this.lblApplianceHours);
            this.grpAppliances.Location = new Point(12, 164);
            this.grpAppliances.Name = "grpAppliances";
            this.grpAppliances.Size = new Size(480, 100);
            this.grpAppliances.TabIndex = 1;
            this.grpAppliances.TabStop = false;
            this.grpAppliances.Text = "Побутові електроприлади";

            // 
            // lblApplianceHours
            // 
            this.lblApplianceHours.AutoSize = true;
            this.lblApplianceHours.Location = new Point(15, 28);
            this.lblApplianceHours.Name = "lblApplianceHours";
            this.lblApplianceHours.Size = new Size(280, 15);
            this.lblApplianceHours.TabIndex = 0;
            this.lblApplianceHours.Text = "Годин використання приладів на день:";

            // 
            // nudApplianceHours
            // 
            this.nudApplianceHours.Location = new Point(320, 25);
            this.nudApplianceHours.Maximum = new decimal(new int[] { 24, 0, 0, 0 });
            this.nudApplianceHours.Name = "nudApplianceHours";
            this.nudApplianceHours.Size = new Size(90, 23);
            this.nudApplianceHours.TabIndex = 1;
            this.nudApplianceHours.Value = new decimal(new int[] { 3, 0, 0, 0 });

            // 
            // lblAppliancePower
            // 
            this.lblAppliancePower.AutoSize = true;
            this.lblAppliancePower.Location = new Point(15, 60);
            this.lblAppliancePower.Name = "lblAppliancePower";
            this.lblAppliancePower.Size = new Size(280, 15);
            this.lblAppliancePower.TabIndex = 2;
            this.lblAppliancePower.Text = "Сумарна потужність приладів, кВт:";

            // 
            // nudAppliancePower
            // 
            this.nudAppliancePower.DecimalPlaces = 2;
            this.nudAppliancePower.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.nudAppliancePower.Location = new Point(320, 57);
            this.nudAppliancePower.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            this.nudAppliancePower.Name = "nudAppliancePower";
            this.nudAppliancePower.Size = new Size(90, 23);
            this.nudAppliancePower.TabIndex = 3;
            this.nudAppliancePower.Value = new decimal(new int[] { 150, 0, 0, 131072 });

            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new Point(12, 276);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new Size(140, 32);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Розрахувати";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // 
            // btnReset
            // 
            this.btnReset.Location = new Point(160, 276);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new Size(140, 32);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Скинути";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.lblAssessment);
            this.grpResult.Controls.Add(this.pnlIndicator);
            this.grpResult.Controls.Add(this.lblTotalYear);
            this.grpResult.Controls.Add(this.lblTotalMonth);
            this.grpResult.Controls.Add(this.lblApplianceResult);
            this.grpResult.Controls.Add(this.lblCarResult);
            this.grpResult.Location = new Point(12, 320);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new Size(480, 230);
            this.grpResult.TabIndex = 4;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Результат";

            // 
            // lblCarResult
            // 
            this.lblCarResult.AutoSize = true;
            this.lblCarResult.Location = new Point(15, 25);
            this.lblCarResult.Name = "lblCarResult";
            this.lblCarResult.Size = new Size(300, 15);
            this.lblCarResult.TabIndex = 0;
            this.lblCarResult.Text = "Викиди від авто: — кг CO2/міс.";

            // 
            // lblApplianceResult
            // 
            this.lblApplianceResult.AutoSize = true;
            this.lblApplianceResult.Location = new Point(15, 50);
            this.lblApplianceResult.Name = "lblApplianceResult";
            this.lblApplianceResult.Size = new Size(300, 15);
            this.lblApplianceResult.TabIndex = 1;
            this.lblApplianceResult.Text = "Викиди від приладів: — кг CO2/міс.";

            // 
            // lblTotalMonth
            // 
            this.lblTotalMonth.AutoSize = true;
            this.lblTotalMonth.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            this.lblTotalMonth.Location = new Point(15, 85);
            this.lblTotalMonth.Name = "lblTotalMonth";
            this.lblTotalMonth.Size = new Size(300, 17);
            this.lblTotalMonth.TabIndex = 2;
            this.lblTotalMonth.Text = "Разом за місяць: — кг CO2";

            // 
            // lblTotalYear
            // 
            this.lblTotalYear.AutoSize = true;
            this.lblTotalYear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            this.lblTotalYear.Location = new Point(15, 112);
            this.lblTotalYear.Name = "lblTotalYear";
            this.lblTotalYear.Size = new Size(300, 17);
            this.lblTotalYear.TabIndex = 3;
            this.lblTotalYear.Text = "Разом за рік: — т CO2";

            // 
            // pnlIndicator
            // 
            this.pnlIndicator.BackColor = Color.Gainsboro;
            this.pnlIndicator.Location = new Point(15, 150);
            this.pnlIndicator.Name = "pnlIndicator";
            this.pnlIndicator.Size = new Size(450, 16);
            this.pnlIndicator.TabIndex = 4;

            // 
            // lblAssessment
            // 
            this.lblAssessment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblAssessment.Location = new Point(15, 175);
            this.lblAssessment.Name = "lblAssessment";
            this.lblAssessment.Size = new Size(450, 45);
            this.lblAssessment.TabIndex = 5;
            this.lblAssessment.Text = "Заповніть дані та натисніть \"Розрахувати\".";

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new Size(504, 562);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpAppliances);
            this.Controls.Add(this.grpCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор екологічного сліду";

            this.grpCar.ResumeLayout(false);
            this.grpCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTripsPerWeek)).EndInit();
            this.grpAppliances.ResumeLayout(false);
            this.grpAppliances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAppliancePower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudApplianceHours)).EndInit();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpCar;
        private System.Windows.Forms.Label lblTripsPerWeek;
        private System.Windows.Forms.NumericUpDown nudTripsPerWeek;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.NumericUpDown nudDistance;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.ComboBox cmbFuelType;

        private System.Windows.Forms.GroupBox grpAppliances;
        private System.Windows.Forms.Label lblApplianceHours;
        private System.Windows.Forms.NumericUpDown nudApplianceHours;
        private System.Windows.Forms.Label lblAppliancePower;
        private System.Windows.Forms.NumericUpDown nudAppliancePower;

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lblCarResult;
        private System.Windows.Forms.Label lblApplianceResult;
        private System.Windows.Forms.Label lblTotalMonth;
        private System.Windows.Forms.Label lblTotalYear;
        private System.Windows.Forms.Panel pnlIndicator;
        private System.Windows.Forms.Label lblAssessment;
    }
}
