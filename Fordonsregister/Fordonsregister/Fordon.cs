using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Fordonsregister
{
    class Fordon
    {
        public static List<Fordon> AllFordon = new List<Fordon>();
        public enum Vehicle { Bil, MC };

        string _regNr,_brand,_model;
        
        Vehicle _type;

        public Fordon(string RegNr, string Brand, string Model, Vehicle type)
        {
            this._regNr = RegNr;
            this._brand = Brand;
            this._model = Model;
            this._type = type;
        }

        public string RegNummer
        {
            get
            {
                return this._regNr;
            }
        }
        public string Brand
        {
            get
            {
                return this._brand;
            }
        }
        public string Model
        {
            get
            {
                return this._model;
            }
        }
        public Vehicle Type
        {
            get
            {
                return this._type;
            }
        }
        public static bool AcceptReg(string Reg)
        {
            if(Reg.Length == 6)
            {
                for (int i = 0; i < Reg.Length; i++)
                {
                    if (i <= 2)
                    {
                        if ((int.TryParse(Reg[i].ToString(), out int r)))
                        {
                            return false;
                        }
                    }
                    if (i > 2)
                    {
                        if (!(int.TryParse(Reg[i].ToString(), out int r)))
                        {
                            return false;
                        }

                    }

                }
                return true;
                
            }

            return false;


        }
        public override string ToString()
        {
            return $"[{this._type.ToString()}]{this._regNr}: {this._brand}, {this._model}";
        }

    }
}
