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

        public List<Prisonnier> prisonniers = new List<Prisonnier>();

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
            AllPrisonners();
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

        private void CreateItem(string imagePath, string labelText)
        {
            int itemWidth = 150;
            int itemHeight = 200; // Adjust as needed based on image and label height

            // Create a new Panel for each item
            Panel panel = new Panel();
            panel.Name = "panel" + labelCount;
            panel.Size = new Size(itemWidth, itemHeight);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Click += new EventHandler(this.item_Click);
            
            // Create a new PictureBox (ImageBox)
            PictureBox imageBox = new PictureBox();
            imageBox.Name = "imageBox" + labelCount;
            imageBox.ImageLocation = imagePath;
            imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox.BorderStyle = BorderStyle.FixedSingle;
            imageBox.Size = new Size(150, 150); // Set the image size

            // Create a new Label
            Label label = new Label();
            label.Name = "label" + labelCount;
            label.Text = labelText;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Size = new Size(itemWidth, 50); // Set label height
            label.Location = new Point(0, 150); // Set label location below image

            // Add PictureBox and Label to the Panel
            panel.Controls.Add(imageBox);
            panel.Controls.Add(label);

            // Calculate the position of the item in the container (listePrisonnier)
            int labelsPerRow = 4; // Number of items per row
            int paddingX = 10;
            int paddingY = 10;

            int i = labelCount;
            int row = i / labelsPerRow;
            int col = i % labelsPerRow;
            int x = paddingX + col * (itemWidth + paddingX);
            int y = paddingY + row * (itemHeight + paddingY);

            // Set the position of the Panel
            panel.Location = new Point(x, y);

            // Add the Panel to the container (listePrisonnier)
            listePrisonnier.Controls.Add(panel);

            labelCount++; // Increment the count for the next item
        }

        private int labelCount = 0; // Add this field to your class

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Prisonnier prisonnier in prisonniers)
            {
                string imagePath = prisonnier.Photo.ToLower();
                imagePath = imagePath.Replace("photo_", "");

                string name = prisonnier.Prenom + " " + prisonnier.Nom;

                CreateItem(imagePath, name);
            }
        }

        private void item_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Item clicked",this); 
        }

    }
}
