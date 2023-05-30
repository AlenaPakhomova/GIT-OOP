using System;
using Model;
namespace View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxСalculator = new System.Windows.Forms.GroupBox();
            this.dataGridViewSpace = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.groupBoxСalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxСalculator
            // 
            this.groupBoxСalculator.Controls.Add(this.dataGridViewSpace);
            this.groupBoxСalculator.Location = new System.Drawing.Point(37, 52);
            this.groupBoxСalculator.Name = "groupBoxСalculator";
            this.groupBoxСalculator.Size = new System.Drawing.Size(307, 219);
            this.groupBoxСalculator.TabIndex = 0;
            this.groupBoxСalculator.TabStop = false;
            this.groupBoxСalculator.Text = "Калькулятор заработных плат";
            this.groupBoxСalculator.Enter += new System.EventHandler(this.groupBoxСalculator_Enter);
            // 
            // dataGridViewSpace
            // 
            this.dataGridViewSpace.AllowUserToResizeColumns = false;
            this.dataGridViewSpace.AllowUserToResizeRows = false;
            this.dataGridViewSpace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpace.Location = new System.Drawing.Point(7, 28);
            this.dataGridViewSpace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewSpace.Name = "dataGridViewSpace";
            this.dataGridViewSpace.RowHeadersWidth = 51;
            this.dataGridViewSpace.RowTemplate.Height = 25;
            this.dataGridViewSpace.Size = new System.Drawing.Size(294, 184);
            this.dataGridViewSpace.TabIndex = 0;
            this.dataGridViewSpace.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSpace_CellContentClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(43, 293);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(137, 31);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(200, 293);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(137, 31);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(43, 332);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(137, 31);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(200, 332);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(137, 31);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "Сбросить";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(43, 371);
            this.buttonRandom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(294, 33);
            this.buttonRandom.TabIndex = 5;
            this.buttonRandom.Text = "Случайная зарплата";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxСalculator);
            this.Name = "MainForm";
            this.Text = "Калькулятор";
            this.groupBoxСalculator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxСalculator;
        private DataGridView dataGridViewSpace;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonSearch;
        private Button buttonReset;
        private Button buttonRandom;
    }
}