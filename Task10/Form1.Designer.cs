using System.Drawing;
using System.Windows.Forms;

namespace MobileTariffSelector
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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblSms = new System.Windows.Forms.Label();
            this.nudSms = new System.Windows.Forms.NumericUpDown();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.lblInternet = new System.Windows.Forms.Label();
            this.nudInternet = new System.Windows.Forms.NumericUpDown();

            this.btnFindTariff = new System.Windows.Forms.Button();

            this.lvTariffs = new System.Windows.Forms.ListView();
            this.colName = new System.Windows.Forms.ColumnHeader();
            this.colPrice = new System.Windows.Forms.ColumnHeader();
            this.colInternet = new System.Windows.Forms.ColumnHeader();
            this.colMinutes = new System.Windows.Forms.ColumnHeader();
            this.colSms = new System.Windows.Forms.ColumnHeader();
            this.colMatch = new System.Windows.Forms.ColumnHeader();

            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblRecommendation = new System.Windows.Forms.Label();
            this.lblDisclaimer = new System.Windows.Forms.Label();

            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInternet)).BeginInit();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();

            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.nudSms);
            this.grpInput.Controls.Add(this.lblSms);
            this.grpInput.Controls.Add(this.nudMinutes);
            this.grpInput.Controls.Add(this.lblMinutes);
            this.grpInput.Controls.Add(this.nudInternet);
            this.grpInput.Controls.Add(this.lblInternet);
            this.grpInput.Location = new Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new Size(600, 130);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Ваші потреби на місяць";

            // 
            // lblInternet
            // 
            this.lblInternet.AutoSize = true;
            this.lblInternet.Location = new Point(15, 30);
            this.lblInternet.Name = "lblInternet";
            this.lblInternet.Size = new Size(260, 15);
            this.lblInternet.TabIndex = 0;
            this.lblInternet.Text = "Обсяг мобільного інтернету, ГБ:";

            // 
            // nudInternet
            // 
            this.nudInternet.Location = new Point(300, 27);
            this.nudInternet.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudInternet.Name = "nudInternet";
            this.nudInternet.Size = new Size(90, 23);
            this.nudInternet.TabIndex = 1;
            this.nudInternet.Value = new decimal(new int[] { 15, 0, 0, 0 });

            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new Point(15, 62);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new Size(260, 15);
            this.lblMinutes.TabIndex = 2;
            this.lblMinutes.Text = "Хвилини дзвінків на інші оператори:";

            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new Point(300, 59);
            this.nudMinutes.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new Size(90, 23);
            this.nudMinutes.TabIndex = 3;
            this.nudMinutes.Value = new decimal(new int[] { 150, 0, 0, 0 });

            // 
            // lblSms
            // 
            this.lblSms.AutoSize = true;
            this.lblSms.Location = new Point(15, 94);
            this.lblSms.Name = "lblSms";
            this.lblSms.Size = new Size(260, 15);
            this.lblSms.TabIndex = 4;
            this.lblSms.Text = "Кількість SMS:";

            // 
            // nudSms
            // 
            this.nudSms.Location = new Point(300, 91);
            this.nudSms.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            this.nudSms.Name = "nudSms";
            this.nudSms.Size = new Size(90, 23);
            this.nudSms.TabIndex = 5;
            this.nudSms.Value = new decimal(new int[] { 30, 0, 0, 0 });

            // 
            // btnFindTariff
            // 
            this.btnFindTariff.Location = new Point(12, 150);
            this.btnFindTariff.Name = "btnFindTariff";
            this.btnFindTariff.Size = new Size(200, 32);
            this.btnFindTariff.TabIndex = 1;
            this.btnFindTariff.Text = "Підібрати тариф";
            this.btnFindTariff.UseVisualStyleBackColor = true;
            this.btnFindTariff.Click += new System.EventHandler(this.btnFindTariff_Click);

            // 
            // lvTariffs
            // 
            this.lvTariffs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colName,
                this.colPrice,
                this.colInternet,
                this.colMinutes,
                this.colSms,
                this.colMatch});
            this.lvTariffs.FullRowSelect = true;
            this.lvTariffs.GridLines = true;
            this.lvTariffs.Location = new Point(12, 192);
            this.lvTariffs.Name = "lvTariffs";
            this.lvTariffs.Size = new Size(600, 200);
            this.lvTariffs.TabIndex = 2;
            this.lvTariffs.UseCompatibleStateImageBehavior = false;
            this.lvTariffs.View = System.Windows.Forms.View.Details;

            // 
            // colName
            // 
            this.colName.Text = "Тариф";
            this.colName.Width = 190;

            // 
            // colPrice
            // 
            this.colPrice.Text = "Ціна, грн/міс.";
            this.colPrice.Width = 90;

            // 
            // colInternet
            // 
            this.colInternet.Text = "Інтернет";
            this.colInternet.Width = 90;

            // 
            // colMinutes
            // 
            this.colMinutes.Text = "Хвилини";
            this.colMinutes.Width = 90;

            // 
            // colSms
            // 
            this.colSms.Text = "SMS";
            this.colSms.Width = 60;

            // 
            // colMatch
            // 
            this.colMatch.Text = "Відповідає";
            this.colMatch.Width = 80;

            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.lblDisclaimer);
            this.grpResult.Controls.Add(this.lblRecommendation);
            this.grpResult.Location = new Point(12, 402);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new Size(600, 120);
            this.grpResult.TabIndex = 3;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Рекомендація";

            // 
            // lblRecommendation
            // 
            this.lblRecommendation.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.lblRecommendation.Location = new Point(15, 25);
            this.lblRecommendation.Name = "lblRecommendation";
            this.lblRecommendation.Size = new Size(570, 65);
            this.lblRecommendation.TabIndex = 0;
            this.lblRecommendation.Text = "Введіть свої потреби та натисніть \"Підібрати тариф\".";

            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            this.lblDisclaimer.ForeColor = Color.Gray;
            this.lblDisclaimer.Location = new Point(15, 92);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.Size = new Size(570, 20);
            this.lblDisclaimer.TabIndex = 1;
            this.lblDisclaimer.Text = "* Тарифи спрощені й орієнтовні (на основі публічних даних Київстар, 2026). Перевіряйте актуальні умови на kyivstar.ua.";

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new Size(624, 534);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.lvTariffs);
            this.Controls.Add(this.btnFindTariff);
            this.Controls.Add(this.grpInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Підбір тарифу мобільного зв'язку";

            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInternet)).EndInit();
            this.grpResult.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblInternet;
        private System.Windows.Forms.NumericUpDown nudInternet;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.Label lblSms;
        private System.Windows.Forms.NumericUpDown nudSms;

        private System.Windows.Forms.Button btnFindTariff;

        private System.Windows.Forms.ListView lvTariffs;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPrice;
        private System.Windows.Forms.ColumnHeader colInternet;
        private System.Windows.Forms.ColumnHeader colMinutes;
        private System.Windows.Forms.ColumnHeader colSms;
        private System.Windows.Forms.ColumnHeader colMatch;

        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lblRecommendation;
        private System.Windows.Forms.Label lblDisclaimer;
    }
}
