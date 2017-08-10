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
using Newtonsoft.Json.Linq;

namespace mV2RayConfig
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            comboBoxLogLevel.SelectedIndex = 2;
            comboBoxProtocol.SelectedIndex = 0;
        }

        ServerInfo serverInfo = new ServerInfo();
        Outbound outbound = new Outbound();
        Inbound inbound = new Inbound();
        InBoundSetting inBoundSetting = new InBoundSetting();
        VmessClients clients = new VmessClients();
        Log log = new Log();

        private void Form1_Load(object sender, EventArgs e)
        {

            log.access = textBoxAccessLog.Text;
            log.error = textBoxErrorLog.Text;
            log.loglevel = comboBoxLogLevel.Text;
            serverInfo.log = log;

            inbound.port = Convert.ToInt32(upDownPort.Value);
            inbound.protocol = comboBoxProtocol.Text;
            clients.id = Guid.NewGuid().ToString();
            clients.alterId = 100;
            JArray centArray = new JArray();
            centArray.Add(JObject.FromObject(clients));
            inBoundSetting.clients = centArray;
            inbound.settings = inBoundSetting;
            serverInfo.inbound = inbound;

            outbound.protocol = "freedom";
            outbound.settings = new JObject();
            serverInfo.outbound = outbound;

            JObject configJson = JObject.FromObject(serverInfo);

            configJson["outboundDetour"] = JArray.Parse(Resource.outboundDetour);
            configJson["routing"] = JObject.Parse(Resource.routing);

            richTextBox1.Text = MyJson.FormatJsonString(configJson.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(null, null);
        }

        private void labelPort_Click(object sender, EventArgs e)
        {
            upDownPort.Value = new Random(DateTime.Now.Second).Next(2000, 7000);
        }
    }
}
