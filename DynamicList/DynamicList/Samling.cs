using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicList
{
    public class Samling<T>
    {
        protected int buffert;
        protected T[] lista;
        protected int längd;
        protected int antal;

        public Samling()
        {
            buffert = 30;
            antal = 0;
            längd = 30;
            lista = new T[längd];
        }

        protected void Expandera(int storlek)
        {
            if(storlek < 1)
            {
                return;
            }

            T[] temp = new T[längd + storlek];
            for(int i = 0; i < antal; i++)
            {
                temp[i] = lista[i];
            }

            lista = temp;
            längd += storlek;
        }

        protected void Reducera()
        {
            T[] temp = new T[antal];

            for (int i = 0; i < antal; i++)
            {
                temp[i] = lista[i];
            }

            lista = temp;
            längd = antal;
        }

        public void Läggtill(T e)
        {
            if(antal + 1 > längd)
            {
                Expandera(1 + buffert);
            }
            lista[antal++] = e;
        }

        public void Läggtill(Samling<T> s)
        {
            for(int i = 0; i < s.antal; i++)
            {
                Läggtill(s.ElementFrån(i));
            }
            
        }

        public T TaBort(int index)
        {
            T temp = lista[index];

            for(int i = index; i<antal-1; i++)
            {
                lista[i] = lista[i + 1];
            }

            antal--;

            if(längd - antal > buffert)
            {
                Reducera();
            }

            return temp;
        }

        public int Antal()
        {
            return antal;
        }

        public T ElementFrån(int index)
        {
            return lista[index];
        }

        public bool Har(T värde)
        {

            foreach(T a in lista)
            {
                if (värde.Equals(a))
                {
                    return true;
                }
            }
            return false;
        }

        public int Sök(T värde)
        {
            for (int i = 0; i < antal; i++)
            {
                if (värde.Equals(lista[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public T this[int index]
        {
            get
            {
                return lista[index];
            }
        }
          

    }
}
