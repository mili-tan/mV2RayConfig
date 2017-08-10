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
            this.labelAccessLog = new System.Windows.Forms.Label();
            this.labelErrorLog = new System.Windows.Forms.Label();
            this.textBoxAccessLog = new System.Windows.Forms.TextBox();
            this.textBoxErrorLog = new System.Windows.Forms.TextBox();
            this.labelLoglevel = new System.Windows.Forms.Label();
            this.comboBoxLogLevel = new System.Windows.Forms.ComboBox();
            this.panelLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(408, 459);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(765, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLog
            // 
            this.panelLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLog.ColumnCount = 2;
            this.panelLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelLog.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelLog.Controls.Add(this.labelLoglevel, 0, 2);
            this.panelLog.Controls.Add(this.labelErrorLog, 0, 1);
            this.panelLog.Controls.Add(this.labelAccessLog, 0, 0);
            this.panelLog.Controls.Add(this.textBoxAccessLog, 1, 0);
            this.panelLog.Controls.Add(this.textBoxErrorLog, 1, 1);
            this.panelLog.Controls.Add(this.comboBoxLogLevel, 1, 2);
            this.panelLog.Location = new System.Drawing.Point(427, 6);
            this.panelLog.Name = "panelLog";
            this.panelLog.RowCount = 3;
            this.panelLog.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLog.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLog.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLog.Size = new System.Drawing.Size(413, 97);
            this.panelLog.TabIndex = 2;
            // 
            // labelAccessLog
            // 
            this.labelAccessLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAccessLog.AutoSize = true;
            this.labelAccessLog.Location = new System.Drawing.Point(3, 8);
            this.labelAccessLog.Name = "labelAccessLog";
            this.labelAccessLog.Size = new System.Drawing.Size(127, 15);
            this.labelAccessLog.TabIndex = 1;
            this.labelAccessLog.Text = "访问日志储存位置";
            // 
            // labelErrorLog
            // 
            this.labelErrorLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelErrorLog.AutoSize = true;
            this.labelErrorLog.Location = new System.Drawing.Point(3, 39);
            this.labelErrorLog.Name = "labelErrorLog";
            this.labelErrorLog.Size = new System.Drawing.Size(127, 15);
            this.labelErrorLog.TabIndex = 2;
            this.labelErrorLog.Text = "错误日志储存位置";
            // 
            // textBoxAccessLog
            // 
            this.textBoxAccessLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAccessLog.Location = new System.Drawing.Point(136, 3);
            this.textBoxAccessLog.Name = "textBoxAccessLog";
            this.textBoxAccessLog.Size = new System.Drawing.Size(274, 25);
            this.textBoxAccessLog.TabIndex = 3;
            this.textBoxAccessLog.Text = "/var/log/v2ray/access.log";
            // 
            // textBoxErrorLog
            // 
            this.textBoxErrorLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxErrorLog.Location = new System.Drawing.Point(136, 34);
            this.textBoxErrorLog.Name = "textBoxErrorLog";
            this.textBoxErrorLog.Size = new System.Drawing.Size(274, 25);
            this.textBoxErrorLog.TabIndex = 4;
            this.textBoxErrorLog.Text = "/var/log/v2ray/error.log";
            // 
            // labelLoglevel
            // 
            this.labelLoglevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoglevel.AutoSize = true;
            this.labelLoglevel.Location = new System.Drawing.Point(3, 72);
            this.labelLoglevel.Name = "labelLoglevel";
            this.labelLoglevel.Size = new System.Drawing.Size(127, 15);
            this.labelLoglevel.TabIndex = 5;
            this.labelLoglevel.Text = "日志级别";
            // 
            // comboBoxLogLevel
            // 
            this.comboBoxLogLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLogLevel.FormattingEnabled = true;
            this.comboBoxLogLevel.Items.AddRange(new object[] {
            "debug",
            "info",
            "warning",
            "error",
            "none"});
            this.comboBoxLogLevel.Location = new System.Drawing.Point(136, 65);
            this.comboBoxLogLevel.Name = "comboBoxLogLevel";
            this.comboBoxLogLevel.Size = new System.Drawing.Size(196, 23);
            this.comboBoxLogLevel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 493);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "V2RayConfig";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLog.ResumeLayout(false);
            this.panelLog.PerformLayout();
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
    }
}

