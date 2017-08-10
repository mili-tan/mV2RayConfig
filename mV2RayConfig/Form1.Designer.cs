namespace mV2RayConfig
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.labelUUID = new System.Windows.Forms.Label();
            this.labelAlterID = new System.Windows.Forms.Label();
            this.textBoxUUID = new System.Windows.Forms.TextBox();
            this.upDownAlterID = new System.Windows.Forms.NumericUpDown();
            this.buttonUUID = new System.Windows.Forms.Button();
            this.panelLog.SuspendLayout();
            this.panelServerConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownPort)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upDownAlterID)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox1.Location = new System.Drawing.Point(13, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(408, 475);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(765, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLog
            // 
            this.panelLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLog.BackColor = System.Drawing.Color.Transparent;
            this.panelLog.ColumnCount = 2;
            this.panelLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.44552F));
            this.panelLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.55448F));
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
            this.comboBoxLogLevel.Location = new System.Drawing.Point(137, 68);
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
            this.labelPort.Location = new System.Drawing.Point(3, 36);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(128, 20);
            this.labelPort.TabIndex = 8;
            this.labelPort.Text = "端口号";
            this.labelPort.Click += new System.EventHandler(this.labelPort_Click);
            // 
            // labelProtocol
            // 
            this.labelProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProtocol.AutoSize = true;
            this.labelProtocol.Location = new System.Drawing.Point(3, 4);
            this.labelProtocol.Name = "labelProtocol";
            this.labelProtocol.Size = new System.Drawing.Size(128, 20);
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
            this.comboBoxProtocol.Location = new System.Drawing.Point(137, 3);
            this.comboBoxProtocol.Name = "comboBoxProtocol";
            this.comboBoxProtocol.Size = new System.Drawing.Size(273, 27);
            this.comboBoxProtocol.TabIndex = 7;
            // 
            // upDownPort
            // 
            this.upDownPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.upDownPort.Location = new System.Drawing.Point(137, 34);
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
            this.upDownPort.Size = new System.Drawing.Size(273, 25);
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
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(427, 180);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 193);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // labelUUID
            // 
            this.labelUUID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUUID.AutoSize = true;
            this.labelUUID.Location = new System.Drawing.Point(3, 5);
            this.labelUUID.Name = "labelUUID";
            this.labelUUID.Size = new System.Drawing.Size(128, 20);
            this.labelUUID.TabIndex = 7;
            this.labelUUID.Text = "用户UUID";
            // 
            // labelAlterID
            // 
            this.labelAlterID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAlterID.AutoSize = true;
            this.labelAlterID.Location = new System.Drawing.Point(3, 36);
            this.labelAlterID.Name = "labelAlterID";
            this.labelAlterID.Size = new System.Drawing.Size(128, 20);
            this.labelAlterID.TabIndex = 8;
            this.labelAlterID.Text = "AlterID数量";
            // 
            // textBoxUUID
            // 
            this.textBoxUUID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUUID.Location = new System.Drawing.Point(137, 3);
            this.textBoxUUID.Name = "textBoxUUID";
            this.textBoxUUID.Size = new System.Drawing.Size(273, 25);
            this.textBoxUUID.TabIndex = 9;
            this.textBoxUUID.Text = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            // 
            // upDownAlterID
            // 
            this.upDownAlterID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.upDownAlterID.Location = new System.Drawing.Point(137, 34);
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
            this.upDownAlterID.Size = new System.Drawing.Size(273, 25);
            this.upDownAlterID.TabIndex = 10;
            this.upDownAlterID.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // buttonUUID
            // 
            this.buttonUUID.Location = new System.Drawing.Point(3, 65);
            this.buttonUUID.Name = "buttonUUID";
            this.buttonUUID.Size = new System.Drawing.Size(128, 32);
            this.buttonUUID.TabIndex = 11;
            this.buttonUUID.Text = "重新生成UUID";
            this.buttonUUID.UseVisualStyleBackColor = true;
            this.buttonUUID.Click += new System.EventHandler(this.buttonUUID_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 493);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelServerConfig);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
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
    }
}

