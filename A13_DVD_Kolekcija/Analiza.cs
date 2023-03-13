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
        private const string CONNSTRING = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\lazar\Documents\GitHub\prog-projekat\A13_DVD_Kolekcija\data\DVD-kolekcija.accdb;Persist Security Info=True";
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
            producentiList = new List<Producent>();
            DataSet ds = new DataSet();
            conn = new OleDbConnection(CONNSTRING);

            OleDbDataAdapter adapter = new OleDbDataAdapter(); //no idea how to do this sql query
            conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
