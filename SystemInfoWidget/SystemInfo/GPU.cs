using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfoWidget.SystemInfo
{
    public class GPU
    {

        public static List<GpuLayout> GetGPUs()
        {
            List<GpuLayout> layouts = new List<GpuLayout>();
            ManagementObjectSearcher objvide = new ManagementObjectSearcher("select * from Win32_VideoController");

            foreach (ManagementObject obj in objvide.Get())
                layouts.Add(new GpuLayout(obj["Name"].ToString(), Math.Round(double.Parse(obj["AdapterRAM"].ToString()) / 1024 / 1024 / 1024).ToString() + "GB", obj["AdapterDACType"].ToString(), obj["DriverVersion"].ToString()));

            return layouts;
        }

        
    }
}
