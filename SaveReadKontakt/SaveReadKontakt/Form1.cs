using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveReadKontakt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeExtenstions();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgOpenFile.ShowDialog();

            if(result == DialogResult.OK)
            {
                FileStream inStream = new FileStream(dlgOpenFile.FileName, FileMode.Open, FileAccess.Read);

                StreamReader stream = new StreamReader(inStream);
                string firstname = stream.ReadLine();
                string lastname = stream.ReadLine();
                string email = stream.ReadLine();
                string phonenumber = stream.ReadLine();
                tbxFirstname.Text = firstname;
                tbxLastname.Text = lastname;
                tbxEmail.Text = email;
                tbxPhonenumber.Text = phonenumber;
                stream.Dispose();
            }
        }

        private void BtnSaveAs_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgSaveFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileStream outStream = new FileStream(dlgSaveFile.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                
                StreamWriter stream = new StreamWriter(outStream);
                string firstname = tbxFirstname.Text;
                string lastname = tbxLastname.Text;
                string email = tbxEmail.Text;
                string phonenumber = tbxPhonenumber.Text;

                stream.WriteLine(firstname);
                stream.WriteLine(lastname);
                stream.WriteLine(email);
                stream.WriteLine(phonenumber);

                stream.Dispose();
            }
        }

        void InitializeExtenstions()
        {
            dlgSaveFile.Filter = "Kontakt filer (*.kon*)|*.kon*";
            dlgSaveFile.DefaultExt = "kon";
            dlgSaveFile.AddExtension = true;

            dlgOpenFile.Filter = "Kontakt filer (*.kon*)|*.kon*";
            dlgOpenFile.DefaultExt = "kon";
            dlgOpenFile.AddExtension = true;
        }

        void ClearTextboxes()
        {
            tbxFirstname.Clear();
            tbxLastname.Clear();
            tbxEmail.Clear();
            tbxPhonenumber.Clear();
        }
    }
}
