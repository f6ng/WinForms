namespace Задание_3
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
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.buttonCelsiusToFahrenheit = new System.Windows.Forms.Button();
            this.buttonFahrenheitToCelsius = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxTemperature
            // 
            this.textBoxTemperature.Location = new System.Drawing.Point(161, 100);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.Size = new System.Drawing.Size(100, 22);
            this.textBoxTemperature.TabIndex = 0;
            // 
            // buttonCelsiusToFahrenheit
            // 
            this.buttonCelsiusToFahrenheit.Location = new System.Drawing.Point(161, 144);
            this.buttonCelsiusToFahrenheit.Name = "buttonCelsiusToFahrenheit";
            this.buttonCelsiusToFahrenheit.Size = new System.Drawing.Size(75, 23);
            this.buttonCelsiusToFahrenheit.TabIndex = 1;
            this.buttonCelsiusToFahrenheit.Text = "C → F";
            this.buttonCelsiusToFahrenheit.UseVisualStyleBackColor = true;
            this.buttonCelsiusToFahrenheit.Click += new System.EventHandler(this.buttonCelsiusToFahrenheit_Click);
            // 
            // buttonFahrenheitToCelsius
            // 
            this.buttonFahrenheitToCelsius.Location = new System.Drawing.Point(242, 144);
            this.buttonFahrenheitToCelsius.Name = "buttonFahrenheitToCelsius";
            this.buttonFahrenheitToCelsius.Size = new System.Drawing.Size(75, 23);
            this.buttonFahrenheitToCelsius.TabIndex = 2;
            this.buttonFahrenheitToCelsius.Text = "F → C";
            this.buttonFahrenheitToCelsius.UseVisualStyleBackColor = true;
            this.buttonFahrenheitToCelsius.Click += new System.EventHandler(this.buttonFahrenheitToCelsius_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(158, 192);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(44, 16);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonFahrenheitToCelsius);
            this.Controls.Add(this.buttonCelsiusToFahrenheit);
            this.Controls.Add(this.textBoxTemperature);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTemperature;
        private System.Windows.Forms.Button buttonCelsiusToFahrenheit;
        private System.Windows.Forms.Button buttonFahrenheitToCelsius;
        private System.Windows.Forms.Label labelResult;
    }
}

