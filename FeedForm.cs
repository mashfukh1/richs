using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Subscribing;
using System;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Json;
using Newtonsoft.Json.Linq;
using MySql.Data.MySqlClient;


namespace MQTT_RICHS
{
    public partial class FeedForm : Form
    {
        string connect = "SERVER= localhost;user id=root;password=;database=richs";
        public int setData = 0;

        public IMqttClient Client { get; private set; }

        public FeedForm(IMqttClient client)
        {
            Client = client;
            InitializeComponent();

            txtTopic.Text = "iot-2/evt/wadata/fmt/scada_gd7HFHpjSauM";

            groupBox1.Hide();
            Height -= groupBox1.Height;

            btnSubscribe.Click += async (o, e)
                => await BtnSubscribe_Click(o, e);

            btnPublish.Click += async (o, e)
                => await BtnPublish_Click(o, e);

        }
        public class Val
        {
            //[JsonPropertyName("DF1:MACHINE_RUNNING")]
            //public double DF1MACHINERUNNING { get; set; }

            // [JsonPropertyName("DF1:MACHINE_IS_INDEXING")]
            //public double DF1MACHINEISINDEXING { get; set; }

            [JsonPropertyName("DF1:ALARM_STATUS")]
            public double DF1ALARMSTATUS { get; set; }
        }

        public class Device123
        {
            [JsonPropertyName("Val")]
            public Val Val { get; set; }
        }

        public class D
        {
            [JsonPropertyName("device123")]
            public Device123 Device123 { get; set; }
        }

        public class Root
        {
            [JsonPropertyName("d")]
            public D D { get; set; }

            [JsonPropertyName("ts")]
            public DateTime Ts { get; set; }
        }
        public class HighLowTemps
        {
            public int Val { get; set; }
            public int Low { get; set; }
        }
        public class Pet
        {
            public string Type { get; set; }
            public string Name { get; set; }
            public double Age { get; set; }
        }

        public class WeatherForecast
        {
            [JsonPropertyName("DF1:MACHINE_RUNNING")]
            public double DF1MACHINERUNNING { get; set; }
        }
        public override System.Drawing.Color ForeColor { get; set; }
        private void FeedForm_Load(object sender, EventArgs e)
        {

        }
        private async Task BtnSubscribe_Click(object sender, EventArgs e)
        {
            try
            {
                txtTopic.Enabled = false;
                MACHINE_STATUS.BackColor = Color.Lime;
                var result = (await Client.SubscribeAsync(
                        new TopicFilterBuilder()
                        .WithTopic(txtTopic.Text)
                        .Build()
                    )).Items[0];

                switch (result.ResultCode)
                {
                    case MqttClientSubscribeResultCode.GrantedQoS0:
                    case MqttClientSubscribeResultCode.GrantedQoS1:
                    case MqttClientSubscribeResultCode.GrantedQoS2:
                        groupBox1.Show();
                        Height += groupBox1.Height;

                        Client.UseApplicationMessageReceivedHandler(me =>
                        {
                            var msg = me.ApplicationMessage;
                            var data = Encoding.UTF8.GetString(msg.Payload);
                            string raw = data.ToString();

                            string dataA = string.Empty;
                            string dataB = string.Empty;
                            string dataC = string.Empty;

                            Invoke((Action)(() =>
                            {


                                txtStream.AppendText($"{data}\n");


                                foreach (char c in raw)
                                {
                                    if (Char.IsUpper(c))
                                    {
                                        dataA += c;
                                    }
                                    if (Char.IsNumber(c))
                                    {
                                        dataB += c;

                                    }
                                    if (Char.IsSeparator(c))
                                    {
                                        dataC += c;
                                    }
                                }

                                string nilai = dataB.ToString();
                                var charArray = nilai.ToCharArray();

                                //label3.Text = charArray[8].ToString();
                                //data1.Text = charArray[4].ToString();

                                var myJsonString = data.ToString();
                                var jo = JObject.Parse(myJsonString);
                                var id = jo["d"]["device123"]["Val"]["DF1:MACHINE_RUNNING"];
                                
                              
                            }));
                        });

                        break;
                    default:
                        throw new Exception(result.ResultCode.ToString());
                }

            }
            catch (Exception ex)
            {
                txtTopic.Enabled = true;
                this.Error(ex);
                MACHINE_STATUS.BackColor = Color.Red;
            }
        }
        public void DATA()
        {
            MySqlConnection connection = new MySqlConnection(connect);
            connection.Open();
            try
            {
                using (var cmd = new MySqlCommand("SELECT lname FROM mixing_1a", connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var fname = reader.GetString(0);

                            label5.Text = fname.ToString();
                            ALARM.BackColor = Color.Lime;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                ALARM.BackColor = Color.Red;
                MessageBox.Show(e.Message);
            }
        }
        static void separateDigits(long n)
        {
            if (n < 10)
            {
                Console.Write("{0}  ", n);
                return;
            }
            separateDigits(n / 10);
            Console.Write(" {0} ", n % 10);
        }
        private async Task BtnPublish_Click(object sender, EventArgs e)
        {
            try
            {
                btnPublish.Enabled = false;
                txtStream.Clear();
                    Timer timer = new Timer();
                    timer.Tick += new EventHandler(T_Alarm1_Tick);
                    T_Alarm1.Start();
            }
            catch (Exception ex)
            {
                this.Error(ex);
            }

            btnPublish.Enabled = true;
        }

        private bool ToggleStatus { get; set; }

        private void btnPublish_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }

        private void T_Alarm1_Tick(object sender, EventArgs e)
        {
            txtStream.ForeColor = Color.Green;
            txtStream.AppendText($"{"Sending Alarm Code : 20 - Time :" + DateTime.Now.ToString() + "  Success.."}\n");
            DATA();
            Val val = new Val()
            {
                DF1ALARMSTATUS = Convert.ToInt32(label5.Text),
            };

            Device123 device123 = new Device123()
            {
                Val = new Val()
                {
                    DF1ALARMSTATUS = Convert.ToInt32(label5.Text),
                },
            };

            D d = new D()
            {
                Device123 = new Device123()
                {
                    Val = new Val()
                    {
                        DF1ALARMSTATUS = Convert.ToInt32(label5.Text),
                    },
                },
            };

            Root root = new Root()
            {
                D = new D()
                {
                    Device123 = new Device123()
                    {
                        Val = new Val()
                        {
                            DF1ALARMSTATUS = Convert.ToInt32(label5.Text),
                        },
                    },
                },
                Ts = DateTime.Now,
            };

            string jsonString = JsonSerializer.Serialize<Root>(root);
            Client.PublishAsync(txtTopic.Text, jsonString);
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            T_Alarm1.Stop();
            ALARM.BackColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MACHINE_STATUS_Click(object sender, EventArgs e)
        {

        }
    }
}
