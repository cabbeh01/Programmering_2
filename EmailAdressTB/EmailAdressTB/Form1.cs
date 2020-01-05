using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailAdressTB
{
    public partial class Form1 : Form
    {
        EmailAddressTextBox emailAddress;
        public Form1()
        {
            InitializeComponent();

            emailAddress = new EmailAddressTextBox();
            emailAddress.Location = new Point(10, 10);
            this.Controls.Add(emailAddress);
        }

        

    }
}
