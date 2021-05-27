using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Medic
    {
        private string nume;
        private string specializare;
        private List<Pacient> listaPacienti;

        public Medic() { }

        public Medic(string nume, string specializare, List<Pacient> listaPacienti)
        {
            this.nume = nume;
            this.specializare = specializare;
            this.listaPacienti = listaPacienti;
        }

        public string Nume
        {
            get { return this.nume; }
            set { this.nume = value; }
        }

        public string Specalizare
        {
            get { return this.specializare; }
            set { this.specializare = value; }
        }

        public string pacientiToString()
        {
            string rez = "";
            foreach(Pacient pac in listaPacienti)
            {
                rez += pac.Nume + ", ";
            }
            return rez;
        }

        public List<Pacient> ListaPacienti
        {
            get { return this.listaPacienti; }
            set { this.listaPacienti = value; }
        }

        public void adaugaPacient(Pacient p)
        {
            this.listaPacienti.Add(p);
        }
    }
}
