using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    class Spital
    {
        private string numeSpital;
        private int codSpital;
        private int codZona;

        public Spital()
        {

        }

        public Spital(string numeSpital,int codSpital,int codZona)
        {
            this.numeSpital = numeSpital;
            this.codSpital = codSpital;
            this.codZona = codZona;
        }

        public string NumeSpital
        {
            get { return numeSpital; }
            set { this.numeSpital = value; }
        }
        public int CodSpital
        {
            get { return codSpital; }
            set { this.codSpital = value; }
        }
        public int CodZona
        {
            get { return codZona; }
            set { this.codZona = value; }
        }
    }
}
