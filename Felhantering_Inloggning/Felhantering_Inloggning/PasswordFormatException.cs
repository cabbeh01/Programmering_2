using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felhantering_Inloggning
{
    class PasswordFormatException : Exception
    {
        public override string ToString()
        {
            return "Lösenordet måste innehålla både bokstäver och siffror";
        }
    }
}
