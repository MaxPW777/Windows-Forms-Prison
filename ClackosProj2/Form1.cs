using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Drawing.Text;
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
        public List<Prisonnier2> prisonniersPlus = new List<Prisonnier2>();
        public Form1()
        {
            InitializeComponent();
            PrisonnierManager prisonnierManager = new PrisonnierManager("SELECT * FROM prisonnier");
            prisonniers = prisonnierManager.GetAllPrisonners();
        }

        private int textBoxCount = 0; // Add this field to your clas

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string search = searchBox.Text;
            Console.WriteLine(search);
            PrisonnierManager prisonnierManager2 = new PrisonnierManager("SELECT * FROM prisonnier WHERE Nom LIKE '%" + search + "%' OR Prenom LIKE '%" + search + "%'");
            prisonniers = prisonnierManager2.GetAllPrisonners();
        }

        private void CreateItem(Prisonnier prisonnier)
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

            // Create a new PictureBox (ImageBox)
            PictureBox imageBox = new PictureBox();
            imageBox.Name = "imageBox" + labelCount;

            string imagePath = prisonnier.Photo.ToLower();
            imagePath = imagePath.Replace("photo_", "images/");
            imageBox.ImageLocation = imagePath;

            imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox.BorderStyle = BorderStyle.FixedSingle;
            imageBox.Size = new Size(150, 150); // Set the image size

            // Create a new Label
            Label label = new Label();
            label.Name = "label" + labelCount;
            label.Text = prisonnier.Nom + " " + prisonnier.Prenom;
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

            panel.Location = new Point(x, y);
            panel.Click += (sender, e) =>
            {
                item_Click(prisonnier);
            };

            listePrisonnier.Controls.Add(panel);

            labelCount++; // Increment the count for the next item
        }

        private void item_Click(Prisonnier prisonnier)
        {
            Console.WriteLine("Item clicked", this);
            Console.WriteLine(prisonnier.Nom);
        }

        private int labelCount = 0; // Add this field to your class

        private void button1_Click(object sender, EventArgs e)
        {

            foreach (Prisonnier prisonnier in prisonniers)
            {
                CreateItem(prisonnier);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string customQuery = @"
                                    SELECT 
                                        p.ID_prisonnier,
                                        p.Nom AS Nom,
                                        p.Prenom AS Prenom,
                                        p.Date_de_naissance AS Date_de_naissance,
                                        p.Genre AS Genre,
                                        p.Adresse AS Adresse,
                                        p.Date_d_entree_en_prison AS Date_d_entree_en_prison,
                                        p.Date_de_liberation_prevue AS Date_de_liberation_prevue,
                                        p.Photo_du_prisonnier AS Photo_du_prisonnier,
                                        p.Statut AS Statut,
                                        i.Nom_de_l_infraction AS Infraction,
                                        c.Numero_de_cellule
                                    FROM 
                                        prisonnier p
                                    JOIN 
                                        relation_table rt ON p.ID_prisonnier = rt.ID_prisonnier
                                    JOIN 
                                        infractions i ON rt.ID_infraction = i.ID_infractions
                                    JOIN 
                                        cellules c ON rt.ID_Cellule = c.ID_cellules;";
            PrisonnierManagerPlus prisonnierManagerPlus = new PrisonnierManagerPlus(customQuery);
            prisonniersPlus = prisonnierManagerPlus.GetAllPrisonners();
        }
    }


}