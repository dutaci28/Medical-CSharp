using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class MeniuGrafic : Form
    {
        private List<Medic> listaMedici;
        private List<Pacient> listaPacienti;
        private List<Prescriptie> listaPrescriptii;
        int nrMed;
        int nrPac;
        int nrPre;
        Graphics g;
        Bitmap bmp;

        public MeniuGrafic(List<Medic> listaMedici, List<Pacient> listaPacienti, List<Prescriptie> listaPrescriptii)
        {
            InitializeComponent();
            bmp = new Bitmap(this.Width, this.Height);
            g = Graphics.FromImage(bmp);

            this.listaMedici = listaMedici;
            this.listaPacienti = listaPacienti;
            this.listaPrescriptii = listaPrescriptii;
            this.nrMed = this.listaMedici.Count();
            this.nrPac = this.listaPacienti.Count();
            this.nrPre = this.listaPrescriptii.Count();

            Pen p = new Pen(Color.Black, 3);
            Brush b = new SolidBrush(Color.DarkGray);
            Brush b1 = new SolidBrush(Color.Black);

            g.DrawLine(p, 200, 400, 700, 400);
            g.DrawLine(p, 200, 50, 200, 400);

            g.FillRectangle(b, 202, 100, 50 * nrMed, 50);
            g.DrawString(nrMed.ToString(), this.Font, b1, new Point((50 * nrMed) + 225, 115 ));
            g.FillRectangle(b, 202, 200, 50 * nrPac, 50);
            g.DrawString(nrPac.ToString(), this.Font, b1, new Point((50 * nrPac) + 225, 215));
            g.FillRectangle(b, 202, 300, 50 * nrPre, 50);
            g.DrawString(nrPre.ToString(), this.Font, b1, new Point((50 * nrPre) + 225, 315));
            Invalidate();
        }

        private void MeniuGrafic_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void pdPrint(object sender, PrintPageEventArgs e)
        {
            Graphics gra = e.Graphics;
            Pen p = new Pen(Color.Black, 3);
            Brush b = new SolidBrush(Color.DarkGray);
            Brush b1 = new SolidBrush(Color.Black);

            gra.DrawLine(p, 200, 400, 700, 400);
            gra.DrawLine(p, 200, 50, 200, 400);

            gra.FillRectangle(b, 202, 100, 50 * nrMed, 50);
            gra.DrawString(nrMed.ToString(), this.Font, b1, new Point((50 * nrMed) + 225, 115));
            gra.FillRectangle(b, 202, 200, 50 * nrPac, 50);
            gra.DrawString(nrPac.ToString(), this.Font, b1, new Point((50 * nrPac) + 225, 215));
            gra.FillRectangle(b, 202, 300, 50 * nrPre, 50);
            gra.DrawString(nrPre.ToString(), this.Font, b1, new Point((50 * nrPre) + 225, 315));
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pdPrint);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }
    }
}
