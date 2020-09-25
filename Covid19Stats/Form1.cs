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
            CheckBoxWorldData.Checked = SettingsService.WorldData;
            RadioButtonSpecificCountry.Checked = SettingsService.SpecificCountry;
            RadioButtonAllCountries.Checked = !SettingsService.SpecificCountry;
            NumericUpDownRefreshInterval.Value = SettingsService.CountryRefreshInterval;
            TextBoxFileLocation.Text = SettingsService.DirectoryPath;
            ComboBoxCountries.Items.AddRange(CovidService.Countries.ToArray());

            if(!string.IsNullOrWhiteSpace(SettingsService.CountryCode))
            {
                var country = CovidService.Countries.FirstOrDefault(c => c.Code == SettingsService.CountryCode);
                if (country != null)
                    ComboBoxCountries.SelectedItem = country;

            }    
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

            UpdateEnable(enable);
        }

        void UpdateEnable(bool enable, bool setStartStop = false)
        {
            RadioButtonAllCountries.Enabled = enable;
            RadioButtonSpecificCountry.Enabled = enable;
            CheckBoxWorldData.Enabled = enable;
            ComboBoxCountries.Enabled = enable;
            ButtonChooseFileLocation.Enabled = enable;
            NumericUpDownRefreshInterval.Enabled = enable;
            ButtonGetData.Enabled = enable;
            if (setStartStop)
                ButtonStartStop.Enabled = enable;
        }

        private async void TimerCountryData_Tick(object sender, EventArgs e)
        {
            if (ProgressBarCountryData.Visible)
                return;

            await GetData();
        }

        async Task GetData()
        {

            ProgressBarCountryData.Visible = true;

            if (TimerCountryData.Enabled)
                LabelNextUpdate.Text = $"Next Update: {DateTime.Now.AddMinutes((int)NumericUpDownRefreshInterval.Value).ToLongTimeString()}";
            else
                LabelNextUpdate.Text = string.Empty;

            await CovidService.UpdateCountryData(RadioButtonSpecificCountry.Checked ? ((Country)ComboBoxCountries.SelectedItem).Code : string.Empty, CheckBoxWorldData.Checked);

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

            TextBoxFileLocation.Text = FolderBrowserDialogFileLocation.SelectedPath;
            SettingsService.DirectoryPath = FolderBrowserDialogFileLocation.SelectedPath;
        }



        void SetCountryDataSettings()
        {
            SettingsService.SpecificCountry = RadioButtonSpecificCountry.Checked;
        }

        private void RadioButtonSpecificCountry_CheckedChanged(object sender, EventArgs e)
        {
            SetCountryDataSettings();
            //RadioButtonAllCountries.Checked = false;

        }

        private void RadioButtonAllCountries_CheckedChanged(object sender, EventArgs e)
        {
            SetCountryDataSettings();
            //RadioButtonSpecificCountry.Checked = false;
        }

        private void CheckBoxWorldData_CheckedChanged(object sender, EventArgs e)
        {
            SettingsService.WorldData = CheckBoxWorldData.Checked;
        }

        private void ComboBoxCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            SettingsService.CountryCode = ((Country)ComboBoxCountries.SelectedItem).Code;
        }

        private async void ButtonGetData_Click(object sender, EventArgs e)
        {
            UpdateEnable(false, true);

            await GetData();

            UpdateEnable(true, true);
        }
    }
}
