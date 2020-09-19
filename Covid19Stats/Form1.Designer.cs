
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
            this.LabelFileLocation = new System.Windows.Forms.Label();
            this.FolderBrowserDialogFileLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.ButtonStartStop = new System.Windows.Forms.Button();
            this.GroupBoxCountryData = new System.Windows.Forms.GroupBox();
            this.TextBoxSpecificCountry = new System.Windows.Forms.TextBox();
            this.CheckBoxSpecificCountry = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProgressBarCountryData = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.TimerCountryData = new System.Windows.Forms.Timer(this.components);
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
            // LabelFileLocation
            // 
            this.LabelFileLocation.Location = new System.Drawing.Point(137, 77);
            this.LabelFileLocation.Name = "LabelFileLocation";
            this.LabelFileLocation.Size = new System.Drawing.Size(190, 15);
            this.LabelFileLocation.TabIndex = 6;
            this.LabelFileLocation.Text = "label4";
            // 
            // ButtonStartStop
            // 
            this.ButtonStartStop.Location = new System.Drawing.Point(102, 130);
            this.ButtonStartStop.Name = "ButtonStartStop";
            this.ButtonStartStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonStartStop.TabIndex = 8;
            this.ButtonStartStop.Text = "Start";
            this.ButtonStartStop.UseVisualStyleBackColor = true;
            this.ButtonStartStop.Click += new System.EventHandler(this.ButtonStartStop_Click);
            // 
            // GroupBoxCountryData
            // 
            this.GroupBoxCountryData.Controls.Add(this.TextBoxSpecificCountry);
            this.GroupBoxCountryData.Controls.Add(this.CheckBoxSpecificCountry);
            this.GroupBoxCountryData.Controls.Add(this.label4);
            this.GroupBoxCountryData.Controls.Add(this.ProgressBarCountryData);
            this.GroupBoxCountryData.Controls.Add(this.label2);
            this.GroupBoxCountryData.Controls.Add(this.ButtonStartStop);
            this.GroupBoxCountryData.Controls.Add(this.label1);
            this.GroupBoxCountryData.Controls.Add(this.LabelFileLocation);
            this.GroupBoxCountryData.Controls.Add(this.NumericUpDownRefreshInterval);
            this.GroupBoxCountryData.Controls.Add(this.label3);
            this.GroupBoxCountryData.Controls.Add(this.ButtonChooseFileLocation);
            this.GroupBoxCountryData.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxCountryData.Name = "GroupBoxCountryData";
            this.GroupBoxCountryData.Size = new System.Drawing.Size(334, 170);
            this.GroupBoxCountryData.TabIndex = 9;
            this.GroupBoxCountryData.TabStop = false;
            this.GroupBoxCountryData.Text = "COVID-19 Country Data";
            // 
            // TextBoxSpecificCountry
            // 
            this.TextBoxSpecificCountry.Location = new System.Drawing.Point(127, 102);
            this.TextBoxSpecificCountry.MaxLength = 2;
            this.TextBoxSpecificCountry.Name = "TextBoxSpecificCountry";
            this.TextBoxSpecificCountry.PlaceholderText = "Country Code";
            this.TextBoxSpecificCountry.Size = new System.Drawing.Size(89, 23);
            this.TextBoxSpecificCountry.TabIndex = 13;
            // 
            // CheckBoxSpecificCountry
            // 
            this.CheckBoxSpecificCountry.AutoSize = true;
            this.CheckBoxSpecificCountry.Checked = true;
            this.CheckBoxSpecificCountry.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxSpecificCountry.Location = new System.Drawing.Point(106, 106);
            this.CheckBoxSpecificCountry.Name = "CheckBoxSpecificCountry";
            this.CheckBoxSpecificCountry.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxSpecificCountry.TabIndex = 12;
            this.CheckBoxSpecificCountry.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Specific Country";
            // 
            // ProgressBarCountryData
            // 
            this.ProgressBarCountryData.Location = new System.Drawing.Point(183, 130);
            this.ProgressBarCountryData.Name = "ProgressBarCountryData";
            this.ProgressBarCountryData.Size = new System.Drawing.Size(100, 23);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupBoxCountryData);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRefreshInterval)).EndInit();
            this.GroupBoxCountryData.ResumeLayout(false);
            this.GroupBoxCountryData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumericUpDownRefreshInterval;
        private System.Windows.Forms.Button ButtonChooseFileLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelFileLocation;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialogFileLocation;
        private System.Windows.Forms.Button ButtonStartStop;
        private System.Windows.Forms.GroupBox GroupBoxCountryData;
        private System.Windows.Forms.Timer TimerCountryData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar ProgressBarCountryData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CheckBoxSpecificCountry;
        private System.Windows.Forms.TextBox TextBoxSpecificCountry;
    }
}

