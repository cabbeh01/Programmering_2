using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicList
{
    public partial class Form1 : Form
    {
        Samling<int> nummer = new Samling<int>();
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            Startup();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Startup()
        {
            for (int i = 0; i < 10; i++)
            {
                nummer.Läggtill(r.Next(10));
            }
            UppdateraListbox();
        }
        private void UppdateraListbox()
        {
            lbxShow.Items.Clear();
            for(int i = 0; i < nummer.Antal(); i++)
            {
                lbxShow.Items.Add(nummer[i]);
            }
        }

        private void BtnSok_Click(object sender, EventArgs e)
        {
            if(nummer.Sök(int.Parse(tbxSok.Text)) != -1)
            {
                int i = nummer.Sök(int.Parse(tbxSok.Text));
                MessageBox.Show(i.ToString());
            }
            else
            {
                MessageBox.Show("Kan inte hitta något nummer");
            }
        }
    }
}
