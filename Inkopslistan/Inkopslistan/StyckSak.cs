using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkopslistan
{
    class StyckSak : Vara
    {
        /// <summary>Styck priset på en vara</summary>
        protected double _styckPris;
        /// <summary>Antalet utav varan</summary>
        protected double _antal;


        /// <summary>Konstruktorn för stycksaker</summary>

        /// <param name="name">Namnet på varan</param>
        /// <param name="pris">Priset på varan</param>
        /// <param name="antal">Antalet utav varan</param>
        public StyckSak(string name, double pris, int antal) : base(name)
        {
            this._antal = antal;
            this._styckPris = pris;
        }

        public double Styckpris
        {
            get
            {
                return this._styckPris;
            }
            set
            {
                this._styckPris = value;
            }
        }


        public override double BeräknaPris()
        {
            return this._antal * this._styckPris;
        }

        public override string ToString()
        {
            return $"{this._name} {this._antal} st, {BeräknaPris()}kr/st";
        }
    }
}
