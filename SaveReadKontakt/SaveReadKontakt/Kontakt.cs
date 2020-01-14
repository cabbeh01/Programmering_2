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

        public string Firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }
        public string Lastname
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public string Phonenumber
        {
            get
            {
                return _phonenumber;
            }
            set
            {
                _phonenumber = value;
            }
        }
    }
}
