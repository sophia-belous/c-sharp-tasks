namespace task_12_winform
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.selectButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBoxNumSel = new System.Windows.Forms.ComboBox();
            this.checkBoxSel = new System.Windows.Forms.CheckBox();
            this.checkBoxAve = new System.Windows.Forms.CheckBox();
            this.comboBoxVarAve = new System.Windows.Forms.ComboBox();
            this.comboBoxNumAve = new System.Windows.Forms.ComboBox();
            this.radioButtonSort = new System.Windows.Forms.RadioButton();
            this.radioButSortDes = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 208);
            this.textBox1.TabIndex = 0;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(12, 226);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(93, 176);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 6;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(217, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 208);
            this.textBox2.TabIndex = 7;
            // 
            // comboBoxNumSel
            // 
            this.comboBoxNumSel.FormattingEnabled = true;
            this.comboBoxNumSel.Location = new System.Drawing.Point(94, 12);
            this.comboBoxNumSel.Name = "comboBoxNumSel";
            this.comboBoxNumSel.Size = new System.Drawing.Size(40, 21);
            this.comboBoxNumSel.TabIndex = 9;
            // 
            // checkBoxSel
            // 
            this.checkBoxSel.AutoSize = true;
            this.checkBoxSel.Location = new System.Drawing.Point(94, 41);
            this.checkBoxSel.Name = "checkBoxSel";
            this.checkBoxSel.Size = new System.Drawing.Size(97, 17);
            this.checkBoxSel.TabIndex = 10;
            this.checkBoxSel.Text = "Count students";
            this.checkBoxSel.UseVisualStyleBackColor = true;
            // 
            // checkBoxAve
            // 
            this.checkBoxAve.AutoSize = true;
            this.checkBoxAve.Location = new System.Drawing.Point(93, 96);
            this.checkBoxAve.Name = "checkBoxAve";
            this.checkBoxAve.Size = new System.Drawing.Size(92, 17);
            this.checkBoxAve.TabIndex = 11;
            this.checkBoxAve.Text = "Averege mark";
            this.checkBoxAve.UseVisualStyleBackColor = true;
            // 
            // comboBoxVarAve
            // 
            this.comboBoxVarAve.FormattingEnabled = true;
            this.comboBoxVarAve.Location = new System.Drawing.Point(93, 64);
            this.comboBoxVarAve.Name = "comboBoxVarAve";
            this.comboBoxVarAve.Size = new System.Drawing.Size(37, 21);
            this.comboBoxVarAve.TabIndex = 12;
            // 
            // comboBoxNumAve
            // 
            this.comboBoxNumAve.FormattingEnabled = true;
            this.comboBoxNumAve.Location = new System.Drawing.Point(148, 64);
            this.comboBoxNumAve.Name = "comboBoxNumAve";
            this.comboBoxNumAve.Size = new System.Drawing.Size(40, 21);
            this.comboBoxNumAve.TabIndex = 13;
            // 
            // radioButtonSort
            // 
            this.radioButtonSort.AutoSize = true;
            this.radioButtonSort.Location = new System.Drawing.Point(94, 120);
            this.radioButtonSort.Name = "radioButtonSort";
            this.radioButtonSort.Size = new System.Drawing.Size(75, 17);
            this.radioButtonSort.TabIndex = 14;
            this.radioButtonSort.TabStop = true;
            this.radioButtonSort.Text = "Sort marks";
            this.radioButtonSort.UseVisualStyleBackColor = true;
            // 
            // radioButSortDes
            // 
            this.radioButSortDes.AutoSize = true;
            this.radioButSortDes.Location = new System.Drawing.Point(94, 143);
            this.radioButSortDes.Name = "radioButSortDes";
            this.radioButSortDes.Size = new System.Drawing.Size(103, 17);
            this.radioButSortDes.TabIndex = 15;
            this.radioButSortDes.TabStop = true;
            this.radioButSortDes.Text = "Sort Desc marks";
            this.radioButSortDes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 261);
            this.Controls.Add(this.radioButSortDes);
            this.Controls.Add(this.radioButtonSort);
            this.Controls.Add(this.comboBoxNumAve);
            this.Controls.Add(this.comboBoxVarAve);
            this.Controls.Add(this.checkBoxAve);
            this.Controls.Add(this.checkBoxSel);
            this.Controls.Add(this.comboBoxNumSel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBoxNumSel;
        private System.Windows.Forms.CheckBox checkBoxSel;
        private System.Windows.Forms.CheckBox checkBoxAve;
        private System.Windows.Forms.ComboBox comboBoxVarAve;
        private System.Windows.Forms.ComboBox comboBoxNumAve;
        private System.Windows.Forms.RadioButton radioButtonSort;
        private System.Windows.Forms.RadioButton radioButSortDes;
    }
}

