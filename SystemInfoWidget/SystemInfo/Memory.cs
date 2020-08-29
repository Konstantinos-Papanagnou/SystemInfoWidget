using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfoWidget.SystemInfo
{
    public class Memory
    {
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetPhysicallyInstalledSystemMemory(out long TotalMemoryInKilobytes);

        private double GetAvailableMemory()
        {
            GetPhysicallyInstalledSystemMemory(out long memKb);
            return memKb / 1024 / 1024;
        }

        private double GetUsedMemory()
        {
            var wmiObject = new ManagementObjectSearcher("select * from Win32_OperatingSystem");

            var memoryValues = wmiObject.Get().Cast<ManagementObject>().Select(mo => new {
                FreePhysicalMemory = Double.Parse(mo["FreePhysicalMemory"].ToString()),
            }).FirstOrDefault();

            if (memoryValues != null)
            {
                return GetAvailableMemory() - Math.Round(memoryValues.FreePhysicalMemory / 1024 / 1024, 2);
            }
            return 0;
        }


        public string GetMemStats()
        {
            return "Physical Ram: " + GetUsedMemory() + "GB / " + GetAvailableMemory() + "GB ( " +  Math.Floor(GetUsedMemory() / GetAvailableMemory() * 100) + "% used )";
        }
    }
}
