using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace EmailAdressTB
{
    class EmailAddressTextBox : TextBox
    {
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);

            if (String.IsNullOrEmpty(this.Text))
            {
                this.BackColor = Color.White;
            }

            string mail = this.Text;
            try
            {
                var addr = new System.Net.Mail.MailAddress(mail);
                this.BackColor = Color.Green;
            }
            catch
            {
                this.BackColor = Color.Red;
            }
        }

    }
}
