using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace trgovina_retro_RPA
{
    public partial class prijava : Form
    {
        private string ConnectionString = "Server=127.0.0.1;Database=trgovina_retro_rpa;User=root;";

        public prijava()
        {
            InitializeComponent();
        }

        private void btn_nazaj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_registracija_Click(object sender, EventArgs e)
        {
            registracija registracija = new registracija();
            this.Hide();
            registracija.Show();
        }

        private void btn_prijavi_Click(object sender, EventArgs e)
        {
            string uporabniskoIme = txtBox_upime.Text;
            string geslo = txtBox_geslo.Text;

            if (string.IsNullOrWhiteSpace(uporabniskoIme) || string.IsNullOrWhiteSpace(geslo))
            {
                MessageBox.Show("Prosimo, izpolnite vsa polja.", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PreveriPrijavo(uporabniskoIme, geslo))
            {
                MessageBox.Show("Uspešna prijava!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

                home home = new home();
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Nepravilno uporabniško ime ali geslo. Poskusite znova.", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool PreveriPrijavo(string uporabniskoIme, string geslo)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM uporabnik WHERE uporabnisko_ime = @uporabniskoIme AND geslo = @geslo";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@uporabniskoIme", uporabniskoIme);
                        cmd.Parameters.AddWithValue("@geslo", geslo);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka pri preverjanju prijave v bazi: " + ex.Message);
                return false;
            }
        }
    }
}
