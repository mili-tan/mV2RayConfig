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
        Vnext vnext = new Vnext();
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
            vnext.address = "serveraddr.com";
            vnext.port = 2333;
            clients.id = "b831381d-6324-4d53-ad4f-8cda48b30811";
            clients.alterId = 32;
            JArray clientsArray = new JArray();
            JObject clientsJson = JObject.FromObject(clients);
            clientsJson.Remove("level");
            clientsArray.Add(clientsJson);
            vnext.users = clientsArray;

            JObject vnextSetJson = new JObject();
            vnextSetJson["vnext"] = JArray.Parse(string.Format("[{0}]", JObject.FromObject(vnext).ToString()));
            outbound.settings = vnextSetJson;

            serverInfo.outbound = outbound;

            JObject configJson = JObject.FromObject(serverInfo);
            return MyJson.FormatJsonString(configJson.ToString());
        }
    }
}
