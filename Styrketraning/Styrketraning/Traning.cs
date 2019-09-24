using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrketraning
{
    class Traning
    {
        public static List<Traning> Traningar = new List<Traning>();

        string _ovning;

        short _set,_rep,_vikt;


        public Traning(string ovning, short set, short rep, short vikt)
        {
            this._ovning = ovning;
            this._set = set;
            this._rep = rep;
            this._vikt = vikt;
        }

        public string Ovning
        {
            get
            {
                return this._ovning;
            }
        }

        public short ViktCalc
        {
            get
            {
                return (short)(this._set * this._rep * this._vikt);
            }
        }



    }
}
