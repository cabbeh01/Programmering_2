using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_3
{
    public partial class Form1 : Form
    {
        Color color = Color.Black;
        int textsize = 12;
        FontFamily[] fontfamilyArray = FontFamily.Families;
        public Form1()
        {
            InitializeComponent();
            Startup();
        }

        private void PbxColor_Click(object sender, EventArgs e)
        {
            cDialog.ShowDialog();

            color = cDialog.Color;
            pbxColor.BackColor = color;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            textsize = (int)nUpDown.Value;

            FontStyle stil = FontStyle.Regular;

            if (cbxBold.Checked)
            {
                stil = stil | FontStyle.Bold;
            }
            if (cbxItalic.Checked)
            {
                stil = stil | FontStyle.Italic;
            }
            if (cbxUnderline.Checked)
            {
                stil = stil | FontStyle.Underline;
            }

            
            rtbx.Font = new Font(cbox.Text,textsize,stil);
            rtbx.ForeColor = color;
        }

        void Startup()
        {
            foreach(FontFamily ff in fontfamilyArray)
            {
                cbox.Items.Add(ff.Name);
            }
            nUpDown.Value = 12;
        }

        private void NUpDown_ValueChanged(object sender, EventArgs e)
        {
            if(nUpDown.Value == 0)
            {
                nUpDown.Value++;
            }
        }
    }
}
