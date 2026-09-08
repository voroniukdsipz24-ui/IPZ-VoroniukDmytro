namespace SubscriptionBudget
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox txtSalary;

        private System.Windows.Forms.Label labelSubscription;
        private System.Windows.Forms.TextBox txtSubscription;

        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox txtPrice;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;

        private System.Windows.Forms.ListBox lstSubscriptions;

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblRemaining;

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
            this.labelSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();

            this.labelSubscription = new System.Windows.Forms.Label();
            this.txtSubscription = new System.Windows.Forms.TextBox();

            this.labelPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();

            this.lstSubscriptions = new System.Windows.Forms.ListBox();

            this.lblTotal = new System.Windows.Forms.Label();
            this.lblRemaining = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор підписок";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // labelSalary
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(40, 35);
            this.labelSalary.Text = "Місячна зарплата:";

            // txtSalary
            this.txtSalary.Location = new System.Drawing.Point(200, 32);
            this.txtSalary.Size = new System.Drawing.Size(300, 27);

            // labelSubscription
            this.labelSubscription.AutoSize = true;
            this.labelSubscription.Location = new System.Drawing.Point(40, 85);
            this.labelSubscription.Text = "Назва підписки:";

            // txtSubscription
            this.txtSubscription.Location = new System.Drawing.Point(200, 82);
            this.txtSubscription.Size = new System.Drawing.Size(300, 27);

            // labelPrice
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(40, 135);
            this.labelPrice.Text = "Ціна підписки:";

            // txtPrice
            this.txtPrice.Location = new System.Drawing.Point(200, 132);
            this.txtPrice.Size = new System.Drawing.Size(200, 27);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(40, 180);
            this.btnAdd.Size = new System.Drawing.Size(220, 40);
            this.btnAdd.Text = "Додати підписку";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(280, 180);
            this.btnClear.Size = new System.Drawing.Size(220, 40);
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // lstSubscriptions
            this.lstSubscriptions.Location = new System.Drawing.Point(40, 240);
            this.lstSubscriptions.Size = new System.Drawing.Size(460, 120);

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(40, 385);
            this.lblTotal.Text = "Всього витрат: 0.00 грн";

            // lblRemaining
            this.lblRemaining.AutoSize = true;
            this.lblRemaining.Location = new System.Drawing.Point(40, 425);
            this.lblRemaining.Text = "Залишок зарплати: 0.00 грн";

            // Add controls
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.txtSalary);

            this.Controls.Add(this.labelSubscription);
            this.Controls.Add(this.txtSubscription);

            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.txtPrice);

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);

            this.Controls.Add(this.lstSubscriptions);

            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblRemaining);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
