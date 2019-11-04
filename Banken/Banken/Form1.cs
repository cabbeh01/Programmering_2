using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {

        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (String.IsNullOrWhiteSpace(tbxCredit.Text))
                {
                    double tempCredit = double.Parse(tbxCredit.Text);

                }
            }
            catch
            {

            }
            
        }

        private void BtnUpdatewithYearInterest_Click(object sender, EventArgs e)
        {

        }
    }
}
