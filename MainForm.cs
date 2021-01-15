using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;


namespace DriveTracker
{
    public partial class MainForm : Form
    {
        private System.Drawing.Size _maxSize;
        private List<DriveAndRule> _drivesAndRules;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _drivesAndRules = new List<DriveAndRule>();
            
            //Занесение дисков в список
            foreach (DriveInfo drive in DriveInfo.GetDrives())
                if (drive.IsReady)
                    _drivesAndRules.Add(new DriveAndRule(drive));

            //Создание графического представления диска и размещение его на форме
            foreach (DriveAndRule driveAndRule in _drivesAndRules)
            {
                driveAndRule.Representation = new AboutDrive(driveAndRule);
                tableLayoutPanel.Controls.Add(driveAndRule.Representation);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Обновление информации, проверка контроля и удаление неактуальных дисков
            bool IsExist;
            for (int i = _drivesAndRules.Count - 1; i>= 0; i--)
            {
                IsExist = false;
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.IsReady && _drivesAndRules[i].DriveName == drive.Name)
                    {
                        //Проверка наличия диска и обновление данных
                        IsExist = true;
                        _drivesAndRules[i].Update(drive);
                    }
                }

                //Проверка мониторинга
                if (_drivesAndRules[i].IsTracking && _drivesAndRules[i].TrackingAmount < _drivesAndRules[i].DriveUsedSpace)
                {
                    //Проверка наличия окна о диске
                    if (!_drivesAndRules[i].Representation.TrackInfo.IsDisposed)
                        _drivesAndRules[i].Representation.TrackInfo.Dispose();

                    //Остановка мониторинга и вывод соосбщения
                    _drivesAndRules[i].IsTracking = false;
                    MessageBox.Show($"Переполнение заданного правилом пространства диска {_drivesAndRules[i].DriveName}", "Warning");
                    _drivesAndRules[i].TrackingAmount = 0;
                    _drivesAndRules[i].Representation.chkBox.Checked = false;
                }

                //Удаление неактуальных диков
                if (!IsExist)
                {
                    //Проверка наличия окна о диске
                    if (!_drivesAndRules[i].Representation.TrackInfo.IsDisposed)
                        _drivesAndRules[i].Representation.TrackInfo.Dispose();

                    //Уничтожение графического представления и элемента списка
                    _drivesAndRules[i].Representation.Dispose();
                    _drivesAndRules.RemoveAt(i);
                }
            }

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                //Поиск новых дисков
                IsExist = false;
                foreach (DriveAndRule driveAndRule in _drivesAndRules)
                    if (drive.IsReady && driveAndRule.DriveName == drive.Name)
                        IsExist = true;

                //Добавление новых дисков
                if (!IsExist)
                {
                    _drivesAndRules.Add(new DriveAndRule(drive));
                    _drivesAndRules[_drivesAndRules.Count-1].Representation = new AboutDrive(_drivesAndRules[_drivesAndRules.Count - 1]);
                    tableLayoutPanel.Controls.Add(_drivesAndRules[_drivesAndRules.Count - 1].Representation);
                }
            }
        }

        //Управление размером фоpмы в зависимости от количества содержимого
        private void tableLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            if (_drivesAndRules.Count <= 4)
            {
                Size = new System.Drawing.Size(tableLayoutPanel.Width, tableLayoutPanel.Height);
                _maxSize = Size;
            }
            else
            {
                MaximumSize = _maxSize;
            }
        }
    }
}
