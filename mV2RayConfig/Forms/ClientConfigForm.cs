using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static mV2RayConfig.Config;

namespace mV2RayConfig.Forms
{
    public partial class ClientConfigForm : Form
    {
        public ClientConfigForm()
        {
            InitializeComponent();
        }

        ServerInfo serverInfo = new ServerInfo();
        Outbound outbound = new Outbound();
        Inbound inbound = new Inbound();
        InBoundSetting inBoundSetting = new InBoundSetting();
        VmessClients clients = new VmessClients();
        Log log = new Log();

        private void ClientConfigForm_Load(object sender, EventArgs e)
        {
            richTextBoxConfig.Text = configGen();
        }

        private string configGen()
        {
            log.access = "Vaccess.log";
            log.error = "Verror.log";
            log.loglevel = "debug";
            serverInfo.log = log;

            inbound.port = 1080;
            inbound.protocol = "socks";
            JObject setJson = new JObject();
            setJson["auth"] = "noauth";
            inbound.settings = setJson;
            serverInfo.inbound = inbound;

            outbound.protocol = "vmess";
            clients.id = "";
            clients.alterId = 32;

            JArray centArray = new JArray();
            centArray.Add(JObject.FromObject(clients));

            JObject configJson = JObject.FromObject(serverInfo);
            return MyJson.FormatJsonString(configJson.ToString());
        }
    }
}
