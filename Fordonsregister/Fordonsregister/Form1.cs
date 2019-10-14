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
            Startup();
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            if (Fordon.AcceptReg(tbxRegnr.Text))
            {
                if (!(String.IsNullOrWhiteSpace(tbxBrand.Text)))
                {
                    if (!(String.IsNullOrWhiteSpace(tbxModel.Text)))
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
                            ClearTextbox();
                        }
                        catch
                        {
                            MessageBox.Show("Du måste välja ett fordon!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Du måste skriva in fordornets modell!");
                    }
                }
                else
                {
                    MessageBox.Show("Du måste skriva in fordornets märke!");
                }


            }
            else
            {
                MessageBox.Show("Du måste skriva in ett giltigt registrerings nummer!");
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

        private void RbnAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnAll.Checked)
            {
                UpdateTable();
            }
        }

        private void RbnCar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnCar.Checked)
            {
                lbxOutput.Items.Clear();
                foreach (Fordon d in Fordon.AllFordon)
                {
                    if (d.Type == Fordon.Vehicle.Bil)
                    {
                        lbxOutput.Items.Add(d);
                    }
                }
            }
        }

        private void RbnMC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnMC.Checked)
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

        private void Startup()
        {
            rbnAll.Checked = true;
            cbxType.SelectedItem = "Bil";
        }

        private void ClearTextbox()
        {
            tbxBrand.Text = "";
            tbxModel.Text = "";
            tbxRegnr.Text = "";
        }
    }
}
