using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCelsiusToFahrenheit_Click(object sender, EventArgs e)
        {
            try
            {
                double celsius = double.Parse(textBoxTemperature.Text);
                double fahrenheit = (celsius * 9 / 5) + 32;
                labelResult.Text = fahrenheit.ToString("F2") + " °F";
            }
            catch (FormatException)
            {
                labelResult.Text = "Ошибка: введите число";
            }
        }

        private void buttonFahrenheitToCelsius_Click(object sender, EventArgs e)
        {
            try
            {
                double fahrenheit = double.Parse(textBoxTemperature.Text);
                double celsius = (fahrenheit - 32) * 5 / 9;
                labelResult.Text = celsius.ToString("F2") + " °C";
            }
            catch (FormatException)
            {
                labelResult.Text = "Ошибка: введите число";
            }
        }

    }
}
