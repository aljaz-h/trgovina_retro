using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace trgovina_retro_RPA
{
    public partial class zapisi : Form
    {
        private string ConnectionString = "Server=127.0.0.1;Database=trgovina_retro_rpa;User=root;";

        public zapisi()
        {
            InitializeComponent();
            NaloziPodatkeIzBaze();

            listViewZapisi.View = View.Details;
            listViewZapisi.Columns.Add("ID", 25);
            listViewZapisi.Columns.Add("Uporabnik", 80);
            listViewZapisi.Columns.Add("Cas vpisa", 110);

            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM zapisi";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable data = new DataTable();
                            adapter.Fill(data);

                            foreach (DataRow row in data.Rows)
                            {
                                ListViewItem item = new ListViewItem(row["id"].ToString());
                                item.SubItems.Add(row["uporabnik"].ToString());
                                item.SubItems.Add(row["cas_vpisa"].ToString());

                                listViewZapisi.Items.Add(item);
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

        private void NaloziPodatkeIzBaze()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM zapisi";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            PrikaziPodatkeVListView(table);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka pri nalaganju podatkov iz baze: " + ex.Message);
            }
        }

        private void PrikaziPodatkeVListView(DataTable table)
        {
            listViewZapisi.Items.Clear();

            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["uporabnik"].ToString());
                item.SubItems.Add(row["cas_vpisa"].ToString());

                listViewZapisi.Items.Add(item);
            }
        }

        private void btn_nazaj_Click(object sender, EventArgs e)
        {
            this.Close();
            home home = new home();
            home.Show();
        }
    }
}
