namespace SystemInfoWidget
{
    partial class GpuLayout
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GPUNameDisplay = new System.Windows.Forms.Label();
            this.AdapterRAMDisplay = new System.Windows.Forms.Label();
            this.AdapterDACType = new System.Windows.Forms.Label();
            this.DriverVersionDisplay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GPUNameDisplay
            // 
            this.GPUNameDisplay.AutoSize = true;
            this.GPUNameDisplay.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.GPUNameDisplay.ForeColor = System.Drawing.Color.Lime;
            this.GPUNameDisplay.Location = new System.Drawing.Point(8, 10);
            this.GPUNameDisplay.Name = "GPUNameDisplay";
            this.GPUNameDisplay.Size = new System.Drawing.Size(90, 28);
            this.GPUNameDisplay.TabIndex = 9;
            this.GPUNameDisplay.Text = "label2";
            // 
            // AdapterRAMDisplay
            // 
            this.AdapterRAMDisplay.AutoSize = true;
            this.AdapterRAMDisplay.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AdapterRAMDisplay.ForeColor = System.Drawing.Color.Lime;
            this.AdapterRAMDisplay.Location = new System.Drawing.Point(9, 50);
            this.AdapterRAMDisplay.Name = "AdapterRAMDisplay";
            this.AdapterRAMDisplay.Size = new System.Drawing.Size(63, 20);
            this.AdapterRAMDisplay.TabIndex = 10;
            this.AdapterRAMDisplay.Text = "label2";
            // 
            // AdapterDACType
            // 
            this.AdapterDACType.AutoSize = true;
            this.AdapterDACType.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AdapterDACType.ForeColor = System.Drawing.Color.Lime;
            this.AdapterDACType.Location = new System.Drawing.Point(7, 80);
            this.AdapterDACType.Name = "AdapterDACType";
            this.AdapterDACType.Size = new System.Drawing.Size(63, 20);
            this.AdapterDACType.TabIndex = 11;
            this.AdapterDACType.Text = "label2";
            // 
            // DriverVersionDisplay
            // 
            this.DriverVersionDisplay.AutoSize = true;
            this.DriverVersionDisplay.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DriverVersionDisplay.ForeColor = System.Drawing.Color.Lime;
            this.DriverVersionDisplay.Location = new System.Drawing.Point(6, 107);
            this.DriverVersionDisplay.Name = "DriverVersionDisplay";
            this.DriverVersionDisplay.Size = new System.Drawing.Size(56, 17);
            this.DriverVersionDisplay.TabIndex = 12;
            this.DriverVersionDisplay.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(349, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 136);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 136);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.Location = new System.Drawing.Point(2, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 1);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Lime;
            this.panel4.Location = new System.Drawing.Point(1, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 1);
            this.panel4.TabIndex = 15;
            // 
            // GpuLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DriverVersionDisplay);
            this.Controls.Add(this.AdapterDACType);
            this.Controls.Add(this.AdapterRAMDisplay);
            this.Controls.Add(this.GPUNameDisplay);
            this.Name = "GpuLayout";
            this.Size = new System.Drawing.Size(351, 135);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GPUNameDisplay;
        private System.Windows.Forms.Label AdapterRAMDisplay;
        private System.Windows.Forms.Label AdapterDACType;
        private System.Windows.Forms.Label DriverVersionDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
