using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LimitedTextbox
{
    public partial class LimitedTBX : UserControl
    {
        public LimitedTBX()
        {
            InitializeComponent();
        }

        private void tbxInput_TextChanged(object sender, EventArgs e)
        {
            lblCount.Text = $"({140 - tbxInput.Text.Length})";
        }
    }
}
