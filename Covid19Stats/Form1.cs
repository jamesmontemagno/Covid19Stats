using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid19Stats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ProgressBarCountryData.Visible = false;
            CheckBoxSpecificCountry.Checked = SettingsService.SpecificCountry;
            TextBoxSpecificCountry.Text = SettingsService.CountryCode;
            NumericUpDownRefreshInterval.Value = SettingsService.CountryRefreshInterval;
            LabelFileLocation.Text = SettingsService.DirectoryPath;
        }

        private void ButtonStartStop_Click(object sender, EventArgs e)
        {
            if(TimerCountryData.Enabled)
            {
                TimerCountryData.Stop();
                ButtonStartStop.Text = "Start";
            }
            else
            {
                ButtonStartStop.Text = "Stop";
                TimerCountryData.Interval = (int)TimeSpan.FromMinutes((int)NumericUpDownRefreshInterval.Value).TotalMilliseconds;
                TimerCountryData.Start();
                TimerCountryData_Tick(null, null);
            }
        }

        private async void TimerCountryData_Tick(object sender, EventArgs e)
        {
            if (ProgressBarCountryData.Visible)
                return;

            ProgressBarCountryData.Visible = true;

            await CovidService.UpdateCountryData(CheckBoxSpecificCountry.Checked ? TextBoxSpecificCountry.Text : string.Empty);

            ProgressBarCountryData.Visible = false;
        }

        private void NumericUpDownRefreshInterval_ValueChanged(object sender, EventArgs e)
        {
            SettingsService.CountryRefreshInterval = (int)NumericUpDownRefreshInterval.Value;
        }
    }
}
