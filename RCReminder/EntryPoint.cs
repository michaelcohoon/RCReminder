using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RCReminder
{
    public partial class EntryPoint : System.Windows.Forms.Form
    {
        private System.Windows.Forms.ContextMenu contextMenu;
        private System.Windows.Forms.MenuItem exitMenuItem;
        private System.Windows.Forms.MenuItem settingsMenuItem;
        private int timeToDisplay = 100;
        private int time = 0;
        Settings settingsForm;

        public EntryPoint()
        {
            this.settingsForm = new Settings();

            InitializeComponent();

            this.components = new System.ComponentModel.Container();
            this.contextMenu = new System.Windows.Forms.ContextMenu();
            this.exitMenuItem = new System.Windows.Forms.MenuItem();
            this.settingsMenuItem = new System.Windows.Forms.MenuItem();
            
            // Initialize contextMenu1
            this.contextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] { this.settingsMenuItem, this.exitMenuItem });

            // Initialize settingsMenuItem
            this.settingsMenuItem.Index = 0;
            this.settingsMenuItem.Text = "S&ettings";
            this.settingsMenuItem.Click += new System.EventHandler(this.settings_Click);

            // Initialize exitMenuItem
            this.exitMenuItem.Index = 1;
            this.exitMenuItem.Text = "E&xit";
            this.exitMenuItem.Click += new System.EventHandler(this.exit_Click);

            // Set up how the form should be displayed.
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Text = "RCReminder";

            // Create the NotifyIcon.
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);

            // The Icon property sets the icon that will appear
            // in the systray for this application.
            notifyIcon.Icon = new Icon("question.ico");

            // The ContextMenu property sets the menu that will
            // appear when the systray icon is right clicked.
            notifyIcon.ContextMenu = this.contextMenu;

            // The Text property sets the text that will be displayed,
            // in a tooltip, when the mouse hovers over the systray icon.
            notifyIcon.Text = "RCReminder";
            notifyIcon.Visible = true;
        }

        private void exit_Click(object Sender, EventArgs e)
        {
            // Close the form, which closes the application.
            settingsForm.Close();
            this.Close();
        }

        private void settings_Click(object Sender, EventArgs e)
        {
            //Hide this form.
            this.Hide();

            // Launches a new form.
            settingsForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (++time >= timeToDisplay)
            {
                this.notifyIcon.ShowBalloonTip(100, "Are you dreaming?", "Question reality.", ToolTipIcon.None);
                time = 0;
            }
        }

        private void SetUpdateTime()
        {
            timeToDisplay = this.settingsForm.GetDisplayTime();
            time = 0;
        }
    }
}
