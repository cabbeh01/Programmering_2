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

namespace Chatapplikation
{
    public partial class Form1 : Form
    {
        TcpClient client = new TcpClient();
        int port = 3333;


        public Form1()
        {
            InitializeComponent();
            client.NoDelay = true;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (!client.Connected)
            {
                StartHandshake();
            }
        }

        private async void StartHandshake()
        {
            try
            {
                IPAddress adress = IPAddress.Parse(tbxIP.Text);
                await client.ConnectAsync(adress, int.Parse(tbxPort.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, $"Error {ex.HResult}");
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            StartSendning(tbxOut.Text);
        }

        private async void StartSendning(string text)
        {

        }
    }
}
