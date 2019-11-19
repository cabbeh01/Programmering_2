using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicList
{
    class Mangd<T> : Samling<T>
    {
        public override void Läggtill(T e)
        {
            if (this.Har(e))
            {
                return;
            }
            else if (antal + 1 > längd)
            {
                Expandera(1 + buffert);
            }
            lista[antal++] = e;
        }
    }
}
