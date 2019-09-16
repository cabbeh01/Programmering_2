using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resebokning
{
    class Resa
    {
        public string name = "";
        public string destination = "";
        public short days;

        Resa(string Name, string Destination, short Days)
        {
            this.name = Name;
            this.destination = Destination;
            this.days = Days;
        }


        

    }
}
