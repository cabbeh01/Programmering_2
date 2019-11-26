using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkopslistan
{
    class LosVikt : Vara
    {
        /// <summary>Kilo priset på en vara</summary>
        protected double _kiloPris;
        /// <summary>Vikten på en vara</summary>
        protected double _vikt;


        /// <summary>Konstruktorn för Lösvikt</summary>

        /// <param name="name">Namnet på varan</param>
        /// <param name="pris">Priset på varan</param>
        /// <param name="vikt">Vikten utav varan</param>
        public LosVikt(string name, double pris, double vikt) : base(name)
        {
            this._kiloPris = pris;
            this._vikt = vikt;
        }


        public double Kilopris
        {
            get
            {
                return this._kiloPris;
            }
            set
            {
                this._kiloPris = value;
            }
        }

        public double Vikt
        {
            get
            {
                return this._vikt;
            }
            set
            {
                this._vikt = value;
            }
        }


        public override double BeräknaPris()
        {
            return this._kiloPris * this._vikt;
        }

        public override string ToString()
        {
            return $"{this._name} {this._vikt} kg, {BeräknaPris()}kr/kg";
        }
    }
}
