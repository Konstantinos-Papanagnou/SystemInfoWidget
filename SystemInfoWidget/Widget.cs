using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SystemInfoWidget.SystemInfo;
using System.Diagnostics;
using System.Management;

namespace SystemInfoWidget
{
    public partial class Widget : Form
    {
        int DiskCount = 0;
        readonly Disk disk;
        List<DriveLayout> layouts;
        public Widget()
        {
            InitializeComponent();
            disk = new Disk();
            InitializeControls();
            this.BackColor = this.TransparencyKey = Color.Turquoise;
            ClockUpdater.Tick += Updater_Tick;
            UsageUpdater.Tick += UpdateControls;
            Thread t = new Thread(new ThreadStart(UpdateDiskActivity));
            t.Start();
        }

        private void UpdateDiskActivity()
        {
            while (true)
            {
                var d_act = disk.GetDiskActivity();
                foreach (var d in d_act)
                {
                    foreach (var layout in layouts)
                        if (layout.Tag.ToString().Contains(d.Volume))
                            layout.SetState(d.Idle);
                }
                Thread.Sleep(200);
            }
        }

        private void Updater_Tick(object sender, EventArgs e)
        {
            TimeDisplay.Text = "System Time: " + DateTime.Now.ToString("hh:mm:ss");
        }

        private void UpdateControls(object sender, EventArgs e)
        {
            double cpu_usage = CPU.GetCPUUsage();
            if (cpu_usage > 50)
                CPUStatusDisplay.ForeColor = Color.DeepPink;
            else CPUStatusDisplay.ForeColor = Color.Lime;
            CPUStatusDisplay.Text = "CPU Usage: " + cpu_usage+ "%";
            if (disk.CheckForUpdates(DiskCount))
            {
                RemoveDisksFromPanel();
                AddDisksToPanel();
                DiskCount = disk.GetDiskCount();
            }
            MemoryDisplay.Text = new Memory().GetMemStats();

        }

        private void InitializeControls()
        {
            OS_Display.Text = OS.OSName;
            CPU in_cpu = new CPU();
            CPUNameDisplay.Text = in_cpu.CPUName + " Manufacturer: " + in_cpu.CPUManufacturer;
            CPUCoreCountDisplay.Text = "Cores: " + in_cpu.CPUNumberOfCores + "   Logical Cores: " + 
                in_cpu.CPUNumberOfLogicalProcessors + "   Clock Speed: " + Math.Round(double.Parse(in_cpu.CPUClockSpeed) / 1000, 2).ToString() + "GHz" +
                "   Maximum Clock Speed: " + Math.Round(double.Parse(in_cpu.CPUMaxClockSpeed) / 1000, 2).ToString() + "GHz";
            CPUStatusDisplay.Text = "CPU Usage: " + CPU.GetCPUUsage() + "%";
            AddDisksToPanel();
            MemoryDisplay.Text = new Memory().GetMemStats();
        }

        private void AddDisksToPanel()
        {
            layouts = disk.GetDriveLayouts();
            DiskCount = disk.GetDiskCount();
            for (int i = 0; i < layouts.Count; i++)
            {
                if (i == 0)
                    layouts[i].Location = new Point(DiskPanel.Location.X + 2, DiskPanel.Location.Y + 5);
                else
                    layouts[i].Location = new Point(layouts[i - 1].Location.X, layouts[i - 1].Location.Y + layouts[i - 1].Size.Height + 5);
                this.DragPanel.Controls.Add(layouts[i]);
            }
        }

        private void RemoveDisksFromPanel()
        {
            layouts.Clear();
            for(int i = 0; i < DragPanel.Controls.Count; i++)
            {
                if(DragPanel.Controls[i] is DriveLayout)
                {
                    DragPanel.Controls.RemoveAt(i);
                    i -= 1;
                }
            }
            
        }

        #region FormMovement
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion
    }
}
