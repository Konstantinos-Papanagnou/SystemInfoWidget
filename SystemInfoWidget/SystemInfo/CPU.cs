using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace SystemInfoWidget.SystemInfo
{
    public class CPU
    {
        ManagementObjectSearcher win32Proc;
        public CPU()
        {
            win32Proc = new ManagementObjectSearcher("select * from Win32_Processor");
        }
        public string CPUName { 
            get 
            { 
                foreach (ManagementObject m_obj in win32Proc.Get()) 
                {
                    return m_obj["Name"].ToString();
                }
                return "Unknown";
            }  
        }

        public string CPUClockSpeed
        {
            get
            {
                foreach (ManagementObject m_obj in win32Proc.Get())
                {
                    return m_obj["CurrentClockSpeed"].ToString();
                }
                return "Unknown";
            }
        }

        public string CPUMaxClockSpeed
        {
            get
            {
                foreach (ManagementObject m_obj in win32Proc.Get())
                {
                    return m_obj["MaxClockSpeed"].ToString();
                }
                return "Unknown";
            }
        }

        public static double GetCPUUsage()
        {
            PerformanceCounter cpuCounter;

            cpuCounter = new PerformanceCounter
            {
                CategoryName = "Processor",

                CounterName = "% Processor Time",

                InstanceName = "_Total"
            };
            //Discard the first value since it is always 0
            _ = cpuCounter.NextValue();
            //Halt for 1 millisec cause of PerformanceCounter lag... -_-
            System.Threading.Thread.Sleep(400);
            // Get Current Cpu Usage
            double second = double.Parse(cpuCounter.NextValue().ToString());
            return Math.Round(second);
        }

        public string CPUNumberOfCores
        {
            get
            {
                foreach (ManagementObject m_obj in win32Proc.Get())
                {
                    return m_obj["NumberOfCores"].ToString();
                }
                return "Unknown";
            }
        }

        public string CPUManufacturer
        {
            get
            {
                foreach (ManagementObject m_obj in win32Proc.Get())
                {
                    return m_obj["Manufacturer"].ToString();
                }
                return "Unknown";
            }
        }

        public string CPUNumberOfLogicalProcessors
        {
            get
            {
                foreach (ManagementObject m_obj in win32Proc.Get())
                {
                    return m_obj["NumberOfLogicalProcessors"].ToString();
                }
                return "Unknown";
            }
        }
    }
}
