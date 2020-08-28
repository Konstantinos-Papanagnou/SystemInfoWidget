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

namespace SystemInfoWidget
{
    public partial class Widget : Form
    {
        public Widget()
        {
            InitializeComponent();
            InitializeControls();
            this.BackColor = this.TransparencyKey = Color.Turquoise;
            ClockUpdater.Tick += Updater_Tick;
            UsageUpdater.Tick += UpdateControls;
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
