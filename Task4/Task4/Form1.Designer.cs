namespace CreditDepositCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblMonths;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtMonths;
        private System.Windows.Forms.RadioButton rbCredit;
        private System.Windows.Forms.RadioButton rbDeposit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.DataGridView dataGridView1;

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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblMonths = new System.Windows.Forms.Label();

            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtMonths = new System.Windows.Forms.TextBox();

            this.rbCredit = new System.Windows.Forms.RadioButton();
            this.rbDeposit = new System.Windows.Forms.RadioButton();

            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();

            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(25, 25);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(105, 15);
            this.lblAmount.Text = "Сума (грн):";

            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(160, 22);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(180, 23);
            this.txtAmount.TabIndex = 0;

            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(25, 65);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(125, 15);
            this.lblRate.Text = "Ставка (% річних):";

            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(160, 62);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(180, 23);
            this.txtRate.TabIndex = 1;

            // 
            // lblMonths
            // 
            this.lblMonths.AutoSize = true;
            this.lblMonths.Location = new System.Drawing.Point(25, 105);
            this.lblMonths.Name = "lblMonths";
            this.lblMonths.Size = new System.Drawing.Size(105, 15);
            this.lblMonths.Text = "Термін (місяців):";

            // 
            // txtMonths
            // 
            this.txtMonths.Location = new System.Drawing.Point(160, 102);
            this.txtMonths.Name = "txtMonths";
            this.txtMonths.Size = new System.Drawing.Size(180, 23);
            this.txtMonths.TabIndex = 2;

            // 
            // rbCredit
            // 
            this.rbCredit.AutoSize = true;
            this.rbCredit.Location = new System.Drawing.Point(380, 25);
            this.rbCredit.Name = "rbCredit";
            this.rbCredit.Size = new System.Drawing.Size(67, 19);
            this.rbCredit.Text = "Кредит";
            this.rbCredit.TabIndex = 3;
            this.rbCredit.TabStop = true;
            this.rbCredit.UseVisualStyleBackColor = true;

            // 
            // rbDeposit
            // 
            this.rbDeposit.AutoSize = true;
            this.rbDeposit.Location = new System.Drawing.Point(380, 60);
            this.rbDeposit.Name = "rbDeposit";
            this.rbDeposit.Size = new System.Drawing.Size(75, 19);
            this.rbDeposit.Text = "Депозит";
            this.rbDeposit.TabIndex = 4;
            this.rbDeposit.UseVisualStyleBackColor = true;

            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(380, 95);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(140, 35);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Розрахувати";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // 
            // lblResult
            // 
            this.lblResult.AutoSize = false;
            this.lblResult.Location = new System.Drawing.Point(25, 145);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(700, 45);
            this.lblResult.Text = "Результат з'явиться після розрахунку.";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dataGridView1.Location = new System.Drawing.Point(25, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(700, 300);
            this.dataGridView1.TabIndex = 6;

            // Додавання колонок
            this.dataGridView1.Columns.Add("Month", "Місяць");
            this.dataGridView1.Columns.Add("StartAmount", "Початкова сума");
            this.dataGridView1.Columns.Add("Principal", "Основна сума");
            this.dataGridView1.Columns.Add("Interest", "Відсотки");
            this.dataGridView1.Columns.Add("Payment", "Платіж");
            this.dataGridView1.Columns.Add("Remaining", "Залишок");

            // 
            // Form1
            // 
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(760, 530);

            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rbDeposit);
            this.Controls.Add(this.rbCredit);
            this.Controls.Add(this.txtMonths);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblMonths);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblAmount);

            this.Name = "Form1";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.Text = "Калькулятор кредиту / депозиту";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
