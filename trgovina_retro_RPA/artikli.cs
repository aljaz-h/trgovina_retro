using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static trgovina_retro_RPA.artikli;
using System.IO;
using System.Runtime.CompilerServices;

namespace trgovina_retro_RPA
{
    public partial class artikli : Form
    {
        private string ConnectionString = "Server=127.0.0.1;Database=trgovina_retro_rpa;User=root;";
        

        public artikli()
        {
            InitializeComponent();
            listView1.SelectedIndexChanged += ListView1_SelectedIndexChanged;
            btn_uredi.Enabled = false;
            btn_izbrisi.Enabled = false;

            listView1.View = View.Details;
            listView1.Columns.Add("ID", 25);
            listView1.Columns.Add("Ime", 85);
            listView1.Columns.Add("Cena", 80);
            listView1.Columns.Add("Kategorija", 70);
            listView1.Columns.Add("Zaloga", 50);

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM artikli";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable data = new DataTable();
                            adapter.Fill(data);

                            foreach (DataRow row in data.Rows)
                            {
                                ListViewItem item = new ListViewItem(row["id"].ToString());
                                item.SubItems.Add(row["ime"].ToString());
                                item.SubItems.Add(row["cena"].ToString());
                                item.SubItems.Add(row["kategorija_id"].ToString());
                                item.SubItems.Add(row["zaloga"].ToString());

                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka pri pridobivanju podatkov iz baze: " + ex.Message);
            }
        }

        private void btn_dodaj_Click(object sender, EventArgs e)
        {
            dodajanje_artikli dodajanje_artikli = new dodajanje_artikli();
            this.Hide();
            dodajanje_artikli.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            home home = new home();
            this.Close();
            home.Show();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_uredi.Enabled = listView1.SelectedItems.Count > 0;
            btn_izbrisi.Enabled = listView1.SelectedItems.Count > 0;
        }

        private void btn_uredi_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                int id = Convert.ToInt32(selectedItem.SubItems[0].Text);
                string ime = selectedItem.SubItems[1].Text;
                string cena = selectedItem.SubItems[2].Text;
                string zaloga = selectedItem.SubItems[3].Text;
                string kategorija_id = selectedItem.SubItems[4].Text;

                urejanje_artikli formUrejanjeArtikli = new urejanje_artikli(this, id, ime, cena, zaloga, kategorija_id);
                this.Hide();
                formUrejanjeArtikli.Show();
            }
            else
            {
                MessageBox.Show("Prvo izberi artikel če želiš urejati.");
            }
        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "CSV files (*.csv)|*.csv";
                    sfd.FileName = "artikli.csv";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            sw.WriteLine("ID;Ime;Cena;Kategorija;Zaloga");

                            foreach (ListViewItem item in listView1.Items)
                            {
                                string id = item.SubItems[0].Text;
                                string ime = item.SubItems[1].Text;
                                string cena = item.SubItems[2].Text;
                                string kategorija = item.SubItems[3].Text;
                                string zaloga = item.SubItems[4].Text;

                                sw.WriteLine($"{id};{ime};{cena};{kategorija};{zaloga}");
                            }
                        }

                        MessageBox.Show("CSV datoteka uspešno ustvarjena!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Napaka pri kreirajnu CSV datoteke: {ex.Message}\nInner Exception: {ex.InnerException?.Message}");
            }
        }

        private void btn_izbrisi_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Ali ste prepričani, da želite izbrisati izbrani artikel?", "Potrditev brisanja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                        {
                            connection.Open();

                            ListViewItem selectedItem = listView1.SelectedItems[0];
                            int id = Convert.ToInt32(selectedItem.SubItems[0].Text);

                            listView1.Items.Remove(selectedItem);

                            string query = "DELETE FROM artikli WHERE id = @id";

                            using (MySqlCommand cmd = new MySqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Artikel uspešno izbrisan!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Napaka pri brisanju artikla: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Najprej izberite artikel, ki ga želite izbrisati.");
            }
        }
    }
}
