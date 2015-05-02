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
using MyMathLibrary;

namespace task_2_wpf
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
            double number, rootOfNumber;

            if (double.TryParse(TextBoxWriter.Text, out number) && double.TryParse(TextBoxForRoot.Text, out rootOfNumber))
            {
                TextBoxReader.Text = MyMath.GetRootOfNumber(number, rootOfNumber).ToString();                 
            }
            else
            {
                TextBoxReader.Text = "Введено неверное значение!";
            }

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int number;
            if (int.TryParse(TextBoxWriter.Text, out number))
            {
                TextBoxReader.Text = Convert.ToString(number, 2);                
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double number, rootOfNumber, difference;

            if (double.TryParse(TextBoxWriter.Text, out number) && double.TryParse(TextBoxForRoot.Text, out rootOfNumber))
            {
                TextBoxReader.Text = MyMath.GetRootOfNumberWithDifference(number, rootOfNumber, out difference).ToString() + "\nРазница в скорости: " + difference;
            }
            else
            {
                TextBoxReader.Text = "Введено неверное значение!";
            }
        }
    }
}
