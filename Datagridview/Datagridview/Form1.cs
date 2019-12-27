using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datagridview
{
    public partial class Form1 : Form
    {
        private List<Match> matcher = new List<Match>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hemmalag = "";
            string bortalag = "";

            int antalMål = 0;

            for(int i = 0; i<matcher.Count; i++)
            {
                if(matcher[i].MålHemmaLag + matcher[i].MålBortaLag > antalMål)
                {
                    hemmalag = matcher[i].HemmaLag;
                    bortalag = matcher[i].BortaLag;
                    antalMål = matcher[i].MålBortaLag + matcher[i].MålHemmaLag;
                }
            }

            tbxInput.Text = $"{hemmalag} {bortalag}: {antalMål}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            Match nyMatch = new Match();
            matcher.Add(nyMatch);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex; //Index förden rad som redigeras
            if(e.ColumnIndex == 0)
            {
                matcher[i].HemmaLag = (string)dataGridView1.Rows[i].Cells[0].Value;
            }
            else if (e.ColumnIndex == 1)
            {
                matcher[i].BortaLag = (string)dataGridView1.Rows[i].Cells[1].Value;
            }
            else if (e.ColumnIndex == 2)
            {
                matcher[i].MålHemmaLag = int.Parse((string)dataGridView1.Rows[i].Cells[2].Value);
            }
            else if (e.ColumnIndex == 3)
            {
                matcher[i].MålBortaLag = int.Parse((string)dataGridView1.Rows[i].Cells[3].Value);
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Match a = e.Row.Tag as Match;
            matcher.Remove(a);
        }
    }

    public class Match
    {
        public string HemmaLag { get; set; }
        public string BortaLag { get; set; }
        public int MålHemmaLag { get; set; }
        public int MålBortaLag { get; set; }
    }
}
