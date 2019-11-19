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
            base.Läggtill(e);

        }
    }
}
