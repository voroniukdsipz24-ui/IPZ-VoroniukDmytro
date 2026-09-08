namespace TestQuestionnaire
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbQ1_1;
        private System.Windows.Forms.RadioButton rbQ1_2;
        private System.Windows.Forms.RadioButton rbQ1_3;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbQ2_1;
        private System.Windows.Forms.RadioButton rbQ2_2;
        private System.Windows.Forms.RadioButton rbQ2_3;

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbQ3_1;
        private System.Windows.Forms.RadioButton rbQ3_2;
        private System.Windows.Forms.RadioButton rbQ3_3;

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbQ4_1;
        private System.Windows.Forms.CheckBox cbQ4_2;
        private System.Windows.Forms.CheckBox cbQ4_3;

        private System.Windows.Forms.Button btnResult;

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
            this.lblTitle = new System.Windows.Forms.Label();

            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbQ1_1 = new System.Windows.Forms.RadioButton();
            this.rbQ1_2 = new System.Windows.Forms.RadioButton();
            this.rbQ1_3 = new System.Windows.Forms.RadioButton();

            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbQ2_1 = new System.Windows.Forms.RadioButton();
            this.rbQ2_2 = new System.Windows.Forms.RadioButton();
            this.rbQ2_3 = new System.Windows.Forms.RadioButton();

            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbQ3_1 = new System.Windows.Forms.RadioButton();
            this.rbQ3_2 = new System.Windows.Forms.RadioButton();
            this.rbQ3_3 = new System.Windows.Forms.RadioButton();

            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbQ4_1 = new System.Windows.Forms.CheckBox();
            this.cbQ4_2 = new System.Windows.Forms.CheckBox();
            this.cbQ4_3 = new System.Windows.Forms.CheckBox();

            this.btnResult = new System.Windows.Forms.Button();

            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                16F,
                System.Drawing.FontStyle.Bold
            );
            this.lblTitle.Location = new System.Drawing.Point(125, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 26);
            this.lblTitle.Text = "Тест: Знання мови C#";

            // groupBox1
            this.groupBox1.Controls.Add(this.rbQ1_3);
            this.groupBox1.Controls.Add(this.rbQ1_2);
            this.groupBox1.Controls.Add(this.rbQ1_1);
            this.groupBox1.Location = new System.Drawing.Point(30, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 105);
            this.groupBox1.Text = "1. Який тип використовується для цілого числа?";

            // rbQ1_1
            this.rbQ1_1.AutoSize = true;
            this.rbQ1_1.Location = new System.Drawing.Point(25, 35);
            this.rbQ1_1.Name = "rbQ1_1";
            this.rbQ1_1.Size = new System.Drawing.Size(56, 17);
            this.rbQ1_1.Text = "string";

            // rbQ1_2
            this.rbQ1_2.AutoSize = true;
            this.rbQ1_2.Location = new System.Drawing.Point(180, 35);
            this.rbQ1_2.Name = "rbQ1_2";
            this.rbQ1_2.Size = new System.Drawing.Size(43, 17);
            this.rbQ1_2.Text = "int";

            // rbQ1_3
            this.rbQ1_3.AutoSize = true;
            this.rbQ1_3.Location = new System.Drawing.Point(330, 35);
            this.rbQ1_3.Name = "rbQ1_3";
            this.rbQ1_3.Size = new System.Drawing.Size(50, 17);
            this.rbQ1_3.Text = "double";

            // groupBox2
            this.groupBox2.Controls.Add(this.rbQ2_3);
            this.groupBox2.Controls.Add(this.rbQ2_2);
            this.groupBox2.Controls.Add(this.rbQ2_1);
            this.groupBox2.Location = new System.Drawing.Point(30, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(540, 105);
            this.groupBox2.Text = "2. Яке ключове слово створює новий об'єкт?";

            // rbQ2_1
            this.rbQ2_1.AutoSize = true;
            this.rbQ2_1.Location = new System.Drawing.Point(25, 35);
            this.rbQ2_1.Name = "rbQ2_1";
            this.rbQ2_1.Size = new System.Drawing.Size(47, 17);
            this.rbQ2_1.Text = "new";

            // rbQ2_2
            this.rbQ2_2.AutoSize = true;
            this.rbQ2_2.Location = new System.Drawing.Point(180, 35);
            this.rbQ2_2.Name = "rbQ2_2";
            this.rbQ2_2.Size = new System.Drawing.Size(57, 17);
            this.rbQ2_2.Text = "object";

            // rbQ2_3
            this.rbQ2_3.AutoSize = true;
            this.rbQ2_3.Location = new System.Drawing.Point(330, 35);
            this.rbQ2_3.Name = "rbQ2_3";
            this.rbQ2_3.Size = new System.Drawing.Size(55, 17);
            this.rbQ2_3.Text = "create";

            // groupBox3
            this.groupBox3.Controls.Add(this.rbQ3_3);
            this.groupBox3.Controls.Add(this.rbQ3_2);
            this.groupBox3.Controls.Add(this.rbQ3_1);
            this.groupBox3.Location = new System.Drawing.Point(30, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(540, 105);
            this.groupBox3.Text = "3. Який тип зберігає значення true або false?";

            // rbQ3_1
            this.rbQ3_1.AutoSize = true;
            this.rbQ3_1.Location = new System.Drawing.Point(25, 35);
            this.rbQ3_1.Name = "rbQ3_1";
            this.rbQ3_1.Size = new System.Drawing.Size(46, 17);
            this.rbQ3_1.Text = "bool";

            // rbQ3_2
            this.rbQ3_2.AutoSize = true;
            this.rbQ3_2.Location = new System.Drawing.Point(180, 35);
            this.rbQ3_2.Name = "rbQ3_2";
            this.rbQ3_2.Size = new System.Drawing.Size(43, 17);
            this.rbQ3_2.Text = "int";

            // rbQ3_3
            this.rbQ3_3.AutoSize = true;
            this.rbQ3_3.Location = new System.Drawing.Point(330, 35);
            this.rbQ3_3.Name = "rbQ3_3";
            this.rbQ3_3.Size = new System.Drawing.Size(46, 17);
            this.rbQ3_3.Text = "char";

            // groupBox4
            this.groupBox4.Controls.Add(this.cbQ4_3);
            this.groupBox4.Controls.Add(this.cbQ4_2);
            this.groupBox4.Controls.Add(this.cbQ4_1);
            this.groupBox4.Location = new System.Drawing.Point(30, 410);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(540, 105);
            this.groupBox4.Text = "4. Які з цих є типами даних C#? (можна декілька)";

            // cbQ4_1
            this.cbQ4_1.AutoSize = true;
            this.cbQ4_1.Location = new System.Drawing.Point(25, 35);
            this.cbQ4_1.Name = "cbQ4_1";
            this.cbQ4_1.Size = new System.Drawing.Size(40, 17);
            this.cbQ4_1.Text = "int";

            // cbQ4_2
            this.cbQ4_2.AutoSize = true;
            this.cbQ4_2.Location = new System.Drawing.Point(180, 35);
            this.cbQ4_2.Name = "cbQ4_2";
            this.cbQ4_2.Size = new System.Drawing.Size(57, 17);
            this.cbQ4_2.Text = "string";

            // cbQ4_3
            this.cbQ4_3.AutoSize = true;
            this.cbQ4_3.Location = new System.Drawing.Point(330, 35);
            this.cbQ4_3.Name = "cbQ4_3";
            this.cbQ4_3.Size = new System.Drawing.Size(78, 17);
            this.cbQ4_3.Text = "computer";

            // btnResult
            this.btnResult.Font = new System.Drawing.Font(
                "Microsoft Sans Serif",
                10F,
                System.Drawing.FontStyle.Bold
            );
            this.btnResult.Location = new System.Drawing.Point(185, 535);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(230, 45);
            this.btnResult.Text = "Завершити тест";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 610);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестова анкета";

            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();

            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();

            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();

            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}