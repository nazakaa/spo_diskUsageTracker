using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DriveTracker
{
    public partial class TrackInfo : Form
    {
        private readonly BindingSource _bindingSuffix = new BindingSource();
        private readonly AboutDriveRepresentation _aboutDriveRepresentation;

        private void TrackInfo_Load(object sender, EventArgs e)
        {
            lblLetterValue.Text = _aboutDriveRepresentation.DriveAndRule.DriveName;
            chkBox.Checked = _aboutDriveRepresentation.DriveAndRule.IsTracking;

            _bindingSuffix.DataSource = Tools.SizeSuffixes;
            comboBox.DataSource = _bindingSuffix;
            txtBox.Text = null;

            if (chkBox.Checked)
            {
                lblAmountValue.Visible = true;
                lblAmount.Visible = true;
                lblAmountValue.Text = Tools.ConvertFromBytes(_aboutDriveRepresentation.DriveAndRule.TrackingAmount);
            }
            else
            {
                lblAmountValue.Visible = false;
                lblAmount.Visible = false;
            }
        }

        private void BtnTrack_Click(object sender, EventArgs e)
        {
            long value;

            //Проверка корректности ввода
            if (!long.TryParse(txtBox.Text, out value))
            {
                MessageBox.Show("Введите корректное значение", "Warning");
                return;
            }

            // если проценты
            if (comboBox.SelectedIndex == 0)
            {
                if (value <= 0 || value > 100)
                {
                    MessageBox.Show("Значение процентов может быть от 0 до 100",
                        "Warning");
                    return;
                }
                if ((long)(_aboutDriveRepresentation.DriveAndRule.DriveSize * ((double)value / 100)) < 
                    (_aboutDriveRepresentation.DriveAndRule.DriveSize - _aboutDriveRepresentation.DriveAndRule.DriveFreeSpace))
                {
                    MessageBox.Show("Объем отслеживаемого пространства меньше," +
                                    " чем объем используемого", "Warning");
                    return;
                }

                _aboutDriveRepresentation.DriveAndRule.TrackingAmount = 
                    (long)(_aboutDriveRepresentation.DriveAndRule.DriveSize * ((double)value / 100));
                _aboutDriveRepresentation.DriveAndRule.IsTracking = true;
                _aboutDriveRepresentation.chkBox.Checked = _aboutDriveRepresentation.DriveAndRule.IsTracking;
            }
            else // если байты
            {
                long valueInBytes = Tools.ConvertToBytes(comboBox.SelectedIndex, value);

                if (value <= 0 ||
                    valueInBytes >= _aboutDriveRepresentation.DriveAndRule.DriveSize)
                {
                    MessageBox.Show("Значение дожно быть больше 0 и меньше размера диска",
                        "Warning");
                    return;
                }
                if (valueInBytes <= _aboutDriveRepresentation.DriveAndRule.DriveUsedSpace)
                {
                    MessageBox.Show("Объем отслеживаемого пространства должен быть больше," +
                                    " чем объем используемого", "Warning");
                    return;
                }

                _aboutDriveRepresentation.DriveAndRule.TrackingAmount = valueInBytes;
                _aboutDriveRepresentation.DriveAndRule.IsTracking = true;
                _aboutDriveRepresentation.chkBox.Checked = _aboutDriveRepresentation.DriveAndRule.IsTracking;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //Сброс контроля
            _aboutDriveRepresentation.DriveAndRule.IsTracking = false;
            _aboutDriveRepresentation.DriveAndRule.TrackingAmount = 0;
            _aboutDriveRepresentation.chkBox.Checked = _aboutDriveRepresentation.DriveAndRule.IsTracking;
        }


        private void TableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public TrackInfo()
        {
            InitializeComponent();
        }
        public TrackInfo(AboutDriveRepresentation ctrl)
        {
            InitializeComponent();
            _aboutDriveRepresentation = ctrl;
        }
    }

}
