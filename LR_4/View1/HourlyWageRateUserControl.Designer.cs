namespace View
{
    partial class HourlyWageRateUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelHourlyRate = new System.Windows.Forms.Label();
            this.labelTimeHourlyRate = new System.Windows.Forms.Label();
            this.textBoxHourlyRate = new System.Windows.Forms.TextBox();
            this.textBoxTimeHourlyRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelHourlyRate
            // 
            this.labelHourlyRate.AutoSize = true;
            this.labelHourlyRate.Location = new System.Drawing.Point(18, 54);
            this.labelHourlyRate.Name = "labelHourlyRate";
            this.labelHourlyRate.Size = new System.Drawing.Size(115, 20);
            this.labelHourlyRate.TabIndex = 0;
            this.labelHourlyRate.Text = "Часовая ставка";
            this.labelHourlyRate.Click += new System.EventHandler(this.labelHourlyRate_Click);
            // 
            // labelTimeHourlyRate
            // 
            this.labelTimeHourlyRate.AutoSize = true;
            this.labelTimeHourlyRate.Location = new System.Drawing.Point(18, 95);
            this.labelTimeHourlyRate.Name = "labelTimeHourlyRate";
            this.labelTimeHourlyRate.Size = new System.Drawing.Size(206, 20);
            this.labelTimeHourlyRate.TabIndex = 1;
            this.labelTimeHourlyRate.Text = "Кол-во отработанных часов";
            this.labelTimeHourlyRate.Click += new System.EventHandler(this.labelTimeHourlyRate_Click);
            // 
            // textBoxHourlyRate
            // 
            this.textBoxHourlyRate.Location = new System.Drawing.Point(139, 54);
            this.textBoxHourlyRate.Name = "textBoxHourlyRate";
            this.textBoxHourlyRate.Size = new System.Drawing.Size(134, 27);
            this.textBoxHourlyRate.TabIndex = 2;
          //  this.textBoxHourlyRate.TextChanged += new System.EventHandler(this.textBoxHourlyRate_TextChanged);
            // 
            // textBoxTimeHourlyRate
            // 
            this.textBoxTimeHourlyRate.Location = new System.Drawing.Point(230, 95);
            this.textBoxTimeHourlyRate.Name = "textBoxTimeHourlyRate";
            this.textBoxTimeHourlyRate.Size = new System.Drawing.Size(43, 27);
            this.textBoxTimeHourlyRate.TabIndex = 3;
           // this.textBoxTimeHourlyRate.TextChanged += new System.EventHandler(this.textBoxTimeHourlyRate_TextChanged);
            // 
            // HourlyWageRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxTimeHourlyRate);
            this.Controls.Add(this.textBoxHourlyRate);
            this.Controls.Add(this.labelTimeHourlyRate);
            this.Controls.Add(this.labelHourlyRate);
            this.Name = "HourlyWageRate";
            this.Size = new System.Drawing.Size(404, 190);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelHourlyRate;
        private Label labelTimeHourlyRate;
        private TextBox textBoxHourlyRate;
        private TextBox textBoxTimeHourlyRate;
    }
}
