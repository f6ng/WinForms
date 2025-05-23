using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGreet_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string greeting = "Привет, " + name + "!";
            labelResult.Text = greeting;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBoxNum1.Text);
            double num2 = Convert.ToDouble(textBoxNum2.Text);
            double result = num1 + num2;
            labelResult.Text = "Результат: " + result.ToString();
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBoxNum1.Text);
            double num2 = Convert.ToDouble(textBoxNum2.Text);
            double result = num1 - num2;
            labelResult.Text = "Результат: " + result.ToString();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBoxNum1.Text);
            double num2 = Convert.ToDouble(textBoxNum2.Text);
            double result = num1 * num2;
            labelResult.Text = "Результат: " + result.ToString();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBoxNum1.Text);
            double num2 = Convert.ToDouble(textBoxNum2.Text);

            if (num2 != 0)
            {
                double result = num1 / num2;
                labelResult.Text = "Результат: " + result.ToString();
            }
            else
            {
                labelResult.Text = "Ошибка: деление на 0";
            }
        }

    }
}
