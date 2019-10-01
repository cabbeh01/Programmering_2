using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anmalan
{
    class Anmalan
    {
        public static List<Anmalan> AnmalanAlla = new List<Anmalan>();

        public string _brottsmisstanke;
        public Garningsman g;

        public Anmalan(Garningsman gMan, string brott)
        {
            this._brottsmisstanke = brott;
            this.g = gMan;
        }

        public override string ToString()
        {
            return $"{this._brottsmisstanke}: {g.ToString()}";
        }
    }
}
