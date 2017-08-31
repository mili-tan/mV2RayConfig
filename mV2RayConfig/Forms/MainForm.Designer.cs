namespace mV2RayConfig
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxConfig = new System.Windows.Forms.RichTextBox();
            this.buttonNewGen = new System.Windows.Forms.Button();
            this.panelLog = new System.Windows.Forms.TableLayoutPanel();
            this.labelLoglevel = new System.Windows.Forms.Label();
            this.labelErrorLog = new System.Windows.Forms.Label();
            this.labelAccessLog = new System.Windows.Forms.Label();
            this.textBoxAccessLog = new System.Windows.Forms.TextBox();
            this.textBoxErrorLog = new System.Windows.Forms.TextBox();
            this.comboBoxLogLevel = new System.Windows.Forms.ComboBox();
            this.panelServerConfig = new System.Windows.Forms.TableLayoutPanel();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelProtocol = new System.Windows.Forms.Label();
            this.comboBoxProtocol = new System.Windows.Forms.ComboBox();
            this.upDownPort = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.upDownAlterID = new System.Windows.Forms.NumericUpDown();
            this.labelAlterID = new System.Windows.Forms.Label();
            this.labelUUID = new System.Windows.Forms.Label();
            this.textBoxUUID = new System.Windows.Forms.TextBox();
            this.buttonUUID = new System.Windows.Forms.Button();
            this.checkBoxUserLevel = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxManyUser = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkBoxManyUser = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxRouting = new System.Windows.Forms.CheckBox();
            this.checkBoxHttpFake = new System.Windows.Forms.CheckBox();
            this.editLink = new System.Windows.Forms.Label();
            this.checkBoxKCP = new System.Windows.Forms.CheckBox();
            this.checkBoxWS = new System.Windows.Forms.CheckBox();
            this.checkBoxTLS = new System.Windows.Forms.CheckBox();
            this.panelLog.SuspendLayout();
            this.panelServerConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPort)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownAlterID)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxConfig
            // 
            this.richTextBoxConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBoxConfig.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBoxConfig.Location = new System.Drawing.Point(13, 6);
            this.richTextBoxConfig.Name = "richTextBoxConfig";
            this.richTextBoxConfig.Size = new System.Drawing.Size(408, 585);
            this.richTextBoxConfig.TabIndex = 0;
            this.richTextBoxConfig.Text = "";
            this.richTextBoxConfig.WordWrap = false;
            // 
            // buttonNewGen
            // 
            this.buttonNewGen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewGen.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonNewGen.Location = new System.Drawing.Point(765, 562);
            this.buttonNewGen.Name = "buttonNewGen";
            this.buttonNewGen.Size = new System.Drawing.Size(75, 29);
            this.buttonNewGen.TabIndex = 1;
            this.buttonNewGen.Text = "生成";
            this.buttonNewGen.UseVisualStyleBackColor = true;
            this.buttonNewGen.Click += new System.EventHandler(this.buttonNewGen_Click);
            // 
            // panelLog
            // 
            this.panelLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLog.BackColor = System.Drawing.Color.Transparent;
            this.panelLog.ColumnCount = 2;
            this.panelLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.68765F));
            this.panelLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.31235F));
            this.panelLog.Controls.Add(this.labelLoglevel, 0, 2);
            this.panelLog.Controls.Add(this.labelErrorLog, 0, 1);
            this.panelLog.Controls.Add(this.labelAccessLog, 0, 0);
            this.panelLog.Controls.Add(this.textBoxAccessLog, 1, 0);
            this.panelLog.Controls.Add(this.textBoxErrorLog, 1, 1);
            this.panelLog.Controls.Add(this.comboBoxLogLevel, 1, 2);
            this.panelLog.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelLog.Location = new System.Drawing.Point(427, 6);
            this.panelLog.Name = "panelLog";
            this.panelLog.RowCount = 3;
            this.panelLog.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLog.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLog.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLog.Size = new System.Drawing.Size(413, 97);
            this.panelLog.TabIndex = 2;
            // 
            // labelLoglevel
            // 
            this.labelLoglevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoglevel.AutoSize = true;
            this.labelLoglevel.Location = new System.Drawing.Point(3, 69);
            this.labelLoglevel.Name = "labelLoglevel";
            this.labelLoglevel.Size = new System.Drawing.Size(128, 20);
            this.labelLoglevel.TabIndex = 5;
            this.labelLoglevel.Text = "日志级别";
            // 
            // labelErrorLog
            // 
            this.labelErrorLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelErrorLog.AutoSize = true;
            this.labelErrorLog.Location = new System.Drawing.Point(3, 36);
            this.labelErrorLog.Name = "labelErrorLog";
            this.labelErrorLog.Size = new System.Drawing.Size(128, 20);
            this.labelErrorLog.TabIndex = 2;
            this.labelErrorLog.Text = "错误日志储存位置";
            // 
            // labelAccessLog
            // 
            this.labelAccessLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAccessLog.AutoSize = true;
            this.labelAccessLog.Location = new System.Drawing.Point(3, 5);
            this.labelAccessLog.Name = "labelAccessLog";
            this.labelAccessLog.Size = new System.Drawing.Size(128, 20);
            this.labelAccessLog.TabIndex = 1;
            this.labelAccessLog.Text = "访问日志储存位置";
            // 
            // textBoxAccessLog
            // 
            this.textBoxAccessLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAccessLog.Location = new System.Drawing.Point(137, 3);
            this.textBoxAccessLog.Name = "textBoxAccessLog";
            this.textBoxAccessLog.Size = new System.Drawing.Size(273, 25);
            this.textBoxAccessLog.TabIndex = 3;
            this.textBoxAccessLog.Text = "/var/log/v2ray/access.log";
            // 
            // textBoxErrorLog
            // 
            this.textBoxErrorLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxErrorLog.Location = new System.Drawing.Point(137, 34);
            this.textBoxErrorLog.Name = "textBoxErrorLog";
            this.textBoxErrorLog.Size = new System.Drawing.Size(273, 25);
            this.textBoxErrorLog.TabIndex = 4;
            this.textBoxErrorLog.Text = "/var/log/v2ray/error.log";
            // 
            // comboBoxLogLevel
            // 
            this.comboBoxLogLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLogLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLogLevel.FormattingEnabled = true;
            this.comboBoxLogLevel.Items.AddRange(new object[] {
            "debug",
            "info",
            "warning",
            "error",
            "none"});
            this.comboBoxLogLevel.Location = new System.Drawing.Point(137, 66);
            this.comboBoxLogLevel.Name = "comboBoxLogLevel";
            this.comboBoxLogLevel.Size = new System.Drawing.Size(273, 27);
            this.comboBoxLogLevel.TabIndex = 6;
            // 
            // panelServerConfig
            // 
            this.panelServerConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelServerConfig.BackColor = System.Drawing.Color.Transparent;
            this.panelServerConfig.ColumnCount = 2;
            this.panelServerConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.44552F));
            this.panelServerConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.55448F));
            this.panelServerConfig.Controls.Add(this.labelPort, 0, 1);
            this.panelServerConfig.Controls.Add(this.labelProtocol, 0, 0);
            this.panelServerConfig.Controls.Add(this.comboBoxProtocol, 1, 0);
            this.panelServerConfig.Controls.Add(this.upDownPort, 1, 1);
            this.panelServerConfig.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelServerConfig.Location = new System.Drawing.Point(427, 110);
            this.panelServerConfig.Name = "panelServerConfig";
            this.panelServerConfig.RowCount = 2;
            this.panelServerConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelServerConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelServerConfig.Size = new System.Drawing.Size(413, 64);
            this.panelServerConfig.TabIndex = 3;
            // 
            // labelPort
            // 
            this.labelPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(3, 38);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(127, 20);
            this.labelPort.TabIndex = 8;
            this.labelPort.Text = "端口 (1~65535)";
            this.labelPort.Click += new System.EventHandler(this.labelPort_Click);
            // 
            // labelProtocol
            // 
            this.labelProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProtocol.AutoSize = true;
            this.labelProtocol.Location = new System.Drawing.Point(3, 6);
            this.labelProtocol.Name = "labelProtocol";
            this.labelProtocol.Size = new System.Drawing.Size(127, 20);
            this.labelProtocol.TabIndex = 6;
            this.labelProtocol.Text = "服务类型";
            // 
            // comboBoxProtocol
            // 
            this.comboBoxProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProtocol.FormattingEnabled = true;
            this.comboBoxProtocol.Items.AddRange(new object[] {
            "vmess"});
            this.comboBoxProtocol.Location = new System.Drawing.Point(136, 3);
            this.comboBoxProtocol.Name = "comboBoxProtocol";
            this.comboBoxProtocol.Size = new System.Drawing.Size(274, 27);
            this.comboBoxProtocol.TabIndex = 7;
            // 
            // upDownPort
            // 
            this.upDownPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.upDownPort.Location = new System.Drawing.Point(136, 36);
            this.upDownPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.upDownPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownPort.Name = "upDownPort";
            this.upDownPort.Size = new System.Drawing.Size(274, 25);
            this.upDownPort.TabIndex = 9;
            this.upDownPort.Value = new decimal(new int[] {
            2332,
            0,
            0,
            0});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.44552F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.55448F));
            this.tableLayoutPanel1.Controls.Add(this.upDownAlterID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAlterID, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelUUID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxUUID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonUUID, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxUserLevel, 1, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(427, 180);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 96);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // upDownAlterID
            // 
            this.upDownAlterID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.upDownAlterID.Location = new System.Drawing.Point(136, 34);
            this.upDownAlterID.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.upDownAlterID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upDownAlterID.Name = "upDownAlterID";
            this.upDownAlterID.Size = new System.Drawing.Size(274, 25);
            this.upDownAlterID.TabIndex = 10;
            this.upDownAlterID.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // labelAlterID
            // 
            this.labelAlterID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAlterID.AutoSize = true;
            this.labelAlterID.Location = new System.Drawing.Point(3, 36);
            this.labelAlterID.Name = "labelAlterID";
            this.labelAlterID.Size = new System.Drawing.Size(127, 20);
            this.labelAlterID.TabIndex = 8;
            this.labelAlterID.Text = "AlterID数量";
            // 
            // labelUUID
            // 
            this.labelUUID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUUID.AutoSize = true;
            this.labelUUID.Location = new System.Drawing.Point(3, 5);
            this.labelUUID.Name = "labelUUID";
            this.labelUUID.Size = new System.Drawing.Size(127, 20);
            this.labelUUID.TabIndex = 7;
            this.labelUUID.Text = "用户UUID";
            // 
            // textBoxUUID
            // 
            this.textBoxUUID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUUID.Location = new System.Drawing.Point(136, 3);
            this.textBoxUUID.Name = "textBoxUUID";
            this.textBoxUUID.Size = new System.Drawing.Size(274, 25);
            this.textBoxUUID.TabIndex = 9;
            this.textBoxUUID.Text = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            // 
            // buttonUUID
            // 
            this.buttonUUID.Location = new System.Drawing.Point(3, 65);
            this.buttonUUID.Name = "buttonUUID";
            this.buttonUUID.Size = new System.Drawing.Size(127, 29);
            this.buttonUUID.TabIndex = 11;
            this.buttonUUID.Text = "重新生成UUID";
            this.buttonUUID.UseVisualStyleBackColor = true;
            this.buttonUUID.Click += new System.EventHandler(this.buttonUUID_Click);
            // 
            // checkBoxUserLevel
            // 
            this.checkBoxUserLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxUserLevel.AutoSize = true;
            this.checkBoxUserLevel.Checked = true;
            this.checkBoxUserLevel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUserLevel.Location = new System.Drawing.Point(136, 67);
            this.checkBoxUserLevel.Name = "checkBoxUserLevel";
            this.checkBoxUserLevel.Size = new System.Drawing.Size(274, 24);
            this.checkBoxUserLevel.TabIndex = 12;
            this.checkBoxUserLevel.Text = "信任此用户，放宽对此用户的限制";
            this.checkBoxUserLevel.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.44552F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.55448F));
            this.tableLayoutPanel2.Controls.Add(this.listBoxManyUser, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxManyUser, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(427, 283);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.64151F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.35849F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(413, 159);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // listBoxManyUser
            // 
            this.listBoxManyUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxManyUser.Enabled = false;
            this.listBoxManyUser.Font = new System.Drawing.Font("微软雅黑", 7.8F);
            this.listBoxManyUser.FormattingEnabled = true;
            this.listBoxManyUser.ItemHeight = 19;
            this.listBoxManyUser.Location = new System.Drawing.Point(136, 39);
            this.listBoxManyUser.Name = "listBoxManyUser";
            this.listBoxManyUser.Size = new System.Drawing.Size(274, 117);
            this.listBoxManyUser.TabIndex = 0;
            this.listBoxManyUser.DoubleClick += new System.EventHandler(this.listBoxManyUser_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDel);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Location = new System.Drawing.Point(3, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 117);
            this.panel1.TabIndex = 16;
            // 
            // buttonDel
            // 
            this.buttonDel.Enabled = false;
            this.buttonDel.Font = new System.Drawing.Font("微软雅黑", 7.8F);
            this.buttonDel.Location = new System.Drawing.Point(0, 38);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(126, 29);
            this.buttonDel.TabIndex = 15;
            this.buttonDel.Text = "删除用户";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Font = new System.Drawing.Font("微软雅黑", 7.8F);
            this.buttonAdd.Location = new System.Drawing.Point(0, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(126, 29);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "添加用户";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkBoxManyUser
            // 
            this.checkBoxManyUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxManyUser.AutoSize = true;
            this.checkBoxManyUser.Font = new System.Drawing.Font("微软雅黑", 7.8F);
            this.checkBoxManyUser.Location = new System.Drawing.Point(136, 6);
            this.checkBoxManyUser.Name = "checkBoxManyUser";
            this.checkBoxManyUser.Size = new System.Drawing.Size(274, 24);
            this.checkBoxManyUser.TabIndex = 13;
            this.checkBoxManyUser.Text = "启用多用户";
            this.checkBoxManyUser.UseVisualStyleBackColor = true;
            this.checkBoxManyUser.CheckedChanged += new System.EventHandler(this.checkBoxManyUser_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSave.Location = new System.Drawing.Point(684, 562);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 29);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxRouting
            // 
            this.checkBoxRouting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRouting.AutoSize = true;
            this.checkBoxRouting.Checked = true;
            this.checkBoxRouting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRouting.Font = new System.Drawing.Font("微软雅黑", 7.8F);
            this.checkBoxRouting.Location = new System.Drawing.Point(564, 440);
            this.checkBoxRouting.Name = "checkBoxRouting";
            this.checkBoxRouting.Size = new System.Drawing.Size(203, 24);
            this.checkBoxRouting.TabIndex = 7;
            this.checkBoxRouting.Text = "启用路由规则 屏蔽内网访问";
            this.checkBoxRouting.UseVisualStyleBackColor = true;
            // 
            // checkBoxHttpFake
            // 
            this.checkBoxHttpFake.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxHttpFake.AutoSize = true;
            this.checkBoxHttpFake.Font = new System.Drawing.Font("微软雅黑", 7.8F);
            this.checkBoxHttpFake.Location = new System.Drawing.Point(564, 461);
            this.checkBoxHttpFake.Name = "checkBoxHttpFake";
            this.checkBoxHttpFake.Size = new System.Drawing.Size(117, 24);
            this.checkBoxHttpFake.TabIndex = 8;
            this.checkBoxHttpFake.Text = "启用Http伪装";
            this.checkBoxHttpFake.UseVisualStyleBackColor = true;
            this.checkBoxHttpFake.CheckedChanged += new System.EventHandler(this.checkBoxHttpFake_CheckedChanged);
            // 
            // editLink
            // 
            this.editLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editLink.AutoSize = true;
            this.editLink.Font = new System.Drawing.Font("微软雅黑", 7.8F);
            this.editLink.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.editLink.Location = new System.Drawing.Point(680, 462);
            this.editLink.Name = "editLink";
            this.editLink.Size = new System.Drawing.Size(37, 20);
            this.editLink.TabIndex = 9;
            this.editLink.Text = "编辑";
            this.editLink.Click += new System.EventHandler(this.editLink_Click);
            // 
            // checkBoxKCP
            // 
            this.checkBoxKCP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxKCP.AutoSize = true;
            this.checkBoxKCP.Font = new System.Drawing.Font("微软雅黑", 7.8F);
            this.checkBoxKCP.Location = new System.Drawing.Point(564, 482);
            this.checkBoxKCP.Name = "checkBoxKCP";
            this.checkBoxKCP.Size = new System.Drawing.Size(99, 24);
            this.checkBoxKCP.TabIndex = 10;
            this.checkBoxKCP.Text = "启用mKCP";
            this.checkBoxKCP.UseVisualStyleBackColor = true;
            this.checkBoxKCP.CheckedChanged += new System.EventHandler(this.checkBoxKCP_CheckedChanged);
            // 
            // checkBoxWS
            // 
            this.checkBoxWS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxWS.AutoSize = true;
            this.checkBoxWS.Font = new System.Drawing.Font("微软雅黑", 7.8F);
            this.checkBoxWS.Location = new System.Drawing.Point(564, 503);
            this.checkBoxWS.Name = "checkBoxWS";
            this.checkBoxWS.Size = new System.Drawing.Size(135, 24);
            this.checkBoxWS.TabIndex = 11;
            this.checkBoxWS.Text = "启用WebSocket";
            this.checkBoxWS.UseVisualStyleBackColor = true;
            this.checkBoxWS.CheckedChanged += new System.EventHandler(this.checkBoxWS_CheckedChanged);
            // 
            // checkBoxTLS
            // 
            this.checkBoxTLS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxTLS.AutoSize = true;
            this.checkBoxTLS.Font = new System.Drawing.Font("微软雅黑", 7.8F);
            this.checkBoxTLS.Location = new System.Drawing.Point(564, 524);
            this.checkBoxTLS.Name = "checkBoxTLS";
            this.checkBoxTLS.Size = new System.Drawing.Size(166, 24);
            this.checkBoxTLS.TabIndex = 12;
            this.checkBoxTLS.Text = "启用TLS (传输层安全)";
            this.checkBoxTLS.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(852, 603);
            this.Controls.Add(this.checkBoxTLS);
            this.Controls.Add(this.checkBoxWS);
            this.Controls.Add(this.checkBoxKCP);
            this.Controls.Add(this.editLink);
            this.Controls.Add(this.checkBoxHttpFake);
            this.Controls.Add(this.checkBoxRouting);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelServerConfig);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.buttonNewGen);
            this.Controls.Add(this.richTextBoxConfig);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "V2RayConfig";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
            this.panelServerConfig.ResumeLayout(false);
            this.panelServerConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPort)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownAlterID)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxConfig;
        private System.Windows.Forms.Button buttonNewGen;
        private System.Windows.Forms.TableLayoutPanel panelLog;
        private System.Windows.Forms.Label labelErrorLog;
        private System.Windows.Forms.Label labelAccessLog;
        private System.Windows.Forms.TextBox textBoxAccessLog;
        private System.Windows.Forms.TextBox textBoxErrorLog;
        private System.Windows.Forms.Label labelLoglevel;
        private System.Windows.Forms.ComboBox comboBoxLogLevel;
        private System.Windows.Forms.TableLayoutPanel panelServerConfig;
        private System.Windows.Forms.Label labelProtocol;
        private System.Windows.Forms.ComboBox comboBoxProtocol;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.NumericUpDown upDownPort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown upDownAlterID;
        private System.Windows.Forms.Label labelAlterID;
        private System.Windows.Forms.Label labelUUID;
        private System.Windows.Forms.TextBox textBoxUUID;
        private System.Windows.Forms.Button buttonUUID;
        private System.Windows.Forms.CheckBox checkBoxUserLevel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox listBoxManyUser;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckBox checkBoxManyUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxRouting;
        private System.Windows.Forms.CheckBox checkBoxHttpFake;
        private System.Windows.Forms.Label editLink;
        private System.Windows.Forms.CheckBox checkBoxKCP;
        private System.Windows.Forms.CheckBox checkBoxWS;
        private System.Windows.Forms.CheckBox checkBoxTLS;
    }
}

