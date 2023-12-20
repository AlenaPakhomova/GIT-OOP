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
            this.salaryUserControl1 = new View.SalaryUserControl();
            this.wageRateUserControl1 = new View.WageRateUserControl();
            this.hourlyWageRateUserControl1 = new View.HourlyWageRateUserControl();
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
            this.payrollMethod.TabIndex = 7;
            this.payrollMethod.TabStop = false;
            this.payrollMethod.Text = "Способ начисления зарплаты";
            this.payrollMethod.Enter += new System.EventHandler(this.payrollMethod_Enter);
            // 
            // comboSalarySelection
            // 
            this.comboSalarySelection.FormattingEnabled = true;
            this.comboSalarySelection.Location = new System.Drawing.Point(22, 49);
            this.comboSalarySelection.Name = "comboSalarySelection";
            this.comboSalarySelection.Size = new System.Drawing.Size(269, 28);
            this.comboSalarySelection.TabIndex = 9;
            this.comboSalarySelection.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSalarySelection);
            // 
            // accrualParameters
            // 
            this.accrualParameters.Controls.Add(this.salaryUserControl1);
            this.accrualParameters.Controls.Add(this.wageRateUserControl1);
            this.accrualParameters.Controls.Add(this.hourlyWageRateUserControl1);
            this.accrualParameters.Location = new System.Drawing.Point(44, 146);
            this.accrualParameters.Name = "accrualParameters";
            this.accrualParameters.Size = new System.Drawing.Size(314, 150);
            this.accrualParameters.TabIndex = 10;
            this.accrualParameters.TabStop = false;
            this.accrualParameters.Text = "Параметры начисления";
            this.accrualParameters.Enter += new System.EventHandler(this.accrualParameters_Enter);
            // 
            // salaryUserControl1
            // 
            this.salaryUserControl1.Location = new System.Drawing.Point(6, 26);
            this.salaryUserControl1.Name = "salaryUserControl1";
            this.salaryUserControl1.Size = new System.Drawing.Size(296, 118);
            this.salaryUserControl1.TabIndex = 1;
            // 
            // wageRateUserControl1
            // 
            this.wageRateUserControl1.Location = new System.Drawing.Point(6, 40);
            this.wageRateUserControl1.Name = "wageRateUserControl1";
            this.wageRateUserControl1.Size = new System.Drawing.Size(302, 91);
            this.wageRateUserControl1.TabIndex = 2;
            this.wageRateUserControl1.Load += new System.EventHandler(this.wageRateUserControl1_Load);
            // 
            // hourlyWageRateUserControl1
            // 
            this.hourlyWageRateUserControl1.Location = new System.Drawing.Point(6, 26);
            this.hourlyWageRateUserControl1.Name = "hourlyWageRateUserControl1";
            this.hourlyWageRateUserControl1.Size = new System.Drawing.Size(302, 90);
            this.hourlyWageRateUserControl1.TabIndex = 0;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(50, 302);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(129, 33);
            this.buttonOk.TabIndex = 13;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.ButtonOk);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(217, 302);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(129, 33);
            this.buttonClose.TabIndex = 14;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose);
            // 
            // AddWageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 410);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.accrualParameters);
            this.Controls.Add(this.payrollMethod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddWageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление зарплаты";
            this.Load += new System.EventHandler(this.SalaryLoad);
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
        private SalaryUserControl salaryUserControl1;
        private WageRateUserControl wageRateUserControl1;
        private HourlyWageRateUserControl hourlyWageRateUserControl1;
    }
}