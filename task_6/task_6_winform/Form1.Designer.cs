namespace task_6_winform
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
            this.buttonShow = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.labelPassError = new System.Windows.Forms.Label();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.labelForTrack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(51, 251);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(75, 23);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(41, 24);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox.Size = new System.Drawing.Size(104, 177);
            this.textBox.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Enabled = false;
            this.vScrollBar1.LargeChange = 1;
            this.vScrollBar1.Location = new System.Drawing.Point(19, 24);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 177);
            this.vScrollBar1.TabIndex = 3;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(41, 306);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(104, 20);
            this.textBoxPass.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sign in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(41, 280);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(104, 20);
            this.textBoxFileName.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Open File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelPassError
            // 
            this.labelPassError.AutoSize = true;
            this.labelPassError.Location = new System.Drawing.Point(145, 179);
            this.labelPassError.Name = "labelPassError";
            this.labelPassError.Size = new System.Drawing.Size(0, 13);
            this.labelPassError.TabIndex = 10;
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(41, 200);
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(104, 45);
            this.trackBar.TabIndex = 11;
            this.trackBar.Value = 1;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // labelForTrack
            // 
            this.labelForTrack.AutoSize = true;
            this.labelForTrack.Location = new System.Drawing.Point(145, 204);
            this.labelForTrack.Name = "labelForTrack";
            this.labelForTrack.Size = new System.Drawing.Size(27, 13);
            this.labelForTrack.TabIndex = 12;
            this.labelForTrack.Text = "stap";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 378);
            this.Controls.Add(this.labelForTrack);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.labelPassError);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.buttonShow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelPassError;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label labelForTrack;
    }
}

