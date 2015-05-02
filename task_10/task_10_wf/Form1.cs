using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace task_10_wf
{
    public partial class Form1 : Form
    {
        TimerLib.Timer timer;
        public Form1()
        {//добавить метод
            InitializeComponent();
            timer = new TimerLib.Timer();

            timer.Tick += (sender, e) => { label1.Text = e.SecondsLeft.ToString(); }; //Timer_OnTick
            timer.CompletedTick += (sender, e) => { MessageBox.Show("Completed"); }; //Timer_OnComleted
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int seconds;

            if (int.TryParse(SecondsTextBox.Text, out seconds) && timer.IsBusy != true)
            {
                timer.Start(seconds);
                label1.Text = SecondsTextBox.Text;
            }
            else
                label1.Text = "Uncorrect input";
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        //private void Timer_OnTick(object sender, TimerLib.TickEventArgs e)
        //{
        //    label1.Text = e.SecondsLeft.ToString();
        //}

        //private void Timer_OnComleted(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Completed");
        //}
    }
}
