﻿namespace DudeoPowerLimiter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CpuPowerSlider = new TrackBar();
            label1 = new Label();
            ApplyPowerLimit = new Button();
            Set99 = new Button();
            RemoveLimit = new Button();
            Github = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)CpuPowerSlider).BeginInit();
            SuspendLayout();
            // 
            // CpuPowerSlider
            // 
            CpuPowerSlider.Location = new Point(146, 100);
            CpuPowerSlider.Name = "CpuPowerSlider";
            CpuPowerSlider.Size = new Size(563, 56);
            CpuPowerSlider.TabIndex = 0;
            CpuPowerSlider.Value = 5;
            CpuPowerSlider.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 77);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(111, 20);
            label1.TabIndex = 1;
            label1.Text = "Max Cpu Power";
            label1.Click += label1_Click;
            // 
            // ApplyPowerLimit
            // 
            ApplyPowerLimit.Location = new Point(517, 197);
            ApplyPowerLimit.Name = "ApplyPowerLimit";
            ApplyPowerLimit.Size = new Size(192, 29);
            ApplyPowerLimit.TabIndex = 2;
            ApplyPowerLimit.Text = "Apply Power Limit";
            ApplyPowerLimit.UseVisualStyleBackColor = true;
            ApplyPowerLimit.Click += ApplyPowerLimit_Click;
            // 
            // Set99
            // 
            Set99.Location = new Point(517, 162);
            Set99.Name = "Set99";
            Set99.Size = new Size(192, 29);
            Set99.TabIndex = 3;
            Set99.Text = "Disable Turbo (99%)";
            Set99.UseVisualStyleBackColor = true;
            Set99.Click += button2_Click;
            // 
            // RemoveLimit
            // 
            RemoveLimit.Location = new Point(517, 232);
            RemoveLimit.Name = "RemoveLimit";
            RemoveLimit.Size = new Size(192, 29);
            RemoveLimit.TabIndex = 4;
            RemoveLimit.Text = "Remove Limit";
            RemoveLimit.UseVisualStyleBackColor = true;
            RemoveLimit.Click += RemoveLimit_Click;
            // 
            // Github
            // 
            Github.AutoSize = true;
            Github.Location = new Point(12, 444);
            Github.Name = "Github";
            Github.Size = new Size(76, 20);
            Github.TabIndex = 5;
            Github.TabStop = true;
            Github.Text = "linkLabel1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 473);
            Controls.Add(Github);
            Controls.Add(RemoveLimit);
            Controls.Add(Set99);
            Controls.Add(ApplyPowerLimit);
            Controls.Add(label1);
            Controls.Add(CpuPowerSlider);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)CpuPowerSlider).EndInit();
            ResumeLayout(false);
            PerformLayout();//
        }

        #endregion

        private TrackBar CpuPowerSlider;
        private Label label1;
        private Button ApplyPowerLimit;
        private Button Set99;
        private Button RemoveLimit;
        private LinkLabel Github;
    }
}