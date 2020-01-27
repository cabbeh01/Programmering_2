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

namespace TcpAsyncClient
{
    public partial class Form1 : Form
    {
        TcpClient client = new TcpClient();
        int port = 12345;

        public Form1()
        {
            InitializeComponent();
            client.NoDelay = true;
            btnSend.Enabled = false;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (!client.Connected)
            {
                startConnection();
            }
        }

        private async void startConnection()
        {
            try
            {
                IPAddress adress = IPAddress.Parse(tbxIPadress.Text);
                await client.ConnectAsync(adress, port);
                btnConnect.Enabled = false;
                btnSend.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            StartSending(tbxOut.Text);
        }

        private async void StartSending(string text)
        {
            byte[] outData = Encoding.Unicode.GetBytes(text);
            try
            {
                await client.GetStream().WriteAsync(outData, 0, outData.Length);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
