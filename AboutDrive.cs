﻿using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace DriveTracker
{
    public partial class AboutDrive : UserControl
    {
        public DriveAndRule DriveAndRule { get; set; }
        public TrackInfo TrackInfo;

        public AboutDrive()
        {
            InitializeComponent();
        }

        public AboutDrive(DriveAndRule driveAndRule)
        {
            DriveAndRule = driveAndRule;

            InitializeComponent();
            TrackInfo = new TrackInfo(this);
            chkBox.Checked = DriveAndRule.IsTracking;


            lblDriveCapacityValue.Text = Tools.SizeSuffixString(DriveAndRule.DriveSize);
            lblDriveLetterValue.Text = DriveAndRule.DriveName;

            DrawSeries();
        }


        private void AboutDrive_MouseClick(object sender, MouseEventArgs e)
        {
            //Окно информации о диске
            TrackInfo.ShowDialog();
            chkBox.Checked = DriveAndRule.IsTracking;
        }

        //Изображение диаграммы
        public void DrawSeries()
        {
            chart.Series.Clear();
            chart.Legends[0].Alignment = StringAlignment.Center;

            Series series = new Series
            {
                IsVisibleInLegend = true,
                ChartType = SeriesChartType.Pie
            };

            series.Font = new Font(FontFamily.GenericSerif, 14, FontStyle.Bold);

            chart.Series.Add(series);

            series.Points.Add(DriveAndRule.DriveFreeSpace);
            series.Points.Add(DriveAndRule.DriveUsedSpace);
            series.Points[0].Color = Color.DarkGray;
            series.Points[1].Color = Color.DarkCyan;

            DataPoint p1 = series.Points[0];
            p1.AxisLabel = Tools.SizeSuffixString((DriveAndRule.DriveFreeSpace));
            p1.LegendText = "Свободно";

            DataPoint p2 = series.Points[1];
            p2.AxisLabel = Tools.SizeSuffixString(DriveAndRule.DriveUsedSpace);
            p2.LegendText = "Используется";

            chart.Invalidate();
        }

        private void chart_Click(object sender, System.EventArgs e)
        {
            chart.SaveImage("myChart.png", format: ChartImageFormat.Png);
        }

        private void AboutDrive_Load(object sender, System.EventArgs e)
        {

        }

        private void chart_Click_1(object sender, System.EventArgs e)
        {
            chart.SaveImage("resultChart.png",ChartImageFormat.Png);
        }
    }
}
