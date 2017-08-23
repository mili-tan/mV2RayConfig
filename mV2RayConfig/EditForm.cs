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
            richTextBoxConfig.Text = MyJson.FormatJsonString(httpFakeStr);
            MaximizeBox = false;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            httpFakeStr = richTextBoxConfig.Text;
            Close();
        }
    }
}
