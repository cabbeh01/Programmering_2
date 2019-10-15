using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felhantering_Inloggning
{
    class EmailFormatException : Exception
    {

        public override string ToString()
        {
            return "Emailen måste vara en giltlig mail!";
        }
    }
}
