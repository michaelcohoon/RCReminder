namespace RCReminder
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hoursTextBox = new System.Windows.Forms.MaskedTextBox();
            this.minutesTextBox = new System.Windows.Forms.MaskedTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.notifyCheckBox = new System.Windows.Forms.CheckBox();
            this.remindEveryPanel = new System.Windows.Forms.Panel();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.remindAtTimePanel = new System.Windows.Forms.Panel();
            this.hoursComboBox3 = new System.Windows.Forms.ComboBox();
            this.hoursComboBox2 = new System.Windows.Forms.ComboBox();
            this.hoursComboBox1 = new System.Windows.Forms.ComboBox();
            this.minutesComboBox3 = new System.Windows.Forms.ComboBox();
            this.minutesComboBox2 = new System.Windows.Forms.ComboBox();
            this.minutesComboBox1 = new System.Windows.Forms.ComboBox();
            this.remindEveryCheckBox = new System.Windows.Forms.CheckBox();
            this.remindAtTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.minutesLabel = new System.Windows.Forms.Label();
            this.remindEveryPanel.SuspendLayout();
            this.remindAtTimePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // hoursTextBox
            // 
            this.hoursTextBox.Location = new System.Drawing.Point(0, 5);
            this.hoursTextBox.Name = "hoursTextBox";
            this.hoursTextBox.Size = new System.Drawing.Size(121, 20);
            this.hoursTextBox.TabIndex = 1;
            this.hoursTextBox.Text = "0";
            this.hoursTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hoursTextBox_KeyDown);
            // 
            // minutesTextBox
            // 
            this.minutesTextBox.Location = new System.Drawing.Point(175, 3);
            this.minutesTextBox.Name = "minutesTextBox";
            this.minutesTextBox.Size = new System.Drawing.Size(121, 20);
            this.minutesTextBox.TabIndex = 0;
            this.minutesTextBox.Text = "1";
            this.minutesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minutesTextBox_KeyDown);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(193, 271);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(274, 271);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 271);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset Fields";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // notifyCheckBox
            // 
            this.notifyCheckBox.AutoSize = true;
            this.notifyCheckBox.Checked = true;
            this.notifyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.notifyCheckBox.Location = new System.Drawing.Point(12, 236);
            this.notifyCheckBox.Name = "notifyCheckBox";
            this.notifyCheckBox.Size = new System.Drawing.Size(121, 17);
            this.notifyCheckBox.TabIndex = 4;
            this.notifyCheckBox.Text = "Display Notifications";
            this.notifyCheckBox.UseVisualStyleBackColor = true;
            this.notifyCheckBox.CheckedChanged += new System.EventHandler(this.notify_CheckedChanged);
            // 
            // remindEveryPanel
            // 
            this.remindEveryPanel.Controls.Add(this.hoursLabel);
            this.remindEveryPanel.Controls.Add(this.minutesTextBox);
            this.remindEveryPanel.Controls.Add(this.hoursTextBox);
            this.remindEveryPanel.Location = new System.Drawing.Point(12, 40);
            this.remindEveryPanel.Name = "remindEveryPanel";
            this.remindEveryPanel.Size = new System.Drawing.Size(299, 33);
            this.remindEveryPanel.TabIndex = 3;
            // 
            // hoursLabel
            // 
            this.hoursLabel.AutoSize = true;
            this.hoursLabel.Location = new System.Drawing.Point(127, 8);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(39, 13);
            this.hoursLabel.TabIndex = 2;
            this.hoursLabel.Text = "hour(s)";
            // 
            // remindAtTimePanel
            // 
            this.remindAtTimePanel.Controls.Add(this.hoursComboBox3);
            this.remindAtTimePanel.Controls.Add(this.hoursComboBox2);
            this.remindAtTimePanel.Controls.Add(this.hoursComboBox1);
            this.remindAtTimePanel.Controls.Add(this.minutesComboBox3);
            this.remindAtTimePanel.Controls.Add(this.minutesComboBox2);
            this.remindAtTimePanel.Controls.Add(this.minutesComboBox1);
            this.remindAtTimePanel.Enabled = false;
            this.remindAtTimePanel.Location = new System.Drawing.Point(12, 117);
            this.remindAtTimePanel.Name = "remindAtTimePanel";
            this.remindAtTimePanel.Size = new System.Drawing.Size(299, 108);
            this.remindAtTimePanel.TabIndex = 2;
            // 
            // hoursComboBox3
            // 
            this.hoursComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hoursComboBox3.FormattingEnabled = true;
            this.hoursComboBox3.Items.AddRange(new object[] {
            " ",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.hoursComboBox3.Location = new System.Drawing.Point(3, 70);
            this.hoursComboBox3.Name = "hoursComboBox3";
            this.hoursComboBox3.Size = new System.Drawing.Size(121, 21);
            this.hoursComboBox3.TabIndex = 0;
            // 
            // hoursComboBox2
            // 
            this.hoursComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hoursComboBox2.FormattingEnabled = true;
            this.hoursComboBox2.Items.AddRange(new object[] {
            " ",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.hoursComboBox2.Location = new System.Drawing.Point(3, 43);
            this.hoursComboBox2.Name = "hoursComboBox2";
            this.hoursComboBox2.Size = new System.Drawing.Size(121, 21);
            this.hoursComboBox2.TabIndex = 1;
            // 
            // hoursComboBox1
            // 
            this.hoursComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hoursComboBox1.FormattingEnabled = true;
            this.hoursComboBox1.Items.AddRange(new object[] {
            " ",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.hoursComboBox1.Location = new System.Drawing.Point(3, 16);
            this.hoursComboBox1.Name = "hoursComboBox1";
            this.hoursComboBox1.Size = new System.Drawing.Size(121, 21);
            this.hoursComboBox1.TabIndex = 2;
            // 
            // minutesComboBox3
            // 
            this.minutesComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minutesComboBox3.FormattingEnabled = true;
            this.minutesComboBox3.Items.AddRange(new object[] {
            " ",
            "00",
            "15",
            "30",
            "45"});
            this.minutesComboBox3.Location = new System.Drawing.Point(175, 70);
            this.minutesComboBox3.Name = "minutesComboBox3";
            this.minutesComboBox3.Size = new System.Drawing.Size(121, 21);
            this.minutesComboBox3.TabIndex = 3;
            // 
            // minutesComboBox2
            // 
            this.minutesComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minutesComboBox2.FormattingEnabled = true;
            this.minutesComboBox2.Items.AddRange(new object[] {
            " ",
            "00",
            "15",
            "30",
            "45"});
            this.minutesComboBox2.Location = new System.Drawing.Point(175, 43);
            this.minutesComboBox2.Name = "minutesComboBox2";
            this.minutesComboBox2.Size = new System.Drawing.Size(121, 21);
            this.minutesComboBox2.TabIndex = 4;
            // 
            // minutesComboBox1
            // 
            this.minutesComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minutesComboBox1.FormattingEnabled = true;
            this.minutesComboBox1.Items.AddRange(new object[] {
            " ",
            "00",
            "15",
            "30",
            "45"});
            this.minutesComboBox1.Location = new System.Drawing.Point(175, 16);
            this.minutesComboBox1.Name = "minutesComboBox1";
            this.minutesComboBox1.Size = new System.Drawing.Size(121, 21);
            this.minutesComboBox1.TabIndex = 5;
            // 
            // remindEveryCheckBox
            // 
            this.remindEveryCheckBox.AutoSize = true;
            this.remindEveryCheckBox.Checked = true;
            this.remindEveryCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.remindEveryCheckBox.Location = new System.Drawing.Point(12, 17);
            this.remindEveryCheckBox.Name = "remindEveryCheckBox";
            this.remindEveryCheckBox.Size = new System.Drawing.Size(114, 17);
            this.remindEveryCheckBox.TabIndex = 0;
            this.remindEveryCheckBox.Text = "Remind me every: ";
            this.remindEveryCheckBox.UseVisualStyleBackColor = true;
            this.remindEveryCheckBox.CheckedChanged += new System.EventHandler(this.remindEveryCheckBox_CheckedChanged);
            // 
            // remindAtTimeCheckBox
            // 
            this.remindAtTimeCheckBox.AutoSize = true;
            this.remindAtTimeCheckBox.Location = new System.Drawing.Point(12, 94);
            this.remindAtTimeCheckBox.Name = "remindAtTimeCheckBox";
            this.remindAtTimeCheckBox.Size = new System.Drawing.Size(150, 17);
            this.remindAtTimeCheckBox.TabIndex = 1;
            this.remindAtTimeCheckBox.Text = "Remind me at these times:";
            this.remindAtTimeCheckBox.UseVisualStyleBackColor = true;
            this.remindAtTimeCheckBox.CheckedChanged += new System.EventHandler(this.remindAtTime_CheckedChanged);
            // 
            // minutesLabel
            // 
            this.minutesLabel.AutoSize = true;
            this.minutesLabel.Location = new System.Drawing.Point(314, 46);
            this.minutesLabel.Name = "minutesLabel";
            this.minutesLabel.Size = new System.Drawing.Size(43, 13);
            this.minutesLabel.TabIndex = 8;
            this.minutesLabel.Text = "minutes";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 306);
            this.Controls.Add(this.minutesLabel);
            this.Controls.Add(this.remindAtTimeCheckBox);
            this.Controls.Add(this.remindEveryCheckBox);
            this.Controls.Add(this.remindAtTimePanel);
            this.Controls.Add(this.remindEveryPanel);
            this.Controls.Add(this.notifyCheckBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Name = "Settings";
            this.Text = "     ";
            this.remindEveryPanel.ResumeLayout(false);
            this.remindEveryPanel.PerformLayout();
            this.remindAtTimePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox hoursTextBox;
        private System.Windows.Forms.MaskedTextBox minutesTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.CheckBox notifyCheckBox;
        private System.Windows.Forms.CheckBox remindEveryCheckBox;
        private System.Windows.Forms.CheckBox remindAtTimeCheckBox;
        private System.Windows.Forms.Panel remindEveryPanel;
        private System.Windows.Forms.Panel remindAtTimePanel;
        private System.Windows.Forms.ComboBox hoursComboBox3;
        private System.Windows.Forms.ComboBox hoursComboBox2;
        private System.Windows.Forms.ComboBox hoursComboBox1;
        private System.Windows.Forms.ComboBox minutesComboBox3;
        private System.Windows.Forms.ComboBox minutesComboBox2;
        private System.Windows.Forms.ComboBox minutesComboBox1;
        private System.Windows.Forms.Label hoursLabel;
        private System.Windows.Forms.Label minutesLabel;
    }
}