using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveReadKontakt
{
    class Kontakt
    {
        private string _firstname;
        private string _lastname;
        private string _email;
        private string _phonenumber;

        public Kontakt(string firstname,string lastname,string email,string phonenumber)
        {
            this._firstname = firstname;
            this._lastname = lastname;
            this._email = email;
            this._phonenumber = phonenumber;
        }

        public override string ToString()
        {
            return $"{this._firstname} {this._lastname}";
        }
    }
}
