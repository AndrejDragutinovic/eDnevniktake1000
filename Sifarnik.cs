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
    public partial class Sifarnik : Form
    {
        SqlDataAdapter adapter;
        DataTable podaci;

        string ime_tabela;
        public Sifarnik(string tabela)
        {
            ime_tabela = tabela;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sifarnik_Load(object sender, EventArgs e)
        {
            string naredba = $"select * from {ime_tabela}";
            adapter = new SqlDataAdapter(naredba, Konekcija.Connect());
            podaci = new DataTable();
            adapter.Fill(podaci);
            dataGridView1.DataSource = podaci;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable promene = podaci.GetChanges();
            adapter.UpdateCommand = new SqlCommandBuilder(adapter).GetUpdateCommand();
            if (promene != null)
            {
                adapter.Update(promene);

            }
            this.Close();
        }
    }
}
