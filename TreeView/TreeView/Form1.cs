using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {

        const int BATALJON = 0, KOMPANI = 1, PLUTON = 2, GRUPP = 3;
        private string[] info = { "Bataljon", "Kompani", "Pluton", "Grupp" };

        

        public Form1()
        {
            InitializeComponent();
            tvwBataljon.SelectedNode = tvwBataljon.Nodes[0];
            tvwBataljon.ExpandAll();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            TreeNode valdNod = tvwBataljon.SelectedNode;
            if(valdNod != null)
            {
                TreeNode nyNod = new TreeNode(tbxName.Text);
                valdNod.ImageIndex = valdNod.Level;
                valdNod.SelectedImageIndex = valdNod.Level;
                valdNod.Nodes.Add(nyNod);
                if(nyNod.Level == GRUPP)
                {
                    try
                    {
                        nyNod.Tag = int.Parse(tbxSoldates.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Användaren måste skriva ett giltligt antal soldater");
                    }
                }
                tbxName.Clear();
                tbxSoldates.Clear();
            }
        }

        private void tvwBataljon_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode valdNod = tvwBataljon.SelectedNode;
            tbxInfo.Text = info[valdNod.Level];
            tbxInfo.AppendText($"\r\nNamn: {valdNod.Text}");

            if (valdNod.Level == GRUPP) gbxNyenhet.Enabled = false;
            else                        gbxNyenhet.Enabled = true;


            if (valdNod.Level == PLUTON) tbxSoldates.Enabled = true;
            else                         tbxSoldates.Enabled = false;
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            TreeNode valdNod = tvwBataljon.SelectedNode;

            if (!(valdNod.Level == BATALJON))
            {
                valdNod.Remove();
            }

        }
    }
}
