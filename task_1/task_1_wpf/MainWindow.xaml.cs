using System;
using System.Collections.Generic;
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
using StringFormatLibrary;
using System.IO;
using Microsoft.Win32;

namespace task_1_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary> 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextBoxReader.Text = string.Empty;
            TextBoxReader.Text = StringFormatter.FormatAllText(TextBoxWriter.Text, "Неверный формат");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TextBoxReader.Text = string.Empty;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "Document";
            dlg.DefaultExt = ".txt"; 
            dlg.Filter = "Text documents (.txt)|*.txt";

            bool? result = dlg.ShowDialog(); 

            if (result == true) 
            {
                TextBoxReader.Text = StringFormatter.FormatAllTextFromFile(dlg.FileName, "Неверный формат");
            }
            
        }
    }
}
