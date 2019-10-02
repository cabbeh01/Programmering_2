using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anmalan
{
    class Garningsman
    {
        string _name;
        short _gender;
        short _age;
        short _lenght;
        string _haircolor;
        string _genderString;
        

        public Garningsman(string name, short gender, short age, short length, string haircolor)
        {
            this._name = name;
            this._gender = gender;
            this._age = age;
            this._lenght = length;
            this._haircolor = haircolor;
        }


        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public short Gender
        {
            get
            {
                return this._gender;
            }
            set
            {
                this._gender = value;
            }
        }
        public short age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
        public short Length
        {
            get
            {
                return this._lenght;
            }
            set
            {
                this._lenght = value;
            }
        }

        public string Haircolor
        {
            get
            {
                return this._haircolor;
            }
            set
            {
                this._haircolor = value;
            }
        }


        void GetGender()
        {

            //Ett bättre alternativ hade varit ifall jag använde enumerationer!
            try
            {
                switch (this._gender)
                {
                    case 1:
                        this._genderString = "Man";
                        break;
                    case 2:
                        this._genderString = "Kvinna";
                        break;
                    case 3:
                        this._genderString = "Annat";
                        break;
                }
            }
            catch
            {
                this._genderString = "Kön kunde inte identifieras";
            }
        }

        public override string ToString()
        {
            GetGender();
            return $"{this._name}, {this._genderString}, {this._age},{this._lenght} cm, Hårfärg: {this._haircolor}";
        }
    }
}
