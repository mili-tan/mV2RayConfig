using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static mV2RayConfig.Config;

namespace mV2RayConfig
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        ServerInfo serverInfo = new ServerInfo();
        Outbound outbound = new Outbound();
        Log log = new Log();

        private void Form1_Load(object sender, EventArgs e)
        {
            log.access = "/var/log/v2ray/access.log";
            log.error = "/var/log/v2ray/error.log";
            log.loglevel = "warning";
            serverInfo.log = log;

            outbound.protocol = "freedom";
            outbound.settings = new Setting();
            serverInfo.outbound = outbound;

            richTextBox1.Text = JsonConvert.SerializeObject(serverInfo);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
