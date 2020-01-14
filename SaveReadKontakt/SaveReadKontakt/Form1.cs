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

        private void ÖppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgOpenFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileStream inStream = new FileStream(dlgOpenFile.FileName, FileMode.Open, FileAccess.Read);

                StreamReader stream = new StreamReader(inStream);

                lbxOut.Items.Clear();
                string firstname = stream.ReadLine();
                while (!(string.IsNullOrEmpty(firstname)))
                {
                    Kontakt k = new Kontakt(firstname, stream.ReadLine(), stream.ReadLine(), stream.ReadLine());
                    lbxOut.Items.Add(k);

                    firstname = stream.ReadLine();
                }

                stream.Dispose();

            }
        }

        private void SparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgSaveFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                FileStream outStream = new FileStream(dlgSaveFile.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                StreamWriter stream = new StreamWriter(outStream);

                foreach (Kontakt k in lbxOut.Items)
                {
                    stream.WriteLine(k.Firstname);
                    stream.WriteLine(k.Lastname);
                    stream.WriteLine(k.Email);
                    stream.WriteLine(k.Phonenumber);
                }
                stream.Dispose();
            }
        }

        private void LäggTillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kontakt a = new Kontakt(tbxFirstname.Text, tbxLastname.Text, tbxEmail.Text, tbxPhonenumber.Text);

            lbxOut.Items.Add(a);
            ClearTextboxes();
        }

        private void TaBortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbxOut.Items.Remove(lbxOut.SelectedItem);
            ClearTextboxes();
        }

        private void LbxOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Kontakt k = (Kontakt)lbxOut.SelectedItem;

                tbxFirstname.Text = k.Firstname;
                tbxLastname.Text = k.Lastname;
                tbxEmail.Text = k.Email;
                tbxPhonenumber.Text = k.Phonenumber;
            }
            catch
            {
                
            }
        }
    }
}
