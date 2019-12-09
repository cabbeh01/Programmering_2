using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkopslista2
{
    class Losvikt : Vara
    {
        private double _kiloPris;
        private double _vikt;

        public Losvikt(string Namn, double Kilopris, double Vikt) : base(Namn)
        {
            this._vikt = Vikt;
            this._kiloPris = Kilopris;
        }


        public double KiloPris
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


        public override double Beräknapris()
        {
            return _vikt * _kiloPris;
        }

        public override string ToString()
        {
            return $"{this.Namn} {this._kiloPris} kr/kg, {this.Beräknapris()} kr";
        }

    }
}
