using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP
{
    public partial class Form1 : Form
    {
        TcpClient client;
        int port = 12345;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendHey_Click(object sender, EventArgs e)
        {
            IPAddress address = IPAddress.Parse(tbxIP.Text);
            client = new TcpClient();
            client.NoDelay = true;
            client.Connect(address, port);

            if (client.Connected)
            {
                byte[] outData = Encoding.Unicode.GetBytes("Hej!");
                client.GetStream().Write(outData, 0, outData.Length);
                client.Close();
            }

        }
    }
}
