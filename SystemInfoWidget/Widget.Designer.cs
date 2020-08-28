namespace SystemInfoWidget
{
    partial class Widget
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.CPUStatusDisplay = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CPUCoreCountDisplay = new System.Windows.Forms.Label();
            this.CPUNameDisplay = new System.Windows.Forms.Label();
            this.OS_Display = new System.Windows.Forms.Label();
            this.TimeDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClockUpdater = new System.Windows.Forms.Timer(this.components);
            this.UsageUpdater = new System.Windows.Forms.Timer(this.components);
            this.DiskPanel = new System.Windows.Forms.Panel();
            this.DragPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragPanel
            // 
            this.DragPanel.Controls.Add(this.DiskPanel);
            this.DragPanel.Controls.Add(this.CPUStatusDisplay);
            this.DragPanel.Controls.Add(this.panel1);
            this.DragPanel.Controls.Add(this.CPUCoreCountDisplay);
            this.DragPanel.Controls.Add(this.CPUNameDisplay);
            this.DragPanel.Controls.Add(this.OS_Display);
            this.DragPanel.Controls.Add(this.TimeDisplay);
            this.DragPanel.Controls.Add(this.label1);
            this.DragPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DragPanel.Location = new System.Drawing.Point(0, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(734, 794);
            this.DragPanel.TabIndex = 1;
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            // 
            // CPUStatusDisplay
            // 
            this.CPUStatusDisplay.AutoSize = true;
            this.CPUStatusDisplay.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CPUStatusDisplay.ForeColor = System.Drawing.Color.DeepPink;
            this.CPUStatusDisplay.Location = new System.Drawing.Point(203, 146);
            this.CPUStatusDisplay.Name = "CPUStatusDisplay";
            this.CPUStatusDisplay.Size = new System.Drawing.Size(90, 28);
            this.CPUStatusDisplay.TabIndex = 6;
            this.CPUStatusDisplay.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(3, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 2);
            this.panel1.TabIndex = 5;
            // 
            // CPUCoreCountDisplay
            // 
            this.CPUCoreCountDisplay.AutoSize = true;
            this.CPUCoreCountDisplay.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CPUCoreCountDisplay.ForeColor = System.Drawing.Color.Lime;
            this.CPUCoreCountDisplay.Location = new System.Drawing.Point(12, 116);
            this.CPUCoreCountDisplay.Name = "CPUCoreCountDisplay";
            this.CPUCoreCountDisplay.Size = new System.Drawing.Size(56, 18);
            this.CPUCoreCountDisplay.TabIndex = 4;
            this.CPUCoreCountDisplay.Text = "label2";
            // 
            // CPUNameDisplay
            // 
            this.CPUNameDisplay.AutoSize = true;
            this.CPUNameDisplay.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.CPUNameDisplay.ForeColor = System.Drawing.Color.Lime;
            this.CPUNameDisplay.Location = new System.Drawing.Point(11, 87);
            this.CPUNameDisplay.Name = "CPUNameDisplay";
            this.CPUNameDisplay.Size = new System.Drawing.Size(63, 20);
            this.CPUNameDisplay.TabIndex = 3;
            this.CPUNameDisplay.Text = "label2";
            // 
            // OS_Display
            // 
            this.OS_Display.AutoSize = true;
            this.OS_Display.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.OS_Display.ForeColor = System.Drawing.Color.Lime;
            this.OS_Display.Location = new System.Drawing.Point(284, 58);
            this.OS_Display.Name = "OS_Display";
            this.OS_Display.Size = new System.Drawing.Size(63, 20);
            this.OS_Display.TabIndex = 2;
            this.OS_Display.Text = "label2";
            // 
            // TimeDisplay
            // 
            this.TimeDisplay.AutoSize = true;
            this.TimeDisplay.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TimeDisplay.ForeColor = System.Drawing.Color.Lime;
            this.TimeDisplay.Location = new System.Drawing.Point(27, 58);
            this.TimeDisplay.Name = "TimeDisplay";
            this.TimeDisplay.Size = new System.Drawing.Size(63, 20);
            this.TimeDisplay.TabIndex = 1;
            this.TimeDisplay.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(105, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "System Info Widget By Konstantinos Pap";
            // 
            // ClockUpdater
            // 
            this.ClockUpdater.Enabled = true;
            this.ClockUpdater.Interval = 1000;
            // 
            // UsageUpdater
            // 
            this.UsageUpdater.Enabled = true;
            this.UsageUpdater.Interval = 3000;
            // 
            // DiskPanel
            // 
            this.DiskPanel.BackColor = System.Drawing.Color.Lime;
            this.DiskPanel.Location = new System.Drawing.Point(3, 177);
            this.DiskPanel.Name = "DiskPanel";
            this.DiskPanel.Size = new System.Drawing.Size(731, 2);
            this.DiskPanel.TabIndex = 6;
            // 
            // Widget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 794);
            this.Controls.Add(this.DragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Widget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.DragPanel.ResumeLayout(false);
            this.DragPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DragPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimeDisplay;
        private System.Windows.Forms.Timer ClockUpdater;
        private System.Windows.Forms.Label CPUCoreCountDisplay;
        private System.Windows.Forms.Label CPUNameDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OS_Display;
        private System.Windows.Forms.Label CPUStatusDisplay;
        private System.Windows.Forms.Timer UsageUpdater;
        private System.Windows.Forms.Panel DiskPanel;
    }
}

