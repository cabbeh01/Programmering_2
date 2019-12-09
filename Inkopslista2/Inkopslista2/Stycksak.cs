using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkopslista2
{
    class Stycksak : Vara
    {
        private double _styckPris;
        private int _antal;

        public Stycksak(string Namn,double Styckpris, int Antal) : base(Namn)
        {
            this._styckPris = Styckpris;
            this._antal = Antal;
        }

        public double Styckpris
        {
            get
            {
                return _styckPris;
            }
            set
            {
                this._styckPris = value;
            }
        }

        public int Antal
        {
            get
            {
                return _antal;
            }
            set
            {
                this._antal = value;
            }
        }

        public override double Beräknapris()
        {
            return this._styckPris*this._antal;
        }

        public override string ToString()
        {
            return $"{this.Namn} {this.Beräknapris()} kr/st,  {this._antal} kr";
        }
    }
}
