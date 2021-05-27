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
    public partial class MeniuDragDropClipboard : Form
    {
        List<string> listaMedicamente;
        List<Prescriptie> listaPrescriptii;

        List<string> listaMedicamenteCopie;
        List<Prescriptie> listaPrescriptiiCopie;


        public MeniuDragDropClipboard(List<Prescriptie> listaPrescriptii)
        {
            InitializeComponent();
            listaMedicamente = new List<string>();
            this.listaPrescriptii = listaPrescriptii;
            listaMedicamenteCopie = new List<string>();
            listaPrescriptiiCopie = new List<Prescriptie>();
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
            lvCopie.Items.Clear();
            foreach (Prescriptie presc in listaPrescriptiiCopie)
            {
                ListViewItem item = new ListViewItem(presc.IdPrescriptie.ToString());
                item.SubItems.Add(presc.NumeMedic);
                item.SubItems.Add(presc.afisareMedicamenteToString());
                lvCopie.Items.Add(item);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Prescriptie p = new Prescriptie(3, "Dragos Iancu", new List<string> { "Xanax", "Supramax" });
            //Clipboard.SetDataObject(p);

            foreach (ListViewItem i in lvPrescriptii.Items)
            {
                if (i.Selected)
                {
                    Clipboard.SetDataObject(listaPrescriptii[i.Index]);
                }
            }

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IDataObject o = Clipboard.GetDataObject();
            if (o.GetDataPresent(typeof(Prescriptie)))
            {
                Prescriptie presc = (Prescriptie)o.GetData(typeof(Prescriptie));
                listaPrescriptiiCopie.Add(presc);
                updateListViews();
            }
        }

        private void lvPrescriptii_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (ListViewItem i in lvPrescriptii.Items)
            {
                if (i.Selected)
                {
                    lvPrescriptii.DoDragDrop(listaPrescriptii[i.Index], DragDropEffects.Copy);
                }
            }
        }

        private void lvCopie_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void lvCopie_DragDrop(object sender, DragEventArgs e)
        {
            Prescriptie presc = (Prescriptie)e.Data.GetData(typeof(Prescriptie));
            listaPrescriptiiCopie.Add(presc);
            updateListViews();
        }
    }
}
