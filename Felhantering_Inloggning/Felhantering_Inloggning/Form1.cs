using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Felhantering_Inloggning
{
    public partial class Form1 : Form
    {

        Account acc;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string email = tbxEmail.Text;
            string password = tbxPassword.Text;

            try
            {
                acc = new Account(email, password);
            }
            catch(PasswordFormatException ex){
                MessageBox.Show(ex.ToString());
                return;
            }
            catch (EmailFormatException ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            MessageBox.Show("Kontot skapat!");
        }
    }
}
