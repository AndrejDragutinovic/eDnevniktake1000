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
    public partial class Raspodela : Form
    {
        DataTable raspodela;
        int br = 0;

        public Raspodela()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void load_data()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM raspodela", veza);
            raspodela = new DataTable();
            adapter.Fill(raspodela);
        }
        private void Raspodela_Load(object sender, EventArgs e)
        {
            load_data();
            ComboFill();

        }
        private void ComboFill()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter;
            DataTable dt_godina, dt_nastavnik, dt_predmet, dt_odeljenje;
            adapter = new SqlDataAdapter("SELECT * FROM Skolska_godina", veza);
            dt_godina = new DataTable();
            adapter.Fill(dt_godina);

            dt_nastavnik = new DataTable();
            adapter = new SqlDataAdapter("SELECT id, ime + prezime as naziv from Osoba where uloga = 2", veza);
            adapter.Fill(dt_nastavnik);

            dt_odeljenje = new DataTable();
            adapter = new SqlDataAdapter("SELECT id, str(razred)+ '-' + indeks as naziv from Odeljenje", veza);
            adapter.Fill(dt_odeljenje);

            dt_predmet = new DataTable();
            adapter = new SqlDataAdapter("select id, naziv from Predmet", veza);
            adapter.Fill(dt_predmet);

            cmb_godina.DataSource = dt_godina;
            cmb_godina.ValueMember = "id";
            cmb_godina.DisplayMember = "naziv";
            cmb_godina.SelectedValue = raspodela.Rows[br]["godina_id"];

            cmb_nastavnik.DataSource = dt_nastavnik;
            cmb_godina.ValueMember = "id";
            cmb_godina.DisplayMember = "naziv";
            cmb_godina.SelectedValue = raspodela.Rows[br]["nastavnik_id"];


            cmb_odeljenje.DataSource = dt_odeljenje;
            cmb_godina.ValueMember = "id";
            cmb_godina.DisplayMember = "naziv";
            cmb_godina.SelectedValue = raspodela.Rows[br]["odeljenje_id"];


            cmb_predmet.DataSource = dt_predmet;
            cmb_godina.ValueMember = "id";
            cmb_godina.DisplayMember = "naziv";
            cmb_godina.SelectedValue = raspodela.Rows[br]["predmet_id"];

            if (raspodela.Rows.Count == 0)
            {
                cmb_godina.SelectedValue = -1;
                cmb_nastavnik.SelectedValue = -1;
                cmb_predmet.SelectedValue = -1;
                cmb_odeljenje.SelectedValue = -1;

                foreach (Control c in Controls)
                {
                    Button b = c as Button;
                    if (b != null)
                    {
                        b.Enabled = false;
                    }
                }

            }
            else
            {

                cmb_godina.SelectedValue = raspodela.Rows[br]["godina_id"];
                cmb_nastavnik.SelectedValue = raspodela.Rows[br]["nastavnik_id"];
                cmb_predmet.SelectedValue = raspodela.Rows[br]["predmet_id"];
                cmb_odeljenje.SelectedValue = raspodela.Rows[br]["odeljenje_id"];

                btb_first.Enabled = (br != 0);
                btn_prev.Enabled = (br != 0);
                btn_last.Enabled = (br != raspodela.Rows.Count - 1);
                btn_next.Enabled = (br != raspodela.Rows.Count - 1);
            }

        }

        private void btb_first_Click(object sender, EventArgs e)
        {
            br = 0;
            ComboFill();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            br --;
            ComboFill();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            br++;
            ComboFill();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            br = raspodela.Rows.Count - 1;
            ComboFill();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {

            SqlConnection veza = Konekcija.Connect();
            string unesi = $"insert into raspodela (godina_id, nastavnik_id, predmet_id, odeljenje_id) values('{cmb_godina.SelectedValue}', '{cmb_nastavnik.SelectedValue}', '{cmb_predmet.SelectedValue}', '{cmb_odeljenje.SelectedValue}')";
            SqlCommand komanda = new SqlCommand(unesi, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            load_data();
            ComboFill();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.Connect();
            string izmeni = $"update Raspodela set godina_id = {cmb_godina.SelectedValue}, nastavnik_id = {cmb_nastavnik.SelectedValue}, predmet_id = {cmb_predmet.SelectedValue}, odeljenje_id={cmb_odeljenje.SelectedValue}";
            SqlCommand komanda = new SqlCommand(izmeni, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            load_data();
            ComboFill();
        }
    

        private void btn_delete_Click(object sender, EventArgs e)
        {
            SqlConnection veza = Konekcija.Connect();
            string obrisi = $"delete from Raspodela where id={label1.Text}";
            SqlCommand komanda = new SqlCommand(obrisi, veza);
            Boolean brisano = false;
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                brisano = true;
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            if (brisano)
            {
                load_data();
               
                if (br > 0) br--;
                ComboFill();
            }
        }
    }
}
