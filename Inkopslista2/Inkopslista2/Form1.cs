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
            CalculateSumma();
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
            if(!(lbxOut.SelectedIndex == -1))
            {
                Vara.Varukorg.RemoveAt(lbxOut.SelectedIndex);
                UpdateList();
                Checkitemsinlist();
            }
            
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            try
            {
                int id = lbxOut.SelectedIndex;
                Change a = new Change(id, Vara.Varukorg[id]);
                this.Enabled = false;
                DialogResult r = a.ShowDialog();
                if (r == DialogResult.OK)
                {
                    UpdateList();
                    this.Enabled = true;
                    gbxModify.Enabled = false;
                }
                else if (r == DialogResult.Cancel)
                {
                    this.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Du måste välja ett objekt i listan");
            }
            
            
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

        private void CalculateSumma()
        {
            double summa = 0;
            foreach(Vara v in Vara.Varukorg)
            {
                summa += v.Beräknapris();
            }
            if (!string.IsNullOrEmpty(tbxRabatt.Text))
            {
                try
                {
                    summa -= double.Parse(tbxRabatt.Text);
                }
                catch
                {
                    MessageBox.Show("Du måste mata in en rabatt som fungerar");
                }
            }

            tbxSumma.Text = summa.ToString();
        }

        private void tbxRabatt_TextChanged(object sender, EventArgs e)
        {
            CalculateSumma();
        }
    }
}
