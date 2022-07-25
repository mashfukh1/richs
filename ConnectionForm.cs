using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Options;
using MQTTnet.Formatter;


namespace MQTT_RICHS
{
    public partial class Connection_Form : Form
    {
        public Connection_Form()
        {
            InitializeComponent();
            btnConnect.Click += async (o, e) => {
                await BtnConnect_ClickAsync(o, e);
            };
        }

        private void Connection_Form_Load(object sender, EventArgs e)
        {

        }
        private async Task BtnConnect_ClickAsync(object sender, System.EventArgs e)
        {
            try
            {
                btnConnect.Enabled = false;

                var client = new MqttFactory().CreateMqttClient();

                var options = new MqttClientOptionsBuilder()
                    .WithTcpServer(txtHost.Text, int.Parse(txtPort.Text))
                    .WithCredentials(txtUsername.Text, txtPassword.Text)
                    .WithProtocolVersion(MqttProtocolVersion.V311)
                    .Build();

                var auth = await client.ConnectAsync(options);

                if (auth.ResultCode != MqttClientConnectResultCode.Success)
                {
                    throw new Exception(auth.ResultCode.ToString());
                }
                else
                {
                    using (var feedFrm = new FeedForm(client))
                    {
                        try
                        {
                            Hide();
                            feedFrm.ShowDialog(this);
                        }
                        catch (Exception ex)
                        {
                            this.Error(ex);
                        }

                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                this.Error(ex);
                btnConnect.Enabled = true;
            }
        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
