using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ÖppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgOpen.ShowDialog();
            if(result == DialogResult.OK)
            {
                FileStream inStream = new FileStream(dlgOpen.FileName, FileMode.Open, FileAccess.Read);

                StreamReader reader = new StreamReader(inStream);

                dgvOut.Rows.Clear();
                //Läs in datan
                string data = reader.ReadLine();
                while (data != null)
                {
                    string[] items = data.Split(';');

                    int col = items.Length;

                    for(int i = 0; i < col; i++)
                    {
                        dgvOut.Columns.Add("","");
                        Console.WriteLine(items[i].ToString());
                    }
                    dgvOut.Rows.Add(items);

                    data = reader.ReadLine();
                }


                reader.Dispose();
            }
        }

        private void SparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgSave.ShowDialog();
            if(result == DialogResult.OK)
            {
                FileStream outStream = new FileStream(dlgSave.FileName, FileMode.Create, FileAccess.Write);

                StreamWriter writer = new StreamWriter(outStream);

                //Skriv datan
                int col = dgvOut.Columns.Count;
                int rows = dgvOut.Rows.Count;
                string row = "";
                for(int x = 0; x < rows; x++)
                {
                    for (int i = 0; i < col; i++)
                    {
                        if (string.IsNullOrEmpty((string)dgvOut.Rows[x].Cells[i].Value))
                        {
                            break;
                        }
                        row = row + (string)dgvOut.Rows[x].Cells[i].Value;
                        if(i < col - 2)
                        {
                            row += ";";
                        }
                    }
                    writer.WriteLine(row);
                    row = "";
                    //Console.WriteLine(row);
                }
                

                writer.Dispose();
            }
        }
    }
}
