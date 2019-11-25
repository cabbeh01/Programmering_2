using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkopslistan
{
    abstract class Vara
    {
        public static List<Vara> varukorg = new List<Vara>();

        protected string _name;

        public Vara(string name)
        {
            this._name = name;
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

        public virtual double BeräknaPris()
        {
            return 0;
        }
    }
}
