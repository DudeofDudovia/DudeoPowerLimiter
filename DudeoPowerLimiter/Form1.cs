using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
