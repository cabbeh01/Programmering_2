using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felhantering_Inloggning
{
    class Account
    {
        string _email;
        string _password;

        public Account(string email,string password)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
            }
            catch
            {
                throw new EmailFormatException();
            }
            


            int countDigits = 0;
            for(int i = 0; i<password.Length; i++)
            {
                if (char.IsDigit(password[i])){
                    countDigits++;
                }
            }

            if(0 < countDigits && countDigits < password.Length)
            {
                this._email = email;
                this._password = password;
            }
            else
            {
                throw new PasswordFormatException();
            }
            
        }
    }
}
