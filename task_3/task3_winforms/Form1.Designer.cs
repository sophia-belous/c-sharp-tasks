namespace task3_winforms
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Calculate_button = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.Vertical_radiobutton = new System.Windows.Forms.RadioButton();
            this.Horizontal_radiobutton = new System.Windows.Forms.RadioButton();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculate_button
            // 
            this.Calculate_button.Location = new System.Drawing.Point(39, 64);
            this.Calculate_button.Name = "Calculate_button";
            this.Calculate_button.Size = new System.Drawing.Size(75, 23);
            this.Calculate_button.TabIndex = 0;
            this.Calculate_button.Text = "Calculate";
            this.Calculate_button.UseVisualStyleBackColor = true;
            this.Calculate_button.Click += new System.EventHandler(this.Calculate_button_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(39, 38);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(100, 20);
            this.OutputTextBox.TabIndex = 1;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(39, 12);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(100, 20);
            this.InputTextBox.TabIndex = 2;
            // 
            // Chart
            // 
            chartArea3.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Chart.Legends.Add(legend3);
            this.Chart.Location = new System.Drawing.Point(172, 12);
            this.Chart.Name = "Chart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.Chart.Series.Add(series3);
            this.Chart.Size = new System.Drawing.Size(300, 300);
            this.Chart.TabIndex = 3;
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.Vertical_radiobutton);
            this.GroupBox.Controls.Add(this.Horizontal_radiobutton);
            this.GroupBox.Location = new System.Drawing.Point(13, 103);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(153, 94);
            this.GroupBox.TabIndex = 4;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Orientation of Histogram";
            // 
            // Vertical_radiobutton
            // 
            this.Vertical_radiobutton.AutoSize = true;
            this.Vertical_radiobutton.Location = new System.Drawing.Point(7, 44);
            this.Vertical_radiobutton.Name = "Vertical_radiobutton";
            this.Vertical_radiobutton.Size = new System.Drawing.Size(60, 17);
            this.Vertical_radiobutton.TabIndex = 1;
            this.Vertical_radiobutton.Text = "Vertical";
            this.Vertical_radiobutton.UseVisualStyleBackColor = true;
            // 
            // Horizontal_radiobutton
            // 
            this.Horizontal_radiobutton.AutoSize = true;
            this.Horizontal_radiobutton.Checked = true;
            this.Horizontal_radiobutton.Location = new System.Drawing.Point(7, 20);
            this.Horizontal_radiobutton.Name = "Horizontal_radiobutton";
            this.Horizontal_radiobutton.Size = new System.Drawing.Size(72, 17);
            this.Horizontal_radiobutton.TabIndex = 0;
            this.Horizontal_radiobutton.TabStop = true;
            this.Horizontal_radiobutton.Text = "Horizontal";
            this.Horizontal_radiobutton.UseVisualStyleBackColor = true;
            this.Horizontal_radiobutton.CheckedChanged += new System.EventHandler(this.Horizontal_Radiobutton_CheckedChanged);
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(20, 204);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(121, 21);
            this.ComboBox.TabIndex = 5;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 355);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.Chart);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.Calculate_button);
            this.Name = "Form1";
            this.Text = "Task3";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculate_button;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.RadioButton Vertical_radiobutton;
        private System.Windows.Forms.RadioButton Horizontal_radiobutton;
        private System.Windows.Forms.ComboBox ComboBox;
    }
}

