using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemInfoWidget
{
    public partial class GpuLayout : UserControl
    {
        public GpuLayout(string GPUName, string GPUMem, string GPUAdapterType, string GPUDriverVersion)
        {
            InitializeComponent();
            GPUNameDisplay.Text = GPUName;
            AdapterRAMDisplay.Text = "Dedicated RAM: " + GPUMem;
            AdapterDACType.Text = "Adapter Type: " + GPUAdapterType;
            DriverVersionDisplay.Text = "Driver Version: " + GPUDriverVersion;
        }
    }
}
