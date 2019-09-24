using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loplogg
{
    class Log
    {
        float _distance;
        float _time;
        bool _switcher = true;


        public Log(float distance, float time)
        {
            this._distance = distance;
            this._time = time;
        }

        public float Distance
        {
            get
            {
                return this._distance;
            }
        }
        public float Time
        {
            get
            {
                return this._time;
            }
        }
        public bool Switcher
        {
            set
            {
                this._switcher = value; 
            }
        }


        public override string ToString()
        {
            if (!this._switcher)
            {
                return this._distance/(this._time / 60)+ " km/h";
            }
            else
            {
                return this._time + "min";
            }
        }

    }
}
