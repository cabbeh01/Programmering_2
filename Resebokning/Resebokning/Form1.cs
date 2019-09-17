using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resebokning
{
    public partial class Form1 : Form
    {
        List<Resa> reseLista = new List<Resa>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBoka_Click(object sender, EventArgs e)
        {
            Resa kund = new Resa(tbxKund.Text, tbxDestination.Text, short.Parse(tbxAntalDagar.Text));
            reseLista.Add(kund);
            UpdateValues();
        }

        private void BtnSok_Click(object sender, EventArgs e)
        {
            lbxSokt.Items.Clear();
            foreach (Resa r in reseLista)
            {
                if(r.getName() == tbxSokKund.Text)
                {
                    lbxSokt.Items.Add(r);
                }
            }
        }


        void ClearValues()
        {
            tbxAntalDagar.Clear();
            tbxDestination.Clear();
            tbxKund.Clear();
        }

        void UpdateValues()
        {
            ClearValues();
            lbxSokt.Items.Clear();
            foreach(Resa r in reseLista)
            {
                lbxSokt.Items.Add(r);
            }
        }
    }
}
