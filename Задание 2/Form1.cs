﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_2
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
            labelGreeting.Text = greeting;
        }
    }
}
