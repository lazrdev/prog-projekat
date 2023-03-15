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
        private const string CONNSTRING = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ucenik.DESKTOP-RO75DVM\Downloads\prog-projekat\prog-projekat\A13_DVD_Kolekcija\data\DVD-kolekcija.accdb;Persist Security Info=True";
        OleDbConnection conn;
        OleDbCommand command;
        List<Producent> producentiList;

        public Form1()
        {
            InitializeComponent();
        }

        public void RefreshList()
        {
            try
            {
                listBox1.Items.Clear();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshList(); //first list load
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void analizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Analiza a = new Analiza();
            //show analiza
            a.Show();
        }

        private void izmeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
           
                try
                { //save the modified values
                    producentiList = new List<Producent>();
                    DataSet ds = new DataSet();
                    conn = new OleDbConnection(CONNSTRING);
                    command = new OleDbCommand();
                    command.Connection = conn;
                    command.CommandText = "UPDATE Producent SET Ime='" + textBox2.Text.Trim() + "', Email='" + textBox3.Text.Trim() + "' WHERE ProducentID = " + textBox1.Text.Trim();
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
                    RefreshList();
                }
            }
        

        private void oAplikacijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }
    }
}
