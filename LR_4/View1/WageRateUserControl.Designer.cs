namespace View
{
    partial class WageRateUserControl
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
            this.labelWorkingHours = new System.Windows.Forms.Label();
            this.labelRate = new System.Windows.Forms.Label();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.textBoxWorkingHours = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelWorkingHours
            // 
            this.labelWorkingHours.AutoSize = true;
            this.labelWorkingHours.Location = new System.Drawing.Point(28, 57);
            this.labelWorkingHours.Name = "labelWorkingHours";
            this.labelWorkingHours.Size = new System.Drawing.Size(206, 20);
            this.labelWorkingHours.TabIndex = 0;
            this.labelWorkingHours.Text = "Кол-во отработанных часов";
            this.labelWorkingHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelWorkingHours_KeyPress);
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(28, 15);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(55, 20);
            this.labelRate.TabIndex = 1;
            this.labelRate.Text = "Ставка";
            this.labelRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelRate_KeyPress);
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(89, 15);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(192, 27);
            this.textBoxRate.TabIndex = 2;
            // 
            // textBoxWorkingHours
            // 
            this.textBoxWorkingHours.Location = new System.Drawing.Point(240, 57);
            this.textBoxWorkingHours.Name = "textBoxWorkingHours";
            this.textBoxWorkingHours.Size = new System.Drawing.Size(41, 27);
            this.textBoxWorkingHours.TabIndex = 3;
            // 
            // WageRateUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxWorkingHours);
            this.Controls.Add(this.textBoxRate);
            this.Controls.Add(this.labelRate);
            this.Controls.Add(this.labelWorkingHours);
            this.Name = "WageRateUserControl";
            this.Size = new System.Drawing.Size(310, 106);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelWorkingHours;
        private Label labelRate;
        private TextBox textBoxRate;
        private TextBox textBoxWorkingHours;
    }
}
