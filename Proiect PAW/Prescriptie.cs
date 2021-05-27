using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
    public class Prescriptie
    {
        private int idPrescriptie;
        private string numeMedic;
        private List<string> listaMedicamente;

        public Prescriptie()
        {
        }

        public Prescriptie(int idPrescriptie, string nume_medic, List<string> listaMedicamente)
        {
            this.idPrescriptie = idPrescriptie;
            this.numeMedic = nume_medic;
            this.listaMedicamente = listaMedicamente;
        }

        public int IdPrescriptie
        {
            get { return idPrescriptie; }
            set { idPrescriptie = value; }
        }

        public string NumeMedic
        {
            get { return numeMedic; }
            set { numeMedic = value; }
        }

        public List<string> ListaMedicamente
        {
            get { return listaMedicamente; }
            set { listaMedicamente = value; }
        }

        public string afisareMedicamenteToString()
        {
            string str = "";
            foreach (string item in listaMedicamente)
            {
                str += item + ",";
            }
            str=str.Remove(str.Length - 1, 1);
            return str;
        }

        public override string ToString()
        {
            return idPrescriptie + "," + numeMedic + "," + afisareMedicamenteToString();
        }
    }
}
