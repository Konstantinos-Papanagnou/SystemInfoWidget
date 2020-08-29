using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfoWidget.SystemInfo
{
    public struct DiskActivity
    {
        public bool Idle;
        public string Volume;
        public DiskActivity(string Volume, bool Idle)
        {
            this.Volume = Volume;
            this.Idle = Idle;
        }
    }
    public class Disk
    {
        readonly DriveInfo[] allDrives;
        readonly ManagementClass m_class;
        public Disk()
        {
            allDrives = DriveInfo.GetDrives();
            m_class = new ManagementClass("Win32_PerfFormattedData_PerfDisk_PhysicalDisk");
        }

        public List<DiskActivity> GetDiskActivity()
        {
            ManagementObjectCollection m_collect = m_class.GetInstances();
            List<DiskActivity> d_act = new List<DiskActivity>();
            foreach (var m_item in m_collect)
            {
                if (m_item["Name"].ToString() == "_Total")
                    continue;
                d_act.Add(new DiskActivity(m_item["Name"].ToString().Remove(0,2), Convert.ToUInt64(m_item["DiskBytesPersec"]) == 0));
            }
            return d_act;
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
            for (int i = 0; i < allDrives.Length; i++)
            {
                DriveType type = GetDriveType(i);

                if (type == DriveType.Fixed || type == DriveType.Removable)
                {
                    DriveLayout temp = new DriveLayout(GetDriveVolume(i), type.ToString(), GetStorage(i), GetDriveFormat(i), GetTotalSize(i), GetAvailableStorage(i));
                    temp.Tag = GetDriveVolume(i);
                    layouts.Add(temp);
                }
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
