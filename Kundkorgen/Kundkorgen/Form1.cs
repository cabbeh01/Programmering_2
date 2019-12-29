using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kundkorgen
{
    public partial class Form1 : Form
    {
        TextBox tbxvara;
        TextBox tbxpris;
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbxvara = new TextBox();
            tbxpris = new TextBox();
            tbxpris.Location = new Point(130, 10 + (i * 30));
            tbxvara.Location = new Point(10, 10+(i * 30));

            this.Controls.Add(tbxvara);
            this.Controls.Add(tbxpris);
            i++;
        }
    }
}
