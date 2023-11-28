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
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClackosProj2
{

    public partial class Form1 : Form
    {

        public List<Prisonnier2> prisonniers = new List<Prisonnier2>();
        string requeteComplete = @"
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
        public Form1()
        {
            InitializeComponent();
            PrisonnierManagerPlus prisonnierManagerPlus = new PrisonnierManagerPlus(requeteComplete);
            prisonniers = prisonnierManagerPlus.GetAllPrisonners();

        }

        private int textBoxCount = 0; // Add this field to your clas

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Variable de recherche
            string search = searchBox.Text;
            string infraction = infractionComboBox.Text;
            string sexe = sexeComboBox.Text;
            string cellule = celluleComboBox.Text;

            // Recherche de base
            string baseQuery = requeteComplete.Replace(";", " ") + "WHERE (Nom LIKE '%" + search + "%' OR Prenom LIKE '%" + search + "%')";

            // Check and append additional filters
            if (!string.IsNullOrEmpty(infraction))
            {
                baseQuery += " AND Nom_de_l_infraction LIKE '%" + infraction + "%'";
            }

            if (!string.IsNullOrEmpty(sexe))
            {
                baseQuery += " AND Genre LIKE '%" + sexe + "%'";
            }

            if (!string.IsNullOrEmpty(cellule))
            {
                baseQuery += " AND Numero_de_cellule LIKE '%" + cellule + "%'";
            }

            // Create the PrisonnierManagerPlus with the dynamic query
            PrisonnierManagerPlus prisonnierManagerFiltre = new PrisonnierManagerPlus(baseQuery);
            generatePrisonniers(prisonnierManagerFiltre.GetAllPrisonners());
            infractionComboBox.SelectedItem = null;
            sexeComboBox.SelectedItem = null;
            celluleComboBox.SelectedItem = null;
        }


        private void CreateItem(Prisonnier2 prisonnier)
        {
            int itemWidth = 150; // Adjust as needed based on image and label width
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
            imageBox.BackColor = Color.Transparent;
            imageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox.BorderStyle = BorderStyle.FixedSingle;

            imageBox.Size = new Size(150, 150); // Set the image size
            imageBox.Click += (sender, args) =>
            {
                item_Click(prisonnier);
            };


            // Create a new Label
            Label label = new Label();
            label.Name = "label" + labelCount;
            label.Text = prisonnier.Nom + " " + prisonnier.Prenom;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.ForeColor = Color.White;
            label.Size = new Size(itemWidth, 50); // Set label height
            label.Location = new Point(0, 150); // Set label location below image
            label.BackColor = Color.FromArgb(40, 40, 40);
            label.Font = new Font("Arial", 10, FontStyle.Bold);

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

            panel.Cursor = System.Windows.Forms.Cursors.Hand;
            listePrisonnier.Controls.Add(panel);

            labelCount++; // Increment the count for the next item
        }

        private void item_Click(Prisonnier2 prisonnier)
        {
            button1.Enabled = false;
            listePrisonnier.Controls.Clear();
            listePrisonnier.Controls.Add(detailPrisonnierPanel);
            detailPrisonnierPanel.Visible = !detailPrisonnierPanel.Visible;

            detailPhoto.ImageLocation = prisonnier.Photo.Replace("photo_", "images/");
            detailPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            detailPhoto.BorderStyle = BorderStyle.FixedSingle;

            detailNomPrenom.Text = prisonnier.Nom + " " + prisonnier.Prenom;
            detailID.Text = "ID : " + prisonnier.ID.ToString();
            detailAdresse.Text = "Adresse : " + prisonnier.Adresse;
            detailEntree.Text = "Entrée le : " + prisonnier.DateEntree.Substring(0, 10);
            detailSortie.Text = "Sortie prévue le : " + prisonnier.DateSortie.Substring(0, 10);
            detailGenre.Text = "Sexe : " + prisonnier.Genre;
            detailNaissance.Text = "Née le  : " + prisonnier.DateNaissance.Substring(0, 10);
            detailInfraction.Text = "Infraction : " + prisonnier.Infraction;
            detailCellule.Text = "Cellule n° : " + prisonnier.Cellule.ToString();

        }

        private int labelCount = 0; // Add this field to your class

        private void button1_Click(object sender, EventArgs e)
        {
            generatePrisonniers(prisonniers);
        }

        private void generatePrisonniers(List<Prisonnier2> prisonniers)
        {
            labelCount = 0;
            listePrisonnier.Controls.Clear();
            foreach (Prisonnier2 prisonnier in prisonniers)
            {
                CreateItem(prisonnier);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            PrisonnierManagerPlus prisonnierManagerPlus = new PrisonnierManagerPlus(requeteComplete);
            prisonniers = prisonnierManagerPlus.GetAllPrisonners();
        }

        private void CloseWindow_Click_1(object sender, EventArgs e)
        {
            detailPrisonnierPanel.Visible = false;
            generatePrisonniers(prisonniers);
            infractionComboBox.SelectedItem = null;
            sexeComboBox.SelectedItem = null;
            celluleComboBox.SelectedItem = null;
            button1.Enabled = true;

        }
    }
}