using System;
using System.IO;
using System.Windows.Forms;

namespace DriveTracker
{
    static class Tools
    {
        //Определенные размеры
        public static string[] SizeSuffixes = { "percents", "bytes", "KB", "MB", "GB", "TB",
            "PB", "EB", "ZB", "YB" };

        //Получение оптимальной приставки для байтов
        public static string ConvertFromBytes(long value)
        {
            if (value < 0) { return "-" + ConvertFromBytes(-value); }
            if (value == 0) { return "0.0 bytes"; }

            int mag = (int)Math.Log(value, 1024);
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));
            return $"{adjustedSize:n1} {SizeSuffixes[mag + 1]}";
        }

        //Перевод из определенного размера в байты
        public static long ConvertToBytes(int index, long value)
        {
            index--; 
            long adjustedSize = value * (1L << (index * 10));
            return adjustedSize;
        }

        public static long UsedSpace(this DriveInfo drive)
        {
            return (drive.TotalSize - drive.TotalFreeSpace);
        }
    }
}
