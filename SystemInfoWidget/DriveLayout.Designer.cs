﻿namespace SystemInfoWidget
{
    partial class DriveLayout
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
            this.DiskCapacity = new System.Windows.Forms.ProgressBar();
            this.DriveNameDiaplay = new System.Windows.Forms.Label();
            this.SpaceInfoDisplay = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FormatDisplay = new System.Windows.Forms.Label();
            this.DriveTypeDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DiskCapacity
            // 
            this.DiskCapacity.Location = new System.Drawing.Point(74, 29);
            this.DiskCapacity.Name = "DiskCapacity";
            this.DiskCapacity.Size = new System.Drawing.Size(510, 23);
            this.DiskCapacity.TabIndex = 0;
            // 
            // DriveNameDiaplay
            // 
            this.DriveNameDiaplay.AutoSize = true;
            this.DriveNameDiaplay.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DriveNameDiaplay.ForeColor = System.Drawing.Color.Lime;
            this.DriveNameDiaplay.Location = new System.Drawing.Point(70, 3);
            this.DriveNameDiaplay.Name = "DriveNameDiaplay";
            this.DriveNameDiaplay.Size = new System.Drawing.Size(76, 23);
            this.DriveNameDiaplay.TabIndex = 1;
            this.DriveNameDiaplay.Text = "label1";
            // 
            // SpaceInfoDisplay
            // 
            this.SpaceInfoDisplay.AutoSize = true;
            this.SpaceInfoDisplay.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SpaceInfoDisplay.ForeColor = System.Drawing.Color.Lime;
            this.SpaceInfoDisplay.Location = new System.Drawing.Point(70, 55);
            this.SpaceInfoDisplay.Name = "SpaceInfoDisplay";
            this.SpaceInfoDisplay.Size = new System.Drawing.Size(63, 20);
            this.SpaceInfoDisplay.TabIndex = 2;
            this.SpaceInfoDisplay.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemInfoWidget.Properties.Resources.diskImage;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormatDisplay
            // 
            this.FormatDisplay.AutoSize = true;
            this.FormatDisplay.ForeColor = System.Drawing.Color.Lime;
            this.FormatDisplay.Location = new System.Drawing.Point(5, 58);
            this.FormatDisplay.Name = "FormatDisplay";
            this.FormatDisplay.Size = new System.Drawing.Size(46, 17);
            this.FormatDisplay.TabIndex = 4;
            this.FormatDisplay.Text = "label1";
            // 
            // DriveTypeDisplay
            // 
            this.DriveTypeDisplay.AutoSize = true;
            this.DriveTypeDisplay.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DriveTypeDisplay.ForeColor = System.Drawing.Color.Lime;
            this.DriveTypeDisplay.Location = new System.Drawing.Point(368, 3);
            this.DriveTypeDisplay.Name = "DriveTypeDisplay";
            this.DriveTypeDisplay.Size = new System.Drawing.Size(76, 23);
            this.DriveTypeDisplay.TabIndex = 5;
            this.DriveTypeDisplay.Text = "label1";
            // 
            // DriveLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DriveTypeDisplay);
            this.Controls.Add(this.FormatDisplay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SpaceInfoDisplay);
            this.Controls.Add(this.DriveNameDiaplay);
            this.Controls.Add(this.DiskCapacity);
            this.Name = "DriveLayout";
            this.Size = new System.Drawing.Size(587, 84);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DriveLayout_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar DiskCapacity;
        private System.Windows.Forms.Label DriveNameDiaplay;
        private System.Windows.Forms.Label SpaceInfoDisplay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FormatDisplay;
        private System.Windows.Forms.Label DriveTypeDisplay;
    }
}