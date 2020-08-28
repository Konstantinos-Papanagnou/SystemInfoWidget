using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfoWidget.SystemInfo
{
    public class Disk
    {
        DriveInfo[] allDrives;
        public Disk()
        {
            allDrives = DriveInfo.GetDrives();
        }

        public bool CheckForUpdates(int drives)
        {
            return allDrives.Length != drives;
        }

        public int GetDiskCount()
        {
            return allDrives.Length;
        }

        public List<DriveLayout> GetDriveLayouts()
        {
            List<DriveLayout> layouts = new List<DriveLayout>();
            for(int i = 0; i < allDrives.Length; i++)
            {
                DriveType type = GetDriveType(i);

                if (type == DriveType.Fixed || type == DriveType.Removable)
                    layouts.Add(new DriveLayout(GetDriveVolume(i), type.ToString(), GetStorage(i), GetDriveFormat(i), GetTotalSize(i), GetAvailableStorage(i)));
            }
            return layouts;
        }

        private double GetAvailableStorage(int drive)
        {
            DriveInfo info = allDrives[drive];

            return info.AvailableFreeSpace / 1024 / 1024 / 1024;
        }

        private double GetTotalSize(int drive)
        {
            DriveInfo info = allDrives[drive];

            return info.TotalSize / 1024 / 1024 / 1024;
        }

        private string GetStorage(int drive)
        {
            return "Available Space: " + GetAvailableStorage(drive).ToString() + "GB out of " + GetTotalSize(drive).ToString() + "GB";
        }

        private string GetDriveVolume(int drive)
        {
            return allDrives[drive].VolumeLabel + " " + allDrives[drive].Name;
        }

        private string GetDriveFormat(int drive)
        {
            return allDrives[drive].DriveFormat;
        }

        private DriveType GetDriveType(int drive)
        {
            return allDrives[drive].DriveType;
        }
    }
}
