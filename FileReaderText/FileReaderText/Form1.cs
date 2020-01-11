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

namespace FileReaderText
{
    public partial class Form1 : Form
    {

        string Filename;
        public Form1()
        {
            InitializeComponent();
        }

        private void stängToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nyttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filename = "";
            tbxOut.Clear();
        }

        private void öppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult result = dlgOpenFile.ShowDialog();
            if(result == DialogResult.OK)
            {
                Filename = dlgOpenFile.FileName;
                FileStream inStream = new FileStream(Filename, FileMode.Open, FileAccess.Read);
                

                StreamReader reader = new StreamReader(inStream);
                tbxOut.Clear();
                string fileText = reader.ReadToEnd();

                tbxOut.Text = fileText;

                reader.Dispose();
            }
        }

        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Filename))
            {
                FileStream OutStream = new FileStream(Filename, FileMode.Create, FileAccess.Write);
                StreamWriter writer = new StreamWriter(OutStream);
                writer.Write(tbxOut.Text);
                writer.Dispose();
            }
            else
            {
                DialogResult result = dlgSaveFile.ShowDialog();
                if (result == DialogResult.OK)
                {
                    FileStream OutStream = new FileStream(dlgSaveFile.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                    StreamWriter writer = new StreamWriter(OutStream);
                    writer.Write(tbxOut.Text);
                    writer.Dispose();
                }

            }
        }

        private void sparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgSaveFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileStream OutStream = new FileStream(dlgSaveFile.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                StreamWriter writer = new StreamWriter(OutStream);
                writer.Write(tbxOut.Text);
                writer.Dispose();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            tbxOut.Text = tbxOut.Text.Replace(tbxOrd1.Text, tbxOrd2.Text);
        }
    }
}
