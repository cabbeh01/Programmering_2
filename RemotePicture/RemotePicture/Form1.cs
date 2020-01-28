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

namespace RemotePicture
{
    public partial class Form1 : Form
    {
        TcpListener listener;
        TcpClient client = new TcpClient();
        int port = 3333;

        public Form1()
        {
            InitializeComponent();
            client.NoDelay = true;
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            StartSend("1");
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            StartSend("2");
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            StartSend("-2");
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            StartSend("-1");
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (!client.Connected)
            {
                StartConnection();
            }
        }

        private async void StartConnection()
        {
            try
            {
                IPAddress adress = IPAddress.Parse(tbxIP.Text);
                await client.ConnectAsync(adress, port);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnConnect.Enabled = false;
        }

        private async void StartListening()
        {
            try
            {
                client = await listener.AcceptTcpClientAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            StartReading(client);
        }
        private async void StartReading(TcpClient k)
        {
            byte[] buffert = new byte[1024];

            int n = 0;

            try
            {
                n = await k.GetStream().ReadAsync(buffert, 0, buffert.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string s = Encoding.Unicode.GetString(buffert, 0, n);
           
            if(s == "btnUp")
            {
                if (btnUp.Enabled)
                {
                    btnUp.Enabled = false;
                }
                else
                {
                    btnUp.Enabled = true;
                }
                
            }
            else if (s == "btnDown")
            {
                if (btnDown.Enabled)
                {
                    btnDown.Enabled = false;
                }
                else
                {
                    btnDown.Enabled = true;
                }
            }
            else if (s == "btnLeft")
            {
                if (btnLeft.Enabled)
                {
                    btnLeft.Enabled = false;
                }
                else
                {
                    btnLeft.Enabled = true;
                }
            }
            else if (s == "btnRight")
            {
                if (btnRight.Enabled)
                {
                    btnRight.Enabled = false;
                }
                else
                {
                    btnRight.Enabled = true;
                }
            }
            StartReading(client);
        }


        //Skicka data till servern
        private async void StartSend(string message)
        {
            byte[] outData = Encoding.Unicode.GetBytes(message);
            try
            {
                await client.GetStream().WriteAsync(outData, 0, outData.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
