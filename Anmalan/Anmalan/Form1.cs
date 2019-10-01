using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anmalan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            short Rchecked = 0;
            if (rBtnBoy.Checked)
            {
                Rchecked = 1;
            }
            else if (rBtnGirl.Checked)  
            {
                Rchecked = 2;
            }
            else if (rBtnOther.Checked)
            {
                Rchecked = 3;
            }
            try
            {
                Garningsman g = new Garningsman(tbxName.Text, Rchecked, short.Parse(tbxAge.Text), short.Parse(tbxLenght.Text), tbxHairColor.Text);
                Anmalan A = new Anmalan(g, tbxCrime.Text);
                Anmalan.AnmalanAlla.Add(A);
                UpdateList();
            }
            catch
            {
                MessageBox.Show("Felkod Affepaffe");
            }
            
        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Anmalan B = lbxResult.SelectedItem as Anmalan;
            if(B == null)
            {
                MessageBox.Show("Du måste väla en anmälan!");
            }
            Anmalan.AnmalanAlla.Remove(B);
            UpdateList();
        }

        private void BtnPick_Click(object sender, EventArgs e)
        {
            Anmalan B = lbxResult.SelectedItem as Anmalan;
            if (B == null)
            {
                MessageBox.Show("Du måste väla en anmälan!");
            }
            else
            {
                tbxAge.Text = B.g.age.ToString();
                tbxCrime.Text = B._brottsmisstanke.ToString();
                tbxName.Text = B.g.Name.ToString();
                tbxHairColor.Text = B.g.Haircolor.ToString();
                tbxLenght.Text = B.g.Length.ToString();
            }
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            Anmalan B = lbxResult.SelectedItem as Anmalan;
            if (B == null)
            {
                MessageBox.Show("Du måste väla en anmälan!");
            }
            else
            {
                try
                {
                    B.g.age = short.Parse(tbxAge.Text);
                    B._brottsmisstanke = tbxCrime.Text;
                    B.g.Name = tbxName.Text;
                    B.g.Haircolor = tbxHairColor.Text;
                    B.g.Length = short.Parse(tbxLenght.Text);
                    UpdateList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Felkod Rasse" + "\n" + ex);
                }
                
                
            }
        }


        private void BtnSok_Click(object sender, EventArgs e)
        {

        }

        private void LbxResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UpdateList()
        {
            lbxResult.Items.Clear();
            foreach(Anmalan A in Anmalan.AnmalanAlla)
            {
                lbxResult.Items.Add(A);
            }
        }

        
    }
}
