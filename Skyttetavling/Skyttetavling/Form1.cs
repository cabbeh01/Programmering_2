using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyttetavling
{
    public partial class Form1 : Form
    {

        List<Tavlande> allTavlande = new List<Tavlande>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            short s;
            bool shortP = short.TryParse(tbxPoints.Text, out s);

            if (shortP)
            {
                allTavlande.Add(new Tavlande(tbxName.Text, s));
            }
            else
            {
                MessageBox.Show("Du måste mata in ett tal!", "Varning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            Update();
            ClearValueAdd();
            MessageBox.Show("Du har nu lagt till en tävlande");
        }

        private void BtnSok_Click(object sender, EventArgs e)
        {
            short sP;
            bool shortSokP = short.TryParse(tbxSokPoints.Text, out sP);
            Update();

            if (shortSokP)
            {
                foreach (Tavlande t in allTavlande)
                {
                    if (t.Points < sP)
                    {
                        lbxOutput.Items.Remove(t);
                    }
                }
            }
            else
            {
                MessageBox.Show("Du måste mata in ett tal!", "Varning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(lbxOutput.Items.Count == 0)
            {
                MessageBox.Show("Kunde inte hitta någon som fick den poängen!");
            }
            ClearValueSok();

        }
        void Update()
        {
            lbxOutput.Items.Clear();

            foreach(Tavlande t in allTavlande)
            {
                lbxOutput.Items.Add(t);
            }
        }

        void ClearValueAdd()
        {
            tbxName.Clear();
            tbxPoints.Clear();
        }
        void ClearValueSok()
        {
            tbxSokPoints.Clear();
        }
    }
}
