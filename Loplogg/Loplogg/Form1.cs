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
            bool fD = float.TryParse(tbxDistance.Text, out float oD);
            bool fT = float.TryParse(tbxTime.Text, out float oT);
            if(fD && fT)
            {
                Logs.Add(new Log(oD, oT));
            }
            else
            {
                MessageBox.Show("Du måste mata in ett flyttal!","Varning");
            }
            UpdateList();
        }

        private void BtnShowTime_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            foreach (Log l in Logs)
            {
                l.Switcher = true;
                lbxOutput.Items.Add(l);
            }
            Search();
        }

        private void BtnShowSpeed_Click(object sender, EventArgs e)
        {
            
            lbxOutput.Items.Clear();
            foreach (Log l in Logs)
            {
                l.Switcher = false;
                lbxOutput.Items.Add(l);
            }
            Search();
        }

        void UpdateList()
        {
            lbxOutput.Items.Clear();
            foreach(Log l in Logs)
            {
                lbxOutput.Items.Add(l);
            }
        }

        void Search()
        {
            foreach (Log l in Logs)
            {
                bool check = float.TryParse(tbxSearchDistance.Text, out float s);
                if (check)
                {
                    if (!(l.Distance == s))
                    {
                        lbxOutput.Items.Remove(l);
                    }
                }
                else
                {
                    MessageBox.Show("Du måste mata in ett flyttal!");
                }
                
            }
        }
    }
}
