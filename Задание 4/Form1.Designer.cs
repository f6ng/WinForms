namespace Задание_4
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
            this.textBoxInitialCount = new System.Windows.Forms.TextBox();
            this.buttonSetInitial = new System.Windows.Forms.Button();
            this.buttonIncrement = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInitialCount
            // 
            this.textBoxInitialCount.Location = new System.Drawing.Point(135, 168);
            this.textBoxInitialCount.Name = "textBoxInitialCount";
            this.textBoxInitialCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxInitialCount.TabIndex = 0;
            // 
            // buttonSetInitial
            // 
            this.buttonSetInitial.Location = new System.Drawing.Point(260, 167);
            this.buttonSetInitial.Name = "buttonSetInitial";
            this.buttonSetInitial.Size = new System.Drawing.Size(75, 23);
            this.buttonSetInitial.TabIndex = 1;
            this.buttonSetInitial.Text = "Установить";
            this.buttonSetInitial.UseVisualStyleBackColor = true;
            this.buttonSetInitial.Click += new System.EventHandler(this.buttonSetInitial_Click);
            // 
            // buttonIncrement
            // 
            this.buttonIncrement.Location = new System.Drawing.Point(135, 214);
            this.buttonIncrement.Name = "buttonIncrement";
            this.buttonIncrement.Size = new System.Drawing.Size(75, 23);
            this.buttonIncrement.TabIndex = 2;
            this.buttonIncrement.Text = "+1";
            this.buttonIncrement.UseVisualStyleBackColor = true;
            this.buttonIncrement.Click += new System.EventHandler(this.buttonIncrement_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(132, 253);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(14, 16);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonIncrement);
            this.Controls.Add(this.buttonSetInitial);
            this.Controls.Add(this.textBoxInitialCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInitialCount;
        private System.Windows.Forms.Button buttonSetInitial;
        private System.Windows.Forms.Button buttonIncrement;
        private System.Windows.Forms.Label labelCount;
    }
}

