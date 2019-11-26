using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inkopslistan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLaggtill_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(tbxVara.Text))
                {
                    string v = tbxVara.Text;

                    if (!String.IsNullOrWhiteSpace(tbxPris.Text))
                    {
                        try
                        {
                            double p = double.Parse(tbxPris.Text);

                            if (!String.IsNullOrWhiteSpace(tbxMangd.Text))
                            {
                                try
                                {
                                    double m = double.Parse(tbxMangd.Text);

                                    if (rbtnLosvikt.Checked)
                                    {
                                        Vara.varukorg.Add(new LosVikt(v, p, m));
                                    }
                                    else if (rbtnStycksak.Checked)
                                    {
                                        Vara.varukorg.Add(new StyckSak(v, p, (int)m));
                                    }

                                    UpdateList();
                                }
                                catch
                                {
                                    MessageBox.Show("Du måste mata in en giltlig mängd på din vara!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Du måste mata in en mängd!");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Du måste mata in ett giltligt pris på din vara!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Du måste mata in ett pris fältet kan inte vara tomt!");
                    }

                }
                else
                {
                    MessageBox.Show("Du måste mata in ett namn på din vara!");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Ett fel uppstod Error 1" + "\n"+err,"Okänt fel",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void UpdateList()
        {
            lbxOut.Items.Clear();
            foreach(Vara v in Vara.varukorg)
            {
                lbxOut.Items.Add(v);
            }

            double totalpris = 0;
            foreach(Vara v in Vara.varukorg)
            {
                totalpris += v.BeräknaPris();
            }
            tbxSumma.Text = totalpris.ToString();

            
        }

        private void BtnRadera_Click(object sender, EventArgs e)
        {
            Vara.varukorg.RemoveAt(lbxOut.SelectedIndex);
            UpdateList();
            lbxOut.ClearSelected();
            btnRadera.Enabled = false;
        }

        private void LbxOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lbxOut.SelectedIndex == -1)
            {
                btnRadera.Enabled = false;
            }
            else
            {
                btnRadera.Enabled = true;
            }
        }
    }
}
