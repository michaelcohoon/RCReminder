using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RCReminder
{
    public partial class Settings : Form
    {
        public Boolean notify;
        public Boolean notifyViaEvery;
        public Boolean notifyViaAtTimes;

        public Settings()
        {
            InitializeComponent();

            // Set up how the form should be displayed.
            this.ClientSize = new System.Drawing.Size(361, 311);
            this.Text = "Settings - RCReminder";
            this.Icon = new Icon("rc_icon1.ico");
            this.notify = this.notifyCheckBox.Checked;
            this.notifyViaEvery = this.remindEveryCheckBox.Checked;
            this.notifyViaAtTimes = this.remindAtTimeCheckBox.Checked;

            // Define the border style of the form to a dialog box.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            this.MinimizeBox = false;
            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void remindAtTime_CheckedChanged(object sender, EventArgs e)
        {
            this.remindAtTimePanel.Enabled = this.remindAtTimeCheckBox.Checked;
            this.notifyViaAtTimes = this.remindAtTimeCheckBox.Checked;
        }

        private void remindEveryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.remindEveryPanel.Enabled = this.remindEveryCheckBox.Checked;
            this.notifyViaEvery = this.remindEveryCheckBox.Checked;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Reset values to default
            this.remindEveryCheckBox.Checked = true;
            this.remindEveryPanel.Enabled = true;
            this.hoursTextBox.Text = "1";
            this.minutesTextBox.Text = "30";
            this.remindAtTimeCheckBox.Checked = false;
            this.remindAtTimePanel.Enabled = false;
            this.hoursComboBox1.SelectedItem = this.hoursComboBox1.Items[0];
            this.hoursComboBox2.SelectedItem = this.hoursComboBox1.Items[0];
            this.hoursComboBox3.SelectedItem = this.hoursComboBox1.Items[0];
            this.minutesComboBox1.SelectedItem = this.hoursComboBox1.Items[0];
            this.minutesComboBox2.SelectedItem = this.hoursComboBox1.Items[0];
            this.minutesComboBox3.SelectedItem = this.hoursComboBox1.Items[0];
            this.notifyCheckBox.Checked = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Close the window after saving the changes
            //Make sure the hours =< 24 and minuts =< 60
            //--if not, don't save, keep values in fields, display modal popup

            string[] fileContents = new string[13];

            fileContents[0]  = this.remindEveryCheckBox.Checked.ToString();
            fileContents[1]  = this.remindEveryPanel.Enabled.ToString();
            fileContents[2]  = this.hoursTextBox.Text.ToString();
            fileContents[3]  = this.minutesTextBox.Text.ToString();
            fileContents[4]  = this.remindAtTimeCheckBox.Checked.ToString();
            fileContents[5]  = this.remindAtTimePanel.Enabled.ToString();
            fileContents[6]  = this.hoursComboBox1.SelectedItem.ToString();
            fileContents[7]  = this.hoursComboBox2.SelectedItem.ToString();
            fileContents[8]  = this.hoursComboBox3.SelectedItem.ToString();
            fileContents[9]  = this.minutesComboBox1.SelectedItem.ToString();
            fileContents[10] = this.minutesComboBox2.SelectedItem.ToString();
            fileContents[11] = this.minutesComboBox3.SelectedItem.ToString();
            fileContents[12] = this.notifyCheckBox.Checked.ToString();

            File.WriteAllLines(@"C:\Users\Mike\Desktop\RCREMINDER.SETTINGS", fileContents);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //Close the window after disregarding the changes
            this.Hide();
        }

        private void hoursTextBox_KeyDown(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Regex regex = new Regex("[0-9]|\b");
            e.Handled = !(regex.IsMatch(e.KeyChar.ToString()));

            if (this.hoursTextBox.Text.Length > 1 && !e.KeyChar.ToString().Equals("\b"))
                e.Handled = true;
        }

        private void minutesTextBox_KeyDown(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Regex regex = new Regex("[0-9]|\b");
            e.Handled = !(regex.IsMatch(e.KeyChar.ToString()));

            if (this.minutesTextBox.Text.Length > 1 && !e.KeyChar.ToString().Equals("\b"))
                e.Handled = true;
        }

        /// <summary>
        /// Returns a TimeSpan for how often to display the notification.
        /// </summary>
        /// <returns>A TimeSpan containing the notification frequency.</returns>
        public TimeSpan GetNotificationFrequency()
        {
            
            int days = 0;
            int hrs = int.Parse(this.hoursTextBox.Text);
            int mins = int.Parse(this.minutesTextBox.Text);

            if (mins == 60)
            {
                mins = 0;
                hrs++;
            }

            if (hrs == 24)
            {
                hrs = 0;
                days++;
            }

            TimeSpan span = new TimeSpan(days, hrs, mins, 0, 0);
            return span;
        }

        private void notifyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.notify = this.notifyCheckBox.Checked;
        }
    }
}