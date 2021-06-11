using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proiect_PAW
{
    public partial class MeniuSpitale : Form
    {
        List<Spital> listaSpitale;
        List<Zona> listaZone;
        string connString;

        public MeniuSpitale()
        {
            InitializeComponent();
            this.listaSpitale = new List<Spital>();
            this.listaZone = new List<Zona>();
            connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BazaDate.accdb";
            functie1();
            functie2();

            //OleDbConnection conexiune = new OleDbConnection(connString);
            //try
            //{
            //    conexiune.Open();
            //    OleDbCommand comanda = new OleDbCommand();
            //    comanda.Connection = conexiune;
            //    comanda.CommandText = "SELECT * FROM Spitale";
            //    OleDbDataReader reader = comanda.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        Spital aux = new Spital();
            //        aux.NumeSpital = reader["NumeSpital"].ToString();
            //        aux.CodSpital = (int)reader["CodSpital"];
            //        aux.CodZona = (int)reader["CodZona"];
            //        listaSpitale.Add(aux);
            //    }
            //    reader.Close();

            //    comanda.CommandText = "SELECT * FROM Zone";
            //    OleDbDataReader reader1 = comanda.ExecuteReader();
            //    reader1 = comanda.ExecuteReader();
            //    while (reader1.Read())
            //    {
            //        Zona auxil = new Zona();
            //        auxil.NumeZona = reader1["NumeZona"].ToString();
            //        auxil.CodZona = (int)reader1["CodZona"];
            //        listaZone.Add(auxil);
            //    }

            //}
            //catch (OleDbException oldb)
            //{
            //    MessageBox.Show(oldb.Message);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    conexiune.Close();
            //}

            updateListViews();
        }

        public void functie1()
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM Spitale";
                OleDbDataReader reader = comanda.ExecuteReader();

                while (reader.Read())
                {
                    Spital aux = new Spital();
                    aux.NumeSpital = reader["NumeSpital"].ToString();
                    aux.CodSpital = (int)reader["CodSpital"];
                    aux.CodZona = (int)reader["CodZona"];
                    listaSpitale.Add(aux);
                }
            }
            catch (OleDbException oldb)
            {
                MessageBox.Show(oldb.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        public void functie2()
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * FROM TabelaZone";
                OleDbDataReader reader = comanda.ExecuteReader();
                while (reader.Read())
                {
                    Zona auxil = new Zona(reader["NumeZona"].ToString(), (int)reader["CodZona"]);
                    listaZone.Add(auxil);
                }

            }
            catch (OleDbException oldb)
            {
                MessageBox.Show(oldb.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        public void updateListViews()
        {
            lvSpitale.Items.Clear();
            foreach (Spital s in listaSpitale)
            {
                ListViewItem item = new ListViewItem(s.NumeSpital);
                item.SubItems.Add(s.CodSpital.ToString());
                item.SubItems.Add(s.CodZona.ToString());
                lvSpitale.Items.Add(item);
            }
            lvZone.Items.Clear();
            foreach (Zona z in listaZone)
            {
                ListViewItem item = new ListViewItem(z.NumeZona);
                item.SubItems.Add(z.CodZona.ToString());
                lvZone.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "INSERT INTO Spitale VALUES(?,?,?)";
                comanda.Parameters.Add("NumeSpital", OleDbType.Char, 50).Value = tbNumeSpital.Text;
                comanda.Parameters.Add("CodSpital", OleDbType.Numeric, 2).Value = int.Parse(tbCodSpital.Text);
                comanda.Parameters.Add("CodZona", OleDbType.Numeric, 2).Value = int.Parse(tbCodZona.Text);

                Spital aux = new Spital();
                aux.NumeSpital = tbNumeSpital.Text;
                aux.CodSpital = int.Parse(tbCodSpital.Text);
                aux.CodZona = int.Parse(tbCodZona.Text);
                listaSpitale.Add(aux);
                updateListViews();
                comanda.ExecuteNonQuery();
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection conexiune = new OleDbConnection(connString);
            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "INSERT INTO TabelaZone VALUES(?,?)";
                comanda.Parameters.Add("NumeZona", OleDbType.Char, 50).Value = tbNumeZona.Text;
                comanda.Parameters.Add("CodZona", OleDbType.Numeric, 2).Value = int.Parse(tbCodZona1.Text);

                Zona aux = new Zona();
                aux.NumeZona = tbNumeZona.Text;
                aux.CodZona = int.Parse(tbCodZona1.Text);
                listaZone.Add(aux);
                updateListViews();
                comanda.ExecuteNonQuery();
            }
            catch (OleDbException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                conexiune.Close();
            }
        }
    }
}
