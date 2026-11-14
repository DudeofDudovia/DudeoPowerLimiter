using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DudeoPowerLimiter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void set99_Click(object sender, EventArgs e)
        {
            SetLimits.SetLimit(99);
            File.WriteAllText(SaveHelper.SaveFile, 99.ToString());
        }

        private void ApplyLimit_Click(object sender, EventArgs e)
        {
            SetLimits.SetLimit(CpuPowerSlider.Value * 10);
            CurrentLimit.Text = (CpuPowerSlider.Value * 10).ToString() + "%";
            LimitValues.LastLimit = CpuPowerSlider.Value * 10;
            File.WriteAllText(SaveHelper.SaveFile, (CpuPowerSlider.Value * 10).ToString());
        }

        private void Unlimit_Click(object sender, EventArgs e)
        {
            SetLimits.SetLimit(100);
            CurrentLimit.Text = "100%";
            File.WriteAllText(SaveHelper.SaveFile, 100.ToString());
        }

        private void CpuPowerSlider_Scroll(object sender, EventArgs e)
        {
            SliderVal.Text = (CpuPowerSlider.Value * 10).ToString() + "%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Path.Exists(SaveHelper.SavePath))
            {
                Directory.CreateDirectory(SaveHelper.SavePath);
            }
            if (Path.Exists(SaveHelper.SavePath))
            {
                if (File.Exists(SaveHelper.SaveFile))
                {
                    if (int.TryParse(File.ReadAllText(SaveHelper.SaveFile), out int LastLimit))
                    {
                        CurrentLimit.Text = LastLimit.ToString() + "%";
                        LimitValues.LastLimit = LastLimit;
                    }
                }
                if (File.Exists(SaveHelper.SaveSlider))
                {
                    if (int.TryParse(File.ReadAllText(SaveHelper.SaveSlider), out int LastLimit))
                    {
                        SliderVal.Text = LastLimit.ToString() + "%";
                        CpuPowerSlider.Value = LastLimit / 10;
                    }
                }
            }
        }

        private void RunCMD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://stackoverflow.com/a/1469790",
                UseShellExecute = true
            });
        }

        private void Github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/DudeofDudovia/DudeoPowerLimiter",
                UseShellExecute = true
            });
        }
    }
}
