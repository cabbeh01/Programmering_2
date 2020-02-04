using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Chatapplikation
{
    class User
    {
        string _name;
        string _username;
        string _password;

        public TcpClient client = new TcpClient();

        public User(string name, string username, string password)
        {
            this._name = name;
            this._username = username;
            this._password = password;
        }

        


        public override string ToString()
        {
            return $"{this._name}";
        }

    }
}
