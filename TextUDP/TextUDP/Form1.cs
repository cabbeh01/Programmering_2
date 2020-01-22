using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace TextUDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.Unicode.GetBytes(tbxOut.Text);

            IPAddress serverIP = IPAddress.Parse(tbxServerIP.Text);
            IPEndPoint dest = new IPEndPoint(serverIP, int.Parse(tbxServerPort.Text));

            UdpClient client = new UdpClient();

            client.Send(message, message.Length, dest);
        }
    }
}
