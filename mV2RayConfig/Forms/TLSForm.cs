using System;
using System.Windows.Forms;

namespace mV2RayConfig
{
    public partial class TLSForm : Form
    {
        public TLSForm()
        {
            InitializeComponent();
        }

        private void TLSForm_Load(object sender, EventArgs e)
        {
            textBoxHostName.Text = Config.ServerName;
            textBoxCertFile.Text = Config.CertificateFile;
            textBoxKeyFile.Text = Config.KeyFile;
            MaximizeBox = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Config.ServerName = textBoxHostName.Text;
            Config.CertificateFile = textBoxCertFile.Text;
            Config.KeyFile = textBoxKeyFile.Text;
            Close();
        }
    }
}
