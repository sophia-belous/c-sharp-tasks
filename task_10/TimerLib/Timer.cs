using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TimerLib
{
    public delegate void TickHandler(object sender, TickEventArgs e);
    public delegate void CompleteHandler(object sender, EventArgs e);


    public class Timer        
    {
        public event TickHandler Tick;
        public event CompleteHandler CompletedTick;
        public bool IsBusy
        {
            get
            {
                return bw.IsBusy;
            }
        }

        private BackgroundWorker bw = new BackgroundWorker();

        public Timer()
        {
            bw.DoWork += bw_DoWork;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            bw.WorkerReportsProgress = false;
            bw.WorkerSupportsCancellation = true;
        }

        public void Start(int seconds)
        {
            if (bw.IsBusy != true)
                bw.RunWorkerAsync(seconds);
        }

        public void Stop()
        {
            if (bw.WorkerSupportsCancellation == true)
                bw.CancelAsync();
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (CompletedTick != null)
                CompletedTick(this, new EventArgs());
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
             BackgroundWorker worker = sender as BackgroundWorker;

             for (int i = 1; i <= (int)e.Argument; i++)
             {
                 if ((worker.CancellationPending == true))
                 {
                     e.Cancel = true;
                     break;
                 }
                 else
                 {
                     System.Threading.Thread.Sleep(1000);
                     Tick(this, new TickEventArgs((int)e.Argument - i));
                 }
             }
        }
    }

    public class TickEventArgs : EventArgs
    {
        public int SecondsLeft { get; private set; }

        public TickEventArgs(int seconds)
        {
            SecondsLeft = seconds;
        }
    }
}
