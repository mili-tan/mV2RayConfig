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
            textBoxUUID.Text = Guid.NewGuid().ToString();
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
            JArray centArray = new JArray();

            if (!checkBoxManyUser.Checked)
            {
                clients.id = textBoxUUID.Text;
                clients.alterId = Convert.ToInt32(upDownAlterID.Value);
                if (checkBoxUserLevel.Checked)
                {
                    clients.level = 1;
                }
                else
                {
                    clients.level = 0;
                }
                centArray.Add(JObject.FromObject(clients));
            }
            else
            {
                foreach (var item in listBoxManyUser.Items)
                {
                    centArray.Add(JObject.Parse(item.ToString()));
                }
            }

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

        private void buttonUUID_Click(object sender, EventArgs e)
        {
            textBoxUUID.Text = Guid.NewGuid().ToString();
        }

        private void checkBoxManyUser_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxManyUser.Checked)
            {
                listBoxManyUser.Enabled = true;
                buttonAdd.Enabled = true;
                buttonDel.Enabled = true;
            }
            else
            {
                listBoxManyUser.Enabled = false;
                buttonAdd.Enabled = false;
                buttonDel.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            clients.id = textBoxUUID.Text;
            clients.alterId = Convert.ToInt32(upDownAlterID.Value);
            if (checkBoxUserLevel.Checked)
            {
                clients.level = 1;
            }
            else
            {
                clients.level = 0;
            }
            listBoxManyUser.Items.Add(JsonConvert.SerializeObject(clients));
            textBoxUUID.Text = Guid.NewGuid().ToString();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            listBoxManyUser.Items.Remove(listBoxManyUser.SelectedItem);
        }

        private void listBoxManyUser_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxManyUser.SelectedItem != null)
            {
                MessageBox.Show(listBoxManyUser.SelectedItem.ToString());
            }
        }
    }
}
