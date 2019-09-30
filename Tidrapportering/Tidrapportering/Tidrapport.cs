using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tidrapportering
{
    class Tidrapport
    {
        string _customer;
        int _time;

        public static List<Tidrapport> tidrapporteringar = new List<Tidrapport>();


        public Tidrapport(string customer, int time)
        {
            this._customer = customer;
            this._time = time;
        }

        
        public string Customer
        {
            get
            {
                return this._customer;
            }
            set
            {
                this._customer = value;
            }
        }
        public int Time
        {
            get
            {
                return this._time;
            }
        }


        public override string ToString()
        {
            return $"{this._customer}: {this._time} min";
        }

    }
}
