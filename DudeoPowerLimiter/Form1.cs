using System.Diagnostics;
using System.Drawing.Printing;

//using static System.Net.WebRequestMethods;
using System.IO;

namespace DudeoPowerLimiter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SetLimits.SetLimit(99);
            File.WriteAllText(SaveHelper.SaveFile, 99.ToString());
        }

        private void ApplyPowerLimit_Click(object sender, EventArgs e)
        {
            SetLimits.SetLimit(CpuPowerSlider.Value * 10);
            CurrentLimit.Text = (CpuPowerSlider.Value * 10).ToString() + "%";
            LimitValues.LastLimit = CpuPowerSlider.Value * 10;
            File.WriteAllText(SaveHelper.SaveFile, (CpuPowerSlider.Value * 10).ToString());
        }
        private void RemoveLimit_Click(object sender, EventArgs e)
        {
            SetLimits.SetLimit(100);
            CurrentLimit.Text = "100%";
            File.WriteAllText(SaveHelper.SaveFile, 100.ToString());
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
                    if (int.TryParse(File.ReadAllText(SaveHelper.SaveFile),out int LastLimit))
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

        private void Github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/DudeofDudovia/DudeoPowerLimiter",
                UseShellExecute = true
            });
        }
        private void CreditLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://stackoverflow.com/a/1469790",
                UseShellExecute = true
            });
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            SliderVal.Text = (CpuPowerSlider.Value*10).ToString() + "%";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
