using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace DriveTracker
{
    public partial class TrackInfo : Form
    {
       
        private BindingSource bindingSuffix = new BindingSource();
        private AboutDrive about;
        public TrackInfo()
        {
            InitializeComponent();
        }

        public TrackInfo( AboutDrive ctrl)
        {
            InitializeComponent();

            about = ctrl;

        }

        private void TrackInfo_Load(object sender, EventArgs e)
        {
            List<string> tmp = new List<string>(Tools.SizeSuffixes);


            lblLetterValue.Text = about.driveAndRule.DriveName;
            chkBox.Checked = about.driveAndRule.isTracking;
            bindingSuffix.DataSource = tmp;
            comboBox.DataSource = bindingSuffix;
            txtBox.Text = null;

            if (chkBox.Checked)
            {
                lblAmountValue.Visible = true;
                lblAmount.Visible = true;
                lblAmountValue.Text = Tools.SizeSuffixString(about.driveAndRule.trackingAmount);
            }
            else
            {
                lblAmountValue.Visible = false;
                lblAmount.Visible = false;

            }
        }

        private void bttnTrack_Click(object sender, EventArgs e)
        {
            Int64 tmp;
            //Проверка корректности ввода
            if (!Int64.TryParse(txtBox.Text, out tmp))
            {
                MessageBox.Show("Input correct value", "Warning");
                return;
            }
            //Определение контрольного значения
            if (comboBox.SelectedIndex == 0)
            {
                if (tmp <= 0 || tmp > 100)
                {
                    MessageBox.Show("Percents must be between 0 and 100", "Warning");
                    return;
                }
                if ((Int64)(about.driveAndRule.DriveSize * ((double)tmp / 100)) < (about.driveAndRule.DriveSize - about.driveAndRule.DriveFreeSpace))
                {
                    MessageBox.Show("Tracking amount less then used space", "Warning");
                    return;
                }

                about.driveAndRule.trackingAmount = (Int64)(about.driveAndRule.DriveSize * ((double)tmp / 100));
                about.driveAndRule.isTracking = true;
                about.chkBox.Checked = about.driveAndRule.isTracking;
            }
            else
            {
                if (tmp <= 0 || Tools.RawData(comboBox.SelectedIndex, tmp) >= about.driveAndRule.DriveSize)
                {
                    MessageBox.Show("Value must be between 0 and Capacity", "Warning");
                    return;
                }
                if (Tools.RawData(comboBox.SelectedIndex, tmp) <= about.driveAndRule.DriveUsedSpace)
                {
                    MessageBox.Show("Tracking amount less then used space", "Warning");
                    return;
                }
                about.driveAndRule.trackingAmount = Tools.RawData(comboBox.SelectedIndex, tmp);
                about.driveAndRule.isTracking = true;
                about.chkBox.Checked = about.driveAndRule.isTracking;
            }
        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {
            //Сброс контроля
            about.driveAndRule.isTracking = false;
            about.driveAndRule.trackingAmount = 0;
            about.chkBox.Checked = about.driveAndRule.isTracking;
        }
    }
}
