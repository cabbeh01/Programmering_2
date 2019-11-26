using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inkopslistan
{
    abstract class Vara
    {
        /// <summary>
        /// Öppet fält där alla varor läggs
        /// </summary>
        public static List<Vara> varukorg = new List<Vara>();

        /// <summary>
        /// Namnet på varan
        /// </summary>
        protected string _name;

        /// <summary>
        /// Konstruktor för Varan
        /// </summary>
        /// <param name="name">Namet på varan</param>
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
