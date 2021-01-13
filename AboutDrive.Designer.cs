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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblDriveCapacityValue = new System.Windows.Forms.Label();
            this.lblDriveLetter = new System.Windows.Forms.Label();
            this.lblDriveLetterValue = new System.Windows.Forms.Label();
            this.lblDriveCapacity = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.chkBox = new System.Windows.Forms.CheckBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDriveCapacityValue
            // 
            this.lblDriveCapacityValue.AutoSize = true;
            this.lblDriveCapacityValue.Location = new System.Drawing.Point(84, 26);
            this.lblDriveCapacityValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriveCapacityValue.Name = "lblDriveCapacityValue";
            this.lblDriveCapacityValue.Size = new System.Drawing.Size(16, 17);
            this.lblDriveCapacityValue.TabIndex = 14;
            this.lblDriveCapacityValue.Text = "0";
            // 
            // lblDriveLetter
            // 
            this.lblDriveLetter.AutoSize = true;
            this.lblDriveLetter.Location = new System.Drawing.Point(165, 26);
            this.lblDriveLetter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriveLetter.Name = "lblDriveLetter";
            this.lblDriveLetter.Size = new System.Drawing.Size(49, 17);
            this.lblDriveLetter.TabIndex = 17;
            this.lblDriveLetter.Text = "Letter:";
            // 
            // lblDriveLetterValue
            // 
            this.lblDriveLetterValue.AutoSize = true;
            this.lblDriveLetterValue.Location = new System.Drawing.Point(241, 26);
            this.lblDriveLetterValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriveLetterValue.Name = "lblDriveLetterValue";
            this.lblDriveLetterValue.Size = new System.Drawing.Size(0, 17);
            this.lblDriveLetterValue.TabIndex = 18;
            this.lblDriveLetterValue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AboutDrive_MouseClick);
            // 
            // lblDriveCapacity
            // 
            this.lblDriveCapacity.AutoSize = true;
            this.lblDriveCapacity.Location = new System.Drawing.Point(4, 27);
            this.lblDriveCapacity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriveCapacity.Name = "lblDriveCapacity";
            this.lblDriveCapacity.Size = new System.Drawing.Size(70, 17);
            this.lblDriveCapacity.TabIndex = 13;
            this.lblDriveCapacity.Text = "Capacity: ";
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.White;
            this.groupBox.Controls.Add(this.chart);
            this.groupBox.Controls.Add(this.chkBox);
            this.groupBox.Controls.Add(this.lblDriveCapacity);
            this.groupBox.Controls.Add(this.lblDriveLetterValue);
            this.groupBox.Controls.Add(this.lblDriveLetter);
            this.groupBox.Controls.Add(this.lblDriveCapacityValue);
            this.groupBox.Location = new System.Drawing.Point(4, 4);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(416, 277);
            this.groupBox.TabIndex = 22;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Drive Info";
            // 
            // chkBox
            // 
            this.chkBox.AutoCheck = false;
            this.chkBox.AutoSize = true;
            this.chkBox.Location = new System.Drawing.Point(311, 25);
            this.chkBox.Margin = new System.Windows.Forms.Padding(4);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(85, 21);
            this.chkBox.TabIndex = 21;
            this.chkBox.Text = "Tracking";
            this.chkBox.UseVisualStyleBackColor = true;
            this.chkBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AboutDrive_MouseClick);
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(8, 47);
            this.chart.Margin = new System.Windows.Forms.Padding(4);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(395, 223);
            this.chart.TabIndex = 19;
            this.chart.Text = "chart1";
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // AboutDrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AboutDrive";
            this.Size = new System.Drawing.Size(420, 279);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AboutDrive_MouseClick);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDriveCapacityValue;
        private System.Windows.Forms.Label lblDriveLetter;
        public System.Windows.Forms.Label lblDriveLetterValue;
        private System.Windows.Forms.Label lblDriveCapacity;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        public System.Windows.Forms.CheckBox chkBox;
    }
}
