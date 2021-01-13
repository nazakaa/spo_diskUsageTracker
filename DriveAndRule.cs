using System;
using System.IO;
using System.Windows.Forms;

namespace DriveTracker
{
    public class DriveAndRule
    {
        DriveInfo drive {  get; set; }
        public bool isTracking { get; set; }
        public Int64 trackingAmount { get; set; }
        public AboutDrive representaition { get; set; }

        public DriveAndRule(DriveInfo d)
        {
            drive = d;
            isTracking = false;
            trackingAmount = 0;
            representaition = null;
        }

        //Получить имя диска
        public string DriveName
        {
            get { return drive.Name; }
        }

        //Получить свободное место диска
        public Int64 DriveFreeSpace
        {
            get { return drive.TotalFreeSpace; }
        }

        //Получить размер диска
        public Int64 DriveSize
        {
            get { return drive.TotalSize; }
        }

        //Получить занятое место на диске
        public Int64 DriveUsedSpace
        {
            get { return Tools.UsedSpace(drive); }
        }

        //Обновить диск и отображение
        public void Update(DriveInfo data)
        {
            drive = data;
            representaition.DrawSeries();
        }
    }
}
