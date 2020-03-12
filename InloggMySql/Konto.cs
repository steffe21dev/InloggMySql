using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InloggMySql
{
    class Konto
    {

        public int id { get; }
        public string namn { get; set; }
        public double saldo { get; set; }
        public string användarnamn { get; set; }


        public Konto(int id, string namn,double saldo, string användarnamn)
        {

            this.id = id;
            this.namn = namn;
            this.saldo = saldo;
            this.användarnamn = användarnamn;

        }


    }
}
