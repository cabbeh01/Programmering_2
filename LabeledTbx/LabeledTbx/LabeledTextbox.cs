using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace LabeledTbx
{
    class LabeledTextbox : TextBox
    {
        private string ledText;
        [Category("Appearance"),Description("Label text."),DefaultValue("...")]

        public string LedText
        {
            get
            {
                return ledText;
            }
            set
            {
                ledText = value;
                Text = value;
                ForeColor = System.Drawing.Color.Gray;
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (this.Text == ledText)
            {
                this.Text = "";
                ForeColor = System.Drawing.Color.Black;
            }
           
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (this.Text == "")
            {
                this.Text = ledText;
                ForeColor = System.Drawing.Color.Gray;
            }
        }
    }
}
