using System.Drawing;
using System.Windows.Forms;

namespace CinemaBooking
{
    partial class MainForm
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

        #region Код, згенерований конструктором Windows Forms

        private void InitializeComponent()
        {
            this.pnlScreen = new System.Windows.Forms.Panel();
            this.lblScreen = new System.Windows.Forms.Label();

            this.pnlHall = new System.Windows.Forms.Panel();

            this.pnlLegend = new System.Windows.Forms.Panel();
            this.pnlSwatchEconomy = new System.Windows.Forms.Panel();
            this.lblSwatchEconomy = new System.Windows.Forms.Label();
            this.pnlSwatchStandard = new System.Windows.Forms.Panel();
            this.lblSwatchStandard = new System.Windows.Forms.Label();
            this.pnlSwatchVip = new System.Windows.Forms.Panel();
            this.lblSwatchVip = new System.Windows.Forms.Label();
            this.pnlSwatchBooked = new System.Windows.Forms.Panel();
            this.lblSwatchBooked = new System.Windows.Forms.Label();

            this.lblSelectedCount = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnClearSelection = new System.Windows.Forms.Button();

            this.pnlScreen.SuspendLayout();
            this.pnlLegend.SuspendLayout();
            this.SuspendLayout();

            // 
            // pnlScreen
            // 
            this.pnlScreen.BackColor = Color.DimGray;
            this.pnlScreen.Controls.Add(this.lblScreen);
            this.pnlScreen.Location = new Point(12, 12);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new Size(660, 30);
            this.pnlScreen.TabIndex = 0;

            // 
            // lblScreen
            // 
            this.lblScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScreen.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            this.lblScreen.ForeColor = Color.White;
            this.lblScreen.Name = "lblScreen";
            this.lblScreen.Text = "Е К Р А Н";
            this.lblScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // pnlHall
            // 
            this.pnlHall.BackColor = Color.White;
            this.pnlHall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHall.Location = new Point(12, 54);
            this.pnlHall.Name = "pnlHall";
            this.pnlHall.Size = new Size(660, 300);
            this.pnlHall.TabIndex = 1;
            // Місця (кнопки) додаються сюди динамічно в MainForm.cs методом BuildHall().

            // 
            // pnlLegend
            // 
            this.pnlLegend.Controls.Add(this.lblSwatchBooked);
            this.pnlLegend.Controls.Add(this.pnlSwatchBooked);
            this.pnlLegend.Controls.Add(this.lblSwatchVip);
            this.pnlLegend.Controls.Add(this.pnlSwatchVip);
            this.pnlLegend.Controls.Add(this.lblSwatchStandard);
            this.pnlLegend.Controls.Add(this.pnlSwatchStandard);
            this.pnlLegend.Controls.Add(this.lblSwatchEconomy);
            this.pnlLegend.Controls.Add(this.pnlSwatchEconomy);
            this.pnlLegend.Location = new Point(12, 366);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new Size(660, 80);
            this.pnlLegend.TabIndex = 2;

            // 
            // pnlSwatchEconomy
            // 
            this.pnlSwatchEconomy.BackColor = Color.PaleGreen;
            this.pnlSwatchEconomy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSwatchEconomy.Location = new Point(10, 10);
            this.pnlSwatchEconomy.Name = "pnlSwatchEconomy";
            this.pnlSwatchEconomy.Size = new Size(20, 20);
            this.pnlSwatchEconomy.TabIndex = 0;

            // 
            // lblSwatchEconomy
            // 
            this.lblSwatchEconomy.AutoSize = true;
            this.lblSwatchEconomy.Location = new Point(36, 13);
            this.lblSwatchEconomy.Name = "lblSwatchEconomy";
            this.lblSwatchEconomy.Size = new Size(150, 15);
            this.lblSwatchEconomy.TabIndex = 1;
            this.lblSwatchEconomy.Text = "Економ — 80 грн";

            // 
            // pnlSwatchStandard
            // 
            this.pnlSwatchStandard.BackColor = Color.LightGreen;
            this.pnlSwatchStandard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSwatchStandard.Location = new Point(220, 10);
            this.pnlSwatchStandard.Name = "pnlSwatchStandard";
            this.pnlSwatchStandard.Size = new Size(20, 20);
            this.pnlSwatchStandard.TabIndex = 2;

            // 
            // lblSwatchStandard
            // 
            this.lblSwatchStandard.AutoSize = true;
            this.lblSwatchStandard.Location = new Point(246, 13);
            this.lblSwatchStandard.Name = "lblSwatchStandard";
            this.lblSwatchStandard.Size = new Size(150, 15);
            this.lblSwatchStandard.TabIndex = 3;
            this.lblSwatchStandard.Text = "Стандарт — 110 грн";

            // 
            // pnlSwatchVip
            // 
            this.pnlSwatchVip.BackColor = Color.MediumSeaGreen;
            this.pnlSwatchVip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSwatchVip.Location = new Point(430, 10);
            this.pnlSwatchVip.Name = "pnlSwatchVip";
            this.pnlSwatchVip.Size = new Size(20, 20);
            this.pnlSwatchVip.TabIndex = 4;

            // 
            // lblSwatchVip
            // 
            this.lblSwatchVip.AutoSize = true;
            this.lblSwatchVip.Location = new Point(456, 13);
            this.lblSwatchVip.Name = "lblSwatchVip";
            this.lblSwatchVip.Size = new Size(150, 15);
            this.lblSwatchVip.TabIndex = 5;
            this.lblSwatchVip.Text = "VIP — 150 грн";

            // 
            // pnlSwatchBooked
            // 
            this.pnlSwatchBooked.BackColor = Color.Tomato;
            this.pnlSwatchBooked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSwatchBooked.Location = new Point(10, 45);
            this.pnlSwatchBooked.Name = "pnlSwatchBooked";
            this.pnlSwatchBooked.Size = new Size(20, 20);
            this.pnlSwatchBooked.TabIndex = 6;

            // 
            // lblSwatchBooked
            // 
            this.lblSwatchBooked.AutoSize = true;
            this.lblSwatchBooked.Location = new Point(36, 48);
            this.lblSwatchBooked.Name = "lblSwatchBooked";
            this.lblSwatchBooked.Size = new Size(220, 15);
            this.lblSwatchBooked.TabIndex = 7;
            this.lblSwatchBooked.Text = "Заброньовано (обрано мною)";

            // 
            // lblSelectedCount
            // 
            this.lblSelectedCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblSelectedCount.Location = new Point(12, 456);
            this.lblSelectedCount.Name = "lblSelectedCount";
            this.lblSelectedCount.Size = new Size(220, 25);
            this.lblSelectedCount.TabIndex = 3;
            this.lblSelectedCount.Text = "Обрано місць: 0";

            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblTotalPrice.Location = new Point(240, 456);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new Size(220, 25);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Сума: 0 грн";

            // 
            // btnClearSelection
            // 
            this.btnClearSelection.Location = new Point(480, 452);
            this.btnClearSelection.Name = "btnClearSelection";
            this.btnClearSelection.Size = new Size(192, 32);
            this.btnClearSelection.TabIndex = 5;
            this.btnClearSelection.Text = "Очистити вибір";
            this.btnClearSelection.UseVisualStyleBackColor = true;
            this.btnClearSelection.Click += new System.EventHandler(this.btnClearSelection_Click);

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new Size(700, 500);
            this.Controls.Add(this.btnClearSelection);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblSelectedCount);
            this.Controls.Add(this.pnlLegend);
            this.Controls.Add(this.pnlHall);
            this.Controls.Add(this.pnlScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бронювання місць — кінозал";

            this.pnlScreen.ResumeLayout(false);
            this.pnlLegend.ResumeLayout(false);
            this.pnlLegend.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlScreen;
        private System.Windows.Forms.Label lblScreen;

        private System.Windows.Forms.Panel pnlHall;

        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Panel pnlSwatchEconomy;
        private System.Windows.Forms.Label lblSwatchEconomy;
        private System.Windows.Forms.Panel pnlSwatchStandard;
        private System.Windows.Forms.Label lblSwatchStandard;
        private System.Windows.Forms.Panel pnlSwatchVip;
        private System.Windows.Forms.Label lblSwatchVip;
        private System.Windows.Forms.Panel pnlSwatchBooked;
        private System.Windows.Forms.Label lblSwatchBooked;

        private System.Windows.Forms.Label lblSelectedCount;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnClearSelection;
    }
}
