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

namespace BinaryFiles
{
    public partial class Form1 : Form
    {
        List<Ingridiens> Ingridienser = new List<Ingridiens>();
        public Form1()
        {
            InitializeComponent();
            InitializeExtenstions();
        }

        private void ÖppnaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgOpen.ShowDialog();
            if(result == DialogResult.OK)
            {
                dgView.Rows.Clear();
                FileStream inStream = new FileStream(dlgOpen.FileName, FileMode.Open, FileAccess.Read);

                BinaryReader reader = new BinaryReader(inStream);

                int antal = reader.ReadInt32();
                for(int i = 0; i < antal; i++)
                {
                    string ingrident = reader.ReadString();
                    float mangd = reader.ReadSingle();
                    string matt = reader.ReadString();

                    Ingridiens I = new Ingridiens(ingrident, mangd, matt);
                    Ingridienser.Add(I);


                    dgView.Rows.Add(ingrident, mangd, matt);
                    dgView.Rows[dgView.Rows.Count - 1].Tag = I;
                }
                
                reader.Dispose();
            }
        }

        private void SparaSomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = dlgSave.ShowDialog();
            if(result == DialogResult.OK)
            {
                FileStream outStream = new FileStream(dlgSave.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                BinaryWriter writer = new BinaryWriter(outStream);

                int antalIngred = Ingridienser.Count();
                writer.Write(antalIngred);

                for(int i = 0; i < antalIngred; i++) {

                    writer.Write(Ingridienser[i].Name);
                    writer.Write(Ingridienser[i].Mangd);
                    writer.Write(Ingridienser[i].Matt);

                }

                writer.Dispose();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Ingridiens I = new Ingridiens(tbxName.Text, float.Parse(tbxMangd.Text), tbxMatt.Text);
                Ingridienser.Add(I);
                dgView.Rows.Add(I.Name, I.Mangd, I.Matt);
                dgView.Rows[dgView.Rows.Count - 1].Tag = I;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Går inte att lägga in dina värden");
            }
            
        }

        void InitializeExtenstions()
        {
            dlgSave.Filter = "Recept filer (*.rec*)|*.rec*";
            dlgSave.DefaultExt = "rec";
            dlgSave.AddExtension = true;

            dlgOpen.Filter = "Recept filer (*.rec*)|*.rec*";
            dlgOpen.DefaultExt = "rec";
            dlgOpen.AddExtension = true;
        }
    }
}
