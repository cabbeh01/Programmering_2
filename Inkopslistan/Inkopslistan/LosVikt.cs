using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkopslistan
{
    class LosVikt : Vara
    {
        protected double _kiloPris;
        protected double _vikt;

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
