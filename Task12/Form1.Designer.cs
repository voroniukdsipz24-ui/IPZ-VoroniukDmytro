namespace PasswordGeneratorApp
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
            this.labelLength = new System.Windows.Forms.Label();
            this.numericUpDownLength = new System.Windows.Forms.NumericUpDown();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxUpper = new System.Windows.Forms.CheckBox();
            this.checkBoxDigits = new System.Windows.Forms.CheckBox();
            this.checkBoxSpecial = new System.Windows.Forms.CheckBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).BeginInit();
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            //
            // labelLength
            //
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(20, 22);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(94, 15);
            this.labelLength.TabIndex = 0;
            this.labelLength.Text = "Довжина пароля:";
            //
            // numericUpDownLength
            //
            this.numericUpDownLength.Location = new System.Drawing.Point(150, 20);
            this.numericUpDownLength.Maximum = new decimal(new int[] { 128, 0, 0, 0 });
            this.numericUpDownLength.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            this.numericUpDownLength.Name = "numericUpDownLength";
            this.numericUpDownLength.Size = new System.Drawing.Size(80, 23);
            this.numericUpDownLength.TabIndex = 1;
            this.numericUpDownLength.Value = new decimal(new int[] { 12, 0, 0, 0 });
            //
            // groupBoxOptions
            //
            this.groupBoxOptions.Controls.Add(this.checkBoxUpper);
            this.groupBoxOptions.Controls.Add(this.checkBoxDigits);
            this.groupBoxOptions.Controls.Add(this.checkBoxSpecial);
            this.groupBoxOptions.Location = new System.Drawing.Point(20, 60);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(320, 120);
            this.groupBoxOptions.TabIndex = 2;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Включити символи";
            //
            // checkBoxUpper
            //
            this.checkBoxUpper.AutoSize = true;
            this.checkBoxUpper.Checked = true;
            this.checkBoxUpper.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUpper.Location = new System.Drawing.Point(20, 25);
            this.checkBoxUpper.Name = "checkBoxUpper";
            this.checkBoxUpper.Size = new System.Drawing.Size(148, 19);
            this.checkBoxUpper.TabIndex = 0;
            this.checkBoxUpper.Text = "Великі літери (A-Z)";
            this.checkBoxUpper.UseVisualStyleBackColor = true;
            //
            // checkBoxDigits
            //
            this.checkBoxDigits.AutoSize = true;
            this.checkBoxDigits.Checked = true;
            this.checkBoxDigits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDigits.Location = new System.Drawing.Point(20, 55);
            this.checkBoxDigits.Name = "checkBoxDigits";
            this.checkBoxDigits.Size = new System.Drawing.Size(74, 19);
            this.checkBoxDigits.TabIndex = 1;
            this.checkBoxDigits.Text = "Цифри (0-9)";
            this.checkBoxDigits.UseVisualStyleBackColor = true;
            //
            // checkBoxSpecial
            //
            this.checkBoxSpecial.AutoSize = true;
            this.checkBoxSpecial.Location = new System.Drawing.Point(20, 85);
            this.checkBoxSpecial.Name = "checkBoxSpecial";
            this.checkBoxSpecial.Size = new System.Drawing.Size(180, 19);
            this.checkBoxSpecial.TabIndex = 2;
            this.checkBoxSpecial.Text = "Спецсимволи (!@#$%...)";
            this.checkBoxSpecial.UseVisualStyleBackColor = true;
            //
            // buttonGenerate
            //
            this.buttonGenerate.Location = new System.Drawing.Point(20, 200);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(150, 32);
            this.buttonGenerate.TabIndex = 3;
            this.buttonGenerate.Text = "Згенерувати пароль";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            //
            // buttonCopy
            //
            this.buttonCopy.Location = new System.Drawing.Point(190, 200);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(150, 32);
            this.buttonCopy.TabIndex = 4;
            this.buttonCopy.Text = "Копіювати";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            //
            // textBoxResult
            //
            this.textBoxResult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxResult.Location = new System.Drawing.Point(20, 245);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(320, 29);
            this.textBoxResult.TabIndex = 5;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 300);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.numericUpDownLength);
            this.Controls.Add(this.labelLength);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор паролів";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLength)).EndInit();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.NumericUpDown numericUpDownLength;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.CheckBox checkBoxUpper;
        private System.Windows.Forms.CheckBox checkBoxDigits;
        private System.Windows.Forms.CheckBox checkBoxSpecial;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

