using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fordonsregister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Fordon.AcceptReg(tbxRegnr.Text).ToString(), "test");
            if (Fordon.AcceptReg(tbxRegnr.Text))
            {
                try
                {
                    Fordon.Vehicle a = new Fordon.Vehicle();
                    if (cbxType.SelectedItem.ToString() == "Bil")
                    {
                        a = Fordon.Vehicle.Bil;

                    }
                    else if (cbxType.SelectedItem.ToString() == "MC")
                    {
                        a = Fordon.Vehicle.MC;
                    }

                    Fordon.AllFordon.Add(new Fordon(tbxRegnr.Text, tbxBrand.Text, tbxModel.Text, a));
                    UpdateTable();
                }
                catch(Exception err)
                {
                    MessageBox.Show("Du måste välja ett fordon!" + "\n" +err);
                }
                


                
            }

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {
            if (rbnAll.Checked)
            {
                UpdateTable();
            }
            else if (rbnCar.Checked)
            {
                lbxOutput.Items.Clear();
                foreach (Fordon d in Fordon.AllFordon)
                {
                    if(d.Type == Fordon.Vehicle.Bil)
                    {
                        lbxOutput.Items.Add(d);
                    }
                }
            }
            else if (rbnMC.Checked)
            {
                lbxOutput.Items.Clear();
                foreach (Fordon d in Fordon.AllFordon)
                {
                    if (d.Type == Fordon.Vehicle.MC)
                    {
                        lbxOutput.Items.Add(d);
                    }
                }
            }
        }

        private void UpdateTable()
        {
            lbxOutput.Items.Clear();
            foreach(Fordon d in Fordon.AllFordon)
            {
                lbxOutput.Items.Add(d);
            }
        }
    }
}
