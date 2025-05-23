namespace Задание_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.nextBoxName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelGreenting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextBoxName
            // 
            this.nextBoxName.Location = new System.Drawing.Point(257, 65);
            this.nextBoxName.Name = "nextBoxName";
            this.nextBoxName.Size = new System.Drawing.Size(100, 22);
            this.nextBoxName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelGreenting
            // 
            this.labelGreenting.AutoSize = true;
            this.labelGreenting.Location = new System.Drawing.Point(254, 128);
            this.labelGreenting.Name = "labelGreenting";
            this.labelGreenting.Size = new System.Drawing.Size(44, 16);
            this.labelGreenting.TabIndex = 2;
            this.labelGreenting.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelGreenting);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nextBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nextBoxName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelGreenting;
    }
}

