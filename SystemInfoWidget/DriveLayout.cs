using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace SystemInfoWidget
{
    public partial class DriveLayout : UserControl
    {
        public DriveLayout(string DriveName, string DriveType, string DriveSpaceInfo, string DriveFormat, double TotalSpace, double AvailableSpace)
        {
            InitializeComponent();
            DriveNameDiaplay.Text = DriveName;
            DriveTypeDisplay.Text = DriveType;
            SpaceInfoDisplay.Text = DriveSpaceInfo;
            FormatDisplay.Text = DriveFormat;
            DiskCapacity.Maximum = (int)TotalSpace;
            DiskCapacity.Value = (int)TotalSpace - (int)AvailableSpace;
        }

        #region FormMovement
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DriveLayout_MouseMove(object sender, MouseEventArgs e)
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
