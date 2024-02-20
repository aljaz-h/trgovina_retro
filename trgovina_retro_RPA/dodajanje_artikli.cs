using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace trgovina_retro_RPA
{
    public partial class dodajanje_artikli : Form
    {
        private string ConnectionString = "Server=127.0.0.1;Database=trgovina_retro_rpa;User=root;";
        public dodajanje_artikli()
        {
            InitializeComponent();
        }

        private void btn_shrani_A_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> emptyFields = new List<string>();

                if (string.IsNullOrWhiteSpace(txtBox_ime_A.Text))
                {
                    emptyFields.Add("Ime artikla");
                }

                if (string.IsNullOrWhiteSpace(txtBox_cena_A.Text))
                {
                    emptyFields.Add("Cena artikla");
                }
                else if (!decimal.TryParse(txtBox_cena_A.Text, out decimal cenaArtikla))
                {
                    MessageBox.Show("Vnesite veljavno številko za ceno artikla.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtBox_zaloga_A.Text))
                {
                    emptyFields.Add("Zaloga artikla");
                }
                else if (!int.TryParse(txtBox_zaloga_A.Text, out int zalogaArtikla))
                {
                    MessageBox.Show("Vnesite veljavno številko za zalogo artikla.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(comBox_kategorije_A.Text))
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

                    string imeArtikla = txtBox_ime_A.Text;
                    decimal cenaArtikla = Convert.ToDecimal(txtBox_cena_A.Text);
                    int zalogaArtikla = Convert.ToInt32(txtBox_zaloga_A.Text);
                    string imeKategorijaArtikla = comBox_kategorije_A.Text;

                    string insertQuery = "INSERT INTO artikli (ime, cena, kategorija_id, zaloga) " +
                                         "VALUES (@ime, @cena, @kategorija_id, @zaloga)";

                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@ime", imeArtikla);
                        cmd.Parameters.AddWithValue("@cena", cenaArtikla);
                        cmd.Parameters.AddWithValue("@zaloga", zalogaArtikla);
                        cmd.Parameters.AddWithValue("@kategorija_id", imeKategorijaArtikla);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Podatki so bili uspešno shranjeni.");

                        txtBox_ime_A.Clear();
                        txtBox_cena_A.Clear();
                        txtBox_zaloga_A.Clear();
                        comBox_kategorije_A.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka pri shranjevanju podatkov: " + ex.Message);
            }
        }

        private void btn_nazaj_Click(object sender, EventArgs e)
        {
            artikli artikli = new artikli();    
            this.Close();
            artikli.Show();
        }
    }
}
