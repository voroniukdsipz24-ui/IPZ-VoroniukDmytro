namespace HealthyEatingAnalyzer
{
    partial class Form1
    {
        /// <summary>
        /// Обов'язкова змінна конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Звільнення використовуваних ресурсів.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматично згенерований конструктором форм Windows Forms

        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label lblCaloriesInput;
        private System.Windows.Forms.TextBox txtCalories;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListBox lstMeals;
        private System.Windows.Forms.GroupBox grpMeals;
        private System.Windows.Forms.GroupBox grpSummary;
        private System.Windows.Forms.Label lblDailyNorm;
        private System.Windows.Forms.NumericUpDown numDailyNorm;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Label lblDailyNormInfo;
        private System.Windows.Forms.ProgressBar progressBarCalories;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblStatus;

        /// <summary>
        /// Обов'язковий метод для підтримки конструктора — не змінюйте
        /// вміст цього методу за допомогою редактора коду.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.lblCaloriesInput = new System.Windows.Forms.Label();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstMeals = new System.Windows.Forms.ListBox();
            this.grpMeals = new System.Windows.Forms.GroupBox();
            this.grpSummary = new System.Windows.Forms.GroupBox();
            this.lblDailyNorm = new System.Windows.Forms.Label();
            this.numDailyNorm = new System.Windows.Forms.NumericUpDown();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.lblDailyNormInfo = new System.Windows.Forms.Label();
            this.progressBarCalories = new System.Windows.Forms.ProgressBar();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpMeals.SuspendLayout();
            this.grpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDailyNorm)).BeginInit();
            this.SuspendLayout();
            //
            // lblProduct
            //
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(15, 28);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(55, 15);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Продукт:";
            //
            // txtProduct
            //
            this.txtProduct.Location = new System.Drawing.Point(90, 25);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(180, 23);
            this.txtProduct.TabIndex = 1;
            //
            // lblCaloriesInput
            //
            this.lblCaloriesInput.AutoSize = true;
            this.lblCaloriesInput.Location = new System.Drawing.Point(285, 28);
            this.lblCaloriesInput.Name = "lblCaloriesInput";
            this.lblCaloriesInput.Size = new System.Drawing.Size(110, 15);
            this.lblCaloriesInput.TabIndex = 2;
            this.lblCaloriesInput.Text = "Калорійність (ккал):";
            //
            // txtCalories
            //
            this.txtCalories.Location = new System.Drawing.Point(401, 25);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(80, 23);
            this.txtCalories.TabIndex = 3;
            //
            // btnAdd
            //
            this.btnAdd.Location = new System.Drawing.Point(15, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnRemove
            //
            this.btnRemove.Location = new System.Drawing.Point(165, 60);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(160, 28);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Видалити обране";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            //
            // btnClear
            //
            this.btnClear.Location = new System.Drawing.Point(335, 60);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(146, 28);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Очистити список";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // lstMeals
            //
            this.lstMeals.FormattingEnabled = true;
            this.lstMeals.ItemHeight = 15;
            this.lstMeals.Location = new System.Drawing.Point(15, 25);
            this.lstMeals.Name = "lstMeals";
            this.lstMeals.Size = new System.Drawing.Size(466, 154);
            this.lstMeals.TabIndex = 0;
            //
            // grpMeals
            //
            this.grpMeals.Controls.Add(this.lstMeals);
            this.grpMeals.Location = new System.Drawing.Point(15, 100);
            this.grpMeals.Name = "grpMeals";
            this.grpMeals.Size = new System.Drawing.Size(496, 194);
            this.grpMeals.TabIndex = 7;
            this.grpMeals.TabStop = false;
            this.grpMeals.Text = "Прийоми їжі за день";
            //
            // grpSummary
            //
            this.grpSummary.Controls.Add(this.lblStatus);
            this.grpSummary.Controls.Add(this.lblPercentage);
            this.grpSummary.Controls.Add(this.progressBarCalories);
            this.grpSummary.Controls.Add(this.lblDailyNormInfo);
            this.grpSummary.Controls.Add(this.lblTotalCalories);
            this.grpSummary.Controls.Add(this.numDailyNorm);
            this.grpSummary.Controls.Add(this.lblDailyNorm);
            this.grpSummary.Location = new System.Drawing.Point(15, 304);
            this.grpSummary.Name = "grpSummary";
            this.grpSummary.Size = new System.Drawing.Size(496, 175);
            this.grpSummary.TabIndex = 8;
            this.grpSummary.TabStop = false;
            this.grpSummary.Text = "Підсумок за день";
            //
            // lblDailyNorm
            //
            this.lblDailyNorm.AutoSize = true;
            this.lblDailyNorm.Location = new System.Drawing.Point(15, 28);
            this.lblDailyNorm.Name = "lblDailyNorm";
            this.lblDailyNorm.Size = new System.Drawing.Size(130, 15);
            this.lblDailyNorm.TabIndex = 0;
            this.lblDailyNorm.Text = "Денна норма (ккал):";
            //
            // numDailyNorm
            //
            this.numDailyNorm.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            this.numDailyNorm.Location = new System.Drawing.Point(160, 26);
            this.numDailyNorm.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numDailyNorm.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.numDailyNorm.Name = "numDailyNorm";
            this.numDailyNorm.Size = new System.Drawing.Size(100, 23);
            this.numDailyNorm.TabIndex = 1;
            this.numDailyNorm.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            this.numDailyNorm.ValueChanged += new System.EventHandler(this.numDailyNorm_ValueChanged);
            //
            // lblTotalCalories
            //
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalCalories.Location = new System.Drawing.Point(15, 65);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(214, 15);
            this.lblTotalCalories.TabIndex = 2;
            this.lblTotalCalories.Text = "Сумарна калорійність: 0 ккал";
            //
            // lblDailyNormInfo
            //
            this.lblDailyNormInfo.AutoSize = true;
            this.lblDailyNormInfo.Location = new System.Drawing.Point(15, 90);
            this.lblDailyNormInfo.Name = "lblDailyNormInfo";
            this.lblDailyNormInfo.Size = new System.Drawing.Size(140, 15);
            this.lblDailyNormInfo.TabIndex = 3;
            this.lblDailyNormInfo.Text = "Денна норма: 2000 ккал";
            //
            // progressBarCalories
            //
            this.progressBarCalories.Location = new System.Drawing.Point(15, 118);
            this.progressBarCalories.Name = "progressBarCalories";
            this.progressBarCalories.Size = new System.Drawing.Size(390, 25);
            this.progressBarCalories.TabIndex = 4;
            //
            // lblPercentage
            //
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(415, 124);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(24, 15);
            this.lblPercentage.TabIndex = 5;
            this.lblPercentage.Text = "0%";
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(15, 148);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 15);
            this.lblStatus.TabIndex = 6;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 496);
            this.Controls.Add(this.grpSummary);
            this.Controls.Add(this.grpMeals);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCalories);
            this.Controls.Add(this.lblCaloriesInput);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.lblProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма-Аналізатор здорового харчування";
            this.grpMeals.ResumeLayout(false);
            this.grpSummary.ResumeLayout(false);
            this.grpSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDailyNorm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}