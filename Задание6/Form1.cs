using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Задание6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string task = textBoxTask.Text.Trim();
            if (!string.IsNullOrEmpty(task))
            {
                listBoxTasks.Items.Add(task);
                textBoxTask.Clear();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex != -1)
            {
                listBoxTasks.Items.RemoveAt(listBoxTasks.SelectedIndex);
            }
        }

        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxTasks.SelectedIndex;
            if (index != -1)
            {
                string task = listBoxTasks.Items[index].ToString();
                if (task.StartsWith("[✓] "))
                    task = task.Substring(4);
                else
                    task = "[✓] " + task;

                listBoxTasks.Items[index] = task;
            }

        }
    }
}
