using System;
using System.IO;


namespace DriveTracker
{
    static class Tools
    {
        //Определенные размеры
        public static string[] SizeSuffixes = { "percents", "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

        //Получение оптимальной присравки для байтов
        public static string SizeSuffixString(Int64 value)
        {
            if (value < 0) { return "-" + SizeSuffixString(-value); }
            if (value == 0) { return "0.0 bytes"; }

            int mag = (int)Math.Log(value, 1024);
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            return string.Format("{0:n1} {1}", adjustedSize, SizeSuffixes[mag + 1]);
        }

        //Перевод из определенного размера в байты
        public static long RawData(int index, Int64 value)
        {
            index--;
            long adjustedSize = value * (1L << (index * 10));
            return adjustedSize;
        }

        public static Int64 UsedSpace(this DriveInfo drive)
        {
            return (drive.TotalSize - drive.TotalFreeSpace);
        }
    }
}
