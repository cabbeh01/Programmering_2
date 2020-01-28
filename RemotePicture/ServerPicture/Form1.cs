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

namespace ServerPicture
{
    public partial class Form1 : Form
    {
        TcpListener listener;
        TcpClient client;
        int port = 3333;

        public Form1()
        {
            InitializeComponent();
            StartServer();
        }

        void StartServer()
        {
            try
            {
                listener = new TcpListener(IPAddress.Any, port);
                listener.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            StartListening();
        }

        private async void StartListening()
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
            switch (s) {
                case "1":
                    if(pBox.Location.Y == 0)
                    {
                        StartSend("btnUP");
                        break;
                    }
                    pBox.Location = new Point(pBox.Location.X, pBox.Location.Y - 10);
                    break;

                case "-1":
                    if (pBox.Location.Y == 350)
                    {
                        StartSend("btnDown");
                        break;
                    }
                    pBox.Location = new Point(pBox.Location.X, pBox.Location.Y + 10);
                    break;

                case "2":
                    if (pBox.Location.X == 0)
                    {
                        StartSend("btnLeft");
                        break;
                    }
                    pBox.Location = new Point(pBox.Location.X + 10, pBox.Location.Y);
                    break;
                case "-2":
                    if (pBox.Location.X == 700)
                    {
                        StartSend("btnRight");
                        break;
                    }
                    pBox.Location = new Point(pBox.Location.X - 10, pBox.Location.Y);
                    break;

                default:

                    break;
            }

            StartReading(client);
        }


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
