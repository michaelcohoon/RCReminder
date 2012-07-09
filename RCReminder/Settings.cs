﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RCReminder
{
    public partial class Settings : Form
    {
        Boolean notify = true;

        public Settings()
        {
            InitializeComponent();

            // Set up how the form should be displayed.
            this.ClientSize = new System.Drawing.Size(361, 311);
            this.Text = "Settings - RCReminder";

            // Define the border style of the form to a dialog box.
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            // Set the MaximizeBox to false to remove the maximize box.
            this.MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            this.MinimizeBox = false;
            // Set the start position of the form to the center of the screen.
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void notify_CheckedChanged(object sender, EventArgs e)
        {
            notify = !notify;
        }

        private void remindAtTime_CheckedChanged(object sender, EventArgs e)
        {
            this.remindAtTimePanel.Enabled = this.remindAtTimeCheckBox.Checked;
        }

        private void remindEveryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.remindEveryPanel.Enabled = this.remindEveryCheckBox.Checked;
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
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //Close the window after disregarding the changes
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
    }
}