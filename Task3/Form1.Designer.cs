namespace StudentRegistration
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.CheckBox chkConsent;
        private System.Windows.Forms.Button btnRegister;

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
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();

            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();

            this.lblGroup = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();

            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();

            this.chkConsent = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();

            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();

            // lblFullName
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(35, 30);
            this.lblFullName.Text = "ПІБ:";

            // txtFullName
            this.txtFullName.Location = new System.Drawing.Point(35, 50);
            this.txtFullName.Size = new System.Drawing.Size(400, 23);

            // lblBirthDate
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(35, 90);
            this.lblBirthDate.Text = "Дата народження:";

            // dtpBirthDate
            this.dtpBirthDate.Format =
                System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location =
                new System.Drawing.Point(35, 110);
            this.dtpBirthDate.Size =
                new System.Drawing.Size(200, 23);

            // lblGroup
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location =
                new System.Drawing.Point(35, 150);
            this.lblGroup.Text =
                "Група/спеціальність:";

            // cmbGroup
            this.cmbGroup.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.Location =
                new System.Drawing.Point(35, 170);
            this.cmbGroup.Size =
                new System.Drawing.Size(300, 23);

            // groupBoxGender
            this.groupBoxGender.Location =
                new System.Drawing.Point(35, 210);
            this.groupBoxGender.Size =
                new System.Drawing.Size(300, 70);
            this.groupBoxGender.Text = "Стать";

            // rbMale
            this.rbMale.AutoSize = true;
            this.rbMale.Location =
                new System.Drawing.Point(20, 30);
            this.rbMale.Text = "Чоловіча";

            // rbFemale
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location =
                new System.Drawing.Point(130, 30);
            this.rbFemale.Text = "Жіноча";

            // chkConsent
            this.chkConsent.AutoSize = true;
            this.chkConsent.Location =
                new System.Drawing.Point(35, 300);
            this.chkConsent.Text =
                "Я погоджуюсь на обробку персональних даних";

            // btnRegister
            this.btnRegister.Location =
                new System.Drawing.Point(35, 345);
            this.btnRegister.Size =
                new System.Drawing.Size(180, 40);
            this.btnRegister.Text = "Зареєструвати";
            this.btnRegister.Click +=
                new System.EventHandler(this.btnRegister_Click);

            // groupBoxGender controls
            this.groupBoxGender.Controls.Add(this.rbMale);
            this.groupBoxGender.Controls.Add(this.rbFemale);

            // Form1
            this.ClientSize =
                new System.Drawing.Size(500, 430);

            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.groupBoxGender);
            this.Controls.Add(this.chkConsent);
            this.Controls.Add(this.btnRegister);

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстрація студента";

            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}