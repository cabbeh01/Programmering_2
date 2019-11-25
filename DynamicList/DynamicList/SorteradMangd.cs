using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicList
{
    class SorteradMangd<T> : Mangd<T> where T : IComparable<T>
    {/*
        protected void Sortera()
        {
            int i, j;
            int n = this.antal;
            if (n < 2)
            {
                return;
            }

            T a;

            for(j=1; j < n; j++)
            {
                a = this.lista[j];
                i = j - 1;


                while(i>=0 && this.lista[i].CompareTo(a) > 0)
                {
                    this.lista[i + 1] = this.lista[i];
                    i--;
                }

                this.lista[i + 1] = a;
            }
        }

        public override void Läggtill(T e)
        {
            this.Läggtill(e);
            Sortera();
        }*/
    }
}
