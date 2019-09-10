using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_3_Object
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            PictureBox[,] bilder = new PictureBox[5, 5];

            for(int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    bilder[r, c] = new PictureBox();
                    bilder[r, c].BackgroundImage = Image.FromFile(@"C:\Users\cashen0116\Downloads\star.jpg");
                    bilder[r, c].Left = (50*c) + 0;
                    bilder[r, c].Width = 50;
                    bilder[r, c].Height = 50;
                    bilder[r, c].Top = (50*r) +0;
                    bilder[r, c].Click += pbxStar_Click;
                    this.Controls.Add(bilder[r,c]);
                    
                }
            }


        }

        private void pbxStar_Click(object sender,EventArgs e)
        {
            PictureBox clickedflower = (PictureBox)sender;
            if (clickedflower.BorderStyle == BorderStyle.FixedSingle)
            {
                clickedflower.BorderStyle = BorderStyle.None;
            }
            else
            {
                clickedflower.BorderStyle = BorderStyle.FixedSingle;
            }
            

            
        }
    }
}
