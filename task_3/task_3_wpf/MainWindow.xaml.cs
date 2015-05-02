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
using LibraryOfGetNODMethods;

namespace task_3_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ColumnChart.Opacity = 0;
            BarChart.Opacity = 0;
        }

        enum OrientationOfHistogram
        {
            Vertical,
            Horizontal
        };

        private void ShowHistogram(double speedOfWorkFirst, double speedOfWorkSecond, OrientationOfHistogram orientation = OrientationOfHistogram.Horizontal)
        {
            List<KeyValuePair<string, double>> values = new List<KeyValuePair<string, double>>();
            values.Add(new KeyValuePair<string, double>("Evclide", speedOfWorkFirst));
            values.Add(new KeyValuePair<string, double>("Stain", speedOfWorkSecond));

            if (orientation == OrientationOfHistogram.Horizontal)
            {
                BarChart.Opacity = 1;
                BarChart.DataContext = values;
                ColumnChart.Opacity = 0;
            }
            else
            {
                ColumnChart.Opacity = 1;
                ColumnChart.DataContext = values;
                BarChart.Opacity = 0;
            }
            
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double speedOfWorkEvclide, speedOfWorkStain;
            int[] numbers = TextBoxWriter.Text.Split().Select(int.Parse).ToArray();
            TextBoxReader.Text = NODGetting.GetNODWithEvclideAndSpeedWork(out speedOfWorkEvclide, numbers).ToString();
            NODGetting.GetNODWithStainAndSpeedWork(out speedOfWorkStain, numbers);

            ShowHistogram(speedOfWorkEvclide, speedOfWorkStain, OrientationOfHistogram.Vertical);

        }
         
    }
}
