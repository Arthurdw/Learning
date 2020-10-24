using System;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        private const string DefaultTarget = "127.0.0.1:8000";

        private static string host;
        private static int port;

        public Form1()
        {
            InitializeComponent();

            txtinput.Enabled = txtOut.Enabled = btnHash.Enabled = false;
            txtHost.Text = DefaultTarget;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string[] data = txtHost.Text.Trim().Split(':');

            try
            {
                if (data.Length != 2) throw new FormatException();

                host = data[0];
                port = int.Parse(data[1]);

                if (port < 0 || port >= 65535) throw new FormatException();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid IP format.\t\n" +
                                "Please format your IP like this: `ip:port`",
                    "Oops...");
                return;
            }

            txtinput.Enabled = txtOut.Enabled = btnHash.Enabled = true;
            txtHost.Enabled = btnConnect.Enabled = false;
        }

        private void btnHash_Click(object sender, EventArgs e)
        {
            try
            {
                TcpClient tcpClient = new TcpClient(host, port);
                byte[] data = Encoding.ASCII.GetBytes(txtinput.Text);

                NetworkStream stream = tcpClient.GetStream();
                stream.Write(data, 0, data.Length);
                Console.WriteLine($"Sent {txtinput.Text}");

                data = new byte[1024];
                string res = "";
                int bytes = stream.Read(data, 0, data.Length);
                res = Encoding.ASCII.GetString(data, 0, bytes);

                txtOut.Text = res;
                txtOut.SelectAll();
                txtOut.Focus();

                Console.WriteLine($"Received {res}");

                stream.Close();
                tcpClient.Close();
            }
            catch (ArgumentNullException exception)
            {
                MessageBox.Show(exception.Message, "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SocketException exception)
            {
                MessageBox.Show(exception.Message, "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}