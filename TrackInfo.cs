using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace DriveTracker
{
    public partial class TrackInfo : Form
    {
        private readonly BindingSource _bindingSuffix = new BindingSource();
        private readonly AboutDrive _about;

        private void TrackInfo_Load(object sender, EventArgs e)
        {
            List<string> tmp = new List<string>(Tools.SizeSuffixes);

            lblLetterValue.Text = _about.DriveAndRule.DriveName;
            chkBox.Checked = _about.DriveAndRule.IsTracking;
            _bindingSuffix.DataSource = tmp;
            comboBox.DataSource = _bindingSuffix;
            txtBox.Text = null;

            if (chkBox.Checked)
            {
                lblAmountValue.Visible = true;
                lblAmount.Visible = true;
                lblAmountValue.Text = Tools.SizeSuffixString(_about.DriveAndRule.TrackingAmount);
            }
            else
            {
                lblAmountValue.Visible = false;
                lblAmount.Visible = false;
            }
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            long tmp;
            //Проверка корректности ввода
            if (!long.TryParse(txtBox.Text, out tmp))
            {
                MessageBox.Show("Введите корректное значение", "Warning");
                return;
            }
            //Определение контрольного значения
            if (comboBox.SelectedIndex == 0)
            {
                if (tmp <= 0 || tmp > 100)
                {
                    MessageBox.Show("Значение процентов может быть от 0 до 100", "Warning");
                    return;
                }
                if ((long)(_about.DriveAndRule.DriveSize * ((double)tmp / 100)) < (_about.DriveAndRule.DriveSize - _about.DriveAndRule.DriveFreeSpace))
                {
                    MessageBox.Show("Объем отслеживаемого пространства меньше, чем объем используемого", "Warning");
                    return;
                }

                _about.DriveAndRule.TrackingAmount = (long)(_about.DriveAndRule.DriveSize * ((double)tmp / 100));
                _about.DriveAndRule.IsTracking = true;
                _about.chkBox.Checked = _about.DriveAndRule.IsTracking;
            }
            else
            {
                if (tmp <= 0 || Tools.RawData(comboBox.SelectedIndex, tmp) >= _about.DriveAndRule.DriveSize)
                {
                    MessageBox.Show("Значение процентов может быть больше 0", "Warning");
                    return;
                }
                if (Tools.RawData(comboBox.SelectedIndex, tmp) <= _about.DriveAndRule.DriveUsedSpace)
                {
                    MessageBox.Show("Объем отслеживаемого пространства меньше, чем объем используемого", "Warning");
                    return;
                }
                _about.DriveAndRule.TrackingAmount = Tools.RawData(comboBox.SelectedIndex, tmp);
                _about.DriveAndRule.IsTracking = true;
                _about.chkBox.Checked = _about.DriveAndRule.IsTracking;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Сброс контроля
            _about.DriveAndRule.IsTracking = false;
            _about.DriveAndRule.TrackingAmount = 0;
            _about.chkBox.Checked = _about.DriveAndRule.IsTracking;
        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public TrackInfo()
        {
            InitializeComponent();
        }

        public TrackInfo(AboutDrive ctrl)
        {
            InitializeComponent();
            _about = ctrl;
        }
    }
}
