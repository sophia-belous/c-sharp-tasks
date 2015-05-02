namespace task_4_winform
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
            this.triangleDrawing = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textCY = new System.Windows.Forms.TextBox();
            this.textAX = new System.Windows.Forms.TextBox();
            this.textAY = new System.Windows.Forms.TextBox();
            this.textBX = new System.Windows.Forms.TextBox();
            this.textBY = new System.Windows.Forms.TextBox();
            this.textCX = new System.Windows.Forms.TextBox();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.sidesLabel = new System.Windows.Forms.Label();
            this.textBoxSide1 = new System.Windows.Forms.TextBox();
            this.textBoxSide2 = new System.Windows.Forms.TextBox();
            this.textBoxSide3 = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.textBoxForPerimeter = new System.Windows.Forms.TextBox();
            this.textBoxForSquare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // triangleDrawing
            // 
            this.triangleDrawing.Location = new System.Drawing.Point(107, 65);
            this.triangleDrawing.Name = "triangleDrawing";
            this.triangleDrawing.Size = new System.Drawing.Size(105, 23);
            this.triangleDrawing.TabIndex = 0;
            this.triangleDrawing.Text = "Draw Triangle";
            this.triangleDrawing.UseVisualStyleBackColor = true;
            this.triangleDrawing.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(301, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 173);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textCY
            // 
            this.textCY.Location = new System.Drawing.Point(57, 92);
            this.textCY.Name = "textCY";
            this.textCY.Size = new System.Drawing.Size(40, 20);
            this.textCY.TabIndex = 2;
            // 
            // textAX
            // 
            this.textAX.Location = new System.Drawing.Point(12, 39);
            this.textAX.Name = "textAX";
            this.textAX.Size = new System.Drawing.Size(40, 20);
            this.textAX.TabIndex = 3;
            // 
            // textAY
            // 
            this.textAY.Location = new System.Drawing.Point(58, 39);
            this.textAY.Name = "textAY";
            this.textAY.Size = new System.Drawing.Size(39, 20);
            this.textAY.TabIndex = 4;
            // 
            // textBX
            // 
            this.textBX.Location = new System.Drawing.Point(12, 65);
            this.textBX.Name = "textBX";
            this.textBX.Size = new System.Drawing.Size(40, 20);
            this.textBX.TabIndex = 5;
            // 
            // textBY
            // 
            this.textBY.Location = new System.Drawing.Point(57, 65);
            this.textBY.Name = "textBY";
            this.textBY.Size = new System.Drawing.Size(40, 20);
            this.textBY.TabIndex = 6;
            // 
            // textCX
            // 
            this.textCX.Location = new System.Drawing.Point(12, 92);
            this.textCX.Name = "textCX";
            this.textCX.Size = new System.Drawing.Size(40, 20);
            this.textCX.TabIndex = 7;
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(13, 12);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(91, 13);
            this.pointsLabel.TabIndex = 8;
            this.pointsLabel.Text = "Points Of Triangle";
            // 
            // sidesLabel
            // 
            this.sidesLabel.AutoSize = true;
            this.sidesLabel.Location = new System.Drawing.Point(9, 126);
            this.sidesLabel.Name = "sidesLabel";
            this.sidesLabel.Size = new System.Drawing.Size(88, 13);
            this.sidesLabel.TabIndex = 9;
            this.sidesLabel.Text = "Sides Of Triangle";
            // 
            // textBoxSide1
            // 
            this.textBoxSide1.Location = new System.Drawing.Point(12, 147);
            this.textBoxSide1.Name = "textBoxSide1";
            this.textBoxSide1.Size = new System.Drawing.Size(85, 20);
            this.textBoxSide1.TabIndex = 10;
            // 
            // textBoxSide2
            // 
            this.textBoxSide2.Location = new System.Drawing.Point(12, 173);
            this.textBoxSide2.Name = "textBoxSide2";
            this.textBoxSide2.Size = new System.Drawing.Size(85, 20);
            this.textBoxSide2.TabIndex = 11;
            // 
            // textBoxSide3
            // 
            this.textBoxSide3.Location = new System.Drawing.Point(12, 199);
            this.textBoxSide3.Name = "textBoxSide3";
            this.textBoxSide3.Size = new System.Drawing.Size(85, 20);
            this.textBoxSide3.TabIndex = 12;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(134, 126);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(109, 13);
            this.resultLabel.TabIndex = 13;
            this.resultLabel.Text = "Perimeter and Square";
            // 
            // textBoxForPerimeter
            // 
            this.textBoxForPerimeter.Location = new System.Drawing.Point(137, 147);
            this.textBoxForPerimeter.Name = "textBoxForPerimeter";
            this.textBoxForPerimeter.Size = new System.Drawing.Size(47, 20);
            this.textBoxForPerimeter.TabIndex = 14;
            // 
            // textBoxForSquare
            // 
            this.textBoxForSquare.Location = new System.Drawing.Point(196, 147);
            this.textBoxForSquare.Name = "textBoxForSquare";
            this.textBoxForSquare.Size = new System.Drawing.Size(47, 20);
            this.textBoxForSquare.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxForSquare);
            this.Controls.Add(this.textBoxForPerimeter);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.textBoxSide3);
            this.Controls.Add(this.textBoxSide2);
            this.Controls.Add(this.textBoxSide1);
            this.Controls.Add(this.sidesLabel);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.textCX);
            this.Controls.Add(this.textBY);
            this.Controls.Add(this.textBX);
            this.Controls.Add(this.textAY);
            this.Controls.Add(this.textAX);
            this.Controls.Add(this.textCY);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.triangleDrawing);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button triangleDrawing;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textCY;
        private System.Windows.Forms.TextBox textAX;
        private System.Windows.Forms.TextBox textAY;
        private System.Windows.Forms.TextBox textBX;
        private System.Windows.Forms.TextBox textBY;
        private System.Windows.Forms.TextBox textCX;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label sidesLabel;
        private System.Windows.Forms.TextBox textBoxSide1;
        private System.Windows.Forms.TextBox textBoxSide2;
        private System.Windows.Forms.TextBox textBoxSide3;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox textBoxForPerimeter;
        private System.Windows.Forms.TextBox textBoxForSquare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

