using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    class Zona
    {
        private int codZona;
        private string numeZona;

        public Zona()
        {

        }

        public Zona(string numeZona, int codZona)
        {
            this.numeZona = numeZona;
            this.codZona = codZona;
        }

        public int CodZona
        {
            get { return codZona; }
            set { this.codZona = value; }
        }
        public string NumeZona
        {
            get { return numeZona; }
            set { this.numeZona = value; }
        }
    }
}
