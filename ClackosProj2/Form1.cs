using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClackosProj2
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            LoadDataFromDatabase();
        }
        private void LoadDataFromDatabase()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Exécutez vos opérations sur la base de données ici
                    // Par exemple, exécutez une requête SQL pour récupérer des données

                    MySqlCommand command = new MySqlCommand("SELECT * FROM VotreTable", connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Lisez les données du lecteur et utilisez-les comme nécessaire
                            string data = reader.GetString(0);
                            label2.Text = data;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Gérez les erreurs ici
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
