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

                if (string.IsNullOrWhiteSpace(txtBox_zaloga_A.Text))
                {
                    emptyFields.Add("Zaloga artikla");
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
