namespace View
{
    partial class FilterWages
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWage = new System.Windows.Forms.TextBox();
            this.checkBoxInput = new System.Windows.Forms.CheckBox();
            this.checkBoxSalary = new System.Windows.Forms.CheckBox();
            this.checkBoxWageRate = new System.Windows.Forms.CheckBox();
            this.checkBoxHourlyWageRate = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxWage);
            this.groupBox1.Controls.Add(this.checkBoxInput);
            this.groupBox1.Controls.Add(this.checkBoxSalary);
            this.groupBox1.Controls.Add(this.checkBoxWageRate);
            this.groupBox1.Controls.Add(this.checkBoxHourlyWageRate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 233);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры фильтрации";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "рублей";
            // 
            // textBoxWage
            // 
            this.textBoxWage.Location = new System.Drawing.Point(241, 187);
            this.textBoxWage.Name = "textBoxWage";
            this.textBoxWage.Size = new System.Drawing.Size(125, 27);
            this.textBoxWage.TabIndex = 4;
            this.textBoxWage.TextChanged += new System.EventHandler(this.TextBoxWage_TextChanged);
            this.textBoxWage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxWage_KeyPress);
            // 
            // checkBoxInput
            // 
            this.checkBoxInput.AutoSize = true;
            this.checkBoxInput.Location = new System.Drawing.Point(14, 187);
            this.checkBoxInput.Name = "checkBoxInput";
            this.checkBoxInput.Size = new System.Drawing.Size(221, 24);
            this.checkBoxInput.TabIndex = 3;
            this.checkBoxInput.Text = "Ввод необходимой суммы ";
            this.checkBoxInput.UseVisualStyleBackColor = true;
            this.checkBoxInput.CheckedChanged += new System.EventHandler(this.CheckBoxInput_CheckedChanged);
            // 
            // checkBoxSalary
            // 
            this.checkBoxSalary.AutoSize = true;
            this.checkBoxSalary.Location = new System.Drawing.Point(14, 135);
            this.checkBoxSalary.Name = "checkBoxSalary";
            this.checkBoxSalary.Size = new System.Drawing.Size(73, 24);
            this.checkBoxSalary.TabIndex = 2;
            this.checkBoxSalary.Text = "Оклад";
            this.checkBoxSalary.UseVisualStyleBackColor = true;
            // 
            // checkBoxWageRate
            // 
            this.checkBoxWageRate.AutoSize = true;
            this.checkBoxWageRate.Location = new System.Drawing.Point(14, 84);
            this.checkBoxWageRate.Name = "checkBoxWageRate";
            this.checkBoxWageRate.Size = new System.Drawing.Size(148, 24);
            this.checkBoxWageRate.TabIndex = 1;
            this.checkBoxWageRate.Text = "Тарифная ставка";
            this.checkBoxWageRate.UseVisualStyleBackColor = true;
            // 
            // checkBoxHourlyWageRate
            // 
            this.checkBoxHourlyWageRate.AutoSize = true;
            this.checkBoxHourlyWageRate.Location = new System.Drawing.Point(14, 39);
            this.checkBoxHourlyWageRate.Name = "checkBoxHourlyWageRate";
            this.checkBoxHourlyWageRate.Size = new System.Drawing.Size(208, 24);
            this.checkBoxHourlyWageRate.TabIndex = 0;
            this.checkBoxHourlyWageRate.Text = "Часовая тарифная ставка";
            this.checkBoxHourlyWageRate.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 261);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(450, 29);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // FilterWages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 302);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "FilterWages";
            this.Text = "Фильтр";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBoxWage;
        private CheckBox checkBoxInput;
        private CheckBox checkBoxSalary;
        private CheckBox checkBoxWageRate;
        private CheckBox checkBoxHourlyWageRate;
        private Button buttonSearch;
    }
}