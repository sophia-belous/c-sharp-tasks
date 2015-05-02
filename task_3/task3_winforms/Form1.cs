using LibraryOfGetNODMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace task3_winforms
{
    public partial class Form1 : Form
    {

        struct ChartData
        {
            public string SeriesName;
            public double Value;
        }

        public Form1()
        {
            InitializeComponent();
            ComboBox.DataSource = Enum.GetValues(typeof(ChartColorPalette));
            Chart.Series.Clear();
            OutputTextBox.ReadOnly = true;
            OutputTextBox.BackColor = System.Drawing.SystemColors.Window;
        }

        private void Calculate_button_Click(object sender, EventArgs e)
        {
            if (!IsInputValid())
            {
                OutputTextBox.Text = "Incorrect input";
                return;
            }
            Chart.Series.Clear();
            SeriesChartType seriesChartType = GetSeriesChartTypeFromRadioButtons();
            ChartColorPalette chartColorPalette = GetChartColorPaletteFromComboBox();
            ShowHistogram(GetValuesForChart(), seriesChartType, chartColorPalette);

        }

        private void Horizontal_Radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            SeriesChartType seriesChartType = GetSeriesChartTypeFromRadioButtons();
            for (int i = 0; i < Chart.Series.Count; i++)
            {
                Chart.Series[i].ChartType = seriesChartType;
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Chart.Palette = GetChartColorPaletteFromComboBox();
        }

        #region Private Methods
        private void ShowHistogram(ChartData[] dataArray, SeriesChartType seriesChartType = SeriesChartType.Column, ChartColorPalette chartColorPolette = ChartColorPalette.Pastel)
        {
            Chart.Palette = chartColorPolette;
            for (int i = 0; i < dataArray.Length; i++)
            {
                Series series = Chart.Series.Add(dataArray[i].SeriesName);
                series.Points.Add(dataArray[i].Value);
                series.ChartType = seriesChartType;
            }
        }

        private ChartData[] GetValuesForChart()
        {
            ChartData[] dataArray = new ChartData[2];
            dataArray[0].SeriesName = "Evclide";
            dataArray[1].SeriesName = "Stain";
            int[] numbers = InputTextBox.Text.Split().Select(int.Parse).ToArray();
            OutputTextBox.Text = NODGetting.GetNODWithEvclideAndSpeedWork(out dataArray[0].Value, numbers).ToString();
            NODGetting.GetNODWithStainAndSpeedWork(out dataArray[1].Value, numbers);
            return dataArray;
        }

        private SeriesChartType GetSeriesChartTypeFromRadioButtons()
        {
            return Horizontal_radiobutton.Checked ? SeriesChartType.Bar : SeriesChartType.Column;
        }

        private ChartColorPalette GetChartColorPaletteFromComboBox()
        {
            ChartColorPalette chartColorPalette;
            Enum.TryParse<ChartColorPalette>(ComboBox.SelectedValue.ToString(), out chartColorPalette);

            return chartColorPalette;
        }

        private bool IsInputValid()
        {
            string pattern = @"^(\d+\s)+\d+$";
            return Regex.IsMatch(InputTextBox.Text, pattern);
        }
        #endregion
    }
}
