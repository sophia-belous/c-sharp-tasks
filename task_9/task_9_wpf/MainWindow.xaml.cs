using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using StreamLib;
using Microsoft.Win32;

namespace task_9_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private OpenFileDialog dlg = new OpenFileDialog();
        

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void CreateFileButton_Click(object sender, RoutedEventArgs e)
        {
            TextBoxForWrite.TextChanged -= TextBoxForWrite_TextChanged;
            dlg.FileName = "Document";
            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (.txt)|*.txt";

            dlg.ShowDialog();

            TextBoxForWrite.Text = File.ReadAllText(dlg.FileName);
            TextBoxForWrite.TextChanged += TextBoxForWrite_TextChanged;
        }

        private void TextBoxForWrite_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextChange tc = e.Changes.First();

            using (FileStreamReader fsr = new FileStreamReader(dlg.FileName))
            {
                string str = TextBoxForWrite.Text.Substring(tc.Offset);
                fsr.ChangeTextInFile(str, tc.Offset, tc.RemovedLength, tc.AddedLength);
            }
        }
    }
}
