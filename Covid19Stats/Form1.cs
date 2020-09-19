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
            var enable = true;
            if(TimerCountryData.Enabled)
            {
                TimerCountryData.Stop();
                ButtonStartStop.Text = "Start";
            }
            else
            {
                ButtonStartStop.Text = "Stop";
                enable = false;
                TimerCountryData.Interval = (int)TimeSpan.FromMinutes((int)NumericUpDownRefreshInterval.Value).TotalMilliseconds;
                TimerCountryData.Start();
                TimerCountryData_Tick(null, null);
            }


            CheckBoxSpecificCountry.Enabled = enable;
            TextBoxSpecificCountry.Enabled = enable;
            ButtonChooseFileLocation.Enabled = enable;
            NumericUpDownRefreshInterval.Enabled = enable;
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

        private void ButtonChooseFileLocation_Click(object sender, EventArgs e)
        {
            var result = FolderBrowserDialogFileLocation.ShowDialog();
            if (result != DialogResult.OK)
                return;

            LabelFileLocation.Text = FolderBrowserDialogFileLocation.SelectedPath;
            SettingsService.DirectoryPath = FolderBrowserDialogFileLocation.SelectedPath;
        }

        private void CheckBoxSpecificCountry_CheckedChanged(object sender, EventArgs e)
        {
            SettingsService.SpecificCountry = CheckBoxSpecificCountry.Checked;
        }

        private void TextBoxSpecificCountry_TextChanged(object sender, EventArgs e)
        {
            SettingsService.CountryCode = TextBoxSpecificCountry.Text;
        }
    }
}
