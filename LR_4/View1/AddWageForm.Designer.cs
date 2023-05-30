namespace View
{
    partial class AddWageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.payrollMethod = new System.Windows.Forms.GroupBox();
            this.comboSalarySelection = new System.Windows.Forms.ComboBox();
            this.accrualParameters = new System.Windows.Forms.GroupBox();
            this.hourlyWageRate = new View.HourlyWageRate();
            this.wageRate = new View.WageRate();
            this.salary = new View.Salary();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.payrollMethod.SuspendLayout();
            this.accrualParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // payrollMethod
            // 
            this.payrollMethod.Controls.Add(this.comboSalarySelection);
            this.payrollMethod.Location = new System.Drawing.Point(44, 28);
            this.payrollMethod.Name = "payrollMethod";
            this.payrollMethod.Size = new System.Drawing.Size(314, 112);
            this.payrollMethod.TabIndex = 0;
            this.payrollMethod.TabStop = false;
            this.payrollMethod.Text = "Способ начисления зарплаты";
            // 
            // comboSalarySelection
            // 
            this.comboSalarySelection.FormattingEnabled = true;
            this.comboSalarySelection.Location = new System.Drawing.Point(22, 49);
            this.comboSalarySelection.Name = "comboSalarySelection";
            this.comboSalarySelection.Size = new System.Drawing.Size(269, 28);
            this.comboSalarySelection.TabIndex = 0;
            this.comboSalarySelection.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSalarySelection);
            // 
            // accrualParameters
            // 
            this.accrualParameters.Controls.Add(this.hourlyWageRate);
            this.accrualParameters.Controls.Add(this.wageRate);
            this.accrualParameters.Controls.Add(this.salary);
            this.accrualParameters.Location = new System.Drawing.Point(44, 159);
            this.accrualParameters.Name = "accrualParameters";
            this.accrualParameters.Size = new System.Drawing.Size(314, 210);
            this.accrualParameters.TabIndex = 1;
            this.accrualParameters.TabStop = false;
            this.accrualParameters.Text = "Параметры начисления";
            // 
            // hourlyWageRate
            // 
            this.hourlyWageRate.Location = new System.Drawing.Point(6, 26);
            this.hourlyWageRate.Name = "hourlyWageRate";
            this.hourlyWageRate.Size = new System.Drawing.Size(302, 154);
            this.hourlyWageRate.TabIndex = 2;
            // 
            // wageRate
            // 
            this.wageRate.Location = new System.Drawing.Point(6, 26);
            this.wageRate.Name = "wageRate";
            this.wageRate.Size = new System.Drawing.Size(302, 154);
            this.wageRate.TabIndex = 1;
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(6, 26);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(302, 154);
            this.salary.TabIndex = 0;
            this.salary.Load += new System.EventHandler(this.SalaryLoad);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(66, 388);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(129, 33);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(206, 388);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(129, 33);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose);
            // 
            // AddWageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 433);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.accrualParameters);
            this.Controls.Add(this.payrollMethod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddWageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление зарплаты";
            this.payrollMethod.ResumeLayout(false);
            this.accrualParameters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox payrollMethod;
        private GroupBox accrualParameters;
        private ComboBox comboSalarySelection;
        private Button buttonOk;
        private Button buttonClose;
        private Salary salary;
        private HourlyWageRate hourlyWageRate;
        private WageRate wageRate;
    }
}