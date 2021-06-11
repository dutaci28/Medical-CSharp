using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proiect_PAW
{
    public partial class MeniuPrincipal : Form
    {
        private List<Medic> listaMedici;
        private List<Pacient> listaPacienti;
        private List<Prescriptie> listaPrescriptii;

        public MeniuPrincipal()
        {
            InitializeComponent();
            listaPrescriptii = new List<Prescriptie>();
            listaPrescriptii.Add(new Prescriptie(1, "Dragos Iancu", new List<string> { "Diclofenac","Paracetamol" }));
            listaPrescriptii.Add(new Prescriptie(2, "Dragos Iancu", new List<string> { "Supramax"}));
            listaPacienti = new List<Pacient>();
            listaPacienti.Add(new Pacient("Andrei Dimulescu", "5010528152521", "M", "28.05.01", new List<Prescriptie> { listaPrescriptii[0] }));
            listaPacienti.Add(new Pacient("Daniel Marin", "5030412283051", "M", "12.04.03", new List<Prescriptie> { listaPrescriptii[1] }));
            listaMedici = new List<Medic>();
            listaMedici.Add(new Medic("Dragos Iancu", "Generalist", new List<Pacient> { listaPacienti[0], listaPacienti[1] }));
            lvPrescriptii.Items.Clear();
            updateListViews();
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

        private void prescriptieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeniuAdaugarePrescriptie f1 = new MeniuAdaugarePrescriptie(listaPrescriptii);
            f1.ShowDialog();
            updateListViews();
        }

        private void updateazaListViewuriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateListViews();
        }

        private void serializarePrescriptieXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream("FisierPrescriptiiXML.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer x = new XmlSerializer(typeof(List<Prescriptie>));
            x.Serialize(f, listaPrescriptii);
            f.Close();
        }

        private void deserializarePrescriptiiXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream("FisierPrescriptiiXML.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer x = new XmlSerializer(typeof(List<Prescriptie>));
            listaPrescriptii = (List<Prescriptie>)x.Deserialize(f);
            f.Close();
            updateListViews();
        }

        private void serializarePrescriptiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream("FisierPrescriptiiBinar.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(f, listaPrescriptii);
            f.Close();
        }

        private void deserializarePrescriptiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream("FisierPrescriptiiBinar.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            listaPrescriptii = (List<Prescriptie>)bf.Deserialize(f);
            f.Close();
            updateListViews();
        }

        private void pacientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeniuAdaugarePacient f1 = new MeniuAdaugarePacient(listaPacienti,listaPrescriptii);
            f1.ShowDialog();
            updateListViews();
        }

        private void lvPrescriptii_ItemActivate_1(object sender, EventArgs e)
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

        private void medicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeniuAdaugareMedic f1 = new MeniuAdaugareMedic(listaPacienti,listaMedici);
            f1.ShowDialog();
            updateListViews();
        }

        private void fisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream("FisierExport.txt", FileMode.Create, FileAccess.Write);
            StreamWriter x = new StreamWriter(f);
            foreach(Prescriptie p in listaPrescriptii)
            {
                x.WriteLine(p.ToString());
            }
            x.Close();
            f.Close();
        }

        private void exempleDDClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeniuDragDropClipboard meniu = new MeniuDragDropClipboard(listaPrescriptii);
            meniu.ShowDialog();
            updateListViews();
        }

        private void graficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeniuGrafic graf = new MeniuGrafic(listaMedici,listaPacienti,listaPrescriptii);
            graf.ShowDialog();
        }

        private void tabeleBazeDeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeniuSpitale meniu = new MeniuSpitale();
            meniu.ShowDialog();
        }
    }
}
