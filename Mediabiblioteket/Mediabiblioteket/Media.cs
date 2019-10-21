using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediabiblioteket
{
    class Media
    {
        public static List<Media> AllMedia = new List<Media>();

        protected string _title;

        public Media(string title)
        {
            this._title = title;
        }

    }
}
