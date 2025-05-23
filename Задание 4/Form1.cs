using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_4
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelCount.Text = count.ToString();
        }

        private void buttonIncrement_Click(object sender, EventArgs e)
        {
            count++;
            labelCount.Text = count.ToString();
        }

        private void buttonSetInitial_Click(object sender, EventArgs e)
        {
            try
            {
                count = int.Parse(textBoxInitialCount.Text);
                labelCount.Text = count.ToString();
            }
            catch (FormatException)
            {
                labelCount.Text = "Ошибка: введите число";
            }
        }

    }
}
