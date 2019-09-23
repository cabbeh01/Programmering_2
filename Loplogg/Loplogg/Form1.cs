using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loplogg
{
    public partial class Form1 : Form
    {

        List<Log> Logs = new List<Log>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            float oD, oT;
            bool fD = float.TryParse(tbxDistance.Text, out oD);
            bool fT = float.TryParse(tbxTime.Text, out oT);
            if(fD && fT)
            {
                Logs.Add(new Log(oD, oT));
            }
            else
            {
                MessageBox.Show("Du måste mata in ett flyttal!","Varning");
            }
            Update();
        }

        private void BtnShowTime_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            foreach (Log l in Logs)
            {
                l.Switcher = true;
                lbxOutput.Items.Add(l);
            }
        }

        private void BtnShowSpeed_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            foreach (Log l in Logs)
            {
                l.Switcher = false;
                lbxOutput.Items.Add(l);
            }
        }

        void Update()
        {
            lbxOutput.Items.Clear();
            foreach(Log l in Logs)
            {
                lbxOutput.Items.Add(l);
            }
        }
    }
}
