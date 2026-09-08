namespace FinanceTracker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Label lblBalance;

        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtDescription;

        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.ComboBox cmbFilter;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;

        private System.Windows.Forms.DataGridView dataGridView1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();

            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();

            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();

            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();

            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // lblAmount
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(25, 25);
            this.lblAmount.Text = "Сума:";

            // txtAmount
            this.txtAmount.Location = new System.Drawing.Point(130, 22);
            this.txtAmount.Size = new System.Drawing.Size(180, 23);

            // lblType
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(25, 65);
            this.lblType.Text = "Тип:";

            // cmbType
            this.cmbType.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Location = new System.Drawing.Point(130, 62);
            this.cmbType.Size = new System.Drawing.Size(180, 23);

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(25, 105);
            this.lblCategory.Text = "Категорія:";

            // cmbCategory
            this.cmbCategory.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Location = new System.Drawing.Point(130, 102);
            this.cmbCategory.Size = new System.Drawing.Size(180, 23);

            // lblCurrency
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(25, 145);
            this.lblCurrency.Text = "Валюта:";

            // cmbCurrency
            this.cmbCurrency.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrency.Location = new System.Drawing.Point(130, 142);
            this.cmbCurrency.Size = new System.Drawing.Size(180, 23);

            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(25, 185);
            this.lblDescription.Text = "Опис:";

            // txtDescription
            this.txtDescription.Location =
                new System.Drawing.Point(130, 182);
            this.txtDescription.Size =
                new System.Drawing.Size(180, 23);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(25, 225);
            this.btnAdd.Size = new System.Drawing.Size(285, 35);
            this.btnAdd.Text = "Додати операцію";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click +=
                new System.EventHandler(this.btnAdd_Click);

            // lblFilter
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(340, 25);
            this.lblFilter.Text = "Фільтр:";

            // cmbFilter
            this.cmbFilter.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Location = new System.Drawing.Point(400, 22);
            this.cmbFilter.Size = new System.Drawing.Size(200, 23);
            this.cmbFilter.SelectedIndexChanged +=
                new System.EventHandler(
                    this.cmbFilter_SelectedIndexChanged);

            // dataGridView1
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dataGridView1.Location =
                new System.Drawing.Point(340, 60);
            this.dataGridView1.Size =
                new System.Drawing.Size(720, 300);

            // lblBalance
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font =
                new System.Drawing.Font(
                    "Microsoft Sans Serif",
                    11F,
                    System.Drawing.FontStyle.Bold);

            this.lblBalance.Location =
                new System.Drawing.Point(340, 380);

            this.lblBalance.Size =
                new System.Drawing.Size(250, 100);

            // btnDelete
            this.btnDelete.Location =
                new System.Drawing.Point(25, 280);
            this.btnDelete.Size =
                new System.Drawing.Size(135, 35);
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click +=
                new System.EventHandler(this.btnDelete_Click);

            // btnSave
            this.btnSave.Location =
                new System.Drawing.Point(175, 280);
            this.btnSave.Size =
                new System.Drawing.Size(135, 35);
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click +=
                new System.EventHandler(this.btnSave_Click);

            // btnLoad
            this.btnLoad.Location =
                new System.Drawing.Point(25, 330);
            this.btnLoad.Size =
                new System.Drawing.Size(285, 35);
            this.btnLoad.Text = "Завантажити";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click +=
                new System.EventHandler(this.btnLoad_Click);

            // Form1
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(1090, 520);

            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lblBalance);

            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtDescription);

            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbCurrency);
            this.Controls.Add(this.cmbFilter);

            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);

            this.Controls.Add(this.dataGridView1);

            this.Name = "Form1";
            this.Text = "Трекер особистих фінансів";
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)
                (this.dataGridView1)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}