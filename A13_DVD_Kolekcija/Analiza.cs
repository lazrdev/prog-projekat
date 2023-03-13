using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A13_DVD_Kolekcija
{
    public partial class Analiza : Form
    {
        private const string CONNSTRING = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\_skola\prog\prog-projekat\A13_DVD_Kolekcija\data\DVD-kolekcija.accdb;Persist Security Info=True";
        OleDbConnection conn;
        OleDbCommand command;
        List<Producent> producentiList;
        public Analiza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            try
            {
                producentiList = new List<Producent>();
                DataSet ds = new DataSet();
                conn = new OleDbConnection(CONNSTRING);
                OleDbDataAdapter adapter; //no idea how to do this sql query

                conn.Open();
                command = new OleDbCommand("SELECT Producent.Ime as [Producent], COUNT(Film.FilmID) as [Broj Filmova] FROM (Producent INNER JOIN Producirao ON Producirao.ProducentID = Producent.ProducentID) INNER JOIN Film ON Film.FilmID = Producirao.FilmID GROUP BY Producent.Ime;", conn);
                //OleDbDataReader reader = command.ExecuteReader();
                adapter = new OleDbDataAdapter(command);
                adapter.Fill(ds);

                DataTable dt = ds.Tables[0];
                DataView dv = new DataView(dt);
                chart1.Series[0].Points.DataBind(dv, "Producent", "Broj Filmova", "");

                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
