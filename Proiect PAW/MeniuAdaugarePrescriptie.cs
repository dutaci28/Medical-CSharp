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
    public partial class MeniuAdaugarePrescriptie : Form
    {
        List<string> listaMedicamente;
        List<Prescriptie> listaPrescriptii;

        public MeniuAdaugarePrescriptie(List<Prescriptie> listaPrescriptii)
        {
            InitializeComponent();
            listaMedicamente = new List<string>();
            this.listaPrescriptii = listaPrescriptii;
            updateListViews();
        }

        public void curataFormular()
        {
            tbIdPrescriptie.Clear();
            tbNumeMedic.Clear();
            tbMedicamente.Clear();
        }

        public void updateListViews()
        {
            lvPrescriptii.Items.Clear();
            foreach (Prescriptie presc in listaPrescriptii)
            {
                ListViewItem item = new ListViewItem(presc.IdPrescriptie.ToString());
                item.SubItems.Add(presc.NumeMedic);
                item.SubItems.Add(presc.afisareMedicamenteToString());
                lvPrescriptii.Items.Add(item);
            }
        }

        private void btnCurata_Click(object sender, EventArgs e)
        {
            curataFormular();
        }

        private void btnAdaugaMedicament_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbMedicamente.Text))
            {
                listaMedicamente.Add(tbMedicamente.Text);
            } 
            else
            {
                MessageBox.Show("Medicament invalid!", "Eroare");
            }
            tbMedicamente.Clear();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            bool valid = true;

            int.TryParse(tbIdPrescriptie.Text,out int idPrescriptie);
            string numeMedic = tbNumeMedic.Text;
            List<string> medicamente = new List<string>();
            foreach (string ceva in listaMedicamente)
            {
                medicamente.Add(ceva);
            }

            if (String.IsNullOrWhiteSpace(numeMedic))
            {
                valid = false;
            }
            if(listaMedicamente.Count() == 0)
            {
                valid = false;
            }

            if (valid)
            {
                Prescriptie p = new Prescriptie(idPrescriptie, numeMedic, medicamente);
                listaPrescriptii.Add(p);

                lvPrescriptii.Items.Clear();
                foreach(Prescriptie presc in listaPrescriptii)
                {
                    ListViewItem item = new ListViewItem(presc.IdPrescriptie.ToString());
                    item.SubItems.Add(presc.NumeMedic);
                    item.SubItems.Add(presc.afisareMedicamenteToString());
                    lvPrescriptii.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Date incorecte", "Eroare");
            }
            curataFormular();
            listaMedicamente.Clear();
        }

        private void lvPrescriptii_ItemActivate(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lvPrescriptii.Items)
            {
                if (i.Selected)
                {
                    EditarePrescriptie edit = new EditarePrescriptie(listaPrescriptii[i.Index]);
                    edit.ShowDialog();
                    updateListViews();
                }
            }
        }

        private void btnAfisare_Click(object sender, EventArgs e)
        {
            updateListViews();
        }

        private void tbIdPrescriptie_TextChanged(object sender, EventArgs e)
        {
            foreach(Prescriptie presc in listaPrescriptii)
            {
                if(tbIdPrescriptie.Text.Length >= 1)
                {
                    if (presc.IdPrescriptie == int.Parse(tbIdPrescriptie.Text))
                    {
                        tbIdPrescriptie.Clear();
                        MessageBox.Show("Id existent", "Eroare");
                    }
                }
            }
        }

        private void tbIdPrescriptie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) //isControl backspace
            {
                e.Handled = true;
            }
        }
    }
}
