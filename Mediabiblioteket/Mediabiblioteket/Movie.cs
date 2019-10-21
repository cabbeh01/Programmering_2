using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediabiblioteket
{
    class Movie : AudioClip
    {
        string _resolution;

        public Movie(string title, int playtime,string resolution) : base(title,playtime)
        {
            this._resolution = resolution;
        }

        public override string ToString()
        {
            return $"[Film] {_title}: {_playTime} minuter, {_resolution}";
        }

        public string Resolution
        {
            get
            {
                return this._resolution;
            }
        }
    }
}
