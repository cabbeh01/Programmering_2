using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dialoger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgColor.ShowDialog();
            if(r == DialogResult.OK)
            {
                btnColor.BackColor = dlgColor.Color;
            }
        }

        private void BtnFolder_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgFolderbrowser.ShowDialog();
            if (r == DialogResult.OK)
            {
                btnFolder.Text = dlgFolderbrowser.SelectedPath;
            }
        }

        private void BtnFont_Click(object sender, EventArgs e)
        {
            DialogResult r = dlgFont.ShowDialog();
            if (r == DialogResult.OK)
            {
                btnFont.Font = dlgFont.Font;
            }
            
        }
    }
}
