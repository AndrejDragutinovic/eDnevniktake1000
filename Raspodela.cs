using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace eDnevnik
{
    public partial class Raspodela : Form
    {
        DataTable raspodela;
        int broj_sloga = 0;

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

        }
        private void ComboFill()
        {
            SqlConnection veza = new SqlConnection();
            SqlDataAdapter adapter;
            DataTable dt_godina, dt_nastavnik, dt_predmet, dt_odeljenje;
            adapter = new SqlDataAdapter("SELECT * FROM skolska_godina", veza);
            dt_godina = new DataTable();
            adapter.Fill(dt_godina);

            dt_nastavnik = new DataTable();
            adapter = new SqlDataAdapter("SELECT id, ime + prezime as naziv from osoba where uloga = 2", veza);
            adapter.Fill(dt_nastavnik);

            dt_odeljenje = new DataTable();
            adapter = new SqlDataAdapter("SELECT id, str(razred)+ '-' + indeks as naziv from odeljenje", veza);
            adapter.Fill(dt_odeljenje);

            dt_predmet = new DataTable();
            adapter = new SqlDataAdapter("select id, naziv from predmet", veza);
            adapter.Fill(dt_predmet);

            cmb_godina.DataSource = dt_godina;
            cmb_godina.ValueMember = "id";
            cmb_godina.DisplayMember = "naziv";
            cmb_godina.SelectedValue = raspodela.Rows[broj_sloga]["godina_id"];

            cmb_nastavnik.DataSource = dt_nastavnik;
            cmb_godina.ValueMember = "id";
            cmb_godina.DisplayMember = "naziv";
            cmb_godina.SelectedValue = raspodela.Rows[broj_sloga]["nastavnik_id"];


            cmb_odeljenje.DataSource = dt_odeljenje;
            cmb_godina.ValueMember = "id";
            cmb_godina.DisplayMember = "naziv";
            cmb_godina.SelectedValue = raspodela.Rows[broj_sloga]["odeljenje_id"];


            cmb_predmet.DataSource = dt_predmet;
            cmb_godina.ValueMember = "id";
            cmb_godina.DisplayMember = "naziv";
            cmb_godina.SelectedValue = raspodela.Rows[broj_sloga]["predmet_id"];

        }
    }
}
