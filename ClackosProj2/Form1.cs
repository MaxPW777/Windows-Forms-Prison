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
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace ClackosProj2
{

    public partial class Form1 : Form
    {
        private DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
            InitializeDataTable();
        }

        private void InitializeDataTable()
        {
            dataTable = new DataTable();

            // Liez le DataTable au DataGridView
            dataGridView1.DataSource = dataTable;
            //Remplir chaque cellule du tableau avec les informations de la base de données
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Nom", typeof(string));
            dataTable.Columns.Add("Prenom", typeof(string));
            dataTable.Columns.Add("Age", typeof(int));
            dataTable.Columns.Add("Genre", typeof(string));
            dataTable.Columns.Add("Adresse", typeof(string));
        }
        private void AllPrisonners()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Exécutez vos opérations sur la base de données ici
                    // Par exemple, exécutez une requête SQL pour récupérer des données

                    MySqlCommand command = new MySqlCommand("SELECT * FROM prisonnier", connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {


                        while (reader.Read())
                        {
                            // Lisez les données du lecteur et utilisez-les comme nécessaire
                            string nom = reader.GetString("Nom");
                            string prenom = reader.GetString("Prenom");
                            int ID = reader.GetInt32("ID_prisonnier");
                            string photo = reader.GetString("Photo_du_prisonnier");

                            // Ajoutez les données à la liste de prisonniers
                            prisonniers.Add(new Prisonnier
                            {
                                Nom = nom,
                                Prenom = prenom,
                                ID = ID,
                                Photo = photo
                            });
                        }
                        foreach (Prisonnier prisonnier in prisonniers)
                        {
                            Console.WriteLine($"Nom: {prisonnier.Nom}, ID: {prisonnier.ID}, Prénom: {prisonnier.Prenom}, Photo: {prisonnier.Photo}");
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        private int textBoxCount = 0; // Add this field to your class

        private void button1_Click(object sender, EventArgs e)
        {
            int textBoxesPerRow = 6; // Change this to the desired number of TextBoxes per row
            int textBoxWidth = 100;
            int textBoxHeight = 30;
            int paddingX = 10;
            int paddingY = 10;


            for (int i = 0; i < prisonniers.Count(); i++)
            {
                // Create a new TextBox
                TextBox textBox = new TextBox();
                textBox.Name = "textBox" + textBoxCount;
                textBox.Text = prisonniers[i].Nom;
                textBox.TextChanged += new EventHandler(DynamicTextBox_TextChanged);
                textBoxCount++;

                // Calculate the position of the TextBox
                int row = i / textBoxesPerRow;
                int col = i % textBoxesPerRow;
                int x = paddingX + col * (textBoxWidth + paddingX);
                int y = paddingY + row * (textBoxHeight + paddingY);

                // Set the position and size of the TextBox
                textBox.Location = new Point(x, y);
                textBox.Size = new Size(textBoxWidth, textBoxHeight);

                // Add the TextBox to the form
                listePrisonnier.Controls.Add(textBox);
            }
        }

        private void DynamicTextBox_TextChanged(object sender, EventArgs e)
        {
            // Handle the TextChanged event for the dynamically generated TextBox
            // Add your custom logic here
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
