using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

using Microsoft.Win32;

namespace Productivity
{    
    public partial class MainWindow : Form
    {
        [DllImport("user32.dll")]
        static extern int GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern int GetWindowText(int hWnd, StringBuilder text, int count);

        private TimerWindow timerWindow;
        private DataTable running_apps;

        private uint total_seconds;

        private uint days;
        private uint hours;
        private uint minutes;
        private uint seconds;
        private DateTime timer_start;
        private ToolTip tooltips;


        private bool reset = true;

        //private static WindowData window_data;
        //private int old_active;

        private bool timer_on = false;

        public MainWindow()
        {
            InitializeComponent();

            total_seconds = 0;
            days = 0;
            hours = 0;
            minutes = 0;
            seconds = 0;

            timerWindow = new TimerWindow();
            timerWindow.Visible = true;

            //timerDetails = new TimerDetails();
            //timerDetails.Visible = false;

            // get configuration from registry
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.OpenSubKey("Software\\petewarrior.com\\ProductivityTimer\\Settings");
            if (regKey != null) productiveWindowsList.Text = (string) regKey.GetValue("ProductiveApps", "");
            
            this.AddOwnedForm(timerWindow);

            //window_data = new WindowData();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            MainWindow_Close();
            base.OnClosing(e);
        }

        private void MainWindow_Close()
        {
            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.CreateSubKey("Software\\petewarrior.com\\ProductivityTimer\\Settings");
            regKey.SetValue("ProductiveApps", productiveWindowsList.Text, RegistryValueKind.String);
        }

        //
        // GetForegroundWindow API 
        //
        private string GetActiveWindow()
        {
            const int nChars = 256;
            int handle = 0;
            StringBuilder Buff = new StringBuilder(nChars);

            handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            } 
            return "";
        }


        //
        // Get all current windows
        //
        private void GetAllWindows()
        {

        }

        //
        // Update productive time
        //
        private void update_time(uint total_seconds)
        {

            days = total_seconds / 26400;
            hours = (total_seconds % 26400) / 3600;
            minutes = (total_seconds % 3600) / 60;
            seconds = total_seconds % 60;

            StringBuilder time = new StringBuilder();

            if (days == 1)
            {
                time.Append(days + "day ");
            }
            else if (days > 1)
            {
                time.Append(days + "days ");
            }

            time.Append(hours);
            
            time.Append(":");

            if (minutes < 10)
            {
                time.Append("0" + minutes);
            }
            else
            {
                time.Append(minutes);
            }

            time.Append(":");

            if (seconds < 10)
            {
                time.Append("0" + seconds);
            }
            else
            {
                time.Append(seconds);
            }

            ElapsedTime.Text = time.ToString();
            TrayIcon.BalloonTipText = "Your productive time: " + time.ToString();
            timerWindow.timerLabel.Text = time.ToString();
        }

        private void update_elapsed_time(TimeSpan time)
        {

            ElapsedTime.Text = time.TotalSeconds.ToString();
 //           TrayIcon.BalloonTipText = "Your productive time: " + time.ToShortTimeString();
   //         timerWindow.timerLabel.Text = time.ToShortTimeString();
        }

        private void showMainWindow()
        {
            this.ShowInTaskbar = true;
            this.Visible = true;
            this.Activate();
        }

        private void hideMainWindow()
        {
            this.ShowInTaskbar = false;
            this.Visible = false;
        }
        private void resetTimer()
        {
            reset = true;
            total_seconds = 0;
            update_time(total_seconds);

            if (timer_on)
            {
                timer_start = DateTime.Now;
                timerWindow.timeSince.Text = "since " + timer_start.ToShortTimeString();
            }
            else
            {
                timerWindow.timeSince.Text = "";
            }
        }


        //
        // Event Handlers
        //

        private void program_timer_Tick(object sender, EventArgs e)
        {
            string active;
            bool entry_found = false;

            //Dictionary<int, WindowInfo> data;
            //WindowInfo active_data;

            active = GetActiveWindow();
            ActiveApp.Text = active;

            foreach (string entry in productiveWindowsList.Lines)
            {
                if (active.ToLower().Contains(entry.ToLower()) && entry != "") entry_found = true;
            }

            if (entry_found && timer_on) work_timer.Enabled = true;
            else work_timer.Enabled = false;
        
            //data = window_data.updateWindows();
            /* if(active != old_active)
                if (data.TryGetValue(active, out active_data))
                {
                    this.ActiveApp.Text = active_data.title;
                    if (active_data.is_productive) work_timer.Enabled = true;
                    else work_timer.Enabled = false;
                }
            ProductiveWindows.Items.Clear();
            foreach (KeyValuePair<int, WindowInfo> win in data)
            {
                if (win.Value.is_productive)
                    ProductiveWindows.SelectedItems.Add(win.Value.title);
                else
                    ProductiveWindows.Items.Add(win.Value.title);

            } */

        }

        private void work_timer_Tick(object sender, EventArgs e)
        {
            total_seconds++;
            update_time(total_seconds);
        }

        private void ProductiveWindows_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            showMainWindow();
        }

        private void SystrayExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerSwitch_Click(object sender, EventArgs e)
        {
            timer_on = !timer_on;
            if (timer_on)
            {
                if (reset)
                {
                    timer_start = DateTime.Now;
                    //timer_current = new TimeSpan(0, 0, 0);
                    total_seconds = 0;

                    timerWindow.timeSince.Text = "since " + timer_start.ToShortTimeString();
                    reset = false;
                }
                timerLabel.Text = "Timer is ON";
            }
            else timerLabel.Text = "Timer is OFF";


        }

        private void ActiveApp_Click(object sender, EventArgs e)
        {

        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            hideMainWindow();
        }

        private void Systray_Config_Click(object sender, EventArgs e)
        {
            showMainWindow();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            tooltips = new System.Windows.Forms.ToolTip();
            tooltips.SetToolTip(this.groupBox3, "Enter the names (full or partial) of your productive applications here");
        }

        private void openSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://prodtimer.petewarrior.com/");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWindow win = new AboutWindow();
            win.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetTimer();
        }
    }
   
}
