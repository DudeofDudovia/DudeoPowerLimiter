namespace DudeoPowerLimiter
{
    partial class Form1
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
            Unlimit = new Button();
            ApplyLimit = new Button();
            set99 = new Button();
            CpuPowerSlider = new TrackBar();
            SliderVal = new Label();
            CurrentLimitText = new Label();
            CurrentLimit = new Label();
            LimitSliderText = new Label();
            Github = new LinkLabel();
            RunCMD = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)CpuPowerSlider).BeginInit();
            SuspendLayout();
            // 
            // Unlimit
            // 
            Unlimit.Location = new Point(316, 210);
            Unlimit.Name = "Unlimit";
            Unlimit.Size = new Size(157, 29);
            Unlimit.TabIndex = 0;
            Unlimit.Text = "Unlimit CPU";
            Unlimit.UseVisualStyleBackColor = true;
            Unlimit.Click += Unlimit_Click;
            // 
            // ApplyLimit
            // 
            ApplyLimit.Location = new Point(316, 175);
            ApplyLimit.Name = "ApplyLimit";
            ApplyLimit.Size = new Size(157, 29);
            ApplyLimit.TabIndex = 1;
            ApplyLimit.Text = "Apply Limit";
            ApplyLimit.UseVisualStyleBackColor = true;
            ApplyLimit.Click += ApplyLimit_Click;
            // 
            // set99
            // 
            set99.Location = new Point(316, 140);
            set99.Name = "set99";
            set99.Size = new Size(157, 29);
            set99.TabIndex = 2;
            set99.Text = "Disable Turbo (99%)";
            set99.UseVisualStyleBackColor = true;
            set99.Click += set99_Click;
            // 
            // CpuPowerSlider
            // 
            CpuPowerSlider.Location = new Point(12, 69);
            CpuPowerSlider.Minimum = 1;
            CpuPowerSlider.Name = "CpuPowerSlider";
            CpuPowerSlider.Size = new Size(461, 56);
            CpuPowerSlider.TabIndex = 3;
            CpuPowerSlider.Value = 5;
            // 
            // SliderVal
            // 
            SliderVal.AutoSize = true;
            SliderVal.Location = new Point(436, 43);
            SliderVal.Name = "SliderVal";
            SliderVal.Size = new Size(37, 20);
            SliderVal.TabIndex = 4;
            SliderVal.Text = "50%";
            // 
            // CurrentLimitText
            // 
            CurrentLimitText.AutoSize = true;
            CurrentLimitText.Location = new Point(322, 43);
            CurrentLimitText.Name = "CurrentLimitText";
            CurrentLimitText.Size = new Size(97, 20);
            CurrentLimitText.TabIndex = 5;
            CurrentLimitText.Text = "Current Limit:";
            // 
            // CurrentLimit
            // 
            CurrentLimit.AutoSize = true;
            CurrentLimit.Location = new Point(212, 43);
            CurrentLimit.Name = "CurrentLimit";
            CurrentLimit.Size = new Size(37, 20);
            CurrentLimit.TabIndex = 6;
            CurrentLimit.Text = "50%";
            // 
            // LimitSliderText
            // 
            LimitSliderText.AutoSize = true;
            LimitSliderText.Location = new Point(12, 43);
            LimitSliderText.Name = "LimitSliderText";
            LimitSliderText.Size = new Size(112, 20);
            LimitSliderText.TabIndex = 7;
            LimitSliderText.Text = "Cpu Clock Limit";
            // 
            // Github
            // 
            Github.AutoSize = true;
            Github.Location = new Point(12, 222);
            Github.Name = "Github";
            Github.Size = new Size(53, 20);
            Github.TabIndex = 8;
            Github.TabStop = true;
            Github.Text = "Github";
            // 
            // RunCMD
            // 
            RunCMD.AutoSize = true;
            RunCMD.Location = new Point(71, 222);
            RunCMD.Name = "RunCMD";
            RunCMD.Size = new Size(186, 20);
            RunCMD.TabIndex = 9;
            RunCMD.TabStop = true;
            RunCMD.Text = "Running Commands Credit";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 251);
            Controls.Add(RunCMD);
            Controls.Add(Github);
            Controls.Add(LimitSliderText);
            Controls.Add(CurrentLimit);
            Controls.Add(CurrentLimitText);
            Controls.Add(SliderVal);
            Controls.Add(CpuPowerSlider);
            Controls.Add(set99);
            Controls.Add(ApplyLimit);
            Controls.Add(Unlimit);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)CpuPowerSlider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Unlimit;
        private Button ApplyLimit;
        private Button set99;
        private TrackBar CpuPowerSlider;
        private Label SliderVal;
        private Label CurrentLimitText;
        private Label CurrentLimit;
        private Label LimitSliderText;
        private LinkLabel Github;
        private LinkLabel RunCMD;
    }
}