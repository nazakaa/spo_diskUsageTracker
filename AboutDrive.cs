using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace DriveTracker
{
    public partial class AboutDrive : UserControl
    {
        public DriveAndRule driveAndRule { get; set; }
        public TrackInfo track;

        public AboutDrive()
        {
            InitializeComponent();
        }

        public AboutDrive(DriveAndRule data)
        {
            driveAndRule = data;

            InitializeComponent();
            track = new TrackInfo(this);
            chkBox.Checked = driveAndRule.isTracking;

            chart.Titles.Clear();

            lblDriveCapacityValue.Text = Tools.SizeSuffixString(driveAndRule.DriveSize);
            lblDriveLetterValue.Text = driveAndRule.DriveName;

            DrawSeries();
        }


        private void AboutDrive_MouseClick(object sender, MouseEventArgs e)
        {
            //Окно информации о диске
            track.ShowDialog();
            chkBox.Checked = driveAndRule.isTracking;
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

            series.Points.Add(driveAndRule.DriveFreeSpace);
            series.Points.Add(driveAndRule.DriveUsedSpace);
            series.Points[0].Color = System.Drawing.Color.LightGray;
            series.Points[1].Color = System.Drawing.Color.DarkGray;

            DataPoint p1 = series.Points[0];
            p1.AxisLabel = Tools.SizeSuffixString((driveAndRule.DriveFreeSpace));
            p1.LegendText = "Свободно";

            DataPoint p2 = series.Points[1];
            p2.AxisLabel = Tools.SizeSuffixString(driveAndRule.DriveUsedSpace);
            p2.LegendText = "Используется";

            chart.Invalidate();
        }

        private void chart_Click(object sender, System.EventArgs e)
        {
            chart.SaveImage("myChart.png", format: ChartImageFormat.Png);
        }
    }
}
