using System.Drawing;
using System.Windows.Forms;

namespace FoxyChanger
{
    partial class ProxyChanger
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProxyChanger));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbxPort = new System.Windows.Forms.TextBox();
            this.TbxIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TbxHomeSSID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChkbxAutoDetect = new System.Windows.Forms.CheckBox();
            this.BtnEnable = new System.Windows.Forms.Button();
            this.BtnDisable = new System.Windows.Forms.Button();
            this.NtfyIcn = new System.Windows.Forms.NotifyIcon(this.components);
            this.CMSMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSaveSettings = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.CMSMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbxPort);
            this.groupBox1.Controls.Add(this.TbxIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(449, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proxy Settings";
            // 
            // TbxPort
            // 
            this.TbxPort.Location = new System.Drawing.Point(61, 51);
            this.TbxPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbxPort.Name = "TbxPort";
            this.TbxPort.Size = new System.Drawing.Size(142, 23);
            this.TbxPort.TabIndex = 4;
            // 
            // TbxIP
            // 
            this.TbxIP.Location = new System.Drawing.Point(61, 22);
            this.TbxIP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbxIP.Name = "TbxIP";
            this.TbxIP.Size = new System.Drawing.Size(363, 23);
            this.TbxIP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TbxHomeSSID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ChkbxAutoDetect);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(449, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Auto Enable Settings";
            // 
            // TbxHomeSSID
            // 
            this.TbxHomeSSID.Location = new System.Drawing.Point(159, 57);
            this.TbxHomeSSID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TbxHomeSSID.Name = "TbxHomeSSID";
            this.TbxHomeSSID.Size = new System.Drawing.Size(265, 23);
            this.TbxHomeSSID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Home WIFI SSID Name: ";
            // 
            // ChkbxAutoDetect
            // 
            this.ChkbxAutoDetect.AutoSize = true;
            this.ChkbxAutoDetect.Location = new System.Drawing.Point(20, 31);
            this.ChkbxAutoDetect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ChkbxAutoDetect.Name = "ChkbxAutoDetect";
            this.ChkbxAutoDetect.Size = new System.Drawing.Size(127, 19);
            this.ChkbxAutoDetect.TabIndex = 0;
            this.ChkbxAutoDetect.Text = "Enable Auto Detect";
            this.ChkbxAutoDetect.UseVisualStyleBackColor = true;
            // 
            // BtnEnable
            // 
            this.BtnEnable.Location = new System.Drawing.Point(306, 207);
            this.BtnEnable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnEnable.Name = "BtnEnable";
            this.BtnEnable.Size = new System.Drawing.Size(74, 23);
            this.BtnEnable.TabIndex = 2;
            this.BtnEnable.Text = "Enable";
            this.BtnEnable.UseVisualStyleBackColor = true;
            this.BtnEnable.Click += new System.EventHandler(this.BtnEnable_Click);
            // 
            // BtnDisable
            // 
            this.BtnDisable.Location = new System.Drawing.Point(387, 207);
            this.BtnDisable.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnDisable.Name = "BtnDisable";
            this.BtnDisable.Size = new System.Drawing.Size(74, 23);
            this.BtnDisable.TabIndex = 3;
            this.BtnDisable.Text = "Disable";
            this.BtnDisable.UseVisualStyleBackColor = true;
            this.BtnDisable.Click += new System.EventHandler(this.BtnDisable_Click);
            // 
            // NtfyIcn
            // 
            this.NtfyIcn.ContextMenuStrip = this.CMSMenu;
            this.NtfyIcn.Icon = ((System.Drawing.Icon)(resources.GetObject("NtfyIcn.Icon")));
            this.NtfyIcn.Text = "Foxy Changer";
            this.NtfyIcn.Visible = true;
            // 
            // CMSMenu
            // 
            this.CMSMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem,
            this.toolStripSeparator1,
            this.openSettingsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.CMSMenu.Name = "CMSMenu";
            this.CMSMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.CMSMenu.Size = new System.Drawing.Size(149, 104);
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Image = global::FoxyChanger.Properties.Resources.enable;
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.enableToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Image = global::FoxyChanger.Properties.Resources.disable;
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // openSettingsToolStripMenuItem
            // 
            this.openSettingsToolStripMenuItem.Image = global::FoxyChanger.Properties.Resources.settings;
            this.openSettingsToolStripMenuItem.Name = "openSettingsToolStripMenuItem";
            this.openSettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openSettingsToolStripMenuItem.Text = "Open Settings";
            this.openSettingsToolStripMenuItem.Click += new System.EventHandler(this.openSettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::FoxyChanger.Properties.Resources.quit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // BtnSaveSettings
            // 
            this.BtnSaveSettings.Location = new System.Drawing.Point(12, 207);
            this.BtnSaveSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnSaveSettings.Name = "BtnSaveSettings";
            this.BtnSaveSettings.Size = new System.Drawing.Size(100, 23);
            this.BtnSaveSettings.TabIndex = 5;
            this.BtnSaveSettings.Text = "Save Settings";
            this.BtnSaveSettings.UseVisualStyleBackColor = true;
            this.BtnSaveSettings.Click += new System.EventHandler(this.BtnSaveSettings_Click);
            // 
            // ProxyChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 237);
            this.Controls.Add(this.BtnSaveSettings);
            this.Controls.Add(this.BtnDisable);
            this.Controls.Add(this.BtnEnable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ProxyChanger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Foxy Changer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProxyChanger_FormClosing);
            this.Load += new System.EventHandler(this.ProxyChanger_Load);
            this.Resize += new System.EventHandler(this.ProxyChanger_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.CMSMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TbxPort;
        private TextBox TbxIP;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private CheckBox ChkbxAutoDetect;
        private TextBox TbxHomeSSID;
        private Label label3;
        private Button BtnEnable;
        private Button BtnDisable;
        private NotifyIcon NtfyIcn;
        private Button BtnSaveSettings;
        private ContextMenuStrip CMSMenu;
        private ToolStripMenuItem enableToolStripMenuItem;
        private ToolStripMenuItem disableToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem openSettingsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}

