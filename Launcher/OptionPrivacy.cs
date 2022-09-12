using System;
using System.Windows.Forms;

namespace Launcher
{
    public partial class OptionPrivacy : Form
    {
        public Main Form1 { get; set; }
        public OptionGeneral Form2 { get; set; }

        public OptionPrivacy()
        {
            InitializeComponent();
        }

        private void OptionPrivacy_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            Hide();
            Form2.Show();
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

        private void BtnTermOfService_Click(object sender, EventArgs e)//apre term
        {
            panel2.Hide();
            panel1.Show();
        }

        private void label2_Click(object sender, EventArgs e)//chiude term
        {
            panel1.Hide();
        }
        private void BtnPrivacyPolicy_Click(object sender, EventArgs e)//apre policy
        {
            panel1.Hide();
            panel2.Show();
        }

        private void labelPolicy_Click(object sender, EventArgs e)//chiude policy
        {
            panel2.Hide();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
