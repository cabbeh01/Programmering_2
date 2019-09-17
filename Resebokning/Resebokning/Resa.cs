using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resebokning
{
    class Resa
    {
        string name;
        string destination;
        short days;

        public Resa(string Name, string Destination, short Days)
        {
            this.name = Name;
            this.destination = Destination;
            this.days = Days;
        }

        public override string ToString()
        {
            return this.name +  " | " + this.destination + ": " + this.days;
        }

        public string getName()
        {
            return name;
        }
    }
}
