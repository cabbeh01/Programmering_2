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
        string markering;
        public Form1()
        {
            InitializeComponent();
            for(int i = 0; i < FontFamily.Families.Length; i++)
            {
                cbxFonts.Items.Add(FontFamily.Families[i].Name);
                cbxFonts.SelectedItem = "Times New Roman";
            }
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

        private void btnAlignleft_Click(object sender, EventArgs e)
        {
            HorizontalAlignment a = HorizontalAlignment.Left;
            rtbxText.SelectionAlignment = a;
        }

        private void btnAlignmiddle_Click(object sender, EventArgs e)
        {
            HorizontalAlignment a = HorizontalAlignment.Center;
            rtbxText.SelectionAlignment = a;
        }

        private void btnAlignRight_Click(object sender, EventArgs e)
        {
            HorizontalAlignment a = HorizontalAlignment.Right;
            rtbxText.SelectionAlignment = a;
        }

        private void btnFet_Click(object sender, EventArgs e)
        {

        }

        private void btnKursiv_Click(object sender, EventArgs e)
        {

        }

        private void btnUnder_Click(object sender, EventArgs e)
        {

        }

        private void nUD_ValueChanged(object sender, EventArgs e)
        {
            if(nUD.Value < 8)
            {
                nUD.Value++;
            }
            else if(nUD.Value > 72)
            {
                nUD.Value--;
            }

            try
            {
                rtbxText.SelectedText = markering;
                rtbxText.SelectionFont = new Font(cbxFonts.SelectedText, (int)nUD.Value);
            }
            catch
            {

            }
        }

        private void cbxFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                rtbxText.SelectedText = markering;
                rtbxText.SelectionFont = new Font(cbxFonts.SelectedText, (int)nUD.Value);
                
            }
            catch
            {

            }
        }

        private void rtbxText_TextChanged(object sender, EventArgs e)
        {
            markering = rtbxText.SelectedText;
        }
    }
}
