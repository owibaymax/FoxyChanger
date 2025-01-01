using FoxyChanger.Properties;
using Microsoft.Win32;
using SimpleWifi;
using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FoxyChanger
{
    public partial class ProxyChanger : Form
    {
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;
        RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);

        public ProxyChanger()
        {
            InitializeComponent();
            NetworkChange.NetworkAddressChanged += NetworkAddressChanged;
        }

        private void NetworkAddressChanged(object sender, EventArgs e)
        {
            if (Settings.Default.ENABLE_AUTO_DETECT)
            {
                try
                {
                    Wifi wifi = new Wifi();
                    var connectedNetwork = wifi.GetAccessPoints().FirstOrDefault(ap => ap.IsConnected);

                    if (connectedNetwork != null)
                    {
                        if (connectedNetwork.Name == Settings.Default.HOME_WIFI_SSID)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                DisableProxy();
                            });
                        }
                    }
                }
                catch { }
            }
        }

        private void ProxyChanger_Load(object sender, EventArgs e)
        {
            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
            Hide();
            UpdateStatus();
        }

        private void openSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TbxIP.Text = Settings.Default.PROXY_IP;
            TbxPort.Text = Settings.Default.PROXY_PORT.ToString();
            TbxHomeSSID.Text = Settings.Default.HOME_WIFI_SSID;
            ChkbxAutoDetect.Checked = Settings.Default.ENABLE_AUTO_DETECT;
            ShowInTaskbar = true;
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProxyChanger_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dr = MessageBox.Show("Do you want to close Interblocks Foxy Chnager?", "Interblocks Foxy Chnager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ProxyChanger_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                Hide();
            }
            else
            {
                ShowInTaskbar = true;
                Show();
            }
        }

        private void UpdateStatus()
        {
            Invoke((MethodInvoker)delegate
            {
                if ((int)registry.GetValue("ProxyEnable", 0) == 0)
                {
                    NtfyIcn.Icon = Resources.proxy_disabled;
                    NtfyIcn.Text = "Foxy Changer - Proxy Disabled";
                    enableToolStripMenuItem.Enabled = true;
                    disableToolStripMenuItem.Enabled = false;

                }
                else
                {
                    NtfyIcn.Icon = Resources.proxy_enabled;
                    NtfyIcn.Text = "Foxy Changer - Proxy Enabled";
                    enableToolStripMenuItem.Enabled = false;
                    disableToolStripMenuItem.Enabled = true;
                }
            });
        }

        private void EnableProxy()
        {
            registry.SetValue("ProxyEnable", 1);
            registry.SetValue("ProxyServer", $"{Settings.Default.PROXY_IP}:{Settings.Default.PROXY_PORT}");
            UpdateStatus();
        }

        private void DisableProxy()
        {
            registry.SetValue("ProxyEnable", 0);
            if (Settings.Default.CLEAR_SERVER_WHEN_DISABLE)
            {
                registry.SetValue("ProxyServer", 0); 
            }
            UpdateStatus();
        }

        private void BtnEnable_Click(object sender, EventArgs e)
        {
            EnableProxy();
        }

        private void BtnDisable_Click(object sender, EventArgs e)
        {
            DisableProxy();
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableProxy();
        }

        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisableProxy();
        }

        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {
            Settings.Default["PROXY_IP"] = TbxIP.Text;
            Settings.Default["PROXY_PORT"] = int.Parse(TbxPort.Text);
            Settings.Default["HOME_WIFI_SSID"] = TbxHomeSSID.Text;
            Settings.Default["ENABLE_AUTO_DETECT"] = ChkbxAutoDetect.Checked;
            Settings.Default.Save();
        }
    }
}
