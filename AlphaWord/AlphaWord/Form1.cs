using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaWord
{
    public partial class Form1 : Form
    {
        string a;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            a = rtbxText.Text;
            DialogResult r = dlgPrint.ShowDialog();

            if (r == DialogResult.OK)
            {
                
                dlgPrintDocument.PrinterSettings = dlgPrint.PrinterSettings;
                StringReader reader = new StringReader(rtbxText.Text);
                //dlgPrintDocument.PrintPage += new PrintPageEventHandler(DocumentToPrint_PrintPage);

               
                dlgPrintDocument.Print();
            }
        }

        private void PbxColor_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgColor.ShowDialog();
            if(r == DialogResult.OK)
            {
                pbxColor.BackColor = dlgColor.Color;
                rtbxText.SelectionColor = dlgColor.Color;
                
            }
        }

        private void DlgPrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {

            //e.Graphics.FillRectangle(new SolidBrush(Color.Black), 20, 20, 100, 1000);
            e.Graphics.DrawString(a, new Font("Times New Roman", 10), new SolidBrush(Color.Black),200,500);
        }
    }
}
