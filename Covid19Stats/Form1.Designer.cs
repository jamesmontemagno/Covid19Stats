
namespace Covid19Stats
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.NumericUpDownRefreshInterval = new System.Windows.Forms.NumericUpDown();
            this.ButtonChooseFileLocation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FolderBrowserDialogFileLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.ButtonStartStop = new System.Windows.Forms.Button();
            this.GroupBoxCountryData = new System.Windows.Forms.GroupBox();
            this.ButtonGetData = new System.Windows.Forms.Button();
            this.ComboBoxCountries = new System.Windows.Forms.ComboBox();
            this.CheckBoxWorldData = new System.Windows.Forms.CheckBox();
            this.RadioButtonAllCountries = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.RadioButtonSpecificCountry = new System.Windows.Forms.RadioButton();
            this.TextBoxFileLocation = new System.Windows.Forms.TextBox();
            this.LabelNextUpdate = new System.Windows.Forms.Label();
            this.ProgressBarCountryData = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.TimerCountryData = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRefreshInterval)).BeginInit();
            this.GroupBoxCountryData.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Refresh Interval";
            // 
            // NumericUpDownRefreshInterval
            // 
            this.NumericUpDownRefreshInterval.Location = new System.Drawing.Point(106, 46);
            this.NumericUpDownRefreshInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NumericUpDownRefreshInterval.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericUpDownRefreshInterval.Name = "NumericUpDownRefreshInterval";
            this.NumericUpDownRefreshInterval.Size = new System.Drawing.Size(120, 23);
            this.NumericUpDownRefreshInterval.TabIndex = 1;
            this.NumericUpDownRefreshInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDownRefreshInterval.ValueChanged += new System.EventHandler(this.NumericUpDownRefreshInterval_ValueChanged);
            // 
            // ButtonChooseFileLocation
            // 
            this.ButtonChooseFileLocation.Location = new System.Drawing.Point(106, 73);
            this.ButtonChooseFileLocation.Name = "ButtonChooseFileLocation";
            this.ButtonChooseFileLocation.Size = new System.Drawing.Size(25, 23);
            this.ButtonChooseFileLocation.TabIndex = 4;
            this.ButtonChooseFileLocation.Text = "...";
            this.ButtonChooseFileLocation.UseVisualStyleBackColor = true;
            this.ButtonChooseFileLocation.Click += new System.EventHandler(this.ButtonChooseFileLocation_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "File Location";
            // 
            // ButtonStartStop
            // 
            this.ButtonStartStop.Location = new System.Drawing.Point(338, 189);
            this.ButtonStartStop.Name = "ButtonStartStop";
            this.ButtonStartStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonStartStop.TabIndex = 8;
            this.ButtonStartStop.Text = "Start";
            this.ButtonStartStop.UseVisualStyleBackColor = true;
            this.ButtonStartStop.Click += new System.EventHandler(this.ButtonStartStop_Click);
            // 
            // GroupBoxCountryData
            // 
            this.GroupBoxCountryData.Controls.Add(this.ButtonGetData);
            this.GroupBoxCountryData.Controls.Add(this.ComboBoxCountries);
            this.GroupBoxCountryData.Controls.Add(this.CheckBoxWorldData);
            this.GroupBoxCountryData.Controls.Add(this.RadioButtonAllCountries);
            this.GroupBoxCountryData.Controls.Add(this.label6);
            this.GroupBoxCountryData.Controls.Add(this.RadioButtonSpecificCountry);
            this.GroupBoxCountryData.Controls.Add(this.TextBoxFileLocation);
            this.GroupBoxCountryData.Controls.Add(this.LabelNextUpdate);
            this.GroupBoxCountryData.Controls.Add(this.ProgressBarCountryData);
            this.GroupBoxCountryData.Controls.Add(this.label2);
            this.GroupBoxCountryData.Controls.Add(this.ButtonStartStop);
            this.GroupBoxCountryData.Controls.Add(this.label1);
            this.GroupBoxCountryData.Controls.Add(this.NumericUpDownRefreshInterval);
            this.GroupBoxCountryData.Controls.Add(this.label3);
            this.GroupBoxCountryData.Controls.Add(this.ButtonChooseFileLocation);
            this.GroupBoxCountryData.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxCountryData.Name = "GroupBoxCountryData";
            this.GroupBoxCountryData.Size = new System.Drawing.Size(419, 218);
            this.GroupBoxCountryData.TabIndex = 9;
            this.GroupBoxCountryData.TabStop = false;
            this.GroupBoxCountryData.Text = "COVID-19 Country Data";
            // 
            // ButtonGetData
            // 
            this.ButtonGetData.Location = new System.Drawing.Point(338, 160);
            this.ButtonGetData.Name = "ButtonGetData";
            this.ButtonGetData.Size = new System.Drawing.Size(75, 23);
            this.ButtonGetData.TabIndex = 20;
            this.ButtonGetData.Text = "Get";
            this.ButtonGetData.UseVisualStyleBackColor = true;
            this.ButtonGetData.Click += new System.EventHandler(this.ButtonGetData_Click);
            // 
            // ComboBoxCountries
            // 
            this.ComboBoxCountries.DisplayMember = "Name";
            this.ComboBoxCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCountries.FormattingEnabled = true;
            this.ComboBoxCountries.Location = new System.Drawing.Point(137, 103);
            this.ComboBoxCountries.Name = "ComboBoxCountries";
            this.ComboBoxCountries.Size = new System.Drawing.Size(177, 23);
            this.ComboBoxCountries.TabIndex = 19;
            this.ComboBoxCountries.ValueMember = "Code";
            this.ComboBoxCountries.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCountries_SelectedIndexChanged);
            // 
            // CheckBoxWorldData
            // 
            this.CheckBoxWorldData.AutoSize = true;
            this.CheckBoxWorldData.Location = new System.Drawing.Point(106, 132);
            this.CheckBoxWorldData.Name = "CheckBoxWorldData";
            this.CheckBoxWorldData.Size = new System.Drawing.Size(113, 19);
            this.CheckBoxWorldData.TabIndex = 18;
            this.CheckBoxWorldData.Text = "World Total Data";
            this.CheckBoxWorldData.UseVisualStyleBackColor = true;
            this.CheckBoxWorldData.CheckedChanged += new System.EventHandler(this.CheckBoxWorldData_CheckedChanged);
            // 
            // RadioButtonAllCountries
            // 
            this.RadioButtonAllCountries.AutoSize = true;
            this.RadioButtonAllCountries.Location = new System.Drawing.Point(320, 104);
            this.RadioButtonAllCountries.Name = "RadioButtonAllCountries";
            this.RadioButtonAllCountries.Size = new System.Drawing.Size(93, 19);
            this.RadioButtonAllCountries.TabIndex = 17;
            this.RadioButtonAllCountries.TabStop = true;
            this.RadioButtonAllCountries.Text = "All Countries";
            this.RadioButtonAllCountries.UseVisualStyleBackColor = true;
            this.RadioButtonAllCountries.CheckedChanged += new System.EventHandler(this.RadioButtonAllCountries_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Data";
            // 
            // RadioButtonSpecificCountry
            // 
            this.RadioButtonSpecificCountry.AutoSize = true;
            this.RadioButtonSpecificCountry.Location = new System.Drawing.Point(117, 107);
            this.RadioButtonSpecificCountry.Name = "RadioButtonSpecificCountry";
            this.RadioButtonSpecificCountry.Size = new System.Drawing.Size(14, 13);
            this.RadioButtonSpecificCountry.TabIndex = 0;
            this.RadioButtonSpecificCountry.TabStop = true;
            this.RadioButtonSpecificCountry.UseVisualStyleBackColor = true;
            this.RadioButtonSpecificCountry.CheckedChanged += new System.EventHandler(this.RadioButtonSpecificCountry_CheckedChanged);
            // 
            // TextBoxFileLocation
            // 
            this.TextBoxFileLocation.Location = new System.Drawing.Point(137, 74);
            this.TextBoxFileLocation.Name = "TextBoxFileLocation";
            this.TextBoxFileLocation.ReadOnly = true;
            this.TextBoxFileLocation.Size = new System.Drawing.Size(276, 23);
            this.TextBoxFileLocation.TabIndex = 15;
            // 
            // LabelNextUpdate
            // 
            this.LabelNextUpdate.AutoSize = true;
            this.LabelNextUpdate.Location = new System.Drawing.Point(6, 184);
            this.LabelNextUpdate.Name = "LabelNextUpdate";
            this.LabelNextUpdate.Size = new System.Drawing.Size(0, 15);
            this.LabelNextUpdate.TabIndex = 14;
            // 
            // ProgressBarCountryData
            // 
            this.ProgressBarCountryData.Location = new System.Drawing.Point(6, 202);
            this.ProgressBarCountryData.Name = "ProgressBarCountryData";
            this.ProgressBarCountryData.Size = new System.Drawing.Size(326, 10);
            this.ProgressBarCountryData.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.ProgressBarCountryData.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "minutes";
            // 
            // TimerCountryData
            // 
            this.TimerCountryData.Tick += new System.EventHandler(this.TimerCountryData_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(256, 233);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(175, 15);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Created by James Montemagno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data from: about-corona.net";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 257);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.GroupBoxCountryData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "COVID-19 Stats";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRefreshInterval)).EndInit();
            this.GroupBoxCountryData.ResumeLayout(false);
            this.GroupBoxCountryData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumericUpDownRefreshInterval;
        private System.Windows.Forms.Button ButtonChooseFileLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialogFileLocation;
        private System.Windows.Forms.Button ButtonStartStop;
        private System.Windows.Forms.GroupBox GroupBoxCountryData;
        private System.Windows.Forms.Timer TimerCountryData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar ProgressBarCountryData;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelNextUpdate;
        private System.Windows.Forms.TextBox TextBoxFileLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RadioButtonSpecificCountry;
        private System.Windows.Forms.CheckBox CheckBoxWorldData;
        private System.Windows.Forms.RadioButton RadioButtonAllCountries;
        private System.Windows.Forms.ComboBox ComboBoxCountries;
        private System.Windows.Forms.Button ButtonGetData;
    }
}

