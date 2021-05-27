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
    public partial class MeniuAdaugarePacient : Form
    {
        List<Pacient> listaPacienti;
        List<Prescriptie> listaPrescriptii;
        List<Prescriptie> listaAuxPrescriptii;

        public MeniuAdaugarePacient(List<Pacient> listaPacienti, List<Prescriptie> listaPrescriptii)
        {
            InitializeComponent();
            this.listaPacienti = listaPacienti;
            this.listaPrescriptii = listaPrescriptii;
            listaAuxPrescriptii = new List<Prescriptie>();
            updateListViews();
        }

        public void updateListViews()
        {
            lvPacienti.Items.Clear();
            foreach (Pacient pac in listaPacienti)
            {
                ListViewItem item = new ListViewItem(pac.Nume);
                item.SubItems.Add(pac._CNP);
                item.SubItems.Add(pac.Sex);
                item.SubItems.Add(pac.DataNastere);
                item.SubItems.Add(pac.listaPrescriptiiToString());
                lvPacienti.Items.Add(item);
            }
            lvPrescriptii.Items.Clear();
            foreach (Prescriptie presc in listaPrescriptii)
            {
                ListViewItem item = new ListViewItem(presc.IdPrescriptie.ToString());
                item.SubItems.Add(presc.NumeMedic);
                item.SubItems.Add(presc.afisareMedicamenteToString());
                lvPrescriptii.Items.Add(item);
            }
        }

        public void curataFormular()
        {
            tbNume.Clear();
            tbCNP.Clear();
            tbDataNasterii.Clear();
            tbSex.Clear();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            List<Prescriptie> listaCopie = new List<Prescriptie>();
            foreach(Prescriptie prescriptie in listaAuxPrescriptii)
            {
                listaCopie.Add(prescriptie);
            }
            Pacient p = new Pacient(tbNume.Text,tbCNP.Text,tbSex.Text,tbDataNasterii.Text,listaCopie);

            listaPacienti.Add(p);
            listaAuxPrescriptii.Clear();
            updateListViews();
            curataFormular();
        }

        private void btnCurata_Click(object sender, EventArgs e)
        {
            curataFormular();
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            updateListViews();
        }

        private void lvPrescriptii_ItemActivate(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lvPrescriptii.Items)
            {
                if (i.Selected)
                {
                    listaAuxPrescriptii.Add(listaPrescriptii[i.Index]);
                    updateListViews();
                }
            }
        }

        private void tbCNP_TextChanged(object sender, EventArgs e)
        {
            string dataString = "";
            if (tbCNP.Text.Length == 13)
            {
                tbDataNasterii.Clear();
                if (tbCNP.Text.Substring(0, 1) == "5")
                {
                    tbSex.Text = "M";
                }
                if (tbCNP.Text.Substring(0, 1) == "6")
                {
                    tbSex.Text = "F";
                }
                dataString = tbCNP.Text.Substring(1, 6);
                tbDataNasterii.Text += dataString.Substring(4, 2) + "." + dataString.Substring(2, 2) + ".20" + dataString.Substring(0, 2);
            }
        }
    }
    
}
