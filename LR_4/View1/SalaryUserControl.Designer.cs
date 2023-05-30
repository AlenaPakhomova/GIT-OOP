namespace View
{
    partial class SalaryUserControl
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
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelDaysInMonth = new System.Windows.Forms.Label();
            this.labelWorkingDays = new System.Windows.Forms.Label();
            this.textBoxDaysInMonth = new System.Windows.Forms.TextBox();
            this.textBoxWorkingDays = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(70, 32);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(213, 27);
            this.textBoxSalary.TabIndex = 0;
            this.textBoxSalary.TextChanged += new System.EventHandler(this.textBoxSalary_TextChanged);
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(13, 39);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(51, 20);
            this.labelSalary.TabIndex = 1;
            this.labelSalary.Text = "Оклад";
            this.labelSalary.Click += new System.EventHandler(this.labelSalary_Click);
            // 
            // labelDaysInMonth
            // 
            this.labelDaysInMonth.AutoSize = true;
            this.labelDaysInMonth.Location = new System.Drawing.Point(13, 69);
            this.labelDaysInMonth.Name = "labelDaysInMonth";
            this.labelDaysInMonth.Size = new System.Drawing.Size(226, 20);
            this.labelDaysInMonth.TabIndex = 2;
            this.labelDaysInMonth.Text = "Кол-во рабочих дней в месяце";
            this.labelDaysInMonth.Click += new System.EventHandler(this.labelDaysInMonth_Click);
            // 
            // labelWorkingDays
            // 
            this.labelWorkingDays.AutoSize = true;
            this.labelWorkingDays.Location = new System.Drawing.Point(13, 106);
            this.labelWorkingDays.Name = "labelWorkingDays";
            this.labelWorkingDays.Size = new System.Drawing.Size(200, 20);
            this.labelWorkingDays.TabIndex = 3;
            this.labelWorkingDays.Text = "Кол-во отработанных дней";
            this.labelWorkingDays.Click += new System.EventHandler(this.labelWorkingDays_Click);
            // 
            // textBoxDaysInMonth
            // 
            this.textBoxDaysInMonth.Location = new System.Drawing.Point(245, 69);
            this.textBoxDaysInMonth.Name = "textBoxDaysInMonth";
            this.textBoxDaysInMonth.Size = new System.Drawing.Size(38, 27);
            this.textBoxDaysInMonth.TabIndex = 4;
            this.textBoxDaysInMonth.TextChanged += new System.EventHandler(this.textBoxDaysInMonth_TextChanged);
            // 
            // textBoxWorkingDays
            // 
            this.textBoxWorkingDays.Location = new System.Drawing.Point(245, 106);
            this.textBoxWorkingDays.Name = "textBoxWorkingDays";
            this.textBoxWorkingDays.Size = new System.Drawing.Size(38, 27);
            this.textBoxWorkingDays.TabIndex = 5;
            this.textBoxWorkingDays.TextChanged += new System.EventHandler(this.textBoxWorkingDays_TextChanged);
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxWorkingDays);
            this.Controls.Add(this.textBoxDaysInMonth);
            this.Controls.Add(this.labelWorkingDays);
            this.Controls.Add(this.labelDaysInMonth);
            this.Controls.Add(this.labelSalary);
            this.Controls.Add(this.textBoxSalary);
            this.Name = "Salary";
            this.Size = new System.Drawing.Size(302, 154);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxSalary;
        private Label labelSalary;
        private Label labelDaysInMonth;
        private Label labelWorkingDays;
        private TextBox textBoxDaysInMonth;
        private TextBox textBoxWorkingDays;
    }
}
