using StreamLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_6_winform
{
    public partial class Form1 : Form
    {
        private FileStreamReader _myStream;
        private OpenFileDialog dlg = new OpenFileDialog();
        private byte[] bytes;
        public Form1()
        {
            InitializeComponent();
            buttonShow.Enabled = false;
            textBox.Enabled = false;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            vScrollBar1.Value = 0;
            textBox.Text = String.Empty;
            label1.Text = String.Empty;
            
            vScrollBar1.Enabled = true;
            textBox.Enabled = true;
            vScrollBar1.Maximum = (int)_myStream.Length / trackBar.Value;
            bytes = new byte[trackBar.Value];
        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {
            if (e.NewValue <= e.OldValue)
            {
                return;
            }

            textBox.Text += _myStream.ReadString(bytes, vScrollBar1.Minimum, trackBar.Value);
            label1.Text = _myStream.ReadedPercent.ToString();            
        }

        private bool IsTruePass()
        {
            if (dlg.FileName == "E:\\file1.txt") 
            {
                _myStream = new FileStreamReader(dlg.FileName, "pass1");
            }
            else if (dlg.FileName == "E:\\file2.txt") 
            {
                _myStream = new FileStreamReader(dlg.FileName, "pass2");
            }
            else if (dlg.FileName == "E:\\file3.txt") 
            {
                _myStream = new FileStreamReader(dlg.FileName, "");
            }
            else
            {
                return false;
            }

            if (_myStream.Password == textBoxPass.Text)
            {
                return true;
            }

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {          

            if (IsTruePass())
            {
                buttonShow.Enabled = true;
            }
            else
	        {
                labelPassError.Text = "Wrong Pass";
                buttonShow.Enabled = false;
	        }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonShow.Enabled = false;
            vScrollBar1.Enabled = true;
            dlg.FileName = "Document";
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (.txt)|*.txt";

            dlg.ShowDialog();
            textBoxFileName.Text = dlg.FileName;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            labelForTrack.Text = trackBar.Value.ToString();
        }
    }
}
