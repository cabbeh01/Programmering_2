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

namespace TcpAsyncServer
{
    public partial class Form1 : Form
    {
        TcpListener listener;
        TcpClient client;
        int port = 12345;

        public Form1()
        {
            InitializeComponent();

            try
            {
                listener = new TcpListener(IPAddress.Any, port);
                listener.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            StartListener();
        }

        private async void StartListener()
        {
            try
            {
                client = await listener.AcceptTcpClientAsync();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            StartReading(client);
        }

        private async void StartReading(TcpClient c) 
        {
            byte[] buffert = new byte[1024];

            int n = 0;

            try
            {
                n = await c.GetStream().ReadAsync(buffert, 0, buffert.Length);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            tbxOut.AppendText(Encoding.Unicode.GetString(buffert, 0, buffert.Length));
            StartReading(c);
        }
    }
}
