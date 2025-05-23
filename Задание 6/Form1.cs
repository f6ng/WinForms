using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_6
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

        }
        private void listBoxTasks_DoubleClick(object sender, EventArgs e)
        {
            int index = listBoxTasks.SelectedIndex;

            if (index != -1)
            {
                string item = listBoxTasks.Items[index].ToString();

                // Проверка: если задача уже отмечена как выполненная, убираем отметку
                if (item.StartsWith("[✓] "))
                {
                    item = item.Substring(4); // убираем [✓]
                }
                else
                {
                    item = "[✓] " + item; // добавляем отметку
                }

                // Обновляем элемент в списке
                listBoxTasks.Items[index] = item;
            }
        }
    }
}
