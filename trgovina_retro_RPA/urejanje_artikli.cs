using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static trgovina_retro_RPA.artikli;

namespace trgovina_retro_RPA
{
    public partial class urejanje_artikli : Form
    {
        private int id;
        private artikli parentForm;

        private string ConnectionString = "Server=127.0.0.1;Database=trgovina_retro_rpa;User=root;";
        public urejanje_artikli(artikli parentForm, int id, string ime, string cena, string zaloga, string kategorija_id)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            SetSelectedItem(id, ime, cena, zaloga, kategorija_id);
        }

        public void SetSelectedItem(int id, string ime, string cena, string kategorija_id, string zaloga)
        {
            this.id = id;
            txtBox_ime_A.Text = ime;
            txtBox_cena_A.Text = cena;
            txtBox_zaloga_A.Text = zaloga;
            comBox_kategorije_A.Text = kategorija_id;
        }

        private void btn_nazaj_Click(object sender, EventArgs e)
        {
            artikli artikli = new artikli();
            this.Close();
            artikli.Show();
        }

        private void btn_shrani_A_Click(object sender, EventArgs e)
        {
            // Get the values from the form controls
            string updatedIme = txtBox_ime_A.Text;
            string updatedCena = txtBox_cena_A.Text;
            string updatedZaloga = txtBox_zaloga_A.Text;
            string updatedKategorija = comBox_kategorije_A.Text;

            try
            {
                List<string> emptyFields = new List<string>();

                if (string.IsNullOrWhiteSpace(updatedIme))
                {
                    emptyFields.Add("Ime artikla");
                }

                if (string.IsNullOrWhiteSpace(updatedCena))
                {
                    emptyFields.Add("Cena artikla");
                }
                else if (!decimal.TryParse(updatedCena, out decimal cenaArtikla))
                {
                    MessageBox.Show("Vnesite veljavno številko za ceno artikla.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(updatedZaloga))
                {
                    emptyFields.Add("Zaloga artikla");
                }
                else if (!int.TryParse(updatedZaloga, out int zalogaArtikla))
                {
                    MessageBox.Show("Vnesite veljavno številko za zalogo artikla.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(updatedKategorija))
                {
                    emptyFields.Add("Kategorija artikla");
                }

                if (emptyFields.Any())
                {
                    string message = "Prosimo, izpolnite naslednja polja:\n" + string.Join("\n", emptyFields);
                    MessageBox.Show(message);
                    return;
                }

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "UPDATE artikli SET ime = @ime, cena = @cena, kategorija_id = @kategorija_id, zaloga = @zaloga WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@ime", updatedIme);
                        cmd.Parameters.AddWithValue("@cena", updatedCena);
                        cmd.Parameters.AddWithValue("@zaloga", updatedZaloga);
                        cmd.Parameters.AddWithValue("@kategorija_id", updatedKategorija);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Uspešno urejeno.");
                        }
                        else
                        {
                            MessageBox.Show("Napaka pri urejanju.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka pri posodabljanju: " + ex.Message);
            }
        }
    }
}
