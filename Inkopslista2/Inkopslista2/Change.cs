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
    public partial class Change : Form
    {
        public int _id;  
        
        internal Change(int Id, Vara v)
        {
            InitializeComponent();

            this._id = Id;


            if (v is Stycksak)
            {
                Stycksak Sk = (Stycksak)v;
                tbxNameCH.Text = Sk.Namn;
                tbxPrisCH.Text = Sk.Styckpris.ToString();
                tbxMangdCH.Text = Sk.Antal.ToString();
            }
            else if(v is Losvikt)
            {
                Losvikt Lg = (Losvikt)v;
                tbxNameCH.Text = Lg.Namn;
                tbxPrisCH.Text = Lg.KiloPris.ToString();
                tbxMangdCH.Text = Lg.Vikt.ToString();
            }

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (rbtnLosviktCH.Checked)
            {
                try
                {
                    Vara.Varukorg.Insert(_id, new Losvikt(tbxNameCH.Text, double.Parse(tbxPrisCH.Text), double.Parse(tbxMangdCH.Text)));
                    Vara.Varukorg.RemoveAt(_id + 1);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Det går inte uppdatera värdena!");
                }
                
            }
            else if(rbtnStycksakCH.Checked)
            {
                try
                {
                    Vara.Varukorg.Insert(_id, new Stycksak(tbxNameCH.Text, double.Parse(tbxPrisCH.Text), int.Parse(tbxMangdCH.Text)));
                    Vara.Varukorg.RemoveAt(_id + 1);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Det går inte uppdatera värdena!");
                }
            }
        }
    }
}
