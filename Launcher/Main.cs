using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Launcher
{
    public partial class Main : Form
    {
        public OptionGeneral Form2 { get; set; }

        public Main()
        {
            InitializeComponent();
            var form3 = new OptionPrivacy() { Form1 = this };
            Form2 = new OptionGeneral() { Form1 = this, Form3 = form3 };
            form3.Form2 = Form2;
            
        }

        public string ipSRV = "185.229.237.102:30120";
        public string DiscordLink = "https://discord.gg/tXBZnJYCCF";
        public string ts3IP = "ts3-3.voicehosting.it:9993";

        private void Form1_Load(object sender, EventArgs e)
        {
            //ServerUpdate();
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            Process.Start(DiscordLink);
        }

        private void btnTs_Click(object sender, EventArgs e)
        {
            Process.Start("ts3server://ts3-3.voicehosting.it:9993");
        }

        private void btbWebsite_Click(object sender, EventArgs e)
        {
            //Process.Start("https://www.home.html");
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Process[] steam = Process.GetProcessesByName("steam");
            if (steam.Length == 0)
            {
                MessageBox.Show("Devi avere steam aperto per poter giocare");
            }
            else
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = "cmd.exe",
                    Arguments = "/C Start fivem://connect/185.229.237.102:30120"
                };
                process.StartInfo = startInfo;
                System.Diagnostics.Process.Start("ts3server://ts3-3.voicehosting.it:9993?password=mugnano");
                process.Start();
                Thread.Sleep(5000);
            }
        }

        public class Player
        {
            public string endpoint { get; set; }
            public int id { get; set; }
            public string[] identifiers { get; set; }
            public string name { get; set; }
            public int ping { get; set; }
        }

        /*public void ServerUpdate()
        {
            string svCon = "http://" + ipSRV + "/players.json";

            // Create a request using a URL that can receive a post.
            WebRequest request = WebRequest.Create(svCon);
            // Set the Method property of the request to POST.
            request.Method = "POST";

            // Create POST data and convert it to a byte array.
            string postData = "This is a test that posts this string to a Web server.";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            try
            {
                // Set the ContentType property of the WebRequest.
                request.ContentType = "application/x-www-form-urlencoded";
                // Set the ContentLength property of the WebRequest.
                request.ContentLength = byteArray.Length;

                // Get the request stream.
                Stream dataStream = request.GetRequestStream();
                // Write the data to the request stream.
                dataStream.Write(byteArray, 0, byteArray.Length);
                // Close the Stream object.
                dataStream.Close();

                // Get the response.
                WebResponse response = request.GetResponse();
                // Display the status.
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);

                string responseFromServer;
                // Get the stream containing content returned by the server.
                // The using block ensures the stream is automatically closed.
                using (dataStream = response.GetResponseStream())
                {
                    // Open the stream using a StreamReader for easy access.
                    StreamReader reader = new StreamReader(dataStream);
                    // Read the content.
                    responseFromServer = reader.ReadToEnd();
                    // Display the content.
                    Console.WriteLine(responseFromServer);
                }
                // Close the response.
                response.Close();
                label2.Text = "Online";
                label2.ForeColor = Color.Green;
                Player[] item = JsonConvert.DeserializeObject<Player[]>(responseFromServer);
                int countPlayers = item.Count();
                label3.Text = countPlayers.ToString() + " Player Connessi";
                label3.Size = new Size(496, 25);
            }
            catch
            {
                label2.Text = "Offline";
                label2.ForeColor = Color.Red;
                //label3.Text = "Entra in Discord e in Teamspeak!";
                label3.Visible = false;
            }
        }*/

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FlagMinimize)
            {
                WindowState = FormWindowState.Minimized;
            }
            else
            {
                Close();
            }
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            //Process.Start("https://www.shop.html");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ServerUpdate();
        }
        public void btnOptions_Click(object sender, EventArgs e)
        {
            Hide();
            Form2.Show();
        }

    }
}
