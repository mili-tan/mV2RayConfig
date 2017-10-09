namespace mV2RayConfig.Forms
{
    partial class ClientConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxConfig = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxHostName = new System.Windows.Forms.TextBox();
            this.labelHostName = new System.Windows.Forms.Label();
            this.labelProtocol = new System.Windows.Forms.Label();
            this.comboBoxProtocol = new System.Windows.Forms.ComboBox();
            this.labelSecurity = new System.Windows.Forms.Label();
            this.comboBoxSecurity = new System.Windows.Forms.ComboBox();
            this.buttonNewGen = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxConfig
            // 
            this.richTextBoxConfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBoxConfig.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBoxConfig.Location = new System.Drawing.Point(0, -1);
            this.richTextBoxConfig.Name = "richTextBoxConfig";
            this.richTextBoxConfig.Size = new System.Drawing.Size(430, 391);
            this.richTextBoxConfig.TabIndex = 1;
            this.richTextBoxConfig.Text = "";
            this.richTextBoxConfig.WordWrap = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.10945F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.89055F));
            this.tableLayoutPanel1.Controls.Add(this.labelSecurity, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelHostName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHostName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelProtocol, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxProtocol, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSecurity, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 397);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(402, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // textBoxHostName
            // 
            this.textBoxHostName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHostName.Font = new System.Drawing.Font("微软雅黑", 7.8F);
            this.textBoxHostName.Location = new System.Drawing.Point(116, 35);
            this.textBoxHostName.Name = "textBoxHostName";
            this.textBoxHostName.Size = new System.Drawing.Size(283, 25);
            this.textBoxHostName.TabIndex = 9;
            this.textBoxHostName.Text = "example.com";
            // 
            // labelHostName
            // 
            this.labelHostName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHostName.AutoSize = true;
            this.labelHostName.Font = new System.Drawing.Font("微软雅黑", 7.8F);
            this.labelHostName.Location = new System.Drawing.Point(3, 38);
            this.labelHostName.Name = "labelHostName";
            this.labelHostName.Size = new System.Drawing.Size(107, 20);
            this.labelHostName.TabIndex = 10;
            this.labelHostName.Text = "域名";
            // 
            // labelProtocol
            // 
            this.labelProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProtocol.AutoSize = true;
            this.labelProtocol.Location = new System.Drawing.Point(3, 8);
            this.labelProtocol.Name = "labelProtocol";
            this.labelProtocol.Size = new System.Drawing.Size(107, 15);
            this.labelProtocol.TabIndex = 11;
            this.labelProtocol.Text = "服务类型";
            // 
            // comboBoxProtocol
            // 
            this.comboBoxProtocol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProtocol.FormattingEnabled = true;
            this.comboBoxProtocol.Items.AddRange(new object[] {
            "vmess"});
            this.comboBoxProtocol.Location = new System.Drawing.Point(116, 4);
            this.comboBoxProtocol.Name = "comboBoxProtocol";
            this.comboBoxProtocol.Size = new System.Drawing.Size(283, 23);
            this.comboBoxProtocol.TabIndex = 12;
            // 
            // labelSecurity
            // 
            this.labelSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSecurity.AutoSize = true;
            this.labelSecurity.Font = new System.Drawing.Font("微软雅黑", 7.8F);
            this.labelSecurity.Location = new System.Drawing.Point(3, 72);
            this.labelSecurity.Name = "labelSecurity";
            this.labelSecurity.Size = new System.Drawing.Size(107, 20);
            this.labelSecurity.TabIndex = 13;
            this.labelSecurity.Text = "加密方式";
            // 
            // comboBoxSecurity
            // 
            this.comboBoxSecurity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSecurity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSecurity.FormattingEnabled = true;
            this.comboBoxSecurity.Items.AddRange(new object[] {
            "aes-128-gcm",
            "chacha20-poly1305",
            "aes-128-cfb",
            "none"});
            this.comboBoxSecurity.Location = new System.Drawing.Point(116, 70);
            this.comboBoxSecurity.Name = "comboBoxSecurity";
            this.comboBoxSecurity.Size = new System.Drawing.Size(283, 23);
            this.comboBoxSecurity.TabIndex = 14;
            // 
            // buttonNewGen
            // 
            this.buttonNewGen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewGen.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonNewGen.Location = new System.Drawing.Point(340, 503);
            this.buttonNewGen.Name = "buttonNewGen";
            this.buttonNewGen.Size = new System.Drawing.Size(75, 29);
            this.buttonNewGen.TabIndex = 3;
            this.buttonNewGen.Text = "生成";
            this.buttonNewGen.UseVisualStyleBackColor = true;
            this.buttonNewGen.Click += new System.EventHandler(this.buttonNewGen_Click);
            // 
            // ClientConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 541);
            this.Controls.Add(this.buttonNewGen);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.richTextBoxConfig);
            this.Name = "ClientConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientConfig";
            this.Load += new System.EventHandler(this.ClientConfigForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxConfig;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxHostName;
        private System.Windows.Forms.Label labelHostName;
        private System.Windows.Forms.Label labelProtocol;
        private System.Windows.Forms.ComboBox comboBoxProtocol;
        private System.Windows.Forms.Label labelSecurity;
        private System.Windows.Forms.ComboBox comboBoxSecurity;
        private System.Windows.Forms.Button buttonNewGen;
    }
}