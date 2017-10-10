using System;
using System.Windows.Forms;
using static mV2RayConfig.Config;

namespace mV2RayConfig
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            richTextBoxConfig.Text = MyJson.FormatJsonString(HttpFakeStr);
            MaximizeBox = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            HttpFakeStr = richTextBoxConfig.Text;
            Close();
        }
    }
}
