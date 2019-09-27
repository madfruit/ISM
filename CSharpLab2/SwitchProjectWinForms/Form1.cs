using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchProjectWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonweek_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox.Text, out int i))
            {
              MessageBox.Show("Ошибка введения значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            switch (i)
            {
                case 1:
                    labelanswer.Visible = true;
                    labelanswer.Text = "Понедельник";
                    break;
                case 2:
                    labelanswer.Visible = true;
                    labelanswer.Text = "Вторник";
                    break;
                case 3:
                    labelanswer.Visible = true;
                    labelanswer.Text = "Среда";
                    break;
                case 4:
                    labelanswer.Visible = true;
                    labelanswer.Text = "Четверг";
                    break;
                case 5:
                    labelanswer.Visible = true;
                    labelanswer.Text = "Пятница";
                    break;
                case 6:
                    labelanswer.Visible = true;
                    labelanswer.Text = "Суббота";
                    break;
                case 7:
                    labelanswer.Visible = true;
                    labelanswer.Text = "Воскресенье";
                    break;
                default:
                    MessageBox.Show("Ошибка введения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
           System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
        }

        private void buttonoperations_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox.Text, out int i))
            {
                MessageBox.Show("Ошибка введения значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            double a, b;
            string znak = textBox2.Text;
            a = Convert.ToDouble(textBox.Text);
            b = Convert.ToDouble(textBox1.Text);
            switch (znak)
            {
                case "+":
                    string answerp = Convert.ToString(a + b);
                    labelanswer.Visible = true;
                    labelanswer.Text = answerp;
                    break;
                case "-":
                    string answerm = Convert.ToString(a - b);
                    labelanswer.Visible = true;
                    labelanswer.Text = answerm;
                    break;
                case "*":
                    string answeru = Convert.ToString(a * b);
                    labelanswer.Visible = true;
                    labelanswer.Text = answeru;
                    break;
                case "/":
                    string answerd = Convert.ToString(a / b);
                    labelanswer.Visible = true;
                    labelanswer.Text = answerd;
                    break;
                default:
                    MessageBox.Show("Нет такой операции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void buttonmonth_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox.Text, out int i1))
            {
                MessageBox.Show("Ошибка введения значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            switch (i1)
            {
                case 1:
                    labelanswer.Visible = true;
                    labelanswer.Text = "Январь";
                    break;
                case 2:
                    labelanswer.Visible = true;
                    labelanswer.Text = "Февраль";
                    break;
                case 3:
                    labelanswer.Visible = true;
                    labelanswer.Text = "Март";
                    break;
                case 4:
                    labelanswer.Visible = true;
                    labelanswer.Text = "Апрель";
                    break;
                case 5:
                    labelanswer.Visible = true;
                    labelanswer.Text = "Май";
                    break;
                case 6:
                    labelanswer.Visible = true;
                    labelanswer.Text = "Июнь";
                    break;
                case 7:
                    labelanswer.Visible = true;
                    labelanswer.Text = "Июль";
                    break;
                case 8:
                    labelanswer.Visible = true;
                    labelanswer.Text = "Август";
                    break;
                case 9:
                    labelanswer.Visible = true;
                    labelanswer.Text = "Сентябрь";
                    break;
                case 10:
                    labelanswer.Visible = true;
                    labelanswer.Text = "Октябрь";
                    break;
                case 11:
                    labelanswer.Visible = true;
                    labelanswer.Text = "Ноябрь";
                    break;
                case 12:
                    labelanswer.Visible = true;
                    labelanswer.Text = "Декабрь";
                    break;
                default:
                    MessageBox.Show("Ошибка введения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
