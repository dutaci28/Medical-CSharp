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
    public partial class MeniuAdaugareMedic : Form
    {
        List<Pacient> listaPacienti;
        List<Medic> listaMedici;
        List<Pacient> listaAuxPacienti;

        public MeniuAdaugareMedic(List<Pacient> listaPacienti, List<Medic> listaMedici)
        {
            InitializeComponent();
            this.listaMedici = listaMedici;
            this.listaPacienti = listaPacienti;
            listaAuxPacienti = new List<Pacient>();
            updateListViews();
        }

        public void curataFormular()
        {
            tbNume.Clear();
            tbSpecializare.Clear();
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
            lvMedici.Items.Clear();
            foreach (Medic med in listaMedici)
            {
                ListViewItem item = new ListViewItem(med.Nume);
                item.SubItems.Add(med.Specalizare);
                item.SubItems.Add(med.pacientiToString());
                lvMedici.Items.Add(item);
            }
        }

        private void lvPacienti_ItemActivate(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lvPacienti.Items)
            {
                if (i.Selected)
                {
                    listaAuxPacienti.Add(listaPacienti[i.Index]);
                    updateListViews();
                }
            }
        }

        private void btnCurata_Click(object sender, EventArgs e)
        {
            curataFormular();
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            updateListViews();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            List<Pacient> listaCopie = new List<Pacient>();
            foreach(Pacient pac in listaAuxPacienti)
            {
                listaCopie.Add(pac);
            }

            Medic med = new Medic(tbNume.Text,tbSpecializare.Text,listaCopie);
            listaMedici.Add(med);
            ListViewItem item = new ListViewItem(tbNume.Text);
            item.SubItems.Add(tbSpecializare.Text);
            item.SubItems.Add(med.pacientiToString());
            listaAuxPacienti.Clear();
            updateListViews();
        }
    }
}
