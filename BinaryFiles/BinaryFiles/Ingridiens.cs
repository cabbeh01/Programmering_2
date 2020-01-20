using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryFiles
{
    class Ingridiens
    {

        private string _name;
        private float _mangd;
        private string _matt;
        

        public Ingridiens(string Name, float Mangd, string Matt)
        {
            this._name = Name;
            this._mangd = Mangd;
            this._matt = Matt;

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
        public float Mangd
        {
            get
            {
                return this._mangd;
            }
            set
            {
                this._mangd = value;
            }
        }

        public string Matt
        {
            get
            {
                return this._matt;
            }
            set
            {
                this._matt = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Name} {this._mangd} {this._matt}";
        }
    }
}
