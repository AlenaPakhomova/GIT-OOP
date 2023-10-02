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
            this.labelHourlyWageRate = new System.Windows.Forms.Label();
            this.labelTimeHourlyRate = new System.Windows.Forms.Label();
            this.textBoxHourlyWageRate = new System.Windows.Forms.TextBox();
            this.textBoxTimeHourlyRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelHourlyWageRate
            // 
            this.labelHourlyWageRate.AutoSize = true;
            this.labelHourlyWageRate.Location = new System.Drawing.Point(18, 20);
            this.labelHourlyWageRate.Name = "labelHourlyWageRate";
            this.labelHourlyWageRate.Size = new System.Drawing.Size(115, 20);
            this.labelHourlyWageRate.TabIndex = 0;
            this.labelHourlyWageRate.Text = "Часовая ставка";
            this.labelHourlyWageRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LabelHourlyWageRate_KeyPress);
            // 
            // labelTimeHourlyRate
            // 
            this.labelTimeHourlyRate.AutoSize = true;
            this.labelTimeHourlyRate.Location = new System.Drawing.Point(18, 62);
            this.labelTimeHourlyRate.Name = "labelTimeHourlyRate";
            this.labelTimeHourlyRate.Size = new System.Drawing.Size(206, 20);
            this.labelTimeHourlyRate.TabIndex = 1;
            this.labelTimeHourlyRate.Text = "Кол-во отработанных часов";
            this.labelTimeHourlyRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LabelHourlyWageRate_KeyPress);
            // 
            // textBoxHourlyWageRate
            // 
            this.textBoxHourlyWageRate.Location = new System.Drawing.Point(139, 20);
            this.textBoxHourlyWageRate.Name = "textBoxHourlyWageRate";
            this.textBoxHourlyWageRate.Size = new System.Drawing.Size(134, 27);
            this.textBoxHourlyWageRate.TabIndex = 2;
            // 
            // textBoxTimeHourlyRate
            // 
            this.textBoxTimeHourlyRate.Location = new System.Drawing.Point(230, 62);
            this.textBoxTimeHourlyRate.Name = "textBoxTimeHourlyRate";
            this.textBoxTimeHourlyRate.Size = new System.Drawing.Size(43, 27);
            this.textBoxTimeHourlyRate.TabIndex = 3;
            // 
            // HourlyWageRateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxTimeHourlyRate);
            this.Controls.Add(this.textBoxHourlyWageRate);
            this.Controls.Add(this.labelTimeHourlyRate);
            this.Controls.Add(this.labelHourlyWageRate);
            this.Name = "HourlyWageRateUserControl";
            this.Size = new System.Drawing.Size(292, 121);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelHourlyWageRate;
        private Label labelTimeHourlyRate;
        private TextBox textBoxHourlyWageRate;
        private TextBox textBoxTimeHourlyRate;
    }
}
