using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skyttetavling
{
    class Tavlande
    {
        string name;
        short points;

        public Tavlande(string n, short p)
        {
            this.name = n;
            this.points = p;
        }

        public string Name    
        {
            get
            {
                return this.name;
            }
        }

        public short Points
        {
            get
            {
                return this.points;
            }
        }

        public override string ToString()
        {
            return name + " | " + points;
        }
    }
}
