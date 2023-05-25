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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.salary1 = new View.Salary();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.wageRate1 = new View.WageRate();
            this.hourlyWageRate1 = new View.HourlyWageRate();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(44, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Способ начисления зарплаты";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(269, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hourlyWageRate1);
            this.groupBox2.Controls.Add(this.wageRate1);
            this.groupBox2.Controls.Add(this.salary1);
            this.groupBox2.Location = new System.Drawing.Point(44, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 210);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры начисления";
            // 
            // salary1
            // 
            this.salary1.Location = new System.Drawing.Point(22, 37);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(258, 125);
            this.salary1.TabIndex = 0;
            this.salary1.Load += new System.EventHandler(this.salary1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Закрыть";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // wageRate1
            // 
            this.wageRate1.Location = new System.Drawing.Point(0, 26);
            this.wageRate1.Name = "wageRate1";
            this.wageRate1.Size = new System.Drawing.Size(211, 132);
            this.wageRate1.TabIndex = 1;
            // 
            // hourlyWageRate1
            // 
            this.hourlyWageRate1.Location = new System.Drawing.Point(92, 48);
            this.hourlyWageRate1.Name = "hourlyWageRate1";
            this.hourlyWageRate1.Size = new System.Drawing.Size(178, 110);
            this.hourlyWageRate1.TabIndex = 2;
            // 
            // AddWageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 433);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddWageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление зарплаты";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Salary salary1;
        private HourlyWageRate hourlyWageRate1;
        private WageRate wageRate1;
    }
}