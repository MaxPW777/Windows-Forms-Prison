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

            for (int i = 0; i < 20; i++) // Change '20' to the desired total number of TextBoxes
            {
                // Create a new TextBox
                TextBox dynamicTextBox = new TextBox();

                // Set properties for the TextBox
                dynamicTextBox.Name = "dynamicTextBox" + textBoxCount;
                dynamicTextBox.Text = "Generated TextBox";
                dynamicTextBox.Width = textBoxWidth;
                dynamicTextBox.BackColor = Color.Red;

                // Set the location based on the count of TextBoxes
                int row = textBoxCount / textBoxesPerRow;
                int col = textBoxCount % textBoxesPerRow;
                int x = col * (textBoxWidth + paddingX);
                int y = row * (textBoxHeight + paddingY);
                dynamicTextBox.Location = new Point(x, y);

                // Add the TextBox to the form's controls
                listePrisonnier.Controls.Add(dynamicTextBox);

                // Optionally, you can handle events for the dynamically generated control
                dynamicTextBox.TextChanged += DynamicTextBox_TextChanged;

                Console.WriteLine("created new textbox");
                textBoxCount++; // Increment the count
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
