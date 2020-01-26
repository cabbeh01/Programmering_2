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

namespace TCPserver
{
    public partial class Form1 : Form
    {
        TcpListener listener;
        TcpClient client;
        int port = 12345;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            listener = new TcpListener(IPAddress.Any, port);

            listener.Start();

            client = listener.AcceptTcpClient();

            byte[] inData = new byte[256];

            int countByte = client.GetStream().Read(inData, 0, inData.Length);

            tbxOut.Text = Encoding.Unicode.GetString(inData, 0, countByte);
            client.Close();
            listener.Stop();
        }
    }
}
