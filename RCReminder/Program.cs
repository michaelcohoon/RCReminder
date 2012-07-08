using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RCReminder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
             ProcessStartInfo startInfo = new ProcessStartInfo();
             startInfo.FileName = "RCReminder.exe";
             startInfo.WindowStyle = ProcessWindowStyle.Hidden;
             Process process = new Process();
             process.StartInfo = startInfo;
             process.Start();
            
             process.Kill();
             */

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EntryPoint());
        }
    }
}
