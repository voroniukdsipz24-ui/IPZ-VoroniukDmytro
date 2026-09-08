using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        TextBox textBox1;
        TextBox textBox2;
        TextBox textBox3;
        Button button1;
        Label label4;
        Label label5;
        Label label6;

        public Form1()
        {
            InitializeComponent();
            CreateForm();
        }

        private void CreateForm()
        {
            this.Text = "Обчислення трьох чисел";
            this.Size = new Size(400, 350);
            this.StartPosition = FormStartPosition.CenterScreen;

            Label label1 = new Label();
            label1.Text = "Перше число:";
            label1.Location = new Point(30, 30);
            label1.AutoSize = true;

            textBox1 = new TextBox();
            textBox1.Location = new Point(150, 27);
            textBox1.Width = 180;

            Label label2 = new Label();
            label2.Text = "Друге число:";
            label2.Location = new Point(30, 70);
            label2.AutoSize = true;

            textBox2 = new TextBox();
            textBox2.Location = new Point(150, 67);
            textBox2.Width = 180;

            Label label3 = new Label();
            label3.Text = "Третє число:";
            label3.Location = new Point(30, 110);
            label3.AutoSize = true;

            textBox3 = new TextBox();
            textBox3.Location = new Point(150, 107);
            textBox3.Width = 180;

            button1 = new Button();
            button1.Text = "Обчислити";
            button1.Location = new Point(130, 150);
            button1.Width = 130;
            button1.Click += Button1_Click;

            label4 = new Label();
            label4.Text = "Сума:";
            label4.Location = new Point(30, 200);
            label4.AutoSize = true;

            label5 = new Label();
            label5.Text = "Різниця:";
            label5.Location = new Point(30, 230);
            label5.AutoSize = true;

            label6 = new Label();
            label6.Text = "Добуток:";
            label6.Location = new Point(30, 260);
            label6.AutoSize = true;

            this.Controls.Add(label1);
            this.Controls.Add(textBox1);

            this.Controls.Add(label2);
            this.Controls.Add(textBox2);

            this.Controls.Add(label3);
            this.Controls.Add(textBox3);

            this.Controls.Add(button1);

            this.Controls.Add(label4);
            this.Controls.Add(label5);
            this.Controls.Add(label6);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            double sum = a + b + c;
            double difference = a - b - c;
            double product = a * b * c;

            label4.Text = "Сума: " + sum;
            label5.Text = "Різниця: " + difference;
            label6.Text = "Добуток: " + product;
        }
    }
}