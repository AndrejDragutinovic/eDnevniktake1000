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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Unesite email i lozinku");
                return;
            }
            else 
            {
                try
                {
                    SqlConnection veza = Konekcija.Connect();
                    SqlCommand komanda = new SqlCommand("SELECT * FROM osoba WHERE  email=@username",veza);
                    komanda.Parameters.AddWithValue("@username", txt_name.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(komanda);
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    int brojac = tabela.Rows.Count;

                    if (brojac == 1) 
                    { 
                        if(String.Compare(tabela.Rows[0]["pass"].ToString(), txt_pass.Text) == 0)
                        {
                            MessageBox.Show("Login successful! ");
                            Program.user_ime = tabela.Rows[0]["ime"].ToString();
                            Program.user_prezime = tabela.Rows[0]["prezime"].ToString();
                            Program.user_uloga = (int)tabela.Rows[0]["uloga"];
                            this.Hide();
                            Glavna frm_glavna = new Glavna();
                            frm_glavna.Show();
                        }
                        else
                        {
                            MessageBox.Show("Pogresna Lozinka!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nepostopjeci e-mail!");
                    }
                    
                }
                catch (Exception greska)
                {
                    MessageBox.Show(greska.Message);  
                }
            }
        }
    }
}
