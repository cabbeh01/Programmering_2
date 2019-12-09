using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inkopslista2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbxVara.Text))
            {
                try
                {
                    double pris = double.Parse(tbxPris.Text);

                    try
                    {
                        if (rbtnLosvikt.Checked)
                        {
                            double vikt = double.Parse(tbxMangd.Text);
                            try
                            {
                                Vara.Varukorg.Add(new Losvikt(tbxVara.Text, pris, vikt));
                                UpdateList();
                            }
                            catch
                            {
                                MessageBox.Show("Det går inte lägga till Lösviktvaran");
                            }
                            
                        }
                        else if(rbtnStycksaker.Checked){
                            int styck = int.Parse(tbxMangd.Text);
                            try
                            {
                                Vara.Varukorg.Add(new Stycksak(tbxVara.Text, pris, styck));
                                UpdateList();
                            }
                            catch
                            {
                                MessageBox.Show("Det går inte lägga till Stycksaken");
                            }
                            
                        }
                        
                    }
                    catch
                    {
                        MessageBox.Show("Du måste sätta en mängd!");
                    }
                }
                catch
                {
                    MessageBox.Show("Du måste skriva in ett pris!");
                }
            }
            else
            {
                MessageBox.Show("Du måste skriva in varan!");
            }
        }

       public void UpdateList()
        {
            lbxOut.Items.Clear();
            foreach(Vara v in Vara.Varukorg)
            {
                lbxOut.Items.Add(v);
            }
        }

        private void LbxOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Vara.Varukorg.Count > 0)
            {
                gbxModify.Enabled = true;
            }
            else
            {
                gbxModify.Enabled = false;
            }
        }


        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Vara.Varukorg.RemoveAt(lbxOut.SelectedIndex);
            UpdateList();
            Checkitemsinlist();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            Change a = new Change();
            a.Show();
        }

        public void Checkitemsinlist()
        {
            if (Vara.Varukorg.Count > 0)
            {
                gbxModify.Enabled = true;
            }
            else
            {
                gbxModify.Enabled = false;
            }
        }
    }
}
