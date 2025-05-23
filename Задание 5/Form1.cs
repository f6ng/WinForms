using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBoxNum1.Text);
                double num2 = double.Parse(textBoxNum2.Text);
                double result = num1 + num2;
                labelResult.Text = "Результат: " + result.ToString();
            }
            catch (FormatException)
            {
                labelResult.Text = "Ошибка: введите числа";
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBoxNum1.Text);
                double num2 = double.Parse(textBoxNum2.Text);
                double result = num1 * num2;
                labelResult.Text = "Результат: " + result.ToString();
            }
            catch (FormatException)
            {
                labelResult.Text = "Ошибка: введите числа";
            }
        }

        private void buttonAdd(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(textBoxNum1.Text);
                double num2 = double.Parse(textBoxNum2.Text);
                double result = num1 + num2;
                labelResult.Text = "Результат: " + result.ToString();
            }
            catch (FormatException)
            {
                labelResult.Text = "Ошибка: введите числа";
            }
        }

    }
}
