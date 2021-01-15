using System.IO;

namespace DriveTracker
{
    public class DriveAndRule
    {
        public DriveInfo Drive {  get; set; }
        public bool IsTracking { get; set; }
        public long TrackingAmount { get; set; }
        public AboutDriveRepresentation Representation { get; set; }

        //Получить имя диска
        public string DriveName => Drive.Name;

        //Получить свободное место диска
        public long DriveFreeSpace => Drive.TotalFreeSpace;

        //Получить размер диска
        public long DriveSize => Drive.TotalSize;

        //Получить занятое место на диске
        public long DriveUsedSpace => Tools.UsedSpace(Drive);

        //Обновить диск и отображение
        public void Update(DriveInfo driveInfo)
        {
            Drive = driveInfo;
            Representation.DrawSeries();
        }


        public DriveAndRule(DriveInfo d)
        {
            Drive = d;
            IsTracking = false;
            TrackingAmount = 0;
            Representation = null;
        }
    }

}
