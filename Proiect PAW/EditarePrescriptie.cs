using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class EditarePrescriptie : Form
    {
        Prescriptie presc;

        public EditarePrescriptie(Prescriptie p)
        {
            InitializeComponent();
            presc = p;
            initializeazaCampuri();
        }

        public void curataFormular()
        {
            tbIdPrescriptie.Clear();
            tbNumeMedic.Clear();
            tbMedicamente.Clear();
        }

        public void initializeazaCampuri()
        {
            tbIdPrescriptie.Text = presc.IdPrescriptie.ToString();
            tbNumeMedic.Text = presc.NumeMedic;
            tbMedicamente.Text = presc.afisareMedicamenteToString();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string numeMedic = tbNumeMedic.Text;

            if (String.IsNullOrWhiteSpace(numeMedic))
            {
                valid = false;
            }

            if (valid)
            {
                presc.NumeMedic = numeMedic;
            }

            curataFormular();
            this.Close();
        }

        private void btnCurata_Click(object sender, EventArgs e)
        {
            curataFormular();
        }
    }
}
