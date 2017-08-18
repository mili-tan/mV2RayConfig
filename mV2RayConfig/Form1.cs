using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static mV2RayConfig.Config;

namespace mV2RayConfig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxLogLevel.SelectedIndex = 2;
            comboBoxProtocol.SelectedIndex = 0;
            textBoxUUID.Text = uuidGen();
        }

        ServerInfo serverInfo = new ServerInfo();
        Outbound outbound = new Outbound();
        Inbound inbound = new Inbound();
        InBoundSetting inBoundSetting = new InBoundSetting();
        VmessClients clients = new VmessClients();
        Log log = new Log();

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBoxConfig.Text = configGen();
        }

        private void buttonNewGen_Click(object sender, EventArgs e)
        {
            richTextBoxConfig.Text = configGen();
        }

        private void labelPort_Click(object sender, EventArgs e)
        {
            upDownPort.Value = new Random(DateTime.Now.Second).Next(2000, 7000);
        }

        private void buttonUUID_Click(object sender, EventArgs e)
        {
            textBoxUUID.Text = uuidGen();
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
            textBoxUUID.Text = uuidGen();
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

        private string configGen()
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
            JObject stream = new JObject();

            configJson["outboundDetour"] = JArray.Parse(outboundDetourStr);
            if (checkBoxRouting.Checked)
            {
                configJson["routing"] = JObject.Parse(routingStr);
            }

            return MyJson.FormatJsonString(configJson.ToString());
        }

        private string uuidGen()
        {
            return Guid.NewGuid().ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "V2Ray配置文件Json|config.json";
            saveFileDialog.FileName = "config.json";
            saveFileDialog.Title = "保存V2Ray配置文件";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, richTextBoxConfig.Text);
            }
        }
    }
}
