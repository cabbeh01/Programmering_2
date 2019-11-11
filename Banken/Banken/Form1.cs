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
        Bank b = new Bank();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDeposit_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(tbxAmount.Text);

            int index = lbxShow.SelectedIndex;

            b.ListBankAccounts[index].Deposit(amount);
            UpdateList();

        }

        private void BtnWithdraw_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(tbxAmount.Text);

            int index = lbxShow.SelectedIndex;

            if (b.ListBankAccounts[index].Withdraw(amount)) {
                UpdateList();
            }
            else
            {
                MessageBox.Show("Det gick inte att ta ut så mycket!");
            }
            
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(tbxCredit.Text))
                {
                    string ssNumber = tbxSocialNumber.Text;
                    double balance = 0;
                    double rate = double.Parse(tbxInterest.Text);
                    SavingAccount temp = new SavingAccount(ssNumber, balance, rate);
                    b.ListBankAccounts.Add(temp);
                }
                else
                {
                    double tempCredit = double.Parse(tbxCredit.Text);
                    string ssNumber = tbxSocialNumber.Text;
                    double balance = 0;
                    double rate = double.Parse(tbxInterest.Text);
                    LoanAccount temp = new LoanAccount(ssNumber, balance, rate, tempCredit);
                    b.ListBankAccounts.Add(temp);
                }

                UpdateList();
            }
            catch
            {
                MessageBox.Show("Gick inte att registrera");
            }
            
        }

        private void BtnUpdatewithYearInterest_Click(object sender, EventArgs e)
        {
            foreach (BankAccount bA in b.ListBankAccounts)
            {
                bA.Balance = bA.CalculateRate();
            }
            UpdateList();
        }

        private void UpdateList()
        {
            lbxShow.Items.Clear();
            foreach(BankAccount bA in b.ListBankAccounts)
            {
                lbxShow.Items.Add(bA);
            }
        }
    }
}
