using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace trgovina_retro_RPA
{
    public partial class registracija : Form
    {
        private string ConnectionString = "Server=127.0.0.1;Database=trgovina_retro_rpa;User=root;";

        public registracija()
        {
            InitializeComponent();
        }

        private void btn_prijavi_Click(object sender, EventArgs e)
        {
            string uporabniskoIme = txtBox_upime.Text;
            string geslo = txtBox_geslo.Text;
            string ponoviGeslo = txtBox_geslo2.Text;

            if (string.IsNullOrWhiteSpace(uporabniskoIme) || string.IsNullOrWhiteSpace(geslo) || string.IsNullOrWhiteSpace(ponoviGeslo))
            {
                MessageBox.Show("Prosimo, izpolnite vsa polja.", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (geslo != ponoviGeslo)
            {
                MessageBox.Show("Gesli se ne ujemata. Poskusite znova.", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (UporabnikObstaja(uporabniskoIme))
            {
                MessageBox.Show("Uporabnik s tem imenom že obstaja. Izberite drugo uporabniško ime.", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (VstaviVbazo(uporabniskoIme, geslo))
            {
                MessageBox.Show("Registracija uspešna!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Napaka pri registraciji. Poskusite znova.", "Napaka", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UporabnikObstaja(string uporabniskoIme)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM uporabnik WHERE uporabnisko_ime = @uporabniskoIme";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@uporabniskoIme", uporabniskoIme);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka pri preverjanju uporabnika v bazi: " + ex.Message);
                return false;
            }
        }

        private bool VstaviVbazo(string uporabniskoIme, string geslo)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO uporabnik (uporabnisko_ime, geslo) VALUES (@uporabniskoIme, @geslo)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@uporabniskoIme", uporabniskoIme);
                        cmd.Parameters.AddWithValue("@geslo", geslo);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka pri vstavljanju podatkov v bazo: " + ex.Message);
                return false;
            }
        }

        private void btn_nazaj_Click(object sender, EventArgs e)
        {
            prijava prijava = new prijava();
            this.Close();
            prijava.Show();
        }
    }
}
