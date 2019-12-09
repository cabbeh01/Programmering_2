using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkopslista2
{
    abstract class Vara
    {
        private string _namn;
        public static List<Vara> Varukorg = new List<Vara>();
        public Vara(string Namn)
        {
            this._namn = Namn;
        }
        public string Namn
        {
            get
            {
                return this._namn;
            }
            set
            {
                _namn = value;
            }
        }

        public virtual double Beräknapris()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"{this.Namn}";
        }
    }
}
