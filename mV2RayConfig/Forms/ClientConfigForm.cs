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
        string mUUID;
        int aID;
        int mPort;

        public ClientConfigForm(string UUID,int alterId,int port)
        {
            InitializeComponent();
            mUUID = UUID;
            aID = alterId;
            mPort = port;

            comboBoxProtocol.SelectedIndex = 0;
            comboBoxSecurity.SelectedIndex = 0;
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

            outbound.protocol = comboBoxProtocol.Text;
            vnext.address = textBoxHostName.Text;
            vnext.port = mPort;
            clients.id = mUUID;
            clients.alterId = aID;
            JArray clientsArray = new JArray();
            JObject clientsJson = JObject.FromObject(clients);
            clientsJson.Remove("level");
            clientsJson["security"] = comboBoxSecurity.Text;
            clientsArray.Add(clientsJson);
            vnext.users = clientsArray;

            JObject vnextSetJson = new JObject();
            vnextSetJson["vnext"] = JArray.Parse(string.Format("[{0}]", JObject.FromObject(vnext).ToString()));
            outbound.settings = vnextSetJson;

            serverInfo.outbound = outbound;

            JObject configJson = JObject.FromObject(serverInfo);
            return MyJson.FormatJsonString(configJson.ToString());
        }

        private void buttonNewGen_Click(object sender, EventArgs e)
        {
            richTextBoxConfig.Text = configGen();
        }
    }
}
