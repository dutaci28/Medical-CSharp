using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Pacient
    {
        private string nume;
        private string CNP;
        private string sex;
        private string dataNastere;
        private List<Prescriptie> listaPrescriptii;

        public string Nume
        {
            get { return this.nume; }
            set { this.nume = value; }
        }

        public string _CNP
        {
            get { return this.CNP; }
            set { this.CNP = value; }
        }

        public string Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }

        public string DataNastere
        {
            get { return this.dataNastere; }
            set { this.dataNastere = value; }
        }

        public List<Prescriptie> ListaPrescriptii
        {
            get { return this.listaPrescriptii; }
            set { this.listaPrescriptii = value; }
        }

        public Pacient() { }

        public Pacient(string nume,string CNP,string sex,string dataNastere,List<Prescriptie> listaPrescriptii)
        {
            this.nume = nume;
            this.CNP = CNP;
            this.sex = sex;
            this.dataNastere = dataNastere;
            this.listaPrescriptii = listaPrescriptii;
        }

        public string listaPrescriptiiToString()
        {
            string rezultat ="";
            foreach(Prescriptie presc in listaPrescriptii)
            {
                rezultat += "ID" + presc.IdPrescriptie + " (" + presc.afisareMedicamenteToString() + ") ";
            }
            return rezultat;
        }
    }
}
