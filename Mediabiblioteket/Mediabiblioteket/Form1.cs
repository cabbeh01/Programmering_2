using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediabiblioteket
{
    public partial class Form1 : Form
    {
        int id = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRegisterBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(tbxTitleBook.Text))
                {
                    Bok tempBok = new Bok(tbxTitleBook.Text, int.Parse(tbxPagesBook.Text));
                    Media.AllMedia.Add(tempBok);
                    UpdateTable();
                    ClearBook();
                }
                else
                {
                    MessageBox.Show("Du måste ge boken en titel");
                }
            }
            catch
            {
                MessageBox.Show("Det går inte lägga till boken");
            }
        }

        private void BtnRegisterAudio_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(tbxTitleAudio.Text))
                {
                    AudioClip tempAudio = new AudioClip(tbxTitleAudio.Text, int.Parse(tbxPlaytimeAudio.Text));
                    Media.AllMedia.Add(tempAudio);
                    UpdateTable();
                    ClearAudioClip();
                }
                else
                {
                    MessageBox.Show("Du måste ge ljudspåret en titel");
                }
            }
            catch
            {
                MessageBox.Show("Det går inte lägga till ljudspåret");
            }
        }

        private void BtnRegisterMovie_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrWhiteSpace(tbxTitleMovie.Text))
                {
                    if (!String.IsNullOrWhiteSpace(tbxResolutionMovie.Text))
                    {
                        Movie tempMovie = new Movie(tbxTitleMovie.Text, int.Parse(tbxPlaytimeMovie.Text), tbxResolutionMovie.Text);
                        Media.AllMedia.Add(tempMovie);
                        UpdateTable();
                        ClearMovie();
                    }
                    else
                    {
                        MessageBox.Show("Du måste ge filmen en upplösning");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Du måste ge filmen en titel");
                }
            }
            catch
            {
                MessageBox.Show("Det går inte lägga till ljudspåret");
            }
        }

        private void UpdateTable()
        {
            lbxOut.Items.Clear();

            foreach(Media a in Media.AllMedia)
            {
                lbxOut.Items.Add(a);
            }
        }

        private void ClearBook()
        {
            tbxTitleBook.Clear();
            tbxPagesBook.Clear();
        }
        private void ClearMovie()
        {
            tbxTitleMovie.Clear();
            tbxResolutionMovie.Clear();
            tbxPlaytimeMovie.Clear();
        }
        private void ClearAudioClip()
        {
            tbxPlaytimeAudio.Clear();
            tbxTitleAudio.Clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Media.AllMedia.RemoveAt(lbxOut.SelectedIndex);
            UpdateTable();
            if (lbxOut.Items.Count == 0)
            {
                btnDelete.Enabled = false;
            }
        }

        private void LbxOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Media m = lbxOut.SelectedItem as Media;
            if(m is Bok)
            {
                Bok b = m as Bok;
                tbxTitleBook.Text = b.Title;
                tbxPagesBook.Text = b.Pages.ToString();
            }
            else if (m is AudioClip)
            {
                AudioClip b = m as AudioClip;
                tbxTitleAudio.Text = b.Title;
                tbxPlaytimeAudio.Text = b.Playtime.ToString();
            }
            else if (m is Movie)
            {
                Movie b = m as Movie;
                tbxTitleBook.Text = b.Title;
                tbxPlaytimeMovie.Text = b.Playtime.ToString();
                tbxResolutionMovie.Text = b.Resolution.ToString();
            }
        }
    }
}
