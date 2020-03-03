using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InloggMySql
{
    class Användare
    {
        public string användarnamn { get; }

        public string password { get; set; }

        public string namn { get; }

        public string adress { get; set; }

        public Användare(string användarnamn, string password, string namn, string adress)
        {
            this.användarnamn = användarnamn;
            this.password = password;
            this.namn = namn;
            this.adress = adress;
        }
    }
}
