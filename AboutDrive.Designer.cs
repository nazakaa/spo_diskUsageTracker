namespace DriveTracker
{
    partial class AboutDrive
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {

            if (disposing && (components != null))
            {

                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblDriveCapacity = new System.Windows.Forms.Label();
            this.lblDriveLetterValue = new System.Windows.Forms.Label();
            this.lblDriveLetter = new System.Windows.Forms.Label();
            this.lblDriveCapacityValue = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chkBox = new System.Windows.Forms.CheckBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.White;
            this.groupBox.Controls.Add(this.lblDriveCapacity);
            this.groupBox.Controls.Add(this.lblDriveLetterValue);
            this.groupBox.Controls.Add(this.lblDriveLetter);
            this.groupBox.Controls.Add(this.lblDriveCapacityValue);
            this.groupBox.Controls.Add(this.chkBox);
            this.groupBox.Controls.Add(this.chart);
            this.groupBox.Location = new System.Drawing.Point(4, 0);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(436, 302);
            this.groupBox.TabIndex = 22;
            this.groupBox.TabStop = false;
            // 
            // lblDriveCapacity
            // 
            this.lblDriveCapacity.AutoSize = true;
            this.lblDriveCapacity.Location = new System.Drawing.Point(19, 54);
            this.lblDriveCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriveCapacity.Name = "lblDriveCapacity";
            this.lblDriveCapacity.Size = new System.Drawing.Size(112, 17);
            this.lblDriveCapacity.TabIndex = 22;
            this.lblDriveCapacity.Text = "Емкость диска: ";
            this.lblDriveCapacity.UseWaitCursor = true;
            // 
            // lblDriveLetterValue
            // 
            this.lblDriveLetterValue.AutoSize = true;
            this.lblDriveLetterValue.Location = new System.Drawing.Point(158, 31);
            this.lblDriveLetterValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriveLetterValue.Name = "lblDriveLetterValue";
            this.lblDriveLetterValue.Size = new System.Drawing.Size(0, 17);
            this.lblDriveLetterValue.TabIndex = 25;
            this.lblDriveLetterValue.UseWaitCursor = true;
            // 
            // lblDriveLetter
            // 
            this.lblDriveLetter.AutoSize = true;
            this.lblDriveLetter.Location = new System.Drawing.Point(19, 29);
            this.lblDriveLetter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriveLetter.Name = "lblDriveLetter";
            this.lblDriveLetter.Size = new System.Drawing.Size(118, 17);
            this.lblDriveLetter.TabIndex = 24;
            this.lblDriveLetter.Text = "Название диска:";
            this.lblDriveLetter.UseWaitCursor = true;
            // 
            // lblDriveCapacityValue
            // 
            this.lblDriveCapacityValue.AutoSize = true;
            this.lblDriveCapacityValue.Location = new System.Drawing.Point(155, 55);
            this.lblDriveCapacityValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriveCapacityValue.Name = "lblDriveCapacityValue";
            this.lblDriveCapacityValue.Size = new System.Drawing.Size(16, 17);
            this.lblDriveCapacityValue.TabIndex = 23;
            this.lblDriveCapacityValue.Text = "0";
            this.lblDriveCapacityValue.UseWaitCursor = true;
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(22, 74);
            this.chart.Margin = new System.Windows.Forms.Padding(4);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(398, 220);
            this.chart.TabIndex = 19;
            this.chart.Text = "chart1";
            this.chart.Click += new System.EventHandler(this.chart_Click_1);
            // 
            // chkBox
            // 
            this.chkBox.AutoCheck = false;
            this.chkBox.AutoSize = true;
            this.chkBox.Location = new System.Drawing.Point(319, 273);
            this.chkBox.Margin = new System.Windows.Forms.Padding(4);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(109, 21);
            this.chkBox.TabIndex = 21;
            this.chkBox.Text = "Мониторинг";
            this.chkBox.UseVisualStyleBackColor = true;
            this.chkBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AboutDrive_MouseClick);
            // 
            // AboutDrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AboutDrive";
            this.Size = new System.Drawing.Size(441, 303);
            this.Load += new System.EventHandler(this.AboutDrive_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AboutDrive_MouseClick);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox;
        public System.Windows.Forms.CheckBox chkBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label lblDriveCapacity;
        public System.Windows.Forms.Label lblDriveLetterValue;
        private System.Windows.Forms.Label lblDriveLetter;
        private System.Windows.Forms.Label lblDriveCapacityValue;
    }
}
