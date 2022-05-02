using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TestWinfromsFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog.Filter = "RR intervals|*.rr";
            openFileDialog.FileName = null;

            InitDataChart();
            InitFourierChart();
        }

        private void InitDataChart()
        {
            var title = new Title("Входные данные")
            {
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            chartData.Titles.Add(title);
            chartData.Legends.Clear();

            var graph = chartData.Series[0];
            graph.ChartType = SeriesChartType.Line;
            graph.MarkerStyle = MarkerStyle.Circle;

            var area = chartData.ChartAreas[0];
            area.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            var font = new Font("Arial", 12);
            area.AxisY.TitleFont = font;
            area.AxisX.TitleFont = font;
            area.AxisY.Title = "RR интервал, с";
            area.AxisX.Title = "Номер итервала";
            area.AxisX.ScaleView.Zoomable = true;
            area.CursorX.AutoScroll = true;
            area.CursorX.IsUserSelectionEnabled = true;
        }

        private void InitFourierChart()
        {
            var title = new Title("Спектр Фурье")
            {
                Font = new Font("Arial", 12, FontStyle.Bold)
            };
            chartFourier.Titles.Add(title);
            chartFourier.Legends.Clear();

            var graph = chartFourier.Series[0];
            graph.ChartType = SeriesChartType.Column;

            var area = chartFourier.ChartAreas[0];
            area.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            area.AxisX.LabelStyle.Format = "{0.00}";
            var font = new Font("Arial", 12);
            area.AxisY.TitleFont = font;
            area.AxisX.TitleFont = font;
            area.AxisY.Title = "Мощность, мс²";
            area.AxisX.Title = "Частота, Гц";


            var sline1 = new StripLine
            {
                IntervalOffset = -0.01,
                StripWidth = 0.05,
                Text = "VLF",
                Font = new Font("Arial", 12),
                TextOrientation = TextOrientation.Horizontal,
                Interval = 0.0,
                BackColor = Color.LightGray
            };
            var sline2 = new StripLine
            {
                IntervalOffset = 0.04,
                StripWidth = 0.11,
                Text = "LF",
                Font = new Font("Arial", 12),
                TextOrientation = TextOrientation.Horizontal,
                Interval = 0.0,
                BackColor = Color.Gold
            };

            var sline3 = new StripLine
            {
                IntervalOffset = 0.15,
                StripWidth = 0.25,
                Text = "HF",
                Font = new Font("Arial", 12),
                TextOrientation = TextOrientation.Horizontal,
                Interval = 0.0,
                BackColor = Color.Plum
            };
            area.AxisX.StripLines.Add(sline1);
            area.AxisX.StripLines.Add(sline2);
            area.AxisX.StripLines.Add(sline3);
        }

        private int[] ReadData(string filename)
        {
            using (var reader = new StreamReader(filename))
            {
                var list = new List<int>();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line.StartsWith(";"))
                        continue;
                    list.Add(int.Parse(line));
                }
                return list.ToArray();
            }
        }

        private async void ChooseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            int[] points;
            try
            {
                points = ReadData(openFileDialog.FileName);
            }
            catch (Exception)
            {
                MessageBox.Show("Файл имел неверный формат!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            chartData.Series[0].Points.Clear();
            chartFourier.Series[0].Points.Clear();
            foreach (var point in points)
                chartData.Series[0].Points.AddY(point);

            double[] fs, ps;
            var startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                CreateNoWindow = true,
                Arguments = String.Format("/C python script.py {0}", String.Join(" ", points)),
                UseShellExecute = false,
                RedirectStandardOutput = true
            };
            await Task.Run(() =>
            {
                using (Process process = Process.Start(startInfo))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        var arr = reader.ReadLine().Split(' ');
                        Array.Resize(ref arr, arr.Length - 1);
                        fs = arr.Select(f => double.Parse(f, CultureInfo.InvariantCulture)).ToArray();

                        reader.ReadLine();
                        arr = reader.ReadLine().Split(' ');
                        Array.Resize(ref arr, arr.Length - 1);
                        ps = arr.Select(p => double.Parse(p, CultureInfo.InvariantCulture)).ToArray();
                    }
                }
                double sumVLF = 0, sumLF = 0, sumHF = 0, sum = 0;
                for (int i = 0; i < fs.Length; i++)
                {
                    if (fs[i] <= 0.4)
                        sum += ps[i];
                    if (fs[i] <= 0.04)
                        sumVLF += ps[i];
                    if (0.04 <= fs[i] && fs[i] <= 0.15)
                        sumLF += ps[i];
                    if (0.15 <= fs[i] && fs[i] <= 0.4)
                        sumHF += ps[i];
                }
                double lfp = sumLF / (sum - sumVLF);
                double hfp = sumHF / (sum - sumVLF);
                Invoke(new Action(() =>
                {
                    labelVLF.Text = sumVLF.ToString("0.00 мс²");
                    labelLF.Text = sumLF.ToString("0.00 мс²");
                    labelHF.Text = sumHF.ToString("0.00 мс²");
                    labelSum.Text = sum.ToString("0.00 мс²");
                    labelLFP.Text = lfp.ToString("P");
                    labelHFP.Text = hfp.ToString("P");

                    if (lfp < 0.63)
                        stressPanel.BackColor = Color.Green;
                    else if (lfp < 0.7)
                        stressPanel.BackColor = Color.Yellow;
                    else
                        stressPanel.BackColor = Color.Red;

                    for (int i = 0; i < fs.Length; i++)
                        chartFourier.Series[0].Points.AddXY(fs[i], ps[i]);
                }));
            });
        }

        private void Chart_MouseMove(object sender, MouseEventArgs e)
        {
            var chart = sender as Chart;
            if (chart.Series[0].Points.Count == 0)
                return;
            var pos = e.Location;
            if (chart.Name == "chartData")
                chart.ChartAreas[0].CursorX.SetCursorPixelPosition(pos, true);
            var results = chart.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint);

            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var prop = result.Object as DataPoint;
                    if (chart.Name == "chartData")
                        chart.Series[0].ToolTip = String.Format("{0} c", prop.YValues[0]);
                    else
                        chart.Series[0].ToolTip = String.Format("{0:0.000} Гц\n{1:0.000} мс²", prop.XValue, prop.YValues[0]);
                }
            }
        }

        private void Panel2_Resize(object sender, EventArgs e)
        {
            chartData.Size = new Size(panel2.Width, panel2.Height / 2);
            chartFourier.Size = new Size(panel2.Width, panel2.Height / 2);
        }
    }
}
