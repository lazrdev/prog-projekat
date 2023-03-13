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

namespace A13_DVD_Kolekcija
{
    public partial class Form1 : Form
    {
        private const string CONNSTRING = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ucenik\Desktop\A13_DVD_Kolekcija\A13_DVD_Kolekcija\data\DVD-kolekcija.accdb;Persist Security Info=True";
        OleDbConnection conn;
        OleDbCommand command;
        List<Producent> producentiList;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                producentiList = new List<Producent>();
                DataSet ds = new DataSet();
                conn = new OleDbConnection(CONNSTRING);
                command = new OleDbCommand();
                command.Connection = conn;
                command.CommandText = "SELECT * FROM Producent";

                conn.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Producent producent = new Producent(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString());
                    producentiList.Add(producent);
                    listBox1.Items.Add(producent.ToString());
                }
                FillTextBoxes(producentiList[0]);
            }catch(Exception exc)
            {
                MessageBox.Show(exc.Message); 
            }
            finally
            {
                conn.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producent producent = producentiList[listBox1.SelectedIndex];
            FillTextBoxes(producent);
        }

        private void FillTextBoxes(Producent producent)
        {
            textBox1.Text = producent.Id.ToString();
            textBox2.Text = producent.Naziv;
            textBox3.Text = producent.Email;
        }

        private void izmeni_Click(object sender, EventArgs e)
        {
            textBox1.Text = "clicked";
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            try
            {
                producentiList = new List<Producent>();
                DataSet ds = new DataSet();
                conn = new OleDbConnection(CONNSTRING);
                command = new OleDbCommand();
                command.Connection = conn;
                command.CommandText = "UPDATE Producent SET Ime='"+ textBox2.Text.Trim() +"', Email='"+textBox3.Text.Trim()+"' WHERE ProducentID = " + textBox1.Text.Trim();
                // refrest listbox
                conn.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Uspesno sacuvano");
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
