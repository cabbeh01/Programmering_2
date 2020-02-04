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
        User user = new User("","","");

        public Form1()
        {
            InitializeComponent();
            user.client.NoDelay = true;
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (!user.client.Connected)
            {
                StartHandshake();
            }
        }

        private async void StartHandshake()
        {
            try
            {
                IPAddress adress = IPAddress.Parse(tbxIP.Text);
                await user.client.ConnectAsync(adress, int.Parse(tbxPort.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, $"Error {ex.HResult}");
            }
            StartReading();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            StartSendning(tbxOut.Text);
        }

        private async void StartSendning(string text)
        {
            byte[] outData = Encoding.Unicode.GetBytes(text);

            try
            {
                await user.client.GetStream().WriteAsync(outData, 0, outData.Length);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private async void StartReading()
        {
            if (user.client.Connected)
            {
                byte[] buffert = new byte[1024];

                int n = 0;
                try
                {
                    n = await user.client.GetStream().ReadAsync(buffert, 0, buffert.Length);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);


                }

                //Sending data back to users
                tbxChat.AppendText($"User 1> {Encoding.Unicode.GetString(buffert, 0, n)}");
                StartReading();
            }
            
        }
    }
}
