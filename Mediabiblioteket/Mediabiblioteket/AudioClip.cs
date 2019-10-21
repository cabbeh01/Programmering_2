using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediabiblioteket
{
    class AudioClip : Media
    {
        protected int _playTime;

        public AudioClip(string title, int playtime) : base(title)
        {
            this._playTime = playtime;
        }

        public override string ToString()
        {
            return $"[Ljudfil] {_title}: {_playTime} minuter";
        }

        public int Playtime
        {
            get
            {
                return this._playTime;
            }
        }
    }
}
