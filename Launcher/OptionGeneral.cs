using Microsoft.Win32;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Launcher
{
    public partial class OptionGeneral : Form
    {
        // The path to the key where Windows looks for startup applications
        readonly RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        public Main Form1 { get; set; }
        public OptionPrivacy Form3 { get; set; }

        public OptionGeneral()
        {
            InitializeComponent();
            // Check to see the current state (running at startup or not)
            if (rkApp.GetValue("MyApp") == null)
            {
                // The value doesn't exist, the application is not set to run at startup
                Properties.Settings.Default.FlagStartUp = false;
            }
            else
            {
                // The value exists, the application is set to run at startup
                Properties.Settings.Default.FlagStartUp = true;
            }
        }

        private void OptionGeneral_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Properties.Settings.Default.FlagStartUp;
            checkBox2.Checked = Properties.Settings.Default.FlagMinimize;
        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            Hide();
            Form1.Show();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            //Process.Start("https://www.shop.html");
        }

        private void btnPrivacy_Click(object sender, EventArgs e)
        {
            Hide();
            Form3.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Start up
            if (checkBox1.Checked)
            {
                checkBox1.Text = "✔";
                checkBox1.BackColor = Color.Red;
            }
            else
            {
                checkBox1.Text = "";
                checkBox1.BackColor = Color.WhiteSmoke;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //Minimize
            if (checkBox2.Checked)
            {
                checkBox2.Text = "✔";
                checkBox2.BackColor = Color.Red;
            }
            else
            {
                checkBox2.Text = "";
                checkBox2.BackColor = Color.WhiteSmoke;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FlagStartUp = checkBox1.Checked;
            Properties.Settings.Default.FlagMinimize = checkBox2.Checked;
            if (Properties.Settings.Default.FlagStartUp)
            {
                // Add the value in the registry so that the application runs at startup
                rkApp.SetValue("MyApp", Application.ExecutablePath);
            }
            else
            {
                // Remove the value from the registry so that the application doesn't start
                rkApp.DeleteValue("MyApp", false);
            }
            Properties.Settings.Default.Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FlagMinimize)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                Form1.Close();
            }
        }
    }
}
