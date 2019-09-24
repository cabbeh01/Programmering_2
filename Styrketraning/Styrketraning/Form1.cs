using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Styrketraning
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSpara_Click(object sender, EventArgs e)
        {
            try
            {
                Traning.Traningar.Add(new Traning(tbxOvning.Text, short.Parse(tbxSet.Text), short.Parse(tbxRep.Text), short.Parse(tbxVikt.Text)));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Felkod: 1887ZA" + "\n" + ex.ToString());
            }
            
        }

        private void BtnSok_Click(object sender, EventArgs e)
        {
            foreach(Traning r in Traning.Traningar)
            {
                if(tbxOvningSok.Text == r.Ovning)
                {
                    tbxShow.Text = r.ViktCalc.ToString();
                }
            }
        }
    }
}
