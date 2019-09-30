using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Tidrapportering
{
    public partial class Form1 : Form
    {
        double time;
        int timarvore;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Tidrapport.tidrapporteringar.Add(new Tidrapport(tbxCustomer.Text, int.Parse(tbxTime.Text)));
                UpdateListbox();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Felkod 122" + "\n" + ex);
            }
            
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            string oldName = tbxOldname.Text;

            foreach (Tidrapport r in Tidrapport.tidrapporteringar)
            {
                if(r.Customer.ToLower() == oldName.ToLower())
                {
                    r.Customer = tbxNewname.Text;
                }
            }
            UpdateListbox();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            timarvore = int.Parse(tbxTimarvode.Text) /2;
            int price = timarvore * (int)time;
            tbxPrice.Text = $"{price} kr";
            
        }

        private void UpdateListbox()
        {
            lbxOutput.Items.Clear();
            foreach (Tidrapport r in Tidrapport.tidrapporteringar)
            {
                lbxOutput.Items.Add(r);
            }
        }

        private void LbxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tidrapport ts = lbxOutput.SelectedItem as Tidrapport;
            try
            {
                time = (double)ts.Time;
                time = time / 30.0;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Felkod 123" + "\n" + ex);
            }
            
            
        }
    }
}
