using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace eDnevnik
{
    public partial class Osoba : Form
    {
        int br_sloga = 0;
        DataTable tabela;
        public Osoba()
        {
            InitializeComponent();
        }

        private void Load_Data()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM osoba", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
        }
        private void Txt_Load()
        {

            if (tabela.Rows.Count == 0)
            {
                txt_id.Text = "";
                txt_ime.Text = "";
                txt_prezime.Text = "";
                txt_adresa.Text = "";
                txt_jmbg.Text = "";
                txt_email.Text = "";
                txt_pass.Text = "";
                txt_uloga.Text = "";
            }
            else
            {
                txt_id.Text = tabela.Rows[br_sloga]["id"].ToString();
                txt_ime.Text = tabela.Rows[br_sloga]["ime"].ToString();
                txt_prezime.Text = tabela.Rows[br_sloga]["prezime"].ToString();
                txt_adresa.Text = tabela.Rows[br_sloga]["adresa"].ToString();
                txt_jmbg.Text = tabela.Rows[br_sloga]["jmbg"].ToString();
                txt_email.Text = tabela.Rows[br_sloga]["email"].ToString();
                txt_pass.Text = tabela.Rows[br_sloga]["pass"].ToString();
                txt_uloga.Text = tabela.Rows[br_sloga]["uloga"].ToString();
            }

            if (br_sloga == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }

            if(br_sloga == tabela.Rows.Count - 1)
            {
                button6.Enabled = false;
                button7.Enabled = false;
            }
            else
            {
                button6.Enabled = true;
                button7.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Osoba_Load(object sender, EventArgs e)
        {
            Load_Data();
            Txt_Load();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            br_sloga = 0;
            Txt_Load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            br_sloga--;
            Txt_Load();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            br_sloga++;
            Txt_Load();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            br_sloga = tabela.Rows.Count - 1;
            Txt_Load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("INSERT INTO osoba (ime, prezime, asdresa, jmbg, email, pass, uloga) VALUES('");
            Naredba.Append(txt_ime.Text +" ' , '");
            Naredba.Append(txt_prezime.Text + " ' , '");
            Naredba.Append(txt_adresa.Text + " ' , '");
            Naredba.Append(txt_jmbg.Text + " ' , '");
            Naredba.Append(txt_email.Text + " ' , '");
            Naredba.Append(txt_pass.Text + " ' , '");
            Naredba.Append(txt_uloga.Text + " ' )");
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(),veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            Load_Data();
            br_sloga = tabela.Rows.Count - 1;
            Txt_Load();

        }
    }
}
