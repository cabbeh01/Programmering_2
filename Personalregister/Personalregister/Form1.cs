﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personalregister
{
    public partial class Form1 : Form
    {
        List<Employed> Employees = new List<Employed>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegisterSales_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(tbxNameVender.Text))
                {
                    Vender V = new Vender(tbxNameVender.Text, double.Parse(tbxProvisionVender.Text), double.Parse(tbxSalesVender.Text));
                    Employees.Add(V);
                    UpdatePayouts();
                    UpdateRegister();
                }
                else
                {
                    MessageBox.Show("Du måste mata in ett namn");
                }
            }
            catch
            {
                MessageBox.Show("Vänligen kontrollera dina värden");
            }
        }

        private void BtnRegisterShift_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(tbxNameConsultant.Text))
                {
                    Consultant V = new Consultant(tbxNameConsultant.Text, double.Parse(tbxTimeWorkedConsultant.Text), double.Parse(tbxHourlyConsultant.Text));
                    Employees.Add(V);
                    UpdatePayouts();
                    UpdateRegister();
                }
                else
                {
                    MessageBox.Show("Du måste mata in ett namn");
                }
            }
            catch
            {
                MessageBox.Show("Vänligen kontrollera dina värden");
            }
        }

        private void BtnRegisterIncome_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(tbxNameClerk.Text))
                {
                    Clerk V = new Clerk(tbxNameClerk.Text, double.Parse(tbxIncomeClerk.Text));
                    Employees.Add(V);
                    UpdatePayouts();
                    UpdateRegister();
                }
                else
                {
                    MessageBox.Show("Du måste mata in ett namn");
                }
            }
            catch
            {
                MessageBox.Show("Vänligen kontrollera dina värden");
            }
        }

        private void BtnCalculateIncome_Click(object sender, EventArgs e)
        {
            tbxTotalSalary.Text = $"{CalculateTotalIncome()} kr";
        }

        private void UpdateRegister()
        {
            lbxRegister.Items.Clear();
            foreach(Employed A in Employees)
            {
                lbxRegister.Items.Add(A);
            }
            ClearTextboxes();
        }
        private void UpdatePayouts()
        {
            lbxPayout.Items.Clear();
            foreach (Employed A in Employees)
            {
                lbxPayout.Items.Add(A.PrintWithSalary((int)A.CalculateIncome()));
            }
        }

        private int CalculateTotalIncome()
        {
            int totalIncome = 0;
            foreach (Employed A in Employees)
            {
                totalIncome += (int)A.CalculateIncome();
            }
            return totalIncome;
        }

        private void ClearTextboxes()
        {
            tbxHourlyConsultant.Clear();
            tbxIncomeClerk.Clear();
            tbxNameClerk.Clear();
            tbxNameConsultant.Clear();
            tbxNameVender.Clear();
            tbxProvisionVender.Clear();
            tbxSalesVender.Clear();
            tbxTimeWorkedConsultant.Clear();
        }
    }
}
