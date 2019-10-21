using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediabiblioteket
{
    class Bok : Media
    {

        int _pages;

        public Bok(string title, int pages) : base(title)
        {
            this._pages = pages;
        }

        public override string ToString()
        {
            return $"[Bok] {_title}: {_pages} sidor";
        }
    }
}
