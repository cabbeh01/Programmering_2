﻿using System;
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


namespace UDPserver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRecive_Click(object sender, EventArgs e)
        {
            IPEndPoint clientEndPoint = new IPEndPoint(IPAddress.Any, 0);
            UdpClient client = new UdpClient(int.Parse(tbxPort.Text));

            byte[] instream = client.Receive(ref clientEndPoint);
            tbxMessages.Text = Encoding.Unicode.GetString(instream);
        }
    }
}
