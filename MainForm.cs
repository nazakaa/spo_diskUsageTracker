using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;


namespace DriveTracker
{
    public partial class MainForm : Form
    {
        private System.Drawing.Size Max;
        private List<DriveAndRule> drivesAndRules;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            drivesAndRules = new List<DriveAndRule>();

            //Занесение дисков в список
            foreach (DriveInfo drive in DriveInfo.GetDrives())
                if (drive.IsReady)
                    drivesAndRules.Add(new DriveAndRule(drive));

            //Создание графического представления диска и размещение его на форме
            foreach (DriveAndRule data in drivesAndRules)
            {
                data.representaition = new AboutDrive(data);
                tableLayoutPanel.Controls.Add(data.representaition);
            }
                
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //Обновление информации, проверка контроля и удаление неактуальных диков
            bool IsExist;
            for (int i = drivesAndRules.Count - 1;i>= 0; i--)
            {
                IsExist = false;

                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    if (drive.IsReady && drivesAndRules[i].DriveName == drive.Name)
                    {
                        //Проверка наличия диска и обновление данных
                        IsExist = true;
                        drivesAndRules[i].Update(drive);
                    }
                }

                //Проверка контроля
                if (drivesAndRules[i].isTracking && drivesAndRules[i].trackingAmount < drivesAndRules[i].DriveUsedSpace)
                {
                    //Проверка наличия окна о диске
                    if (!drivesAndRules[i].representaition.track.IsDisposed)
                        drivesAndRules[i].representaition.track.Dispose();

                    //Остановка контроля и вывод соосбщения
                    drivesAndRules[i].isTracking = false;
                    MessageBox.Show($"Drive {drivesAndRules[i].DriveName} memory tracking rule overwlow", "Warning");
                    drivesAndRules[i].trackingAmount = 0;
                    drivesAndRules[i].representaition.chkBox.Checked = false;
                }

                //Удаление неактуальных диков
                if (!IsExist)
                {
                    //Проверка наличия окна о диске
                    if (!drivesAndRules[i].representaition.track.IsDisposed)
                        drivesAndRules[i].representaition.track.Dispose();

                    //Уничтожение графического представления и элемента списка
                    drivesAndRules[i].representaition.Dispose();
                    drivesAndRules.RemoveAt(i);
                }
            }

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                //Поиск новых дисков
                IsExist = false;
                foreach (DriveAndRule data in drivesAndRules)
                    if (drive.IsReady && data.DriveName == drive.Name)
                        IsExist = true;

                //Добавление новых дисков
                if (!IsExist)
                {
                    drivesAndRules.Add(new DriveAndRule(drive));
                    drivesAndRules[drivesAndRules.Count-1].representaition = new AboutDrive(drivesAndRules[drivesAndRules.Count - 1]);
                    tableLayoutPanel.Controls.Add(drivesAndRules[drivesAndRules.Count - 1].representaition);
                }
            }
        }

        //Управление размером фомы в зависимости от количества содержимого
        private void tableLayoutPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            if (drivesAndRules.Count <= 4)
            {
                Size = new System.Drawing.Size(tableLayoutPanel.Width, tableLayoutPanel.Height);
                Max = Size;
            }
            else
            {
                MaximumSize = Max;
            }

        }
    }
}
