namespace SleepTrackerApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelSleepTime = new System.Windows.Forms.Label();
            this.dateTimePickerSleep = new System.Windows.Forms.DateTimePicker();
            this.labelWakeTime = new System.Windows.Forms.Label();
            this.dateTimePickerWake = new System.Windows.Forms.DateTimePicker();
            this.labelAgeCategory = new System.Windows.Forms.Label();
            this.comboBoxAge = new System.Windows.Forms.ComboBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelDurationResult = new System.Windows.Forms.Label();
            this.labelRecommendationResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // labelSleepTime
            //
            this.labelSleepTime.AutoSize = true;
            this.labelSleepTime.Location = new System.Drawing.Point(20, 23);
            this.labelSleepTime.Name = "labelSleepTime";
            this.labelSleepTime.Size = new System.Drawing.Size(101, 15);
            this.labelSleepTime.TabIndex = 0;
            this.labelSleepTime.Text = "Час засинання:";
            //
            // dateTimePickerSleep
            //
            this.dateTimePickerSleep.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerSleep.Location = new System.Drawing.Point(180, 19);
            this.dateTimePickerSleep.Name = "dateTimePickerSleep";
            this.dateTimePickerSleep.ShowUpDown = true;
            this.dateTimePickerSleep.Size = new System.Drawing.Size(150, 23);
            this.dateTimePickerSleep.TabIndex = 1;
            this.dateTimePickerSleep.Value = new System.DateTime(2024, 1, 1, 23, 0, 0, 0);
            //
            // labelWakeTime
            //
            this.labelWakeTime.AutoSize = true;
            this.labelWakeTime.Location = new System.Drawing.Point(20, 58);
            this.labelWakeTime.Name = "labelWakeTime";
            this.labelWakeTime.Size = new System.Drawing.Size(122, 15);
            this.labelWakeTime.TabIndex = 2;
            this.labelWakeTime.Text = "Час пробудження:";
            //
            // dateTimePickerWake
            //
            this.dateTimePickerWake.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerWake.Location = new System.Drawing.Point(180, 54);
            this.dateTimePickerWake.Name = "dateTimePickerWake";
            this.dateTimePickerWake.ShowUpDown = true;
            this.dateTimePickerWake.Size = new System.Drawing.Size(150, 23);
            this.dateTimePickerWake.TabIndex = 3;
            this.dateTimePickerWake.Value = new System.DateTime(2024, 1, 1, 7, 0, 0, 0);
            //
            // labelAgeCategory
            //
            this.labelAgeCategory.AutoSize = true;
            this.labelAgeCategory.Location = new System.Drawing.Point(20, 93);
            this.labelAgeCategory.Name = "labelAgeCategory";
            this.labelAgeCategory.Size = new System.Drawing.Size(112, 15);
            this.labelAgeCategory.TabIndex = 4;
            this.labelAgeCategory.Text = "Вікова категорія:";
            //
            // comboBoxAge
            //
            this.comboBoxAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAge.FormattingEnabled = true;
            this.comboBoxAge.Items.AddRange(new object[] {
            "Немовля (0-1 рік)",
            "Дитина (1-5 років)",
            "Школяр (6-13 років)",
            "Підліток (14-17 років)",
            "Дорослий (18-64 роки)",
            "Похилий вік (65+ років)"});
            this.comboBoxAge.Location = new System.Drawing.Point(180, 90);
            this.comboBoxAge.Name = "comboBoxAge";
            this.comboBoxAge.Size = new System.Drawing.Size(180, 23);
            this.comboBoxAge.TabIndex = 5;
            this.comboBoxAge.SelectedIndex = 4;
            //
            // buttonCalculate
            //
            this.buttonCalculate.Location = new System.Drawing.Point(20, 130);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(340, 34);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Розрахувати";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            //
            // labelDurationResult
            //
            this.labelDurationResult.AutoSize = true;
            this.labelDurationResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelDurationResult.Location = new System.Drawing.Point(20, 180);
            this.labelDurationResult.Name = "labelDurationResult";
            this.labelDurationResult.Size = new System.Drawing.Size(0, 19);
            this.labelDurationResult.TabIndex = 7;
            //
            // labelRecommendationResult
            //
            this.labelRecommendationResult.Location = new System.Drawing.Point(20, 215);
            this.labelRecommendationResult.Name = "labelRecommendationResult";
            this.labelRecommendationResult.Size = new System.Drawing.Size(340, 60);
            this.labelRecommendationResult.TabIndex = 8;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 290);
            this.Controls.Add(this.labelRecommendationResult);
            this.Controls.Add(this.labelDurationResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.comboBoxAge);
            this.Controls.Add(this.labelAgeCategory);
            this.Controls.Add(this.dateTimePickerWake);
            this.Controls.Add(this.labelWakeTime);
            this.Controls.Add(this.dateTimePickerSleep);
            this.Controls.Add(this.labelSleepTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Трекер сну";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSleepTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerSleep;
        private System.Windows.Forms.Label labelWakeTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerWake;
        private System.Windows.Forms.Label labelAgeCategory;
        private System.Windows.Forms.ComboBox comboBoxAge;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelDurationResult;
        private System.Windows.Forms.Label labelRecommendationResult;
    }
}